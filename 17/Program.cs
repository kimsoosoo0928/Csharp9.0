using System;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            int Calc(char opType, int operand1, int operand2)
            {
                switch (opType)
                {
                    case '+': return operand1 + operand2;
                    case '-': return operand1 + operand2;
                    case '*': return operand1 + operand2;
                    case '/': return operand1 + operand2;
                }

                return 0;
            }

            Calc('+', 5, 6);
        }
    }
}
