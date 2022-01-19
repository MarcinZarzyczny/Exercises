using System;

namespace c1
{
    public class Punkt {
        public int x;
        public int y;

        public Punkt()
        {
            ustawWspulrzendne(20, 52);

        }
        public Punkt(int x, int y)
        {
            ustawWspulrzendne(x, y);

        }
        public int getX() {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public void ustawWspulrzendne(int x, int y) {
            this.x = x;
            this.y = y;
        }
        public Punkt pobierzWspulrzendne () {
            Punkt punkt = new Punkt();
            punkt.x = x;
            punkt.y = y;
            return punkt;
        }
        public void pobierzWspulrzendne(Punkt punkt)
        {
            punkt.x = x;
            punkt.y = y;

        }
        public void ustawX(int wspyX) {
            x = wspyX;
        }
        public void ustawY(int wspyY)
        {
            y = wspyY;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Punkt punkt = new Punkt();
            Console.WriteLine(punkt);
            Console.WriteLine("Pubkt X: " + punkt.getX());
            Console.WriteLine("Pubkt Y: " + punkt.getY());

            Punkt punkt1 = new Punkt(100, 200);
            Console.WriteLine("Pubkt X: " + punkt1.getX());
            Console.WriteLine("Pubkt Y: " + punkt1.getY());




        }
    }
}
