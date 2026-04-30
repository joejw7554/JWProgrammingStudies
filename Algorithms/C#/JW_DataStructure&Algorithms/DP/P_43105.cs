using System;
public class P_43105
{
    public int solution(int[][] triangle)
    {
        int answer = 0;

        //DP 작성 과정
        for (int i = 1; i < triangle.Length; i++)
        {
            for (int j = 0; j < triangle[i].Length; j++)
            {
                int leftParent = 0;
                int rightParent = 0;

                if (j > 0)
                {
                    leftParent = triangle[i - 1][j - 1];
                }
                if (j < triangle[i - 1].Length)
                {
                    rightParent = triangle[i - 1][j];
                }

                triangle[i][j] += Math.Max(leftParent, rightParent);
            }
        }


        int lastRow = triangle.Length - 1;
        for (int i = 0; i < triangle[lastRow].Length; i++)
        {
            answer = Math.Max(answer, triangle[lastRow][i]);
        }

        return answer;
    }

    static void Main()
    {
        var test = new P_43105();

        int[][] triangle = new int[][] {
            new int[] {7},
            new int[] {3, 8},
            new int[] {8, 1, 0},
            new int[] {2, 7, 4, 4},
            new int[] {4, 5, 2, 6, 5}
        };

        int result = test.solution(triangle);
        Console.WriteLine(result);

        int c = 8;
    }
}