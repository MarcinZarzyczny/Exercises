using System;

namespace c1
{
    class Program
    {
        public static void Main(string[] args)
        {

            Tablica tab = new Tablica();
            try{
                int value = tab.getElement(20);
                Console.WriteLine("Element nr 20 ma wartosc: " + value);
            }
            catch(IndexOutOfRangeException){ 
                Console.WriteLine("Nie ma elementu o podanym numerze.");
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
