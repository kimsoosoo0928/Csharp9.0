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

            //string txt1 = "C#";
            //string txt2 = txt1;


            //bool result; // 변수 result에는 false 값이 들어있다.
            //int n; // 변수 n에는 0 값이 들어 있다. 
            //string text; // 변수 text에는 null;값이 들어있다.


            //const bool result = false;
            //const int n = 5; 
            //const string text = "hello";

            //result = true; // 컴파일 오류 발생, const 상수값은 바꿀 수 없다.

            //int n = Math.Max(0, 5); //프로그램을 실행할 때 n 값이 결정된다. 변수 n 에는 5가 대입  

            //const int maxN = Math.Max(0, 5); // math.MAX 메서드가 실행된 이후에야 값이 결정되고, 컴파일러가 미리 그 값을 결정할 수 없으므로 오류가 발생 

            //const int n = 5 * 100 / 2; // 이러한 단순 수식은 컴파일러가 값을 계산할 수 있다. 



            //int n = 5;
            //int divider = 3;
            //int mod = n % divider;
            //Console.WriteLine(mod);
            //2

            //int n = 500;
            //Console.WriteLine("n = " +n); n = 500

            //int[] product = new int[5];

            //string[] names = new string[1000];

            //product[0] = 100;
            //product[1] = 200;

            //int book = product[0];

            //int sum = product[0] + product[1];

            //int[] products = new int[5] { 1, 2, 3, 4, 5 }; // 배열의 요소 개수를 지정

            //int[] products = new int[] { 1, 2, 3, 4, 5 }; // 배열의 요소 개수를 미지정

            //            string text = "Hello World";
            //            char ch1 = text[0];
            //            char ch2 = text[1];

            //            Console.WriteLine(ch1);
            //            Console.WriteLine(ch2);


            //            H
            //e

            //int[] students = new int[60];
            //students[0] = 50;
            //Console.WriteLine(students[0]); // 출력 결과 : 50 

            //students = new int[120];
            //Console.WriteLine(students[0]); // 출력 결과 :0

            //int[,] arr2 = new int[10, 5]; // 2차원 배열, 요소에 대해 각각 4바이트씩 총 200바이트 메모리 점유
            //short[,,] arr3 = new short[8, 3, 10]; // 3차원 배열, 요소에 대해 각각 2바이트씩 총 480바이트 메모리 점유

            //int[,] arr2 = new int[2, 3]
            //{
            //    {1,2,3}, // 1차원 요소 수는 3개이고
            //    {4,5,6 } // 2차원 요소 수는 2개인 배열을 초기화 
            //};

            //int[,,] arr3 = new int[2, 3, 4]
            //{
            //    {
            //        {1,2,3,4 }, // 1차원의 요소 수는 4개이고 
            //        {5,6,7,8 },
            //        {9,10,11,12 } //2차원의 요소 수는 3개이고,
            //    },
            //{ 
            //{ 13,14,15,16},
            //{ 17,18,19,20},
            //{ 21,22,23,24}, //3차원 요소 수는 2개인 배열을 초기화 
            //}
            //};

            //    int value = 5;
            //    if (value <= 255)
            //    {
            //        Console.WriteLine("byte 변환 가능");
            //    }
            //    else if (value <= 65535)
            //    {
            //        Console.WriteLine("ushort 변환 가능");

            //    }
            //    else
            //    {
            //        Console.WriteLine("int 타입");
            //    }

            //    }

            //byte 변환 가능

            //int value = 5;
            //string result;
            //if (value % 2 == 0)
            //{
            //    result = "짝수";
            //}
            //else
            //{
            //    result = "홀수";
            //}
            //Console.WriteLine(result);

            //홀수

            //int value = 5;
            //string result = (value % 2 == 0) ? "짝수" : "홀수";

            //char ch = 'F';

            //switch (ch)
            //{
            //    case 'M':
            //        Console.WriteLine("남성");
            //        break;

            //    case 'F':
            //        Console.WriteLine("여성");
            //        break;

            //    default:
            //        Console.WriteLine("알 수 없음");
            //        break;

            //}

            //여성

            //    char ch = 'F';

            //    if (ch=='M')
            //    {
            //        Console.WriteLine("남성");
            //    }
            //    else if (ch=='F')
            //    { Console.WriteLine("여성"); 
            //}
            //    else
            //    {
            //        Console.WriteLine("알 수 없음");
            //    }
            //    여성


            //string text = "C#";

            //switch (text)
            //{
            //    case "C#":
            //    case "VB.NET":
            //        Console.WriteLine(".NET 호환 언어");
            //    case "Java":
            //        Console.WriteLine("JVM 언어");
            //        break;

            //    default:
            //        Console.WriteLine("알 수 없음");
            //        break;
            //}

            //string text = "C#";

            //if (text == "C#" || text == "VB.NET")

            //{
            //    Console.WriteLine(".NET 호환 언어");
            //}
            //else if (text == "Java'")
            //{
            //    Console.WriteLine("JVM언어");
            //}
            //else
            //{
            //    Console.WriteLine("알 수 없음");
            //}

            //string text = "C#";

            //switch (text)
            //{
            //    case "C#":
            //        Console.WriteLine(".NET 호환 언어");
            //        break;
            //    case "Java":
            //        Console.WriteLine("JVM 언어");
            //        break;
            //}

            //int n = 50;
            //Console.WriteLine(n++); // n을 평가하고 난 다음 1만큼 증가

            //n = 50;
            //Console.WriteLine(++n); // n의 값을 1만큼 증가시키고 식을 평가

            //int n = 50;
            //int result;
            //result = n++;

            //n = 50;
            //result = ++n;

            //n = 50;
            //result = n--;

            //n = 50;
            //result = --n;

            //}

            //            int n;

            //            for (n = 1; n <= 9; n++)
            //            {
            //                Console.WriteLine(n);
            //            }

            ////            1
            ////2
            //3
            //4
            //5
            //6
            //7
            //8
            //9

            //int n = 1;
            //for (; n<=9; n++)
            //{ Console.WriteLine(n); }

            //int n = 1;
            //for (; ; n++)
            //{
            //    if (n > 9) break;
            //    Console.WriteLine(n);
            //}

            //int n = 1;
            //for(;;)
            //{
            //    if (n > 9) break;
            //    Console.WriteLine(n);
            //    n++;
            //}

            //            for (int x = 2; x < 10; x++)
            //                for (int y = 1; y<10; y++)
            //                    Console.WriteLine(x + "*"+y+"="+(x*y));

            //            2 * 1 = 2
            //2 * 2 = 4
            //2 * 3 = 6
            //2 * 4 = 8
            //2 * 5 = 10
            //2 * 6 = 12
            //2 * 7 = 14
            //2 * 8 = 16
            //2 * 9 = 18
            //3 * 1 = 3
            //3 * 2 = 6
            //3 * 3 = 9
            //3 * 4 = 12
            //3 * 5 = 15
            //3 * 6 = 18
            //3 * 7 = 21
            //3 * 8 = 24
            //3 * 9 = 27
            //4 * 1 = 4
            //4 * 2 = 8
            //4 * 3 = 12
            //4 * 4 = 16
            //4 * 5 = 20
            //4 * 6 = 24
            //4 * 7 = 28
            //4 * 8 = 32
            //4 * 9 = 36
            //5 * 1 = 5
            //5 * 2 = 10
            //5 * 3 = 15
            //5 * 4 = 20
            //5 * 5 = 25
            //5 * 6 = 30
            //5 * 7 = 35
            //5 * 8 = 40
            //5 * 9 = 45
            //6 * 1 = 6
            //6 * 2 = 12
            //6 * 3 = 18
            //6 * 4 = 24
            //6 * 5 = 30
            //6 * 6 = 36
            //6 * 7 = 42
            //6 * 8 = 48
            //6 * 9 = 54
            //7 * 1 = 7
            //7 * 2 = 14
            //7 * 3 = 21
            //7 * 4 = 28
            //7 * 5 = 35
            //7 * 6 = 42
            //7 * 7 = 49
            //7 * 8 = 56
            //7 * 9 = 63
            //8 * 1 = 8
            //8 * 2 = 16
            //8 * 3 = 24
            //8 * 4 = 32
            //8 * 5 = 40
            //8 * 6 = 48
            //8 * 7 = 56
            //8 * 8 = 64
            //8 * 9 = 72
            //9 * 1 = 9
            //9 * 2 = 18
            //9 * 3 = 27
            //9 * 4 = 36
            //9 * 5 = 45
            //9 * 6 = 54
            //9 * 7 = 63
            //9 * 8 = 72
            //9 * 9 = 81

            //for (int x = 2; x <10; x++)
            //{
            //    for (int y = 1; y<10; y++)
            //    {
            //        Console.WriteLine(x + "*"+y+"="+(x*y));
            //    }

//            int[] arr = new int[] { 1, 2, 3, 4, 5 };
//            foreach(int elem in arr)
//            { Console.WriteLine(elem); }
//            1
//2
//3
//4
//5
            }

        }
    }

