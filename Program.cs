using System;

namespace SredniaOcen
{
    class Program
    {
        static void Main(string[] args)
        {
            // wprowadzanie liczby ocen
            int liczbaOcen = 0;
            while (liczbaOcen <= 0)
            {
                Console.WriteLine("Podaj liczbę ocen: ");
                liczbaOcen = Convert.ToInt32(Console.ReadLine());
            }

            // tworzenie tablic z ocenami i wagami
            int[] tablicaOcen = new int[liczbaOcen];
            int[] tablicaWag = new int[liczbaOcen];

            // wprowadzanie ocen i wag

            for (int i = 0; i < liczbaOcen; i++)
            {
                while (tablicaOcen[i] <= 0 || tablicaOcen[i] > 6)
                {
                    Console.WriteLine("Podaj {0}. ocenę: ", i + 1);
                    tablicaOcen[i] = Convert.ToInt32(Console.ReadLine());
                }
                while (tablicaWag[i] <= 0 || tablicaWag[i] > 6)
                {
                    Console.WriteLine("Podaj wagę {0}. oceny: ", i + 1);
                    tablicaWag[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Srednia sr = new Srednia();
            float srednia;
            srednia = sr.ObliczanieSredniej(tablicaOcen, tablicaWag);
            Console.WriteLine("Twoja srednia ocen wynosi: {0}!", srednia);
            Console.ReadKey();
        }
    }

    class Srednia
    {
        public int ObliczanieSredniej(int[] oceny, int[] wagi)
        {
            int i = 0;
            int sumaOcen = 0;
            int sumaWag = 0;

            foreach (var item in oceny)
            {
                sumaOcen += oceny[i] * wagi[i];
            }
            foreach (var item in wagi)
            {
                sumaWag += wagi[i];
            }
            double srednia;
            srednia = sumaOcen / sumaWag;
            return srednia;
        }
    }
}