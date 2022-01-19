using System;

namespace _15 { 

    enum Days
{
    Sunday = 5, Monday= 10, Tuesday, Wednesday, Thursday =15, Friday, Saturday
}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Days : {(int)Days.Friday}");
        }
    }
}
