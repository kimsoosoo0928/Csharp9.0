using System;

namespace ch03_연습문제_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int sum = 0;

            for (n = 1; n<1000; n++) 
            {
                if (n % 3 == 0 || n % 5 == 0)
                {
                    sum += n;
                }
                
            }
            Console.WriteLine(sum);

        }
    }
}
