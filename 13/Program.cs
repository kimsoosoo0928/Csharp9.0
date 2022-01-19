using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 500;
            string txt = n.ToString(); // int형 값을 문자열로 반환

            Console.WriteLine($"string : {txt}");

            int reuslt;
            int.TryParse(txt, out reuslt); // 문자열로부터 int 형 값을 복원

            Console.WriteLine($"int : {reuslt}");
        }
    }
}
