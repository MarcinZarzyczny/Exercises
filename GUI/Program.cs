using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Example
{
    public int x;
    public int y;

    public Example(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public delegate void ShowCallBack(Example examp);
    public void Show(ShowCallBack examp)
    {
        examp(this);

    }

}
namespace GUI
{
    static class Program
    {
            public static void Show(Example examp) {
                Console.WriteLine("x = {0}", examp.x);
                Console.WriteLine("y = {0}", examp.y);

            }
            public static void Main()
            {
                Example przyklad = new Example(100, 200);
                Example.ShowCallBack callBack= new Example.ShowCallBack(Program.Show);
                przyklad.Show(callBack);
            
        }
      
       
    }
}
//książka strona 118
