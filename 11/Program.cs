using System;

namespace _11
{

    struct DivideResult
    {
        public bool Success;
        public int Result;
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool Divide(int n1, int n2, out int result)
            {
                if (n2 == 0)
                {
                    result = 0; // 만약 5번째 줄의 result = 0;을 제거하면
                    return false; // 빌드할 때 오류가 발생
                }

                result = n1 / n2;
                return true;
            }

            // Divide 메서드 사용 예제
            int quotient;

            if (Divide(15, 3, out quotient) == true)
            {
                Console.WriteLine(quotient);  // 출력 결과 : 5
            }

        }
    }
}
