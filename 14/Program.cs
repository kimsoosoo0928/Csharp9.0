using System;

namespace _14
{

    enum Days
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }
    class Program
    {
        static void Main(string[] args)
        {
            Days today = Days.Sunday;
            Console.WriteLine($"Today : {today}");
            int n = (int)today;
            Console.WriteLine($"Today : {n}");
            short s = (short)today;
            Console.WriteLine($"Today : {s}");
            today = (Days)5;
            Console.WriteLine($"Today : {today}");

        }

        
    }
}



//Today: Sunday

//Today: Sunday
//Today : 0
//Today: 0
//Today: Friday
