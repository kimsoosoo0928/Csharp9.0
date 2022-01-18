using System;
using System.Collections;

//int[] intArray = new int[] { 1, 2, 3, 4, 5 };

//IEnumerator enumerator = intArray.GetEnumerator();
//while(enumerator.MoveNext()) // 더이상 촬영할 수 없을 때 false
//{
//    System.Console.WriteLine(enumerator.Current + ", ");
//}



class Hardware { }

class USB
{
    string name;

    public USB(string name) { this.name = name; }
    public override string ToString()
    {
        return name;
    }
}

class Notebook : Hardware, IEnumerable // 인터페이스 구현 
{ USB[] usbList = new USB[] { new USB("USB1"), new USB("USB2") };

    public IEnumerator GetEnumerator() // IEnumerator를 구현한 열거자 인스턴스 반환
    {
        
    }
