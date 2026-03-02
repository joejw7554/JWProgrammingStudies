//using System;
//using System.Collections.Generic;
//using System.Text;

////https://www.acmicpc.net/problem/2810
//class B_2810
//{
//    static void Main()
//    {
//        int count = int.Parse(Console.ReadLine());
//        string seats = Console.ReadLine();

//        int holderCount = 1;
//        for (int i = 0; i < seats.Length; i++)
//        {
//            holderCount++;

//            if (seats[i] == 'L' || seats[i]=='l') //L만나면 한칸 건너뜀
//            {
//                i++;
//            }
//        }



//        int answer = Math.Min(count, holderCount);
//        Console.WriteLine(answer);
//    }

//}
