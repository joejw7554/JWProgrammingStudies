//using System;
//using System.Collections.Generic;

//public class StackQueue
//{
//    public bool solution(string s) //단순 스택만 이용해서 풀기
//    {
//        var stack = new Stack<char>();


//        foreach (var item in s)
//        {
//            if (item == '(' || item == '[' || item == '{')
//            {
//                stack.Push(item);
//            }
//            else //아이템이 ) ] } 일경우
//            {
//                char temp;
//                if (stack.TryPop(out temp)) //stack 요소가 있다면
//                {
//                    switch (item) //스택에서 꺼낸 요소와 item 이 같은 괄호 짝이 아니라면 실패
//                    {
//                        case ')':
//                            if (temp != '(') return false;
//                            break;

//                        case ']':
//                            if (temp != '[') return false;
//                            break;

//                        case '}':
//                            if (temp != '{') return false;
//                            break;

//                    }
//                }
//                else //스택에 아무것도 없어도 실패
//                {
//                    return false;
//                }
//            }
//        }

//        if (stack.Count > 0) return false; //아직도 스택에 남아있다는건 짝이 안맞다는뜻


//        return true;
//    }

//    public bool solution2(string s)  //Dictionary<char, char>를 사용해 짝을 미리 정의하여 풀어보기
//    {
//        var dic = new Dictionary<char, char>
//        {
//            {'(', ')' },
//            {'[', ']' },
//            {'{', '}' }
//        };

//        var stack = new Stack<char>();

//        foreach (var item in s)
//        {
//            if (item == '(' || item == '[' || item == '{')
//            {

//            }
//        }




//        return false;
//    }

//}


//class StackQueueTest
//{
//    static void Main(string[] args)
//    {
//        StackQueue sol = new StackQueue();

//        // 테스트 케이스들
//        string[] testCases = {
//            "()[]{}",        // True
//            "([{}])",        // True (중첩된 구조)
//            "(]",            // False (다른 종류의 짝)
//            "([)]",          // False (교차된 순서 - Stack이 필요한 이유!)
//            "(",             // False (닫히지 않음)
//            ")",             // False (열리지 않음)
//            "{{[[(())]]}}"   // True
//        };

//        Console.WriteLine("--- 괄호 판별 테스트 시작 ---");
//        foreach (var s in testCases)
//        {
//            bool result = sol.solution(s);
//            Console.WriteLine($"입력: {s,-15} => 결과: {result}");
//        }
//    }
//}