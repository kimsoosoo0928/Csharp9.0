using System;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            int Divide(int n1, int n2)
            {
                if (n2 == 0) // 분모가 0이면 나눗셈 결과로 0을 반환
                {
                    return 0;
                }

                return n1 / n2; 
            }
        }
    }
}

// 0으로 나올 수 있는 올바란 연산 결과가 있다는 점을 감안 했을 때 분모가 0인 경우도 동일한 값을 반환하는 것은 분명 잘못된 구현이다.
