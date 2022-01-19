using System;

namespace _07
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
            Point pt1 = null;

            Change1(pt1); // 메서드 호출 : 얕은 복사
            Console.WriteLine("pt1: " + pt1);

            Change2(ref pt1); // 메서드 호출 : ref 사용 
            Console.WriteLine("pt1: X = " + pt1.X + ", Y = "+ pt1.Y );
            

        }

        private static void Change1(Point pt)
        {
            pt = new Point();

            pt.X = 6;
            pt.Y = 12;
        }
        private static void Change2(ref Point pt)
        {
            pt = new Point();
            
            pt.X = 7;
            pt.Y = 14;
        }
    }
}