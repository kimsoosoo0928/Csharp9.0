//class Person
//{
//    static public Person President = new Person("대통령"); // public 정적 필드
//    string _name;

//    private Person(string name) // private 인스턴스 생성자
//    {
//        _name = name;
//    }

//    public void DisplayName() // public 인스턴스 메서드
//    {
//        System.Console.WriteLine(_name);
//    }
//}

////Person.President.DisplayName(); // 정적 필드로 단일 인스턴스 접근
////Person person1 = new Person("홍길동"); // 생성자가 private이므로 오류 발생 

//class Person
//{
//    static int CountOfInstance; // private 정적 필드
//    public string _name;

//    public Person(string name)
//    {
//        CountOfInstance++;
//        _name = name;
//    }

//    static public void OutputCount() // public 정적 메서드 
//    {
//        System.Console.WriteLine((CountOfInstance); // 정적 메서드에서 정적 필드에 접근
//    }
//}

//class Program
//{
//    static void main(string[] args)
//    {
//        Person.OutputCount(); // 클래스 이름으로 정적 메서드 호출

//        Person person1 = new Person("홍길동");
//        Person person2 = new Person("홍길순");

//        Person.OutputCount(); // 출력결과 : 2
//    }
//}

//using System;

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args) // 메인 정적 메서드 정의
//        { //문자열 출력}
//            Console.WriteLine("Hellow World"); // Consolw 타입에 정의된 정적 메서드 사용
//        }
//    }
//}

//class Person
//{
//    static public Person President;

//    public string _name;

//    private Person(string name)
//    {
//        _name = name;
//    }

//    static Person() // 정적 생성자
//    {
//        President = new Person("대통령"); // 정적 필드 초기화/


//class Person
//{
//    public string _name;

//    public Person(string name)
//    {
//        _name = name;
//        System.Console.WriteLine("ctor 실행");

//    static Person()
//        {
//            System.Console.WriteLine("cctor 실행");

//        }
//    }


//    namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string [] args)
//        {
//            Person person1 = new Person("");
//            System.Console.WriteLine("-------");
//            Person person2 = new Person("");
//        }
//    }
//}
//}


//namespace MilkyWay
//{
//    class Earth
//    {

//    }
//}

//namespace Andromeda
//{
//    class Earth
//    {

//    }
//}

//using Communication;
//using Disk.FileSystem; // using문은 반드시 파일의 첫 부분에 있어야 한다. 어떤 코드도 using문 앞에 와서는 안된다.

//namespace Communication
//{
//    class Http
//    {

//    }

//    class Ftp
//    {

//    }
//}


//namespace Disk.FileSystem
//{
//    class File
//    {

//    }
//}

//namespace ConsolApp1
//{
//    class Program
//    {
//        static void Main(string args)
//        {
//            Http http = new Http();
//            File file = new File();
//        }
//    }
//}

////namespace ConsoleApp1
////{
//    class Program
//    {
//        static void Main(string args)
//        {
//            Communication.Http http = new Communication.Http(); // 다른 네임스페이스에 클래스에 대한 객체 생성
//            Disk.FileSystem.File file = new Disk.FileSystem.File(); 
//        }
//    }
//}


//using System;

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //문자열 출력
//            Console.WriteLine("H_W");
//        }
//    }
//}

// 캡슐화 : 객체의 밖에서 알아야 할 필요가 없는 내부 멤버를 숨기는 일 

//double pi = 3.14;

//double GetAreaofCircle(double radius) // 원의 넓이를 반환하는 함수
//{
//    return radius * radius * pi;
//}

//void Print(double value)
//{
//    System.Console.WriteLine(GetAreaofCircle(value));
//}

//Print(10);

//class Circle
//{
//    double pi = 3.14; // 클래스를 통한 캡슐화 
    
//    double GetArea(double radius) 
//    {
//        return radius * radius * pi;
//    }

//    public void Print(double value) // 호출가능
//    {
//        System.Console.WriteLine(GetArea(value));
//    }
//}

//class Circle
//{
//    double pi = 3.14;

//    public double GetPi()
//    {
//        return pi;
//    }
    
//    public void SetPi(double value)
//    {
//        pi = value;
//    }
//    //
//}

//Circle o = new Circle();
//o.SetPi(3.14159); // 쓰기
//double piValue = o.GetPi();

//class Circle
//{
//    double pi = 3.14;

//    public void SetPi(double value)
//    {
//        if (value <= 3 || value >= 3.15)
//        { System.Console.WriteLine("문제 발생!"); }
//        pi = value;
//    }

//    // --- 생략 ---

//    Circle o = new Circle();
//    o.SetPi(3.14159);
//    o.SetPi(3.5); // 출력 : 문제 발생 
 

