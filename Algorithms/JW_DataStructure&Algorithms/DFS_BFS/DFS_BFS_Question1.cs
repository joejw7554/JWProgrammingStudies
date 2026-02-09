//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Runtime.InteropServices;

//class DFSBFS_Test
//{
//    static void Main(string[] args)
//    {
//        int[,] maps = new int[,]
//        {
//            {1, 0, 1, 1, 1},
//            {1, 0, 1, 0, 1},
//            {1, 0, 1, 1, 1},
//            {1, 1, 1, 0, 1},
//            {0, 0, 0, 0, 1}
//        };

//        DFSBFS solution = new DFSBFS();
//        int result = solution.solution(maps);
//        Console.WriteLine($"Result: {result}");
//    }
//}

//class DFSBFS
//{
//    public int solution(int[,] maps)
//    {
//        int answer = 0;

//        //2중배열 맵으로 방문여부 체크
//        int row = maps.GetLength(0);
//        int col = maps.GetLength(1);

//        bool[,] visited = new bool[row, col];

//        //운직임 방향 dx dy 로 방향 체크 direction변수를 이용하여 방향조정

//        int direction = 0; //기본 방향 
//        (int row, int col, int count) currentLoc = (0, 0, 0);
//        //아래 오른쪽 왼쪽 위
//        int[] dx = new int[] { 0, 1, -1, 0 };
//        int[] dy = new int[] { 1, 0, 0, -1 };


//        int minMove = int.MaxValue;
//        int moveCount = 0;

//        var stack = new Stack<(int row, int col, int count)>(); //Stack을 이용하여 DFS 구현할 예정
//        stack.Push((0, 0, 1));
//        visited[0, 0] = true;

//        while (stack.Count > 0)
//        {
//            currentLoc = stack.Pop();

//            if (currentLoc.row == row - 1 && currentLoc.col == col - 1)
//            {
//                minMove = Math.Min(minMove, moveCount); //목표지점에 도착하면 MinMove갱신 
//                continue;
//            }

//            int i = 0;
//            bool bHasPushed = false;
//            while (i < 4) //4방향 모두 점검하고 이동가능 조건이면 스택에 추가
//            {
//                int nextRow = currentLoc.row + dy[direction];
//                int nextCol = currentLoc.col + dx[direction];
//                moveCount = currentLoc.count;

//                //3가지 조건
//                bool bOverLimit = (nextRow < 0 || nextRow >= row) || (nextCol < 0 || nextCol >= col); //Index 범위 내인가?
//                if (!bOverLimit)
//                {
//                    bool bVisited = visited[nextRow, nextCol] == true; //방문을 한적이 있는가?
//                    bool bIsWall = maps[nextRow, nextCol] == 0; //벽인가?

//                    if (!bOverLimit && !bVisited && !bIsWall) //조건 모두 만족하면 스택에 넣고 새로운 방향 조정 
//                    {
//                        stack.Push((nextRow, nextCol, moveCount + 1));
//                        visited[nextRow, nextCol] = true;
//                        bHasPushed = true;
//                    }
//                }

//                direction = (direction + 1) % 4;

//                i++; //횟수 증가
//            }

//            if (!bHasPushed)//아무것도 push 못했다는건 막다른길이라는뜻이니
//            {
//                break;
//            }
//        }

//        answer = minMove;

//        return answer;
//    }
//}