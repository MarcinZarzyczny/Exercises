using System;

namespace c1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int index = 1;
            Tablica tab = new Tablica();
            try
            {
                int value = tab.getElement(index);
                Console.WriteLine("Element nr {0} ma wartosc: " + value, index);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Nie ma elementu o indeksie {0}! ", index);
            }            
        }
    }
    public class Tablica
    {
        int[] tab;
        public Tablica()
        {
            tab = new int[5];
        }
        public int getElement(int index)
        {    
            return tab[index];  
        }
    }
}
