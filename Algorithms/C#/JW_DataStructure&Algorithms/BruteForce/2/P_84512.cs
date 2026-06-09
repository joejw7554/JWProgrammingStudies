using System;
using System.Collections.Generic;
using System.Text;

//https://school.programmers.co.kr/learn/courses/30/lessons/84512
class P_84512
{
    List<string> allWords = new List<string>();
    char[] vowels = { 'A', 'E', 'I', 'O', 'U' };

    public int solution(string word)
    {
        //최대 단어는 5개

        //규칙이 뭐지? 왜 AAAAA가 5인거지? 순서대로 해서 5인거잖아? 이게 무슨 규칙이지?

        //결국 알파뱃 순서대로의 조합이잖아? 그리고 나올 수 있는 최대 경우의 수는 1번째(A,E,I,O,U)5가지 *2번째(A,E,I,O,U)5가지  *... 5번쨰 = 5의 5승  이게 힌트인거 같은데

        //아 규칙을 모르겠는데?? A=1 E=2 ... U=5 이런식으로 두고 규칙을 찾아야하나? 이건 아닌거같은데 
        //일일히 조합하는건 아니고 규칙을 찾는게 관건인거야..

        //해답=> DFS 

        //if (allWords.Count == 0)
        //{
        //    DFS("");
        //}
        //var index = allWords.IndexOf(word); //인덱스 0부터 시작해서 +1 해야함

        //if (index == -1) return -1;

        //return index + 1;


        //인덱싱을 이용하여 푸는 방법


        int answer = 0;

        // 각 자리수별로 다음 알파벳으로 넘어갈 때 건너뛰는 단어의 개수 (가중치)
        int[] weights = { 781, 156, 31, 6, 1 };

        // 알파벳별 인덱스 매핑을 쉽게 하기 위한 문자열
        string vowels = "AEIOU";

        for (int i = 0; i < word.Length; i++)
        {
            // 현재 글자가 A, E, I, O, U 중 몇 번째 인덱스인지 찾음 (A=0, E=1...)
            int index = vowels.IndexOf(word[i]);

            // (내가 건너뛴 분량) + (글자 자체의 카운트 1)
            answer += (index * weights[i]) + 1;
        }

        return answer;
    }

    void DFS(string current)
    {
        if (current != "")
            allWords.Add(current);

        if (current.Length == 5) return;

        for (int i = 0; i < vowels.Length; i++)
        {
            DFS(current + vowels[i]);
        }
    }

    static void Main()
    {
        var test = new P_84512();

        // 테스트 케이스
        Console.WriteLine(test.solution("AAAAE"));      // 예상: 6
        Console.WriteLine(test.solution("AAAI"));      
        Console.WriteLine(test.solution("I"));         // 예상: 1563      
        Console.WriteLine(test.solution("EIO"));         // 예상: 1189
    }
}
