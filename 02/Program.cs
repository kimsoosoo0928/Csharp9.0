using System;

namespace _02
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

            Vector v2 = v1; // 값 형식의 대입은 인스턴스의 메모리 자체가 복사됨

            v2.X = 7;
            v2.Y = 14;

            Console.WriteLine("v1: X= " + v1.X + ",Y = " + v1.Y);
            Console.WriteLine("v2: X= " + v2.X + ",Y = " + v2.Y);


        }
    }
}


//v1: X = 5,Y = 10
//v2: X = 7,Y = 14