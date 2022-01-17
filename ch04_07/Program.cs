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


using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //문자열 출력
            Console.WriteLine("H_W");
        }
    }
}