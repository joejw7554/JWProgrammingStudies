//using System;
//using System.Collections.Generic;
//using System.Text;

////https://www.acmicpc.net/problem/11047
//class B_11047
//{
//    static void Main()
//    {
//        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
//        int N = inputs[0], K = inputs[1];

//        int[] coinTypes = new int[N];
//        for(int i=0; i<N; i++)
//        {
//            coinTypes[i]= int.Parse(Console.ReadLine());
//        }

//        Array.Sort(coinTypes, (a, b) => b.CompareTo(a));

//        int count = 0;
//        foreach(int type in coinTypes)
//        {
//            count += K / type;
//            K = K % type;
//        }

//        Console.WriteLine(count);

//    }
//}
