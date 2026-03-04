using System;
using System.Collections.Generic;
using System.Text;

//https://www.acmicpc.net/problem/1931
class B_1931
{
    static void Main()
    {
        int answer = 0;

        int inputCount = int.Parse(Console.ReadLine());
        var table = new List<(int, int)>();

        // 각 회의가 겹치지 않게 하면서 회의실을 사용할 수 있는 최대 갯수를 어떻게 구할것인가
        for (int i = 0; i < inputCount; i++)
        {
            var schedule = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            table.Add((schedule[0], schedule[1]));
        }

        //끝나는 시간기준으로 정렬
        table.Sort((a, b) =>
        {
            if (a.Item2 != b.Item2) return a.Item2.CompareTo(b.Item2);

            return a.Item1.CompareTo(b.Item1);
        });

        int lastEndTime = 0;
       foreach(var meeting in table)
        {
            if(meeting.Item1 >= lastEndTime)
            {
                answer++;
                lastEndTime = meeting.Item2;
            }
        }


        Console.WriteLine(answer);

    }
}
