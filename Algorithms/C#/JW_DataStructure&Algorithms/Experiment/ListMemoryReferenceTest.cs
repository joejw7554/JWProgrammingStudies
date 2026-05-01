using System;
using System.Collections.Generic;

class ListMemoryReferenceTest
{
    static void Main()
    {
        // 1. 외부 리스트 생성
        List<List<int>> outerList = new List<List<int>>();

        // 2. 내부 리스트 생성 및 데이터 삽입
        List<int> innerList = new List<int>();
        innerList.Add(777); // 우리가 찾을 목표 데이터: 777

        outerList.Add(innerList);

        // 여기서 중단점(F9)을 걸고 조사를 시작합니다.
        Console.WriteLine("조사 시작!");
    }
}