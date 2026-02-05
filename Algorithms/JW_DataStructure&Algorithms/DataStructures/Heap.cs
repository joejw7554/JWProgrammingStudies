//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Text;
//using TestC_Proj;

//namespace TestC_Proj
//{
//    internal class Heap<T> where T: IComparable<T>
//    {
//        private List<T> heapContainer;

        

//        public Heap() 
//        {
//            heapContainer = new List<T>();
//        }

//        public void Push(T value) //이부분이 더 간결하게 표현했네
//        {
//            heapContainer.Add(value);

//            int currentIdx = heapContainer.Count - 1;

//            while (currentIdx > 0) //parent Index가 0미만이아니고 자식이 부모보다 크다면 교환
//            {
//                int parentIdx = GetParentcurrentIdx(currentIdx);

//                if (heapContainer[parentIdx].CompareTo(heapContainer[currentIdx]) < 0)
//                {
//                    Swap(currentIdx, parentIdx);
//                    currentIdx = parentIdx;
//                }
//                else
//                {
//                    break;
//                }
//            }
//        }

//        public T Pop()
//        {
//            if (heapContainer.Count == 0) throw new InvalidOperationException("힙 사이즈 0!!!");

//            //루트 노드값 미리 저장하고 마지막 노드를 루트로 올림
//            //int valueToReturn = heapContainer[0];
//            //heapContainer[0]= heapContainer[heapContainer.Count-1];
//            //heapContainer.RemoveAt(heapContainer.Count-1);

//            //이제 루트 노드서부터 비교해서 적절한 자리를 다시 배정해주는 것 (Parent가 작다면 스왑한다)
//            //int currentIdx = 0;

//            //while (currentIdx < heapContainer.Count)
//            //{
//            //    bool hasLIdx = GetLeftcurrentIdx(currentIdx) < heapContainer.Count;
//            //    bool hasRIdx = GetRightcurrentIdx(currentIdx) < heapContainer.Count;

//            //    int LIdx = GetLeftcurrentIdx(currentIdx);
//            //    int RIdx = GetRightcurrentIdx(currentIdx);

//            //    if (hasLIdx) //Left가 존재할경우
//            //    {
//            //        if (hasRIdx) //Right도 존재할 경우
//            //        {
//            //            if (heapContainer[LIdx] > heapContainer[RIdx])
//            //            {
//            //                if (heapContainer[currentIdx] < heapContainer[LIdx])
//            //                {
//            //                    Swap(currentIdx, LIdx);
//            //                    currentIdx = LIdx;
//            //                }
//            //                else break;

//            //            }
//            //            else
//            //            {
//            //                if (heapContainer[currentIdx] < heapContainer[RIdx])
//            //                {
//            //                    Swap(currentIdx, RIdx);
//            //                    currentIdx = RIdx;
//            //                }
//            //                else break;
//            //            }
//            //        }
//            //        else  //Right가 없는 경우
//            //        {
//            //            if (heapContainer[LIdx] > heapContainer[currentIdx])
//            //            {
//            //                Swap(currentIdx, LIdx);
//            //                currentIdx = LIdx;
//            //            }
//            //            else break;
//            //        }
//            //    }
//            //    else break;
//            //}


//            // return valueToReturn;



//            //////////////////////////////////////////////////////////////////// 더 간결한 방식으로 작성
//            //루트 노드 저장해서 마지막에 리턴하고
//            T valueToReturn = heapContainer[0];

//            //제일 마지막 노드를 루트노드로 임명
//            heapContainer[0]= heapContainer[Count - 1];
//            heapContainer.RemoveAt(Count - 1);



//            int currentIdx = 0;
//            int LIdx = 0;
//            int RIdx = 0;

//            //자식들중 가장 큰 값과 교체
//            while (currentIdx < Count)
//            {
//                int targetIdx = currentIdx;
//                LIdx = GetLeftcurrentIdx(currentIdx);
//                RIdx = GetRightcurrentIdx(currentIdx);

//                if (LIdx < Count && heapContainer[targetIdx].CompareTo(heapContainer[LIdx]) <0)
//                {
//                    targetIdx = LIdx;
//                }

//                if (RIdx < Count && heapContainer[targetIdx].CompareTo(  heapContainer[RIdx])<0)
//                {
//                    targetIdx = RIdx;
//                }

//                if (targetIdx == currentIdx) break; //교체할 대상이 현재 인덱스와 같다는건 위의 조건들이 모두 거짓이기에 더이상 교체할 필요가 없다는뜻

//                Swap(currentIdx, targetIdx);
//                currentIdx = targetIdx;
//            }

//            return valueToReturn;
//        }

//        public void Display()
//        {
//            int index = 0;
//            int level = 1;
//            int levelSize = 1;

//            while (index < heapContainer.Count)
//            {
//                Console.Write($"Level {level}: ");

//                for (int i = 0; i < levelSize && index < heapContainer.Count; i++)
//                {
//                    Console.Write($"{heapContainer[index]} ");
//                    index++;
//                }

//                Console.WriteLine();
//                level = level + 1;
//                levelSize = levelSize * 2;
//            }
//        }

//        public T Peek()
//        {
//            if (Count == 0)
//            {
//                throw new InvalidOperationException("Heap size is 0!!"); 
//            }

//            return heapContainer[0];
//        }

//        public void Clear()
//        {
//            heapContainer.Clear();
//        }

//        public bool Contains(T value)
//        {
//            for(int i=0; i<Count; i++)
//            {
//                if (heapContainer[i].Equals(value))
//                {
//                    return true;
//                }
//            }
//            return false;
//        }

//        void Swap(int sourcecurrentIdx, int targetcurrentIdx)
//        {
//            T temp = heapContainer[sourcecurrentIdx];
//            heapContainer[sourcecurrentIdx] = heapContainer[targetcurrentIdx];
//            heapContainer[targetcurrentIdx] = temp;
//        }

//        public int Count => heapContainer.Count;

//        int GetParentcurrentIdx(int currentIdx)
//        {
//            return (currentIdx - 1) / 2;
//        }

//        int GetLeftcurrentIdx(int currentIdx)
//        {
//            return currentIdx * 2 + 1;
//        }

//        int GetRightcurrentIdx(int currentIdx)
//        {
//            return currentIdx * 2 + 2;
//        }

//    }
//}


//class HeapTest
//{ 
//    static void Main()
//    {
//        Heap<int> heap= new Heap<int>();

//        heap.Push(200);
//        heap.Push(300);
//        heap.Push(400);
//        heap.Push(500);
//        heap.Push(600);
//        heap.Push(700);

//        heap.Push(800);
//        heap.Push(900);
//        heap.Push(1000);
//        heap.Push(4000);

//        heap.Display();

//        Console.WriteLine($"{heap.Pop()} Poped");
//        Console.WriteLine($"{heap.Pop()} Poped");





//    }
//}

