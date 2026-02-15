//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Text;


////https://school.programmers.co.kr/learn/courses/30/lessons/1844


//namespace TestC_Proj.DFS_BFS
//{
//    class Solution
//    {
//        bool[,] visited;

//        public int solution(int[,] maps)
//        {

//            int maxRow = maps.GetLength(0);
//            int maxCol = maps.GetLength(1);

//            visited = new bool[maxRow, maxCol];
//            visited[0, 0] = true;

//            ////BFS
//            //int[] dx = new int[] { 1, 0, -1, 0 };
//            //int[] dy = new int[] { 0, 1, 0, -1 };

//            //Queue<(int, int, int)> queue = new Queue<(int, int, int)>();
//            //queue.Enqueue((0, 0, 1));

//            //while (queue.Count > 0)
//            //{
//            //    //꺼내고 방문처리
//            //    (int row, int col, int distance) = queue.Dequeue();

//            //    //목표지점 도착하면 조기종료
//            //    if (row == maxRow - 1 && col == maxCol - 1) return distance;


//            //    //해당 구역에서 모든 방향을 탐색한다
//            //    for (int i = 0; i < dx.Length; i++)
//            //    {
//            //        int nextR = row + dy[i];
//            //        int nextC = col + dx[i];

//            //        //Index 이내인가
//            //        if (IsVaild(nextR, nextC, maxRow, maxCol) && IsPath(nextR, nextC, maps) && visited[nextR, nextC] == false)
//            //        {
//            //            visited[nextR, nextC] = true;
//            //            queue.Enqueue((nextR, nextC, distance + 1));
//            //        }
//            //    }
//            //}



//            return -1;
//        }

//        static bool IsVaild(int row, int col, int maxRow, int maxCol)
//        {
//            return row >= 0 && row < maxRow && col >= 0 && col < maxCol;
//        }

//        static bool IsPath(int row, int col, int[,] maps)
//        {
//            return maps[row, col] == 1;
//        }

//        static void Main()
//        {
//            var sol = new Solution();

//            // 테스트 케이스 1: 기본 최단 경로 (5x5)
//            int[,] test1 = {
//                {1, 0, 1, 1, 1},
//                {1, 0, 1, 0, 1},
//                {1, 0, 1, 1, 1},
//                {1, 1, 1, 0, 1},
//                {0, 0, 0, 0, 1}
//            };
//            Console.WriteLine($"테스트 1: {sol.solution(test1)} (예상: 11)");

//            // 테스트 케이스 2: 도달 불가능
//            int[,] test2 = {
//                {1, 0, 1, 1, 1},
//                {1, 0, 1, 0, 1},
//                {1, 0, 1, 1, 1},
//                {1, 1, 1, 0, 0},
//                {0, 0, 0, 0, 1}
//            };
//            Console.WriteLine($"테스트 2: {sol.solution(test2)} (예상: -1)");

//            // 테스트 케이스 3: 직선 경로 (2x5)
//            int[,] test3 = {
//                {1, 1, 1, 1, 1},
//                {0, 0, 0, 0, 1}
//            };
//            Console.WriteLine($"테스트 3: {sol.solution(test3)} (예상: 6)");

//            // 테스트 케이스 4: 최소 맵 (1x1)
//            int[,] test4 = {
//                {1}
//            };
//            Console.WriteLine($"테스트 4: {sol.solution(test4)} (예상: 1)");

//            // 테스트 케이스 5: 우회 경로
//            int[,] test5 = {
//                {1, 1, 1, 1},
//                {0, 0, 0, 1},
//                {1, 1, 1, 1},
//                {1, 0, 0, 1}
//            };
//            Console.WriteLine($"테스트 5: {sol.solution(test5)} (예상: 7)");
//        }
//    }
//}
