//using System;

//// 문제: N×N 체스판에 N개의 퀸을 서로 공격할 수 없도록 배치
//// 가능한 배치의 개수를 구하세요

//namespace TestC_Proj.BackTracking
//{
//    class Step4_NQueen
//    {
//        static int count = 0;
//        // TODO: 필요한 변수 선언 (체스판, 방문 체크 등)

//        static bool IsSafe(int row, int col, int n)
//        {
//            // TODO: (row, col)에 퀸을 놓을 수 있는지 확인
//            // 힌트: 같은 열, 대각선 체크
//            return false;
//        }

//        static void NQueen(int row, int n)
//        {
//            // TODO: 백트래킹으로 N-Queen 구현
//            // 힌트:
//            // 1. 종료 조건: row == n (모든 행에 배치 완료)
//            // 2. 현재 행의 각 열에 퀸을 놓아보기
//            // 3. 안전하면: 배치 → 재귀 → 제거
//        }

//        static void Main()
//        {
//            Console.WriteLine("=== N-Queen 문제 ===");
            
//            int n = 4;
//            Console.WriteLine($"N={n}일 때:");
//            count = 0;
//            NQueen(0, n);
//            Console.WriteLine($"가능한 배치 수: {count}");
            
//            n = 8;
//            Console.WriteLine($"\nN={n}일 때:");
//            count = 0;
//            NQueen(0, n);
//            Console.WriteLine($"가능한 배치 수: {count}");
//        }
//    }
//}