using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;


//https://school.programmers.co.kr/learn/courses/30/lessons/1843
class P_1843_R
{
    int solution(string[] arr)
    {
        int answer = -1;


        //단계1 데이터 분리
        List<int> numbers = new List<int>();
        List<char> opers = new List<char>();

        foreach (string str in arr)
        {
            if (int.TryParse(str, out int num))
            {
                numbers.Add(num);
            }
            else
            {
                opers.Add(str[0]);
            }
        }

        int[][] max_dp = new int[numbers.Count][];
        int[][] min_dp = new int[numbers.Count][];

        for (int i = 0; i < max_dp.Length; i++)
        {
            max_dp[i] = new int[numbers.Count];
            min_dp[i] = new int[numbers.Count];

            max_dp[i][i] = numbers[i];
            min_dp[i][i] = numbers[i];
        }

        //단계 2: 루프 구성
        int n = numbers.Count;
        for (int step = 1; step < n; step++)
        {
            for (int i = 0; i < n - step; i++)
            {
                int j = step + i;

                max_dp[i][j] = int.MinValue;
                min_dp[i][j] = int.MaxValue;

                for (int k = i; k < j; k++)
                {
                    Console.WriteLine($"구간[{i}~{j}] 계산 중... 기준점 k={k} ({numbers[i]}...{numbers[j]})");
                    Console.WriteLine($"  -> 왼쪽({i}~{k}): {max_dp[i][k]}, 오른쪽({k + 1}~{j}): {max_dp[k + 1][j]}");

                    if (opers[k] == '+')
                    {
                        max_dp[i][j] = Math.Max(max_dp[i][j], max_dp[i][k] + max_dp[k + 1][j]);
                        min_dp[i][j] = Math.Min(min_dp[i][j], min_dp[i][k] + min_dp[k + 1][j]);
                    }
                    else if (opers[k] == '-')
                    {
                        max_dp[i][j] = Math.Max(max_dp[i][j], max_dp[i][k] - min_dp[k + 1][j]);
                        min_dp[i][j] = Math.Min(min_dp[i][j], min_dp[i][k] - max_dp[k + 1][j]);
                    }
                }

            }
        }


        //단계 3: 최종결과
        return answer;
    }

    static void Main()
    {
        P_1843_R test = new P_1843_R();
        string[] sample = new string[] { "1", "-", "3", "+", "5", "-", "8" };

        var result = test.solution(sample);
    }
}
