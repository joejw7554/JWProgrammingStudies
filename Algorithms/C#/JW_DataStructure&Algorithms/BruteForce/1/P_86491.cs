//using System;
//using System.Collections.Generic;
//using System.Text;

////https://school.programmers.co.kr/learn/courses/30/lessons/86491
//class P_86491
//{
//    public int solution(int[,] sizes)
//    {
//        int maxWidth = 0;
//        int maxHeight = 0;

//        for (int i = 0; i < sizes.GetLength(0); i++)
//        {
//            int currentMax = Math.Max(sizes[i, 0], sizes[i, 1]);
//            int currentMin = Math.Min(sizes[i, 0], sizes[i, 1]);

//            maxWidth = Math.Max(currentMax, maxWidth);
//            maxHeight = Math.Max(currentMin, maxHeight);

//        }

//        int answer = maxWidth * maxHeight;
//        return answer;
//    }


//    static void Main()
//    {
//        var test = new P_86491();
//        var result = test.solution(new int[,] { { 60, 50 }, { 30, 70 }, { 60, 30 }, { 80, 40 } });
//        Console.WriteLine(result);


//    }
//}
