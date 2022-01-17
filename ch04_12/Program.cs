using System;

//namespace ch04_12
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //int n = 5;
//            //if((n as string) != null) // 컴파일 오류 발생
//            //{
//            //    Console.WriteLine("변수 n은 string 타입");
//            //}

//            //string txt = "text";
//            //if ((txt as int) != null)
//            //{
//            //    Console.WriteLine("컴파일 오류 발생");
//            //}

//            int n = 5;
//            if (n is string) // 불린형 결괏값만 필요하므로 is 연산자를 사용하는 것만으로 충분하다.
//            {
//                Console.WriteLine("변수 n은 string 타입 ");
//            }

//            string txt = "text";
//            if (txt is int)
//            {
//                Console.WriteLine("변수 txt는 int 타입");
//            }
//        }
//    }
//}

//public class A

//{

//}

//public class A : Object
//{

//}
// 동일한 코드

//Computer computer = new Computer();
//object obj1 = computer;
//Computer pc1 = obj1 as Computer;

//Notebook notebook = new Notebook();
//object obj2 = notebook;
//notebook pc2 = obj2 as notebook;

//public class Object
//{
//    public virtual bool Equals(object obj);
//    public virtual int GetHashCode();
//    public Type GetType();
//    public virtual string ToString();
//}

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Program program = new Program();
//            Console.WriteLine(program.ToString());

//            int n = 500;
//            double d = 3.14;
//            string txt = "Hello: ";

//            Console.WriteLine(txt + n.ToString()); // c# 기본 타입은 ToString을 클래스의 전체 이름이 아닌 해당 타입이 담고 있는 값을 반환하도록 변경했다. 
//            Console.WriteLine(txt + d.ToString());

//            txt = d.ToString();
//            Console.WriteLine(txt);
//        }
//    }
//}

//ConsoleApp1.Program

//ConsoleApp1.Program
//Hello: 500
//Hello: 3.14
//3.14

//Computer computer = new Computer();
//Type = computer.GetType();

//Console.WriteLine(Type.FullName);
//Console.WriteLine(Type.IsClass);
//Console.WriteLine(Type.IsArray);

//int n = 5;
//string txt = "text";

//Type intType = n.GetType();

//Console.WriteLine(intType.FullName);
//Console.WriteLine(txt.GetType().FullName);

//Type type = typeof(double);
//Console.WriteLine(type.FullName);

//Console.WriteLine(typeof(System.Int16).FullName);

//int n = 5;
//Console.WriteLine(n.Equals(5));

//int n1 = 5;
//int n2 = 5;
//Console.WriteLine(n1.Equals(n2));

//n2 = 6;
//Console.WriteLine(n1.Equals(n2));

//True
//False

