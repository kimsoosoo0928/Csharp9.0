//using System;

//namespace ch04_05
//{
//    class Book
//    {
//        public string Title;
//        public decimal ISBN13;
//        public string Author;

//        public Book(string title)
//        { Title = title; }

//        public Book(string title, decimal isbn13)
//        { 
//            Title = title;
//            ISBN13 = isbn13;
//        }

//        public Book(string title, decimal isbn13,string author)
//        {
//            Title = title;
//            ISBN13 = isbn13;
//            Author = author;
//        }

//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            .// 개발자는 각 생성자를 상황에 따라 골라 쓸 수 있다.
//            Book gulliver = new Book("걸리버 여행기");
//            Book huckleberry = new Book("허클베리 핀의 모험, 9788952753403");
//            Book alice = new Book("이상한 나라의 엘리스", 962342345, "Lewis carroll");
//        }

//    }
//}


//class Book
//{
//    public Book() // 생성자
//    {

//    }
//    ~Book() // 종료자
//    {
//        // 자원을 해제한다
//    }
//    //......
//}

//class Person
//{
//    public string _name; // 인스턴스 필드

//    public Person(string name) // 인스턴스 생상지 
//    { _name = name; }

//    public void OuputYourName(); // 인스턴스 메서드
//    {Console.WriteLine(_name);
//}
//}

//class Program
//{
//    static void main(string[] args);
//    {
//    Person person = new Person("홍길동"); // new를 통해 인스턴스 생성자에 접근 
//    Person.OutputYourName(); //new로 생성된 객체의 인스턴스 메서드를 호출
//    System.Console.WriteLine(Person_name); // new로 생성된 객체의 인스턴스 필드에 접근


//class Person
//{
//    public int CountOfInstance;
//    public string _name;

//    public Person(string name)
//    {
//        CountOfInstance++; // 생성자에서 필드값 증가
//        _name = name;
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Person person1 = new Person("홍길동");
//            System.Console.WriteLine(person1.CountOfInstance);

//            Person person2 = new Person("홍길순");
//            System.Console.WriteLine(person2.CountOfInstance);
//        }
//    }


//}

class Person
{
    static public int CountOfInstance; // static 예약어로 정적 필드로 만듦
    public string _name;

    public Person(string name)
    {
        CountOfInstance++;
        _name = name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(Person.CountOfInstance);

        Person person1 = new Person("홍길동");
        Person person2 = new Person("홍길순");

        System.Console.WriteLine(Person.CountOfInstance); // 클래스이름. 정적필드 형태로 접근 
    }
}