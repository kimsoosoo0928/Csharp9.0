using System;

namespace _01
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

            Vector v2 = v1; // 값 형식의 대입

            Point pt1 = new Point();
            pt1.X = 6;
            pt1.Y = 12;

            Point pt2 = pt1; // 참조 형식의 대입


        }
    }
}
