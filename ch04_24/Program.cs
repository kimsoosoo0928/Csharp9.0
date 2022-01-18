////abstract class DrawinObject
////{
////    public abstract void Draw();
////    public abstract void Move(int offset);
////}

////interface IDrawingObject
////{
////    void Draw();
////    void Move(int offset);
////}



//// 추상 메서드만 -개 이상 담고 있는 추상 클래스 

////class Computer
////{

////}

////interface IMonitor // 메서드 시그니처만을 포함하고 있는 인터페이스 
////{
////    void TurnOn();
////}

////interface IKeyboard { } // 비어있는 인터페이스 정의 가능 
////// 클래스 상속과 함께 인터페이스로부터 다중 상속 가능
////class Notebook : Computer, IKeyboard, IMonitor
////{
////    //public void TurnOn() { } // 추상 메서드와는 달리 오버라이드 예약어가 필요 없음
////    //void IMonitor.TurnOn() { }

////    Notebook notebook = new Notebook();
////    Notebook.TurnOn(); // IMonitor.TurnOn 메서드는 Notebook 인스턴스로 호출 불가능

////        IMonitor mon = Notebook as IMonitor
////        mon.TurnOn(); // 반드시 인터페이스로 형변환해서 호출
////}

////interface IMonitor
////{
////    void TurnOn();
////    int Inch { get; set; } // 
////    int Width { get; }
////}

////class Notebook : IMonitor
////{
////    public void TurnOn() { }
////    int inch;
////    public int Inch
////    {
////        get { return inch; }
////        set { inch = value; }
////    }

////    int width;
////    public int Width { get { return width; } }
////}

//// 인터페이스 메서드는 가상 메서드이기 때문에 다형성의 특징이 그대로 적용된다.
////interface IDrawingObject
////{
////    void Draw();
////}

////class Line : IDrawingObject
////{
////    public void Draw() { System.Console.WriteLine("Line"); }
////}

////class Rectangle : IDrawingObject
////{
////    public void Draw() { System.Console.WriteLine("Rectangle"); }
////}

////// 인터페이스 자체는 new로 인스턴스화할 수 없지만, 인터페이스 배열은 가능하다.

////IDrawingObject[] instances = new IDrawingObject[] {new Line(), new Rectangle()}

////foreach ( IDrawingObject item in instances){
////    item.Draw(); // 인터페이스를 상속받은 객체의 Draw 메서드가 호출됨 
////}

////// 자식 클래스로부터 암시적 형변환 가능
////IDrawingObject instance = new Line();
////instance.Draw();


//// 인터페이스 자체로 의미 부여
//// 비어 있는 인터페이스를 상속받는 것으로도 의미가 부여될 수 있다. 

////interface IObjectToString { } // ToString을 재정의한 클래스에만 사용될 빈 인터페이스 정의

////class Computer { } // ToString을 재정의하지 않은 예제 타입

////class Person : IObjectToString // Tostring을 재정의 했다는 의미로 인터페이스 상속
////{
////    string name;
////    public Person(string name)
////    {
////        this.name = name;
////    }

////    public override string ToString()
////    {
////        return "Person: " + this.name;
////    }

////    class Program
////    {
////        private static void DisplayObject(object obj)
////        {


////            if (obj is IObjectToString) // 인터페이스로 형변환이 가능한가?
////            { System.Console.WriteLine(obj.ToString()); }

////        }

////        static void Main(string[] args)
////        {
////            DisplayObject(new Computer());
////            DisplayObject(new Person("홍길동"));
////        }
////    }
////}

//interface ISource
//{
//    int GetResult(); // 콜백용으로 사용될 메서드를 인터페이스로 분리한다.
//}

//class Source : ISource
//{
//    public int GetResult() { return 10; }
//    public void Test()
//    {
//        Target target = new Target();
//        target.Do(this);
//    }
//}

//class Target
//{
//    public void Do(ISource obj) // source 타입이 아닌 ISource 인터페이스를 받는다. 
//    {
//        System.Console.WriteLine(obj.GetResult()); // 콜백 메서드 호출!
//    }
//}

//// 대부분의 콜백 패턴에 대해 인터페이스를 사용하는 방법이 더 선호된다. 
//// 델리게이트는 각 메서드마다 정의해야 하는 불편함이 있지만 인터페이스는 하나의 타입에서 여러개의 메서드 계약을 담을 수 있기 때문이다.
//// 델리게이트는 여러개의 메서드를 담을 수 있어서 한 번의 호출을 통해 다중으로 등록된 콜백 메서드를 호출할 수 있다는 고유의 장점이 있다.
//// 따라서 다중 호출에 대한 필요성만 없다면 인터페이스를 이용해 콜백을 구현하는 것이 더 일반적이다. 

////public static void Sort(Array array);
////public static void(Array array, IComparer, comparer);

//using System;
//using System.Collections; // Icomparer가 정의된 네임스페이스를 사용

//class IntegerCompare : IComparer
//{
//    // IComparer 인터페이스의 Compare 메서드를 구현
//    // 이 메서드는 Array.Sort 메서드 내에서 콜백으로 호출됨.
//    public int Compare(object x, object y)
//    {
//        int xValue = (int)x;
//        int yValue = (int)y;

//        if (xValue > yValue) return -1; // 내림차순 정렬이 되도록 -1을 반환
//        else if (xValue == yValue) return 0;

//        return 1;

//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] intArry = new[] { 1, 2, 3, 4, 5, };

//        // IComparer를 상속받은 IntegerCompare 인스턴스 전달
//        Array.Sort(intArry, new IntegerCompare());
//        foreach (int item in intArray)
//        {
//            Console.WriteLine(item + ",");
//        }
//    }
//}