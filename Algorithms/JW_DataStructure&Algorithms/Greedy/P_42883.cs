//using System;
//using System.Collections.Generic;
//using System.Text;

////https://school.programmers.co.kr/learn/courses/30/lessons/42883
//class P_42883
//{
//    public string solution(string number, int k)
//    {
//        string answer = "";
//        int removeCount = 0;

//        Stack<char> stack = new Stack<char>();

//        foreach (var item in number)
//        {
//            //지금 스택의 Top이 item 보다 큰지 확인해서 끝까지 다 뺀다
//            //RemoveCount가 K보다 작아야한다
//            //빈 stack이 아니어야한다
//            while (stack.Count > 0 &&
//                   removeCount < k&&  
//                   stack.Peek() < item  )
//            {
//                stack.Pop();
//                removeCount++;
//            }

//            stack.Push(item);
//        }

       
//        while(removeCount<k)
//        {
//            stack.Pop();
//            removeCount++;
//        }

//        StringBuilder sb;
//        char[] temp = stack.ToArray();
//        Array.Reverse(temp);

//        answer = new string(temp);

//        return answer;
//    }
//}
