using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TestC_Proj;

namespace TestC_Proj
{
    internal class Heap
    {
        private List<int> heapContainer;

        

        public Heap(int initialValue) 
        {
            heapContainer = new List<int> { initialValue };
        }

        public void Insert(int value)
        {
            heapContainer.Add(value);

            int currentIdx = heapContainer.Count - 1;
            int parentIdx = GetParentcurrentIdx(currentIdx);

            if (parentIdx < 0) return;

            while (heapContainer[currentIdx] > heapContainer[parentIdx] && parentIdx >= 0) //parent Index가 0미만이아니고 자식이 부모보다 크다면 교환
            {
                Swap(currentIdx, parentIdx);
                currentIdx = parentIdx;
                parentIdx = GetParentcurrentIdx(currentIdx);
            }
        }

        public void Remove(int value)
        {

        }

        public void Display()
        {
            int index = 0;
            int level = 1;
            int levelSize = 1;

            while (index < heapContainer.Count)
            {
                Console.Write($"Level {level}: ");

                for (int i = 0; i < levelSize && index < heapContainer.Count; i++)
                {
                    Console.Write($"{heapContainer[index]} ");
                    index++;
                }

                Console.WriteLine();
                level = level + 1;
                levelSize = levelSize * 2;
            }
        }

        void Swap(int sourcecurrentIdx, int targetcurrentIdx)
        {
            int temp = heapContainer[sourcecurrentIdx];
            heapContainer[sourcecurrentIdx] = heapContainer[targetcurrentIdx];
            heapContainer[targetcurrentIdx] = temp;
        }

        int GetParentcurrentIdx(int currentIdx)
        {
            return (currentIdx - 1) / 2;
        }

        int GetLeftcurrentIdx(int currentIdx)
        {
            return currentIdx * 2 + 1;
        }

        int GetRightcurrentIdx(int currentIdx)
        {
            return currentIdx * 2 + 2;
        }
    }
}


class HeapTest
{ 
    static void Main()
    {
        Heap heap= new Heap(200);

        heap.Insert(300);
        heap.Insert(400);
        heap.Insert(500);
        heap.Insert(600);
        heap.Insert(700);
        heap.Insert(800);
        heap.Insert(900);
        heap.Insert(1000);
        heap.Insert(4000);

        heap.Display();


    }
}

