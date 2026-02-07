//using System;
//using System.Collections.Generic;
//using System.Runtime.InteropServices;
//using System.Text;

//internal class B_2720
//{
//    static void Main()
//    {
//        int[] coins = new int[] { 25, 10, 5, 1 };

//        string inputT = Console.ReadLine();
//        if (inputT == null) return;

//        int t = int.Parse(inputT);


//        for (int i = 0; i < t; i++)
//        {

//            string inputC = Console.ReadLine();
//            if (inputC == null) continue;
//            int c = int.Parse(inputC);
//            int[] result = new int[coins.Length];

//            for (int j = 0; j < coins.Length; j++)
//            {
//                result[j] = c / coins[j];
//                c %= coins[j];
//            }

//            Console.WriteLine(string.Join(" ", result));
//        }

//    }
//}





