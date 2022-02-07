using System;

namespace c1
{
    class Program
    {
        public static void Main(string[] args)
        {

           

            Rectangle prostokant = new Rectangle(100, 200, 50, 50);
            Point punkt1 = new Point(10, 20);
            Point punkt2 = new Point(15, 18);
            Point punkt3 = new Point(42, 24);
            Triangle trojkant = new Triangle(punkt1, punkt2, punkt3);
            prostokant.Show();
            trojkant.Show();
            punkt1.Show();
            punkt2.Show();
            punkt3.Show();
        }
    }

    interface IShow {
        void Show();  
    }
    public class Shape {
        public int color;
        public virtual void Show(){
            Console.WriteLine("Metoda Show klasy bazowej.");
        
        }
    }
    public class Rectangle: Shape, IShow {
        public int x;
        public int y;
        public int width;
        public int height;
        public Rectangle(int x, int y, int width, int height) {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        public override void Show() {
            Console.Write("\nParametry prostokąta");
            Console.Write("\nwspółrzędna x = {0}", x);
            Console.Write("\nwspółrzędna y = {0}", y);
            Console.Write("\ndługość = {0}", width);
            Console.Write("\nwysokość = {0}\n", height);
        }
    }
    public class Triangle : Shape {
        public Point a;
        public Point b;
        public Point c;
        public Triangle(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override void Show()
        {
            Console.Write("\nParametry trójkąta");
            Console.Write("\npunkt a  = ({0}, {1})", a.x , a.y);
            Console.Write("\npunkt b  = ({0}, {1})", b.x, b.y);
            Console.Write("\npunkt a  = ({0}, {1})", c.x, c.y);
            Console.Write("\n");
        }
    }
    public class Point:Shape, IShow {
        public static int liczbaObiektow;
        private int id;
        public int x;
        public int y;

        public Point(int x, int y){
            this.x = x;
            this.y = y;
            liczbaObiektow++;
            this.id = liczbaObiektow;
        }
        public override void Show()
        {
            Console.Write("punkt {2}:\n x = {0}, y = {1}\n", this.x, this.y, this.id);
        }
    }
}
