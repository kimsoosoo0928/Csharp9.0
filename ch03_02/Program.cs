using System;

namespace ch03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n1 = 50; // 선언과 동시에 값을 부여할 수도 있고
            //int n2; // 선언만 하고 
            //n2 = 100; // 값은 나중에 부여하는 것도 가능하다.

            //long sum = n1 + n2;// 더한 값을 저장

            //Console.WriteLine(sum); // 150

            //int n1 = 50;
            //n1 = 200;
            //Console.WriteLine(n1); // 출력 결과 : 200

            //System.Int32 n1 = 50;
            //System.Int32 n2;
            //n2 = 100;

            //System.Int32 sum = n1 + n2;

            //Console.WriteLine(sum); // 출력 결과 : 150 

            //float f = 5.2f;
            //double d = 10.5;
            //decimal money = 200.099m;

            //Console.WriteLine(f);
            //Console.WriteLine(d);
            //Console.WriteLine(money);


            //5.2
            //10.5
            //200.099

            //char ch = 'A';
            //Console.WriteLine(ch);

            ////A
            ///


            //char ch1 = '\t'; // tab 문자를 표현 
            //char ch2 = 'T';
            //char ch3 = '\n'; // 개행(new Line) 문자를 표현
            //char ch4 = 'o';

            //Console.Write(ch1);
            //Console.Write(ch2);
            //Console.Write(ch3);
            //Console.Write(ch4);


            //            T
            //o


            //char ch = '\u2023';
            //Console.Write(ch);

            //?


            //char ch = '\\';
            //Console.WriteLine(ch);

            //\

            //string text = "Hello World";
            //Console.WriteLine(text);

            //Hello World


            //string text = "\tHello\nWorld";
            //Console.WriteLine(text);

            //            Hello
            //World

            //string text = "\"Hello World\"";
            //Console.WriteLine(text);

            //"Hello World"

            //string text = @"\tHello\nWorld";
            //Console.WriteLine(text); // \tHello\nWorld

            //string text = "Hello";
            //Console.WriteLine(text + " " + "World");
            //Hello World

            //bool isNumeric = false;
            //Console.WriteLine(isNumeric);

            //False

            // C#은 정적 타입 언어이기 때문에 반드시 자료형을 명시해야 한다.

            // 형변환

            // 암시적 형변환

            //byte b = 250;
            //short s = b;
            //Console.WriteLine(s);

            //250 암시적 변환

            // 명시적 변환 

            //ushort u = 65;
            //char c = u;

            //            심각도 코드  설명 프로젝트    파일 줄   비표시 오류(Suppression) 상태
            //오류  CS0266 암시적으로 'ushort' 형식을 'char' 형식으로 변환할 수 없습니다. 명시적 변환이 있습니다.캐스트가 있는지 확인하세요.ch03_02 C:\Users\kimso\Desktop\workspace\homework\c#_9.0\ch03_02\Program.cs	119	활성


            //ushort u = 65;
            //char c = (char)u;
            //Console.WriteLine(c);

            //A

            //int n = 40000;
            //short s = (short)n;
            //Console.WriteLine(s);

            //-25536

            //string text;

            //string text1;
            //string text2 = null;

            //string name = "C#";
            //name = null;
            //// 참조형 변수가 더는 사용되지 않음을 명시하기 위해 null을 할당

            //            int n1 = 5;
            //            int n2 = n1;

            //            Console.WriteLine(n1);
            //            Console.WriteLine(n2);


            //            5
            //5

            string txt1 = "C#";
            string txt2 = txt1;









        }
    }
}
