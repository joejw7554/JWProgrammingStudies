//using System;
//using System.Collections.Generic;
//using System.Text;

//class B_4796
//{
//    //L 일동안
//    //P ?? 일중
//    // V 휴가
//    static void Main()
//    {

//        //한번에 입력처리
//        int i = 1;
//        while (true)
//        {
//            string[] numbers = Console.ReadLine().Split();

//            int L = int.Parse(numbers[0]);
//            int P = int.Parse(numbers[1]);
//            int V = int.Parse(numbers[2]);


//            if (L==0 && P==0 && V==0)
//            {
//                break;
//            }

//            int answer = L * (V / P) + Math.Min((V % P), L);
//            Console.WriteLine($"Case {i++}: {answer}");
//        }

//    }
//}
