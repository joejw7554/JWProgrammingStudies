//using System;
//using System.Collections.Generic;
//using System.Security.Principal;
//using System.Text;

////https://www.acmicpc.net/problem/1715
//class B_1715
//{
//    static void Main()
//    {
//        int count = int.Parse(Console.ReadLine());
//        PriorityQueue<int, int> heap = new PriorityQueue<int, int>();


//        for (int i = 0; i < count; i++)
//        {
//            int intput = int.Parse(Console.ReadLine());
//            heap.Enqueue(intput, intput);
//        }


//        int total = 0;
//        while (heap.Count > 1)
//        {
//            int a = heap.Dequeue();
//            int b = heap.Dequeue();
//            int sum = a + b;


//            total += sum;
//            heap.Enqueue(sum, sum);
//        }


//        Console.WriteLine(total);
//    }
//}
