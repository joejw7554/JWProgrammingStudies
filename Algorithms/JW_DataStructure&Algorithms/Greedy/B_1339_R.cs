//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

////https://www.acmicpc.net/problem/1339
//class B_1339_R
//{
//    static void Main()
//    {
//        int Count = int.Parse(Console.ReadLine());

//        List<string> str = new List<string>();
//        for (int i = 0; i < Count; i++)
//        {
//            str.Add(Console.ReadLine());
//        }

//        //알파벳에 숫자를 배정한다
//        Dictionary<char, int> weight = new Dictionary<char, int>();

//        foreach (string member in str)
//        {
//            int length = member.Length;
//            for (int i = 0; i < member.Length; i++)
//            {
//                if (weight.ContainsKey(member[i]))
//                {
//                    weight[member[i]] += (int)Math.Pow(10, length - 1 - i);
//                }
//                else
//                {
//                    weight.Add(member[i], (int)Math.Pow(10, length - 1 - i));
//                }
//            }
//        }

//        //가중치대로 정렬을 한다
//        var list = weight.ToList();
//        list.Sort((a, b) => b.Value.CompareTo(a.Value));

//        //가중치대로 정렬한 리스트를 토대로 새로운 Dictionary에 가중치가 큰거 부터 큰값을 부여한다
//        Dictionary<char, int> assigned = new Dictionary<char, int>();
//        int number = 9;

//        foreach (var item in list)
//        {
//            assigned[item.Key] = number--;
//        }

//        //계산한다
//        int sum = 0;

//        foreach (var item in str)
//        {
//            for (int i = 0; i < item.Length; i++)
//            {
//                sum += assigned[item[i]] * (int)Math.Pow(10, item.Length - 1 - i);
//            }
//        }

//        //값을 출력한다
//        Console.WriteLine(sum);
//    }
//}
