using System;

namespace _10
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
            DivideResult Divide(int n1, int n2)
            {
                DivideResult ret = new DivideResult();

                if (n2 == 0) // 분모가 0이면 Success 필드를 false로 설정 
                {
                    ret.Success = false;
                    return ret;
                }

                ret.Success = true;
                ret.Result = n1 / n2;
                return ret;

            }

        }
    }
}

// 0으로 나올 수 있는 올바란 연산 결과가 있다는 점을 감안 했을 때 분모가 0인 경우도 동일한 값을 반환하는 것은 분명 잘못된 구현이다.
