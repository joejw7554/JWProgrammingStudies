//using System;
//using System.Collections.Generic;
//using System.Text;

////https://school.programmers.co.kr/learn/courses/30/lessons/42895?language=csharp
//class P_42895
//{
//    public int solution(int N, int number)
//    {
//        if (N == number) return 1;

//        HashSet<int>[] hash = new HashSet<int>[9];
//        //초기화
//        for (int i = 0; i < hash.Length; i++)
//        {
//            hash[i] = new HashSet<int>();
//        }

//        //5숫자 N번까지 넣기

//        for (int n = 1; n <= 8; n++)
//        {
//            hash[n].Add(int.Parse(new string(N.ToString()[0], n)));

//            for (int i = 1; i < n; i++)
//            {
//                int j = n - i;

//                foreach (var a in hash[i])
//                {
//                    foreach (var b in hash[j])
//                    {
//                        hash[n].Add(a + b);
//                        hash[n].Add(a - b);
//                        hash[n].Add(a * b);
//                        if (b != 0) hash[n].Add(a / b);
//                    }
//                }
//            }

//            if (hash[n].Contains(number)) return n;
//        }

//        return -1;
//    }

//    static void Main()
//    {
//        var sol = new P_42895();

//        int result = sol.solution(5, 12);

//        int b = 3;
//    }
//}
