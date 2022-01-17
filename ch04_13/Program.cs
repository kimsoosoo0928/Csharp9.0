//using System;

//namespace ch04_13
//{
//    class Book
//    {
//        decimal _isbn;


//        public Book(decimal isbn)
//        {
//            _isbn = isbn;
//        }
//    }



//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Book book1 = new Book(1);
//            Book book2 = new Book(1);
//            Console.WriteLine(book1.Equals(book2)); // False
//            // 힙메모리의 위치가 다르기 때문! 
//        }
//    }
//}

//string txt1 = new string(new char[] { 't' });
//string txt2 = new string(new char[] { 't' });
//System.Console.WriteLine(txt1.Equals(txt2));
//True
//string이 기본 동작을 재정의하지 않았다면 출력 결과로 f가 나왔을것이다.

//short n1 = 256;
//short n2 = 123;
//short n3 = 256;

//System.Console.WriteLine(n1.GetHashCode());
//System.Console.WriteLine(n2.GetHashCode());
//System.Console.WriteLine(n3.GetHashCode()); // 값 타입에 대해서는 gethashcode의 동작 방식을 재정의해서 해당 인스턴스가 동일한 값을 가지고 있다면 같은 해시코드를 반환한다. 

//Book book1 = new Book(123);
//Book book2 = new Book(123);

//System.Console.WriteLine(book1.Gethashcode());
//System.Console.WriteLine(book2.Gethashcode());

//// 임의의 갑승로 실행할때마다 달라짐


int[] intArray = new int[] { 1, 2, 3, 4, 5 };

