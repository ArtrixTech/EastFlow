import cv2
import numpy
from PIL import ImageGrab, Image, ImageDraw
from collections import namedtuple
import matplotlib.pyplot as plt

cap = cv2.VideoCapture(0)

Point = namedtuple("Point", ['x', 'y'])

block_width, block_height = (0, 0)


def draw_result_rectangles(input_image, color, rectangles):
    if len(rectangles) > 0:
        for rect in rectangles:
            x, y, w, h = rect
            cv2.rectangle(input_image, (x, y), (x + w, y + h), color)
            # cv2.rectangle(input_image, (x, y), (w, h), color)
    return input_image


def crop_block(hole_img, x, y):
    x1, y1 = x * block_width, y * block_height
    x2, y2 = x1 + block_width, y1 + block_height
    return hole_img.crop((x1, y1, x2, y2))


def analyze_block(block):
    assert isinstance(block, Image.Image)
    ratio = [0, 0, 0]
    count = [0, 0, 0]
    all = 0
    # pix_count = block_width * block_height

    for y1 in range(int(block_height)):
        for x1 in range(int(block_width)):
            count[0] += block.getpixel((x1, y1))[0]
            count[1] += block.getpixel((x1, y1))[1]
            count[2] += block.getpixel((x1, y1))[2]
            all += block.getpixel((x1, y1))[0]
            all += block.getpixel((x1, y1))[1]
            all += block.getpixel((x1, y1))[2]

    ratio[0] = count[0] / all
    ratio[1] = count[1] / all
    ratio[2] = count[2] / all

    return ratio


while (1):

    # ret, frame = cap.read()
    frame = cv2.imread("t2.jpg")

    frame_pil = Image.fromarray(cv2.cvtColor(frame, cv2.COLOR_BGR2RGB))

    frame_height, frame_width, depth = frame.shape
    rect_width, rect_height = 350, 350

    blocks_count_x = 8
    blocks_count_y = 8

    blocks_img = [[0 for i in range(blocks_count_y)] for i in range(blocks_count_x)]

    padding_x, padding_y = (10, 10)
    block_width, block_height = ((rect_width - padding_x) / blocks_count_x, (rect_height - padding_y) / blocks_count_y)

    cut_rect = [int(frame_width / 2 - (rect_width - 2 * padding_x) / 2),
                int(frame_height / 2 - (rect_height - 2 * padding_y) / 2),
                int(frame_width / 2 - (rect_width - 2 * padding_x) / 2) + rect_width - 2 * padding_x,
                int(frame_height / 2 - (rect_height - 2 * padding_y) / 2) + rect_height - 2 * padding_y]

    draw_rect = [int(frame_width / 2 - rect_width / 2),
                 int(frame_height / 2 - rect_height / 2),
                 rect_width, rect_height]

    cut_img = frame_pil  # .crop(cut_rect)
    thres = 0.38

    res = []
    return_str = ""
    for y in range(blocks_count_y):
        line = ""
        for x in range(blocks_count_x):
            blocks_img[x][y] = crop_block(cut_img, x, y)
            ratio = analyze_block(blocks_img[x][y])
            if ratio[0] > thres and ratio[1] > thres:
                res.append((x, y, 3))
                line += "4 "
            elif ratio[0] > thres:
                res.append((x, y, 0))
                line += "1 "
            elif ratio[1] > thres:
                res.append((x, y, 1))
                line += "2 "
            elif ratio[2] > thres:
                res.append((x, y, 2))
                line += "3 "
            else:
                line += "0 "
            if x == blocks_count_x - 1:
                line = line.strip()
        line += "\n"
        return_str += line

    drawn = draw_result_rectangles(frame, [255, 0, 0],
                                   [draw_rect])

    # show a frame
    cv2.imshow("capture", drawn)

    draw = ImageDraw.Draw(cut_img)

    for block in res:
        px = int(block[0] * block_width + block_width / 2)
        py = int(block[1] * block_height + block_height / 2)
        size = 2
        # print(res)
        if block[2] == 0:
            draw.rectangle((px - size, py - size, px + size, py + size), 'white', 'red')
        if block[2] == 1:
            draw.rectangle((px - size, py - size, px + size, py + size), 'white', 'green')
        if block[2] == 2:
            draw.rectangle((px - size, py - size, px + size, py + size), 'white', 'cyan')
        if block[2] == 3:
            draw.rectangle((px - size, py - size, px + size, py + size), 'white', 'yellow')

    plt.imshow(cut_img)
    plt.show()
    print(return_str)
    if cv2.waitKey(1) & 0xFF == ord('q'):
        break
cap.release()
cv2.destroyAllWindows()
