using System;
using System.Collections.Generic;
using System.Text;


//https://school.programmers.co.kr/learn/courses/30/lessons/42578
class P_42578
{
    public int solution(string[,] clothes)
    {
        int answer = 0;


        //전부 하나씩 해봐야하는거라서 BruteForce의 BackTracking으로 풀어야할꺼같은 느낌인데... 

        //옷을 종류별로 컨테이러르 나누어서 풀어야하는걸까?

        //얼굴 상의 하의 겉옷 이런식으로 미리 나눠서 ?

        //그다음 옷의 조합을 맞추는 CurrentWear를 해쉬테이블로해야겠네? 중복되면 안되니까?

        //어떻게 풀어야하는거지?

        //4개의 컨테이너로 4중 반복문은 절대 아닐꺼란 말이지

        //해답 -> 딕션너리로 종류를 나눠보라고? 그러고 어떤 선택지가 남는지 생각해보라고? 

        var dict = new Dictionary<string, int>();

        for (int i = 0; i < clothes.GetLength(0); i++)
        {
            string type = clothes[i, 1];
            dict.TryGetValue(type, out int count);
            dict[type] = count + 1;
        }


        //아이템이 2개(A,B)가 있다면 선택지는 3개 A입기 또는  B입기 + 아무것도 안입기 (ItemCount+1)
        answer = 1;
        foreach (var count in dict.Values)
        {
            answer = answer * (count+1); 
        }

        answer = answer - 1; //나체인 경우는 없으니 -1
        return answer;
    }

    static void Main()
    {
        P_42578 p = new P_42578();

        // 테스트 1: headgear 2개, eyewear 1개 → 5
        Console.WriteLine(p.solution(new string[,]
        {
            { "yellowhat",      "headgear" },
            { "bluesunglasses", "eyewear"  },
            { "green_turban",   "headgear" }
        }) == 5 ? "TC1 통과" : "TC1 실패");

        // 테스트 2: face 3개 → 3
        Console.WriteLine(p.solution(new string[,]
        {
            { "crowmask",       "face" },
            { "bluesunglasses", "face" },
            { "smoky_makeup",   "face" }
        }) == 3 ? "TC2 통과" : "TC2 실패");
    }
}  