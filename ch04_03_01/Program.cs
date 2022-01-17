using System;

namespace ch04_03_01
{
    //class Mathematics
    //{
    //    public int GetAreaOfSquare(int x)
    //    {
    //        return x * x;
    //    }

    //    public int GetValue() // 매개변수는 없고 값만 반환
    //    {
    //        return 10;
    //    }

    //    // 2개의 매개변수를 받고, 반환값이 없음
    //    public void Output(string prefix, int value)
    //    {
    //        Console.WriteLine(prefix, int value);
    //        {
    //            Console.WriteLine(prefix + value); 
    //        }
    //    }

    //    // 접근 한정자, 형식, 메소드이름(매개변수 목록)
    //    static void Main(string[] args)
    //    {
    //        Mathematics m = new Mathematics(); // 메모리 할당
    //        int result = m.GetAreaOfSquare(m.GetValue()); // 메서드를 사용하려면 해당 클래스에 대한 메모리 할당이 필요하다.


    //        m.Output("결과 : ", result);
    //    }
    //class Book
    //{
    //    public string Title;
    //    public decimal ISBN13;
    //    public string Contents;
    //    public string Author;
    //    public int PageCount; // 속성 필드 

    //    public void Open() // 메서드
    //    {
    //        Console.WriteLine("Book is opened");
    //    }

    //    public void Close()
    //    {
    //        Console.WriteLine("Book is closed");
    //    }
    //}

    //public void WriteIf(bool output, string txt)
    //{
    //    if (output == false)
    //    {
    //        return; // 메서드 안에서 사용되는 return문은 값을 반환하는 목적 말고도 점프 구문의 역할도 수행한다. 
    //    }

    //    Console.WriteLine(txt);
    //}

    //static void Main(string[] args)
    //{ int x = 5;
    //if (x % 2 == 0)
    //    {
    //        Console.WriteLine(x);
    //    }
    //    x = 10;
    //    if(x% == 0)
    //    {
    //        Console.WriteLine(x); // 중복되는코드
    //    }
    //}

    //class Mathematics
    //{
    //    public void PrintfEven(int value)
    //    {
    //        if (value % 2 == 0)
    //        { Console.WriteLine(value); }
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Mathematics m = new Mathematics();

    //        int x = 5;
    //        m.PrintfEven(x);

    //        x = 10;
    //        m.PrintfEven(x);
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("person 객체 생성되기 전.");
            Person person = new Person(); // 반환 타입이 없고 클래스 이름과 동일한 "public Person" 메서드를 정의해 두면 코드에서 "new Person"을 실행하는 시점에 해당 메서드의 코드가 실행된다. 
            Console.WriteLine("person 객체 생성된 후 ");
        }
        class Person
        {
            string name;

            public Person()
            {
                name = "홍길동";
                Console.WriteLine("생성자 호출");
            }
        }
    }
}
