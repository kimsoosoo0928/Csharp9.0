using System;

namespace ex04_14
{
    class Program
    {
        private static void OutpuArrayInfo(Array arr)
        {
            Console.WriteLine("배열의 차원 수: " + arr.Rank); // 랭크 프로퍼티
            Console.WriteLine("배열의 요소 수: " + arr.Length); // 랭스 프로퍼티 
            Console.WriteLine();
        }

        private static void OutputArrayElement(string title , Array arr)
        {
            Console.WriteLine("[" + title + "]");

            for (int i=0; <arr.Length; i++)
            {
                Console.WriteLine(arr.GetValue(i) + ", "); // getvalue 인스턴스 메서드
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            bool[,] boolArray = new bool[,] { { true, false }, { false, false } };
            OutpuArrayInfo(boolArray);

            int[] intArray = new int[] { 5, 4, 3, 2, 1, 0 };
            OutpuArrayInfo(intArray);

            OutputArrayElement("원본 intArray", intArray);
            Array.Sort(intArray); // Sort 정적 메서드 
            OutputArrayElement("Array.Sort 후 intArray", intArray);

            int[] copyArray = new int[intArray.Length];
            Array.Copy(intArray, copyArray, intArray.Length);

            OutputArrayElement("intArray로부터 복사된 copyArray", copyArray);
        }
    }
}
