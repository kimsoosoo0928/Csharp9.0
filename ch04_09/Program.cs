public class Computer // 부모 클래스 : 공통된 기능 
{
    protected bool powerOn;
    public void Boot() { }
    public void Shutdown (){ }
    
    public void Reset() { }

    sealed class Pen { } // 상속을 의도적으로 막고 싶을 때
    
}

class Monitor { }

 public class Notebook : Computer// ,Monitor  // 상속 : 부모의 기능 물려받기 , 다중 상속은 허용하지 않는다.
{
    bool fingerScan; // 노트북 타입에 해당하는 멤버만 추가 
    public bool HasFingerScanDevice() { return fingerScan; }

    public void CloseLid()
    {
        if (powerOn == true) // 컴파일 오류 발생 : 접근 불가
        {
            Shutdown(); // Notebook에서 추가된 메서드 내에서 부모의 메서드 호출 
        }
    }

    //public class ElectricPen : Pen // 컴파일 오류 발생 

}

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Notebook noteBook = new Notebook();
            //noteBook.Boot(); // Notebook 인스턴스에 대해 부모의 메서드 호출 

            //Computer pc1 = noteBook; // 암시적 형변환 가능
            //pc1.Boot();
            //pc1.Shutdown();

            //Notebook note2 = (Notebook)pc1;
            //note2.CloseLid();

            //Computer pc = new Computer();
            //Notebook notebook = (Notebook)pc; // 명시적 형변환, 컴파일은 가능

            //Notebook notebook = new Notebook();
            //Desktop desktop = new Desktop();
            //Netbook netbook = new Netbook();

            //DeviceManager manager = new DeviceManager();
            //manager.TurnOff(notebook);
            //manager.TurnOff(desktop);
            //manager.TurnOff(netbook);

            //Computer[] machines = new Computer[] { new Notebook(), new Desktop(), new Notebook() }; // 암시적 형변환  // 부모 객체의 배열에 자식 클래스 인스턴스 넣기

            //DeviceManager manager = new DeviceManager();
            //foreach (Computer device in machines)
            //{
            //    manager.TurnOff(device); // 
            //}

            Computer pc = new Computer();
            Notebook notebook = pc as Notebook; // as는 형변환이 가능하면 지정된 타입의 인스턴스 값을 반환하고, 아니면 null을 반환한다. 
            
            if (notebook != null)
            {
                notebook.CloseLid();
            }
        }
    }
}

public class Desktop : Computer
{

}

public class Netbook : Computer
{

}

public class DeviceManager
{
    public void TurnOff(Computer device)
    {
        device.Shutdown();
    }
}


// 부모 클래스의 기능을 물려받을 수 있고 실제로 상속받은 클래스는 부모의 속성과 행위를 접근 제한자 규칙에 따라 외부에 제공한다. 
