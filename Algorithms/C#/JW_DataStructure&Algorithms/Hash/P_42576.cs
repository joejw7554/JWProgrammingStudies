//using System;
//using System.Collections.Generic;
//using System.Numerics;
//using System.Text;
//using System.Xml.Linq;

////https://school.programmers.co.kr/learn/courses/30/lessons/42576
//class P_42576
//{

//    string solution(string[] participant, string[] completion)
//    {
//        string answer = "";


//        //동명 이인이 문제네

//        //해쉬셋을 쓰면 동명이인 집어넣을 때 중복으로 못넣어서 문제 생기는데.. 그럼 동명이인은 어떻게 처리할꺼냐가 문제의 핵심인거네?

//        //단순 배열로 검찾게되면 n*n 의 시간 복잡도가 나오게되겠지..

//        //딕션너리 숫자,인트 로 해서 마지막에 인트 값이 1인것만 출력하게하면 될 문제같은데? 그러면 시간 복잡도는 추가하는데 n  검색도 n 아닌가 결국 배열일떄 검색하는거와 차이가 없는거잖아?

//        //동명이인 처리할 완벽한 자료구조가없다 그냥 동명이인있을때 따로 처리해야하는데 어떻게 처리할것인가의 문제네

//        Dictionary<string, int> dict = new Dictionary<string, int>();

//        foreach (var name in participant)
//        {
//            // 단축 코드 (2줄)
//            dict.TryGetValue(name, out int count); // 1) 값을 일단 꺼내와본다.
//            dict[name] = count + 1;                // 2) 꺼내온 값에 1을 더해서 집어넣는다!
//        }

//        foreach (var item in completion)
//        {
//            dict[item]--;
//        }

//        foreach (var item in dict)
//        {
//            if(item.Value>0)
//            {
//                answer= item.Key;
//            }
//        }

//        return answer;
//    }
//    static void Main()
//    {
//        var test = new P_42576();
//        var result = test.solution(["leo", "kiki", "eden"], ["eden", "kiki"]);
//        var result2 = test.solution(["marina", "josipa", "nikola", "vinko", "filipa"], ["josipa", "filipa", "marina", "nikola"]);
//        var result3 = test.solution(["mislav", "stanko", "mislav", "ana"], ["stanko", "ana", "mislav"]);


//        Console.WriteLine(result);
//        Console.WriteLine(result2);
//        Console.WriteLine(result3);

//    }
//}
