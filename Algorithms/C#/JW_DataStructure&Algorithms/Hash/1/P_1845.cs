//using System;
//using System.Collections.Generic;
//using System.Numerics;
//using System.Text;


////https://school.programmers.co.kr/learn/courses/30/lessons/1845
//class P_1845
//{
//    int solution(int[] nums)
//    {
//        int selectlimit = nums.Length / 2;

//        ////Dictionary<포켓몬 번호, 갯수> 이런식으로 저장하고

//        ////Dictionary Key값 갯수를 세어보면 되는거잖아? Key값이 포켓몬 종류(번호) 니까 

//        ////이게 만약 key.Count >= selectLimit 이면 selectLimit을 반환하고 아니면

//        ////KeyCount 갯수를 반환하면 되는거잖아 현재 종류가 N/2보다 작다면  현재 종류만큼밖에 못가져가니까 그게 최대인거지


//        //var monsterList = new Dictionary<int, int>();
//        //foreach (int type in nums)
//        //{
//        //    monsterList.TryGetValue(type, out int count);
//        //    monsterList[type] = count + 1;
//        //}

//        //if (monsterList.Count >= selectlimit) return selectlimit;
//        //else return monsterList.Count;

//        //다른 방안
        
//        var hash = new HashSet<int>(nums); //비록 이렇게 작성했어도 내부적으로는 foreach 문을 통해 하나하나 해쉬에 추가하는것이고 그 과정에서 중복이 발생하는지 체크하는거구나

//        return Math.Min(hash.Count, selectlimit);

//    }

//    static void Main()
//    {
//        var test = new P_1845();

//        var result = test.solution([3, 1, 2, 3]);
//        var result2 = test.solution([3, 3, 3, 2, 2, 4]);
//        var result3 = test.solution([3, 3, 3, 2, 2, 2]);


//        Console.WriteLine(result);
//        Console.WriteLine(result2);
//        Console.WriteLine(result3);

//    }


//}
