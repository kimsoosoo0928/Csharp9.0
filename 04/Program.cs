using System;

namespace _04
{
    struct Vector // 구조체는 인스턴스가 가진 메모리 자체가 복사되어 새로운 변수에 대입 : 깊은 복사
    {
        public int X;
        public int Y;
    }

    class Point // // 참조 형식 : 얕은 복사 
    {
        public int X;
        public int Y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector v1;

            v1.X = 5;
            v1.Y = 10;

            Change(v1); // 메서드 호출 후 v1의 값에는 변함이 없음
            Console.WriteLine("v1 : X = " + v1.X + ", Y = " + v1.Y);

        }

        private static void Change(Vector vt)
        {
            vt.X = 7;
            vt.Y = 14;
        }
    }
}

//v1: X = 5, Y = 10