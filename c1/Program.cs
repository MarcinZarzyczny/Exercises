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

            Console.WriteLine("Przed ustawieniem wartości:");
            Console.WriteLine("Wspułżędna X = " + punkt.pobierzWspolrzedne().x);
            Console.WriteLine("Wspułżędna Y = " + punkt.pobierzWspolrzedne().y);

            punkt.ustawWspulrzendne(1, 2);
            Console.WriteLine("\nPo ustawieniu wartości: ");
            Console.WriteLine("Wspułrzendna X = " + punkt.pobierzWspolrzedne().x);
            Console.WriteLine("Wspułrzendna Y = " + punkt.pobierzWspolrzedne().y);




        }
    }
}
