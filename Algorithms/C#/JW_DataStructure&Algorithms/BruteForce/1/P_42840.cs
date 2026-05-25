using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.XPath;

//https://school.programmers.co.kr/learn/courses/30/lessons/42840?language=csharp
class P_42840
{
    public int[] solution(int[] answers)
    {
        List<int> answer = new List<int>();
        int[] result = new int[3];

        int n = answers.Length;

        //전체 진행
        //일단 1,2,3 맞춘 갯수를 기록한다 이과정에서 Max값이 새로나오면 갱신한다
        //기록에서 Max값의 인덱스를 출력한다

        int[] pattern1 = new int[] { 1, 2, 3, 4, 5 };
        int[] pattern2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] pattern3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };


        for (int i = 0; i < n; i++)
        {
            if (answers[i] == pattern1[i % pattern1.Length]) result[0]++;
            if (answers[i] == pattern2[i % pattern2.Length]) result[1]++;
            if (answers[i] == pattern3[i % pattern3.Length]) result[2]++;
        }


        int max = result.Max();
        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] == max) answer.Add(i + 1);
        }

        return answer.ToArray();
    }


    static void Main()
    {

    }

}
