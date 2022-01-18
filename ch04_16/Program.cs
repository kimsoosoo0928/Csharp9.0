using System;

namespace ch04_16
{
    class Book
    {
        decimal isbn13;

        public Book(decimal isbn13)
        {
            this.isbn13 = isbn13;
        }
    }

    class EBook : Book
    {
        public EBook() : base(0) // 에러 발생 : 자식 클래스는 부모 클래스의 private 멤버에 접근할 수 없으므로 초기화가 불가능하다.
        {
            
        }

        public EBook(decimal isbn) : base(isbn)
        {
        }// 이렇게 값을 연계하는것도 가능하다.
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kimhs");
        }
    }
}
