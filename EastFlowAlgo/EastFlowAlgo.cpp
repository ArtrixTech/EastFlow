/*
	Date: 2018.7.17
	Author: LiuChenxuan
*/

#include <iostream>
using namespace std;

int map[8][8];
bool castle[8][8];
bool visit[8][8];
int nextpos[4][2] = { { -1, 0 }, { 0, -1 }, { 1, 0 }, { 0, 1 } };

void printmap();

bool dfs(int x, int y, int block);

int main()
{
    for (int i = 0; i < 8; ++i) {
        for (int j = 0; j < 8; ++j) {
            cin >> map[i][j];
            if (map[i][j])
                castle[i][j] = true;
        }
    }

	for (int i = 0; i < 8; ++i) {
        for (int j = 0; j < 8; ++j) {
            if (castle[i][j]) {
                visit[i][j] = true;
                dfs(i, j, map[i][j]);
                printmap();
                return 0;
            }
        }
    }
}

bool isfinished();

bool dfs(int x, int y, int block)
{
    for (int k = 0; k < 4; ++k) {
        int nx = x + nextpos[k][0];
        int ny = y + nextpos[k][1];
        if (nx >= 0 && nx <= 7 && ny >= 0 && ny <= 7) {
            if (map[nx][ny] == 0) {
                map[nx][ny] = block;
                if (dfs(nx, ny, block)) {
                    return true;
                } else {
                    map[nx][ny] = 0;
                }
            } else if (castle[nx][ny] && map[nx][ny] == block && !visit[nx][ny]) {
				visit[nx][ny] = true;
                if (isfinished())
                    return true;
                bool breakflag = false; 
                for (int i = 0; i < 8 && !breakflag; ++i) {
                    for (int j = 0; j < 8 && !breakflag; ++j) {
                        if (castle[i][j] && !visit[i][j]) {
                            visit[i][j] = true;
                            if (!dfs(i, j, map[i][j])) {
                                visit[i][j] = false;
                                breakflag = true;
                            } else
                                return true;
                        }
                    }
                }
                visit[nx][ny] = false;
            }
        }
    }
    return false;
}

bool isfinished()
{
    for (int i = 0; i < 8; ++i)
        for (int j = 0; j < 8; ++j)
            if (map[i][j] == 0 || (castle[i][j] && !visit[i][j]))
                return false;
    return true;
}

void printmap()
{
    for (int i = 0; i < 8; ++i) {
        for (int j = 0; j < 8; ++j)
            cout << map[i][j] << ' ';
        cout << endl;    
	}
    system("pause");
}