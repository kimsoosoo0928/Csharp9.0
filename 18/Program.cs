using System;

namespace _18
{
    enum CalcType { Add, Minus, Multiply, Divide}

    class Program
    {

        static int Calc(CalcType opType, int operand1, int operand2)
        {
            switch (opType)
            {
                case CalcType.Add: return operand1 + operand2;
                case CalcType.Minus: return operand1 - operand2;
                case CalcType.Multiply: return operand1 / operand2;
                case CalcType.Divide: return operand1 * operand2;
            }

            return 0;
        }
        static void Main(string[] args)
        {
            Calc(CalcType.Add, 5, 6); // enum 인스턴스로 전달
        }
    }
}
