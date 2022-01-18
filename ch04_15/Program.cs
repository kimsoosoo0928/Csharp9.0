using System;

namespace ch04_15
{
    //class Book // this 클래스 내부의 코드에서 객체 자신을 가리킬 수 있는 방법 this 예약어!
    //{
    //    decimal _isbn;
    //    public decimal ISBN
    //    {
    //        get { return this._isbn; }
    //    }

    //    public Book(decimal isbn)
    //    {
    //        this._isbn = isbn; // this를 생략하면 메소드의 매개변수인 isbn 변수가 사용된다.
    //    }

    //    public decimal GetISBN()
    //    {
    //        return this.ISBN;
    //    }

    //    public void Sell()
    //    {
    //        Console.WriteLine("Sell: " +this.GetISBN());
    //    }
    //}

    //    class Book
    //    {
    //        string title;
    //        decimal isbn13;
    //        string author;

    //        public Book(string title) : this(title, 0)
    //        {

    //        }

    //        public Book(string title, decimal isbn13) : this(title, isbn13, string.Empty)
    //        {

    //        }

    //        // 초기화 코드를 하나의 생성자에서 처리
    //        public Book(string title, decimal isbn13, string author)
    //            {
    //            this.title = title;
    //            this.isbn13 = isbn13;
    //            this.author = author;


    //}
    //        public Book() : this(string.Empty, 0, string.Empty) 
    //        { }
    //    }

    class Book
    {
        string title; // 인스턴트 필드
        static int count; // 정적 필드

        public Book(string title) // 인스턴스 생성자
        {
            this.title = title; // this로 인스턴스 필드 식별 가능
            this.Open(); // this로 인스 턴스 메서드 식별 가능
            Increment(); // 정적 메서드 사용 가능
        }

        void Open() // 인스턴스 메서드
        {
            Console.WriteLine(this.title); // 인스턴스 멤버 사용 가능
            Console.WriteLine(count); // 정적 멤버 사용 가능        }
        }

        public void Close()
        {
            Console.WriteLine(this.title + "책을 덮는다.");
        }

        static void Increment()
        {
            count++; // 정적 메서드, 정적 필드 사용 가능, 정적 메서드에는 thisㅏ가 없으므로 인스턴스 멤버 사용 불가능
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}
