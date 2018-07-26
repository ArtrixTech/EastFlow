/*
	Author: LiuChenxuan
	Date: 2018.7.24
*/

#include <iostream>
#include <opencv2/opencv.hpp>

#define DEBUG true
#define DEBUG_THRESHOLD true

int map[8][8];

int main()
{
    cv::Mat image = cv::imread("Image.jpg");
    cv::namedWindow("Image", CV_WINDOW_NORMAL);
    cv::imshow("Image", image);

    std::vector<cv::Mat> bgr;
    cv::split(image, bgr);

    cv::threshold(bgr[0], bgr[0], 95, 255, CV_THRESH_BINARY);
    cv::threshold(bgr[1], bgr[1], 100, 255, CV_THRESH_BINARY);
    cv::threshold(bgr[2], bgr[2], 100, 255, CV_THRESH_BINARY);
    if (DEBUG && DEBUG_THRESHOLD) {
        cv::namedWindow("blue", CV_WINDOW_NORMAL);
        cv::imshow("blue", bgr[0]);
        cv::namedWindow("green", CV_WINDOW_NORMAL);
        cv::imshow("green", bgr[1]);
        cv::namedWindow("red", CV_WINDOW_NORMAL);
        cv::imshow("red", bgr[2]);
    }

    for (int i = 0; i < 8; ++i) {
        for (int j = 0; j < 8; ++j) {
            cv::Mat ROI_B = bgr[0](cv::Rect(50 + j * 425, 50 + i * 425, 400, 400));
            cv::Mat ROI_G = bgr[1](cv::Rect(50 + j * 425, 50 + i * 425, 400, 400));
            cv::Mat ROI_R = bgr[2](cv::Rect(50 + j * 425, 50 + i * 425, 400, 400));

            int count[3] = { 0, 0, 0 };
            for (int x = 0; x < 400; ++x) {
                for (int y = 0; y < 400; ++y) {
                    if (ROI_B.at<uchar>(x, y) == 255)
                        ++count[0];
                    if (ROI_G.at<uchar>(x, y) == 255)
                        ++count[1];
                    if (ROI_R.at<uchar>(x, y) == 255)
                        ++count[2];
                }
            }
            bool blue = count[0] > 80000 ? true : false;
            bool green = count[1] > 80000 ? true : false;
            bool red = count[2] > 80000 ? true : false;

            if (blue && green && red)
                map[i][j] = 0;
            else if (green && red)
                map[i][j] = 4;
            else if (blue)
                map[i][j] = 3;
            else if (green)
                map[i][j] = 2;
            else
                map[i][j] = 1;
        }
    }

    for (int i = 0; i < 8; ++i) {
        for (int j = 0; j < 8; ++j) {
            std::cout << map[i][j] << ' ';
        }
        std::cout << std::endl;
    }
    cv::waitKey();
    return 0;
}
