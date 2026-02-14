//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;


//class Result
//{

//    /*
//     * Complete the 'chess_puzzle' function below.
//     *
//     * The function accepts INTEGER n as parameter.
//     */

//    //우 우하// 하// 좌하// 좌// //좌상// 상// 우상
//    static int[] dx = new int[] { 1, 1, 0, -1, -1, -1, 0, 1 };
//    static int[] dy = new int[] { 0, 1, 1, 1, 0, -1, -1, -1 };
//    static bool[,] field;

//    public static void chess_puzzle(int n)
//    {
//        field = new bool[n, n];


//        BackTrack(0, 0, field);
//    }

//    static void BackTrack(int row, int col, bool[,] field)
//    {
//        int max = field.GetLength(0);
        
//        if (row == max) return;


//        for (int i = 0; i < field.GetLength(0); i++)
//        {
//           if(!IsOverlapped(row,i, max, field))
//            {
//                field[row, i] = true;
//                BackTrack(row + 1, 0, field);
//                field[row, i] = false;
//            }
//        }



//    }

//    private static void ShowResult(bool[,] field)
//    {
//        for (int m = 0; m < field.GetLength(0); m++)
//        {
//            for (int n = 0; n < field.GetLength(0); n++)
//            {
//                if (field[m, n] == true)
//                {
//                    Console.WriteLine($"{m} {n}");
//                }
//            }
//        }
//    }

//    static bool IsOverlapped(int row, int col, int n, bool[,] copy)
//    {
//        int direction = 0;

//        do//8방향 모두 검사
//        {
//            int nextRow = row + dy[direction];
//            int nextCol = col + dx[direction];

//            while (IsInBoundary(nextRow, nextCol, n))
//            {
//                if (copy[nextRow, nextCol] == true) //해당 방향에 퀸이 있다면 Overlap true 바로 리턴
//                {
//                    return true;
//                }

//                nextRow += dy[direction];
//                nextCol += dx[direction];
//            }

//            direction = (direction + 1) % 8;
//        }
//        while (direction != 0);


//        return false;
//    }

//    static bool IsInBoundary(int row, int col, int n)
//    {
//        return (row >= 0 && row < n && col >= 0 && col < n);
//    }



//}
//class Solution
//{
//    public static void Main(string[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine().Trim());

//        Result.chess_puzzle(n);
//    }
//}
