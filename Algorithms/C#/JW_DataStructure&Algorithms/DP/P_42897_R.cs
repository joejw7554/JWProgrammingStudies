//using System;
//using System.Collections.Generic;
//using System.Numerics;
//using System.Text;

////https://school.programmers.co.kr/learn/courses/30/lessons/42897

//class P_42897_R
//{

//    int solution(int[] money)
//    {
        
//        int n = money.Length;

//        if (n == 1)
//            return money[0];
        
//        int[] dp1 = new int[n];
//        int[] dp2 = new int[n];

//        dp1[0] = money[0];
//        dp1[1] = Math.Max(money[0], money[1]);

//        for (int i = 2; i < n - 1; i++)
//        {
//            dp1[i] = Math.Max(dp1[i - 1], dp1[i - 2] + money[i]);
//        }

//        dp2[0] = 0;
//        dp2[1] = money[1];
//        for (int i = 2; i < n; i++)
//        {
//            dp2[i] = Math.Max(dp2[i - 1], dp2[i - 2] + money[i]);
//        }


//        int answer = Math.Max(dp2[n-1], dp1[n-2]);



//        return answer;
//    }

//    static void Main()
//    {
//        var sol = new P_42897_R();
//        var result = sol.solution(new int[] { 1,2,3,1 });
//        Console.WriteLine(result);


//    }

//}
