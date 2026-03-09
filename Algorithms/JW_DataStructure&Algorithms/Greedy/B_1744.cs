//using System;
//using System.Collections.Generic;
//using System.Diagnostics.CodeAnalysis;
//using System.Text;

////https://www.acmicpc.net/problem/1744

//class B_1744
//{
//    static void Main()
//    {
//        int count = int.Parse(Console.ReadLine());

//        List<int> positive = new List<int>();
//        List<int> negative = new List<int>();
//        bool hasZero = false;
//        int oneCount = 0;


//        for (int i = 0; i < count; i++)
//        {
//            int input = int.Parse(Console.ReadLine());

//            // 입력 분류
//            if (input > 1)
//                positive.Add(input);
//            else if (input == 1)
//                oneCount++;
//            else if (input == 0)
//                hasZero = true;
//            else
//                negative.Add(input);
//        }

//        positive.Sort((a, b) =>  b.CompareTo(a));
//        negative.Sort((a, b) => { return a.CompareTo(b); });



//        int sum = 0;

//        //양수들 처리
//        for (int i = 0; i < positive.Count - 1; i += 2)
//        {
//            sum += (positive[i] * positive[i + 1]);
//        }

//        //남은 양수 처리
//        if (positive.Count % 2 == 1)
//            sum += positive[positive.Count - 1];


//        //음수처리
//        for (int i = 0; i < negative.Count - 1; i += 2)
//        {
//            sum += (negative[i] * negative[i + 1]);
//        }

//        //1들 처리
//        sum += oneCount;

//        //남는 음수는 -1 과 곱해서 처리
//        if(hasZero && negative.Count % 2 == 1)
//        {
//            negative.RemoveAt(negative.Count - 1);
//        }

//        //남은 음수는 어쩔 수 없이 더한다

//        if (negative.Count % 2 == 1)
//            sum += negative[negative.Count - 1];

//        Console.WriteLine(sum);


//    }

//}