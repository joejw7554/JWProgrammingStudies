//using System;
//using System.Collections.Generic;
//using System.Text;

////https://www.acmicpc.net/problem/11399
//class B_11399
//{
//    static void Main()
//    {
//        //입력받아오는 구간
//        int size = int.Parse(Console.ReadLine());
//        string[] inputs = Console.ReadLine().Split();
//        int[] waitTime = Array.ConvertAll(inputs, int.Parse);


//        //오름차순으로 정렬
//        Array.Sort(waitTime);



//        //계산방법
//        //sum 변수를 이용해서 계속 더해서 sum을 중첩시키고 각숫자에 더하여 최소시간을 구한다

//        int prev = 0;
//        int total = 0;
//        foreach (int person in waitTime)
//        {
//            prev = prev + person; //이전 사람의 시간 + 현재 사람의 시간
//            total += prev; // 총합 = 이전 사람 + 현재 사람 시간
//        }

//        Console.WriteLine(total);
//    }

//}
