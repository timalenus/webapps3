using System;

namespace _02exFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            const int AantalGetallen = 1000;
            Console.WriteLine("Rij van Fibonnaci");
            int volgnr = 0;
            while (volgnr < 1 || volgnr > AantalGetallen)
            {
                Console.WriteLine("Geef het volgnummer (1.." + AantalGetallen + ") van het getal op dat moet berekend worden");
                volgnr = int.Parse(Console.ReadLine());
            }
            int[] fibonacci = new int[AantalGetallen];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 2; i < AantalGetallen; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            Console.WriteLine("Het getal is {0}", fibonacci[volgnr - 1]);
            Console.ReadLine();
        }
    }
}
