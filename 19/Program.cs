using System;

namespace _19
{
    public class Scheduler
    {
        readonly int second = 1; // 읽기 전용 필드 정의 및 값을 대입
        readonly string name; // 읽기 전용 필드 정의 

        public Scheduler()
        {
            this.name = "일정관리"; // 읽기 전용 필드는 생성자에서도 대입 가능
        }

        public void Run()
        {
            //this.second = 5; // 컴파일 오류 발생! 일반 메서드에서 값을 대입할 수 없다.
        }
    }

    public class Point // 불변 타입 
    {
        int x, y;

        public int X { get { return x; } }
        public int Y { get { return y; } }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    
    class Program
    {

        
        

        static void Main(string[] args)
        {
            Point pt = new Point(5, 10);
            Point pt2 = new Point(pt.X + 1, pt.Y + 1);
        }
    }
}
