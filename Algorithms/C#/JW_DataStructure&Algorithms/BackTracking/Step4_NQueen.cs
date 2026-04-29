//using System;
//using System.Transactions;

//// 문제: N×N 체스판에 N개의 퀸을 서로 공격할 수 없도록 배치
//// 가능한 배치의 개수를 구하세요

//namespace TestC_Proj.BackTracking
//{
//    class Step4_NQueen
//    {
//        static int count = 0;
//        // TODO: 필요한 변수 선언 (체스판, 방문 체크 등)
//        static bool[,] board;

//        static (int row, int col)[] directions = [(-1, 0), (-1, 1), (-1, -1)];

//        static bool IsSafe(int row, int col, int n)
//        {
//            // TODO: (row, col)에 퀸을 놓을 수 있는지 확인

//             //위, 우상, 좌상

//            for (int i = 0; i < directions.Length; i++)
//            {
//                int nextR = row + directions[i].row;
//                int nextC = col + directions[i].col;

//                while(nextR>=0 && nextR<n && nextC>=0 && nextC<n)
//                {
//                    if (board[nextR, nextC] == true) return false;

//                    nextR += directions[i].row;
//                    nextC += directions[i].col;
//                }
//            }

//            return true;
//        }

//        static void NQueen(int row, int n)
//        {

//            if (row >= n) //여기까지왔다는건 문제가 없었다는 뜻이니 유효로 간주할 수 밖에 없다
//            {
//                count++;
//                return;
//            }

//            for (int j = 0; j < n; j++)
//            {
//                if (IsSafe(row, j, n))
//                {
//                    board[row, j] = true;
//                    NQueen(row + 1, n);
//                    board[row, j] = false;
//                }
//            }
//        }



//        static void Main()
//        {
//            Console.WriteLine("=== N-Queen 문제 ===");

//            int n = 4;
//            board = new bool[n, n];
//            Console.WriteLine($"N={n}일 때:");
//            count = 0;
//            NQueen(0, n);
//            Console.WriteLine($"가능한 배치 수: {count}");

           
//            n = 8;
//            board = new bool[n, n];
//            Console.WriteLine($"\nN={n}일 때:");
//            count = 0;
//            NQueen(0, n);
//            Console.WriteLine($"가능한 배치 수: {count}");
//        }
//    }
//}



//    // TODO: 백트래킹으로 N-Queen 구현
//    // 힌트:
//    // 1. 종료 조건: row == n (모든 행에 배치 완료)
//    // 2. 현재 행의 각 열에 퀸을 놓아보기
//    // 3. 안전하면: 배치 → 재귀 → 제거
