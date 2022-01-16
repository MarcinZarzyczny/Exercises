using System;

namespace c1
{
    class Program
    {
            public static int pobierzLiczbe(string param)
            {
                int liczba = -0;
                bool sukces;
                do
                {
                    Console.WriteLine("Proszę podać {0} parametr równaia.", param);
                    try {
                        liczba = Int32.Parse(Console.ReadLine());
                        sukces = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Podany parametr nie jest prawidłową liczbą całkowitą!");
                        sukces = false;
                    }
                } while (!sukces);
                return liczba;


            }
        

        public static void Main(string[] args)
        {
            int parametrA, parametrB, parametrC;
            parametrA = pobierzLiczbe("pierwszy");
            parametrB = pobierzLiczbe("drugi");
            parametrC = pobierzLiczbe("trzeci");

            Console.WriteLine("Wprowadzone parametry rónania:\n");
            Console.WriteLine("A: " + parametrA + " B:  " + parametrB + " C: " + parametrC + "\n");

            if (parametrA == 0) {
                Console.WriteLine("To nie jest rónanie kwadratowe : a= 0!");
            }
            else {
                double delta = parametrB * parametrB - 4 * parametrA * parametrC;
                double wynik;
                if (delta < 0)
                {
                    Console.WriteLine("Delta < 0.");
                    Console.WriteLine("To równanie nie ma rozwiązania w zbioże liczb rzeczywistych!");
                }
                else if (delta == 0)
                {
                    wynik = -parametrB / 2 * parametrA;
                    Console.WriteLine("Rozwiązanie rónania: x =" + wynik);

                }
                else {
                    wynik = (-parametrB + Math.Sqrt(delta)) / 2 * parametrA;
                    Console.WriteLine("Rozwiązanie: x1 = " + wynik);
                    wynik = (-parametrB - Math.Sqrt(delta)) / 2 * parametrA;
                    Console.WriteLine("Rozwiązanie: x2 = " + wynik);

                }


            }






        }
    }
}
