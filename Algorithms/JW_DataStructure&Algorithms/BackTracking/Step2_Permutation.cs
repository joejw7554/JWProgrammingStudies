//using System;
//using System.Collections.Generic;

//// 문제: 1부터 N까지의 숫자 중에서 M개를 선택하는 모든 순열을 출력
//// 예: N=3, M=2 → (1,2), (1,3), (2,1), (2,3), (3,1), (3,2)
//// 조합과 다르게 순서가 중요!

//namespace TestC_Proj.BackTracking
//{
//    class Step2_Permutation
//    {
//        // TODO: 필요한 변수 선언
//        // 힌트: visited 배열이 필요할 수 있음

//        static void Permutation(int n, int m, int depth)
//        {
//            // TODO: 백트래킹으로 순열 구현
//            // 힌트:
//            // 1. 종료 조건: depth == m
//            // 2. for문으로 1부터 n까지 순회
//            // 3. 방문하지 않은 숫자만 선택
//            // 4. 선택 → 재귀 호출 → 되돌리기
//        }

//        static void Main()
//        {
//            Console.WriteLine("=== 순열 문제 ===");
//            Console.WriteLine("N=3, M=2인 경우:");
//            Permutation(3, 2, 0);
//        }
//    }
//}