using System;

namespace c1
{
    public class Punkt {
        private double modul, sinalfa;
        public Punkt()
        {
            modul = Math.Sqrt(Math.Pow(800, 2) + Math.Pow(600, 2));
            sinalfa = (double)600 / modul;

        }
        public Punkt(int x, int y)
        {
            ustawWspulrzedne(x, y);

        }
        public void ustawWspulrzedne(int x, int y) {
            modul = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            sinalfa = (double)y / modul;
        }
        public Punkt pobierzWspulrzedne() {
            Punkt punkt = new Punkt();
            punkt.sinalfa = sinalfa;
            punkt.modul = modul;
            return punkt;
        }
        public void pobierzWspulrzedne(Punkt punkt)
        {
            punkt.sinalfa = sinalfa;
            punkt.modul = modul;

        }
        public void ustawX(int wspyX) {
            ustawWspulrzedne(wspyX, pobierzY());
        }
        public void ustawY(int wspY)
        {
            ustawWspulrzedne(pobierzX(), wspY);
        }
        public int pobierzX() {
            double x;
            x = modul * Math.Sqrt(1 - Math.Pow(sinalfa, 2));
            return (int)Math.Round(x);
        }
        public int pobierzY()
        {
            double y;
            y = modul * sinalfa;
            return (int)Math.Round(y);
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            Punkt punkt = new Punkt();
            Console.WriteLine(punkt);
            Console.WriteLine("Pubkt X: " + punkt.pobierzX());
            Console.WriteLine("Pubkt Y: " + punkt.pobierzY());

            Punkt punkt1 = new Punkt(100, 200);
            Console.WriteLine("Pubkt X: " + punkt1.pobierzX());
            Console.WriteLine("Pubkt Y: " + punkt1.pobierzY());




        }
    }
}
