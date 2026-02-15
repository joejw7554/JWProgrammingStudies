using System;
using System.Collections.Generic;

// 문제: 배열에서 합이 정확히 Target이 되는 모든 부분집합 찾기
// 예: [1,2,3,4,5], target=5 → {1,4}, {2,3}, {5}

namespace TestC_Proj.BackTracking
{
    class Step3_SubsetSum
    {
        // TODO: 필요한 변수 선언

        static void SubsetSum(int[] arr, int index, int currentSum, int target)
        {
            // TODO: 백트래킹으로 부분집합 합 구현
            // 힌트:
            // 1. 종료 조건: currentSum == target (출력)
            // 2. 가지치기: currentSum > target (종료)
            // 3. 각 원소마다 2가지 선택: 포함 or 제외
        }

        static void Main()
        {
            Console.WriteLine("=== 부분집합 합 문제 ===");
            int[] arr = { 1, 2, 3, 4, 5 };
            int target = 5;

            Console.WriteLine($"배열: [{string.Join(", ", arr)}]");
            Console.WriteLine($"목표 합: {target}");
            Console.WriteLine("결과:");
            SubsetSum(arr, 0, 0, target);
        }
    }
}