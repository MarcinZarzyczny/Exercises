using System;

namespace c1
{
    public class Punkt {
        public int x;
        public int y;
        public void ustawWspulrzendne(int wspX, int wspY) {
            this.x = wspX;
            this.y = wspY;
        }
        public Punkt pobierzWspolrzedne()
        {
            Punkt punkt = new Punkt();
            punkt.x = x;
            punkt.y = y;
            return punkt;

        }
    
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Punkt punkt = new Punkt();
            Punkt pomocniczyPunkt;
            pomocniczyPunkt = punkt.pobierzWspolrzedne();

            Console.WriteLine("Przed ustawieniem wartości:");
            Console.WriteLine("Wspułżędna X = " + pomocniczyPunkt.x);
            Console.WriteLine("Wspułżędna Y = " + pomocniczyPunkt.y);

            punkt.ustawWspulrzendne(1, 2);
            pomocniczyPunkt = punkt.pobierzWspolrzedne();






        }
    }
}
