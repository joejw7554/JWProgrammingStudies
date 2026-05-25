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
//            maxWidth = Math.Max(maxWidth, Math.Max(sizes[i, 0], sizes[i, 1]));
//            maxHeight = Math.Max(maxHeight, Math.Max(sizes[i, 0], sizes[i, 1]));
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
