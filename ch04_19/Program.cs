using System;

//namespace ch04_19
//{




//    class Book
//    {
//        decimal isbn13;
//        string title;
//        string contents;

//        public Book(decimal isbn13, string title, string contents)
//        {
//            this.isbn13 = isbn13;
//            this.title = title;
//            this.contents = contents;
//        }

//        public override bool Equals(object obj)
//        {
//            if (obj == null)
//            {
//                return false;
//            }

//            Book book = obj as Book;
//            if (book == null)
//            {
//                return false;
//            }

//            return this.isbn13 == book.isbn13;
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {

//        }
//    }
//}



//class Mathmatics
//{
//    public int Abs(int value)
//    {
//        return (value >= 0) ? value : -value;
//    }

//    public int Abs(int value)
//    {
//        return (value >= 0) ? value : -value;
//    }

//    public int Abs(int value)
//    {
//        return (value >= 0) ? value : -value;
//    }


// }
//// c# 언어에서는 오버로드를 지원하기 때문에 다음과 같이 동일한 이름의 메서드로 일관성있게 클래스를 작성할 수 있다.
///

//int n1 = 5;
//int n2 = 10;
//int sum = n1 + n2;

//string txt1 = "123";
//string txt2 = "456";
//Console.WriteLine(txt1+txt2);

//public class Kilogram
//{
//    double mass;

//    public Kilogram(double value)
//    {
//        this.mass = value;
//    }

//    public Kilogram Add(Kilogram target)
//    {
//        return new Kilogram(this.mass + target.mass);
//    }

//    public override string ToString()
//    {
//        return mass + "kg";
//    }
//}


//Kilogram kg1 = new Kilogram(5);
//Kilogram kg2 = new Kilogram(10);

//Kilogram kg3 = kg1.Add(kg2);

//Console.WriteLine(kg3);


//public class Kilogram
//{
//    // 생략

//    public static Kilogram operator +(Kilogram op1, Kilogram op2)
//    {
//        return new Kilogram(op1.mass + op2, mass);
//    }
//}

//// 킬로그램 타입 사용 예제

//Kilogram kg1 = new Kilogram(5);
//Kilogram kg2 = new Kilogram(10);

//Kilogram kg3 = kg1 + kg2;


// public class Currency
//{
//    decimal money;
//    public decimal Money { get { return money; } }
//    public Currency(decimal moneuy)
//    {
//        this.money = money;
//    }
//}

//public class Won : Currency
//{
//    public Won(decimal money) : base(money) { }
//    public override string ToString()
//    {
//        return Money + "Won";
//    }
//}

//public class Dollar : Currency
//{
//    public Dollar(decimal money) : base(money) { }
//    public override string ToString()
//    {
//        return Money + "Dollar";
//    }
//}

//public class Dollar : Currency
//{
//    public Dollar(decimal money) : base(money) { }

//    public override string ToString()
//    {
//        return Money + "Yen";
//    }
//}

//public class Yen : Currency
//{
//    // 생략
//    static public implicit operator Won(Yen yen)
//    {
//        return new Won(yen.Money * 13m); // 1엔당 13원으로 가정
//    }
////}



//// 중첩클래스를 외부에서 사용하고 싶다면 명시적으로 public 접근 제한자를 지정해야한다. 

// // 추상클래스


//class Point
//{
//    int x, y;
//    public Point(int x, int y)
//    {
//        this.x = x; this.y = y;
//    }


//    public override string ToString()
//    {
//        return "X: " + x + ", Y: " + y;
//    }
//}

//abstract class DrawingObject // 추상 클래스
//{
//    public abstract void Draw(); // 추상 메서드 // 코드 없는 가상 메서드 

//    public void Move() { Console.WriteLine("Move"); } // 일반 메서드도 정의 가능 
//}

//class Line : DrawingObject // 추상 클래스를 상속 받는 line 클래스
//{
//    Point pt1, pt2;
//    public Line(Point pt1, Point pt2)
//    {
//        this.pt1 = pt1;
//        this.pt2 = pt2;
//    }

//    public override void Draw()
//    {
//        Console.WriteLine("Line" + pt1.ToString() + "~" +pt2.ToString()); // 추상클래스의 추상메서드를 반드시 정의해야함!
//    }
//}

//DrawingObject line = new Line(new Point(10, 10), new Point(20, 20));
//line.Draw(); // 다형성에 따라 Line.Draw가 호출됨 !!!!!!!!!


//public class Disk
//{
//    public int Clean(object arg)
//    {
//        Console.WriteLine("작업 실행");
//        return 0;
//    }
//}

//// 메서드 자체를 값으로 갖는 타입도 가능
////Disk disk = new Disk();

////Disk disk = new Disk();

////FUncDelgate cleanFunc = new FUncDelgate(disk.Clean);
////FuncDelegate workFUnc = disk.Clean;

//Disk disk = new Disk();

//FuncDelegate cleanFunc = disk.Clean;

//disk.Clean(null);
//cleanFunc(null);


using System;

public class Mathematics
{
    delegate int CalcDelegate(int x, int y);

    static int Add(int x, int y) { return x + y; }
    static int Subtract(int x, int y) { return x - y; }
    static int Multiply(int x, int y) { return x * y; }
    static int Divide(int x, int y) { return x / y; }

    CalcDelegate[] methods;

    public Mathematics()
    {
        // static 메서드를 가리키는 델리게이트 배열 초기화
        methods new CalcDelegate[] { Mathematics.Add, Mathematics.Subtract, Mathematics.Multiply, Mathematics.Divide };

    }


}

