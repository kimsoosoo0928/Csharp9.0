using System;

namespace _03
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

            Point pt2 = pt1; // 참조 형식의 대입은 참조 주소만 복사됨

            pt2.X = 7;
            pt2.Y = 14;


            Console.WriteLine("pt1: X = "+ pt1.X+ ",Y=" + pt1.Y);
            Console.WriteLine("pt2: X = " + pt2.X + ",Y=" + pt2.Y);

        }
    }
}

//pt1: X = 7,Y = 14
//pt2: X = 7,Y = 14