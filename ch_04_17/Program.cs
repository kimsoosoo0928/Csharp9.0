using System;

//namespace ch_04_17
//{
//    class Mammal
//    {
//        virtual public void Move() // 가상 메서드로 변경
//        { 
//            Console.WriteLine("이동한다."); 
//        }
//    }

//    class Lion : Mammal 
//    { 
//       override public void Move() // 메서드 오버라이드 
//        { Console.WriteLine("네 발로 움직인다."); }
//    }

//    class Whale : Mammal
//    {
//        override public void Move()
//        {
//            Console.WriteLine("수영한다.");
//        }
//    }

//    class Human : Mammal
//    {
//        override public void Move()
//        {
//            Console.WriteLine("두발로 움직인다.");
//        }
//    }


//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Mammal one = new Mammal();
//            one.Move();

//            Lion lion = new Lion();
//            Mammal one = lion; // 부모 타입으로 형변환
//            one.Move();


            

//            Whale whale = new Whale();
//            whale.Move();

//            Human human = new Human();
//            human.Move();

            
//        }
//    }
//}


public class Computer
{
    virtual public void Boot()
    {
        Console.WriteLine("메인보드 켜기");
    }
}

public class NoteBook : Computer
{
    public override void Boot()
    {
        base.Boot();
        Console.WriteLine("액정 화면 켜기");
    }
}