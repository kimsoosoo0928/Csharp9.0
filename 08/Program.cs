using System;

namespace _08
{
  

    class Program
    {
        static void Main(string[] args)
        {

            int value1 = 1;
            int value2 = 2;
            int value3 = 3;

            //SwapValue(ref value1, ref value2);

            //Console.WriteLine("value1 == " +value1 + ", value2 == " +value2);

            //swap3value(ref value1, ref value2, ref value3);

            Console.WriteLine($"value1 : {value1}, value2 : {value2}, value3 : {value3}");
            
        }

        private static void SwapValue(ref int value1, ref int value2)
        {
            int temp = value1;
            value1 = value2;
            value2 = temp;
        }

        private static void Swap3Value(ref int value1, ref int value2, ref int value3)
        {
            int temp = value1;
            value1 = value2;
            value2 = value3;
            value3 = temp;
        }
       
    }
}

// value1 == 5, value2 == 5 

/*
int value1; // 값이 없으므로 ref인자로 전달할 수 없음 
string text = null;
int value2;
value2 = 5; // 메서드 호출 전에 값을 가진다면 ref 인자로 전달 가능 

Vector vt;
vt.X  = 5 // X,Y가 포함된 Vertor 구조체에 y값이 초기화되지 않았으므로 ref 인자로 부적절

Vector vt2 = new Vector(); // X,Y 필드가 0으로 초기화 됐으므로 ref 인자로 전달 가능 
 */ 