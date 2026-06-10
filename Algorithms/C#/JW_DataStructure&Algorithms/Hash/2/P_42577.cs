using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

//https://school.programmers.co.kr/learn/courses/30/lessons/42577
class P_42577
{
    bool solution(string[] phone_book)
    {

        //접두어가 있으면 answer=false 처리

        //그런데 이걸 무조건 첫번쨰꺼 기준으로 비교하면 쉬운데 아니라면 다른 문제인데..

        //일단 첫번쨰꺼로 무조건 기준을 잡는다는 가정하에 풀게되면


        //통쨰로 해시에 집어넣기
        var hash = new HashSet<string>(phone_book);

        //번호 하나씩 꺼내어 검사
        for (int i = 0; i < phone_book.Length; i++)
        {
            string currentNumber = phone_book[i];
            StringBuilder sb = new StringBuilder();

            //마지막에 자기 자신을 검사하면 안되니까 마지막 인덱스전에 끝낸다
            for (int j = 0; j < currentNumber.Length - 1; j++)
            {
                //접두어를 하나하나 붙여가고
                sb.Append(currentNumber[j]);

                //여기서 확인해본다
                if (hash.Contains(sb.ToString()))
                {
                    return false;
                }
            }

        }


        return true;
    }

    static void Main()
    {

        var test = new P_42577();

        var result = test.solution(["119", "97674223", "1195524421"]);
        var result2 = test.solution(["123", "456", "789"]);
        var result3 = test.solution(["12", "123", "1235", "567", "88"]);


        Console.WriteLine(result);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
    }


}
