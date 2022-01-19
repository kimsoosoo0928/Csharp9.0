////class Computer
////{
////    public void TurnOn()
////    {
////        System.Console.WriteLine("Computer: TurnOn");
////    }
////}

////class Switch
////{
////    public void PowerOn(Computer machine)
////    {
////        machine.TurnOn();
////    }
////}

////class Monitor
////{
////    public void TurnOn()
////    {
////        System.Console.WriteLine("Monitor: TurnOn");
////    }



////}

//interface Ipower
//{
//    void TurnOn();
//}

//class Monitor : IPower
//{
//    public void TurnOn()
//    {
//        System.Console.WriteLine("Monitor : TurnOn");
//    }
//}

//class Switch
//{
//    public void PowerOn(Ipower machine)
//    {
//        machine.TurnOn();
//    }
//

//using System;

//namespace ConsoleApp1
//{
//    struct Vector
//    {
//        public int X;
//        public int Y;

//        public Vector(int x, int y) // 매개변수를 가진 생성자 정의 
//        {
//            this.X = x; // 구조체가 가진 모든 필드를 초기화
//            this.Y = y;
//        }

//        public override string Tostring() // ToString 재정의
//        {
//            return "X : " + X + ", Y = " + Y;
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Vector v1 = new Vector(); // new를 사용해 인스턴스 생성 가능
//            Vector v2; // 

//            Vector v3 = new Vector(5, 10);

//            Console.WriteLine(v3);
//        }
//    }
//        }

//    }
//}

// 값 형식과 참조 형식의 결정적인 차이점은 인스턴스 대입이 일어날 때 뚜렷해진다.




