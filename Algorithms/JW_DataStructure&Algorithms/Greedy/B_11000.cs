using System;
using System.Collections.Generic;
using System.Text;

//https://www.acmicpc.net/problem/11000
class B_11000
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        var table = new List<(int, int)>();


        for (int i = 0; i < count; i++)
        {
            int[] schedule = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            table.Add((schedule[0], schedule[1]));
        }

        table.Sort((a, b) =>
        {
            return a.Item1.CompareTo(b.Item1);
        });

        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();


        foreach (var schedule in table)
        {
            if (minHeap.Count > 0 && minHeap.Peek() <= schedule.Item1)
            {
                minHeap.Dequeue();
            }

            minHeap.Enqueue(schedule.Item2, schedule.Item2);
        }


        Console.WriteLine(minHeap.Count);

    }
}