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
        //풀이 방향

        //결국엔 결과는 재생된 횟수가 가장 높은 순서대로 정렬하되 재생 순서가 같다면 고유번호가 낮은거부터 먼저 정렬하라는 예외사항인거네?

        //그럼 Dict에서 <string,KeyValuePair<ID, PlayTime> = <장르, <ID, 재생된횟수>> 이런식으로 한다면 Category별로 묶을 수도있고 각각 고유 ID의 재생시간도 알 수 있겠네

        var comparer = Comparer<(int play, int id)>.Create((x, y) =>
        {
            if (x.play == y.play)
            {
                return x.id.CompareTo(y.id);
            }
            return y.play.CompareTo(x.play);
        });

        var ranks = new Dictionary<string, SortedSet<(int play, int id)>>();
        var genrePlaySum = new Dictionary<string, int>();

        //음 여기서 이거에 대한 예외처리 해야할꺼같은데 :장르 내에서 재생 횟수가 같은 노래 중에서는 고유 번호가 낮은 노래를 먼저 수록합니다

        for (int i = 0; i < genres.Length; i++)
        {
            string genre = genres[i];
            int ID = i;
            int playCount = plays[i];


            genrePlaySum.TryGetValue(genre, out int current);
            genrePlaySum[genre] = current + playCount;

            if (!ranks.ContainsKey(genre))
            {
                ranks[genre] = new SortedSet<(int play, int id)>(comparer);
            }

            ranks[genre].Add((playCount, ID));
        }

        var sortedGenres = genrePlaySum.OrderByDescending(x => x.Value).Select(x => x.Key);

        foreach (var genre in sortedGenres)
        {
            foreach (var song in ranks[genre].Take(2))
            {
                answer.Add(song.id);
            }
        }



        //이제 여기서 정렬을 해서 출력해야겠지

        //rank 에서 가장 많이 수록된 장르가 무엇인지 찾아야겠네 어? 생각해보니 리스트여야겠네 여러개 저장해야되잖아? => 여기서 리스트로 반영한 아이디어 생각해냄

        //잠깐 근데 재생횟수가 모두 다르다했고 내가 정렬해야할때는 재생횟수 순으로 해야하니까 ID 순이나이라 (재생횟수, ID)이게 더 효율적이겠네 그리고 정렬을 해주는 자료구조를 써야겠네 orderedSet같은거
        //List에서 SortedSet으로 바꾸고 playCount위주로 정렬되도록 반영


        //이렇게해도 여전히 내가 Dict에서 장르별로 몇개인지 확인해서 Max를 찾아야하는건가
        //이렇게하면 정렬도 되고 몇개인지 확인 가능하니 순서대로 다 하나씩 answer에 추가하면 되는거겠네?




        return answer.ToArray();
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