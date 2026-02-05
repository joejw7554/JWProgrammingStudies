using System;
using System.Collections.Generic;

public class Othello
{
    // board: 8x8 2차원 배열 (0: 빈칸, 1: 흑돌, 2: 백돌)
    // 흑돌(1)을 놓아 뒤집을 수 있는 백돌(2)의 최대 개수를 반환
    public int solution(int[,] board)
    {
        int answer = 0;

        int[] dx = new int[] { 1, 1, 0, -1, -1, -1, 0, 1 }; //우 우하 하, 좌하, 좌, 좌상, 상, 우상,  
        int[] dy = new int[] { 0, 1, 1, 1, 0, -1, -1, -1 };
        int direction = 0;
        int sum = 0;
        int max = 0;
        // TODO: 로직 구현
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[i, j] == 0)
                {
                    for (int k = 0; k < dx.Length; k++) //8방향진행
                    {
                        int count = 0;
                        int row = dy[direction] + i;
                        int col = dx[direction] + j;

                        //범위 이내이면서 백돌이라면 
                        if ((row >= 0 && col >= 0 && row < board.GetLength(0) && col < board.GetLength(1)) &&
                            board[row, col] == 2)
                        {
                            //백돌이아닐때까지 같은방향으로 계속 전진
                            while ((row < board.GetLength(0) && col < board.GetLength(1) && row >= 0 && col >= 0) && board[row, col] == 2)
                            {
                                count++;

                                row += dy[direction];
                                col += dx[direction];
                            }
                            //마지막이 흑돌이라면 sum에추가
                            if ((row < board.GetLength(0) && col < board.GetLength(1) && row >= 0 && col >= 0) && board[row, col] == 1)
                            {
                                sum += count;
                            }
                        }
                        //방향바꿔서 진행
                        direction = (direction + 1) % dx.Length;
                    }
                    if (sum > max) max = sum;
                    sum = 0;
                }

            }
        }
        answer = max;

        return answer;
    }
}

class Othello_Test
{
    static void Main(string[] args)
    {
        Othello sol = new Othello();

        // 0: 빈칸, 1: 내 돌(흑), 2: 상대 돌(백)
        // (2, 2) 자리가 가장 매력적인 '정답' 후보가 되도록 구성했습니다.
        int[,] board = new int[8, 8] {
            {0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 2, 0, 0, 0}, // 1행
            {0, 0, 0, 2, 0, 0, 0, 0}, // 2행 (2, 2) 자리에 놓으면 대각선으로 (1, 3), (0, 4) 쪽 포위 가능
            {0, 0, 2, 1, 0, 0, 0, 0}, // 3행
            {0, 2, 2, 2, 1, 0, 0, 0}, // 4행
            {0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0}
        };

        // 추천 테스트 시나리오:
        // 1. (2, 2)에 두었을 때 오른쪽 아래 대각선, 아래쪽 세로 등이 뒤집히는지 확인
        // 2. (4, 0)에 두었을 때 가로로 3개가 뒤집히는지 확인

        int result = sol.solution(board);
        Console.WriteLine($"최대로 뒤집을 수 있는 돌의 개수: {result}");
    }
}