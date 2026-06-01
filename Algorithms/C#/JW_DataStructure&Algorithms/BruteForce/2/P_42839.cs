//using System;
//using System.Collections.Generic;
//using System.Runtime.InteropServices;
//using System.Text;

////https://school.programmers.co.kr/learn/courses/30/lessons/42839
//class P_42839
//{
//    public int solution(string numbers)
//    {
//        int answer = 0;

//        //DFS 와 BackTracking을 활용해야한다고?

//        int n = numbers.Length;
//        bool[] used = new bool[n];    //visted로 체크해야겠네?
//        HashSet<int> hash = new HashSet<int>();  //hashSet으로 중복 막고 Int 타입 저장하면 되겠네?

//        //아니 그런데 IndexOf 로 idx 추출한다해도 만약 같은 숫자가 여러개면??


//        DFS(numbers, "", used, hash);

//        //이제 여기서 hash 의 있는 숫자들이 소수인지 아닌지 어떻게 판별하는가
//        foreach (var element in hash)
//        {
//            if (IsPrime(element))
//            {
//                answer++;
//            }
//        }

//        return answer;
//    }

//    public void DFS(string numbers, string current, bool[] used, HashSet<int> hash)
//    {
//        if (current != "")
//        {
//            hash.Add(int.Parse(current));
//        }

//        for (int i = 0; i < numbers.Length; i++)
//        {
//            if (!used[i])
//            {
//                used[i] = true;
//                string next = current + numbers[i];
//                DFS(numbers, next, used, hash);
//                used[i] = false;
//            }
//        }
//    }

//    bool IsPrime(int num)
//    {
//        if (num <= 1) return false;

//        for (int i = 2; i * i <= num; i++)
//        {
//            if (num % i == 0)
//            {
//                return false;
//            }
//        }

//        return true;

//    }
//    static void Main()
//    {
//        var test = new P_42839();
//        var result = test.solution("17");
//        Console.WriteLine(result);
//    }
//}
