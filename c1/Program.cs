using System;

namespace c1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Point Punkt = new Point();
            Punkt.x = 100;
            Punkt.y = 100;
            Punkt.Show();
        }
    }
    interface IShow {
        void Show();  
    }
    public class Point:IShow
    {
        public int x;
        public int y;
        public void Show() {
            Console.WriteLine("Dane dotyczą punktu: \n");
            Console.WriteLine("Współrzędna x = {0}", x);
            Console.WriteLine("Współrzędna y = {0}", y);
        }
       
    }
}
