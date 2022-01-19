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
            Point pt1 = new Point();

            pt1.X = 5;
            pt1.Y = 10;

            Change(pt1); // 메서드 호출 후 v1의 값에는 변함이 없음
            Console.WriteLine("pt1 : X = " + pt1.X + ", Y = " + pt1.Y);

        }

        private static void Change(Point pt)
        {
            pt.X = 7;
            pt.Y = 14;
        }
    }
}

//pt1: X = 7, Y = 14