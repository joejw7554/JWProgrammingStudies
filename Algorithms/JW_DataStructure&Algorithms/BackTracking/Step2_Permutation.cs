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
//        static List<int> selected = new List<int>();
//        static bool[] visited;

//        static void Permutation(int n, int m, int depth)
//        {
//            // TODO: 백트래킹으로 순열 구현

//            if (depth == m)
//            {
//                Console.WriteLine("(" + string.Join(',', selected) + ")");
//                return;
//            }


//            for (int i=1; i<=n; i++) //i가 매번 바뀌어야한다..
//            {

//                if (visited[i] == true) continue;

//                visited[i] = true;
//                selected.Add(i);
//                Permutation(n, m, depth + 1);

//                visited[i] = false;
//                selected.RemoveAt(selected.Count - 1);
//            }
//        }

//        static void Main()
//        {
//            int n = 3;
//            visited = new bool[n + 1];
//            Console.WriteLine("=== 순열 문제 ===");
//            Console.WriteLine("N=3, M=2인 경우:");
//            Permutation(n, 2, 0);
//        }
//    }
//}