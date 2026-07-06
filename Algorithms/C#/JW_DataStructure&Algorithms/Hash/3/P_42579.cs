using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


//https://school.programmers.co.kr/learn/courses/30/lessons/42579
public class P_42579
{
    public int[] solution(string[] genres, int[] plays)
    {

        List<int> answer = new List<int>();
        //2개식 모아 선정

        //속한 노래가 많이 재생된 장르 먼저 수록

        //장르내 많이 재생된 노래 2개 수록


        //장르별로 어떤게 많이 재생됐는지 알아야함
        var genreSum = new Dictionary<string, int>();

        //재생 횟수가 같으면 고유 번호가 낮은 노래 먼저 수록(예외처리)
        var comparer = Comparer<(int count, int ID)>.Create((a, b) =>
        {
            if (a.count == b.count)
            {
                return a.ID.CompareTo(b.ID);
            }

            return b.count.CompareTo(a.count);
        });


        //장르별로 재생된 노래를 기준으로 정렬하고 ID도 알아야함
        var genreList = new Dictionary<string, SortedSet<(int count, int id)>>();

        for (int i = 0; i < genres.Length; i++)
        {
            int ID = i;
            int count = plays[i];
            string category = genres[i];

            //장르별로 누적합 계산
            genreSum.TryGetValue(category, out int current);
            genreSum[category] = current + count;

            //장르별로 각 재생 횟수 ID 정리
            if (!genreList.ContainsKey(category))//만약 새로운 장르이고 SortedSet 초기화가 안되었다면 초기화
            {
                genreList[category] = new SortedSet<(int count, int id)>(comparer);
            }

            genreList[category].Add((count, ID));
        }

        var orderedGenre = genreSum.OrderByDescending(x => x.Value).Select(x => x.Key);

        foreach (var genre in orderedGenre)
        {
            var twoSongs = genreList[genre].Take(2).ToArray();

            foreach (var item in twoSongs)
            {
                answer.Add(item.id);
            }

        }

        return answer.ToArray();


        ////더 효율적인 방법

        //var sum = new Dictionary<string, int>();
        //var top = new Dictionary<string, List<int>>(); // 장르 -> 상위 곡 인덱스 최대 2개

        //for (int i = 0; i < genres.Length; i++)
        //{
        //    string g = genres[i];

        //    sum.TryGetValue(g, out int s);
        //    sum[g] = s + plays[i];

        //    if (!top.ContainsKey(g)) top[g] = new List<int>();
        //    var list = top[g];

        //    list.Add(i);
        //    // 원소가 최대 3개뿐이라 이 정렬은 사실상 O(1)
        //    list.Sort((a, b) =>
        //        plays[a] != plays[b] ? plays[b].CompareTo(plays[a]) : a.CompareTo(b));
        //    if (list.Count > 2) list.RemoveAt(2); // 3등은 버림
        //}

        //var answer = new List<int>();
        //foreach (var g in sum.OrderByDescending(x => x.Value).Select(x => x.Key))
        //    answer.AddRange(top[g]);

        //return answer.ToArray();
    }

    static void Main()
    {
        var solution = new P_42579();

        // 테스트 케이스 1: 기본 예제
        string[] genres1 = { "classic", "pop", "classic", "classic", "pop" };
        int[] plays1 = { 500, 600, 150, 800, 2500 };
        int[] result1 = solution.solution(genres1, plays1);
        Console.WriteLine("Test 1: " + string.Join(", ", result1));
        // 예상 결과: [4, 1, 3, 0]
        // 설명: pop 장르(총 3100) -> 4(2500), 1(600)
        //       classic 장르(총 1450) -> 3(800), 0(500)

        // 테스트 케이스 2: 동일한 재생 횟수 (고유번호 낮은 순)
        string[] genres2 = { "pop", "pop", "pop" };
        int[] plays2 = { 100, 100, 100 };
        int[] result2 = solution.solution(genres2, plays2);
        Console.WriteLine("Test 2: " + string.Join(", ", result2));
        // 예상 결과: [0, 1]
        // 설명: 재생 횟수 같으면 고유번호 낮은 순

        // 테스트 케이스 3: 장르 내 곡이 1개만
        string[] genres3 = { "classic", "pop", "jazz" };
        int[] plays3 = { 500, 600, 800 };
        int[] result3 = solution.solution(genres3, plays3);
        Console.WriteLine("Test 3: " + string.Join(", ", result3));
        // 예상 결과: [2, 1, 0]
        // 설명: jazz(800) -> 2, pop(600) -> 1, classic(500) -> 0

        // 테스트 케이스 4: 여러 장르, 복잡한 케이스
        string[] genres4 = { "classic", "pop", "classic", "jazz", "pop", "jazz" };
        int[] plays4 = { 400, 3000, 500, 200, 2500, 300 };
        int[] result4 = solution.solution(genres4, plays4);
        Console.WriteLine("Test 4: " + string.Join(", ", result4));
        // 예상 결과: [1, 4, 2, 0, 5, 3]
        // 설명: pop(5500) -> 1(3000), 4(2500)
        //       classic(900) -> 2(500), 0(400)
        //       jazz(500) -> 5(300), 3(200)

        // 테스트 케이스 5: 동일 장르 내 재생 수 동일 + ID 확인
        string[] genres5 = { "pop", "pop", "pop", "pop" };
        int[] plays5 = { 1000, 1000, 500, 500 };
        int[] result5 = solution.solution(genres5, plays5);
        Console.WriteLine("Test 5: " + string.Join(", ", result5));
        // 예상 결과: [0, 1]
        // 설명: 1000회 재생 중 ID 낮은 0, 1 선택
    }
}