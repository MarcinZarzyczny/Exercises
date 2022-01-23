using System;

namespace c1
{
    public class Punkt {
        private int x, y;
        public Punkt()
        {
            this.x = 4;
            this.y = 7;

        }
        public Punkt(int x, int y)
        {
            UstawWspulrzedne(x, y);

        }
        public void UstawWspulrzedne(int x, int y) {
            this.x = x;
            this.y = y;
        }
        public Punkt PobierzWspulrzedne() {
            Punkt punkt = new Punkt();
            punkt.x = x;
            punkt.y = y;
            return punkt;
        }
        public void PobierzWspulrzedne(Punkt punkt)
        {
            punkt.x = x;
            punkt.y = y;

        }
        public void UstawX(int wspyX) {
            UstawWspulrzedne(wspyX, PobierzY());
        }
        public void UstawY(int wspY)
        {
            UstawWspulrzedne(PobierzX(), wspY);
        }
        public int PobierzX() {
           
            return (this.x);
        }
        public int PobierzY()
        {
            return this.y;
        }
    }
    public class KolorowyPunkt : Punkt
    {
        protected int kolor;
        public KolorowyPunkt()
        {
            this.kolor = 0;

        }
        public KolorowyPunkt(int wspX, int wspY, int nowyKolor)
        {
            UstawWspulrzedne(wspX, wspY);
            this.kolor = nowyKolor;

        }
        public int PobierzKolor() {
            return (this.kolor);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Punkt punkt = new Punkt();
            Console.WriteLine(punkt);
            Console.WriteLine("Pubkt X: " + punkt.PobierzX());
            Console.WriteLine("Pubkt Y: " + punkt.PobierzY());

            KolorowyPunkt kolorowyPunkt = new KolorowyPunkt(100, 200, 155678);
            Console.WriteLine("Kolorowy pubkt X: " + kolorowyPunkt.PobierzX());
            Console.WriteLine("Kolorowy pubkt Y: " + kolorowyPunkt.PobierzY());
            Console.WriteLine("Kolor punktu: " + kolorowyPunkt.PobierzKolor());





        }
    }
}
