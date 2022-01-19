using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            if (int.TryParse("1234567", out n) == true) // System.Int32의 TryParse를 호출
            {
                Console.WriteLine($"Int : {n}"); 
            }

            double d;
            if (double.TryParse("12E3", out d) == true) // double은 지수 표기법의 문자열도 지원
            {
                Console.WriteLine($"Double : {d}");
            }

            bool b;
            if (bool.TryParse("true", out b) == true) // bool 타입도 관련된 문자열 해석 
            {
                Console.WriteLine($"Bool : {b}"); 
            }

            short s;
            
            if (short
                .TryParse("123456789", out s) == true) // short의 범위를 초과 : false를 반환 
            {
                Console.WriteLine($"Short : {s}"); // false가 반환됐으므로 실행되지 않음
            }
            else Console.WriteLine("Short: False");

            if (short
                .TryParse("Not_a_number", out s) == true) // 숫자가 아니므로 false를 반환 
            {
                Console.WriteLine($"Short : {s}"); // false가 반환됐으므로 실행되지 않음
            }
            else Console.WriteLine("Short: False");



        }
    }
}


//Int: 1234567
//Double: 12000
//Bool: True
//Short: False
//Short: False