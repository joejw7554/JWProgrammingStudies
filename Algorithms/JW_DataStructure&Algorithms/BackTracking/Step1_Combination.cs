using System;
using System.Collections.Generic;

// 문제: 1부터 N까지의 숫자 중에서 M개를 선택하는 모든 조합을 출력
// 예: N=4, M=2 → (1,2), (1,3), (1,4), (2,3), (2,4), (3,4)

namespace TestC_Proj.BackTracking
{
    class Step1_Combination
    {
        // TODO: 필요한 변수 선언
        static List<int> selected = new List<int>();

        static void Combination(int start, int n, int m)
        {
            if (selected.Count == m)
            {
                Console.WriteLine("(" + string.Join(" ", selected) + ")");
                return;
            }

            for (int i = start; i <= n; i++)
            {
                selected.Add(i);
                Combination(i + 1, n, m);
                selected.RemoveAt(selected.Count - 1);
            }


        }


        static void Main()
        {
            Console.WriteLine("=== 조합 문제 ===");
            Console.WriteLine("N=4, M=2인 경우:");
            Combination(1, 4, 2);

            Console.WriteLine("\nN=5, M=3인 경우:");
            Combination(1, 5, 3);
        }
    }
}