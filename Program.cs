using System;

namespace SredniaOcen
{
    class Program
    {
        static void Main(string[] args)
        {
            int marksCount = 0;

            while (marksCount <= 0)
            {
                Console.WriteLine("Insert number of marks: ");
                marksCount = Convert.ToInt32(Console.ReadLine());
            }

            int[] marksArray = new int[marksCount];
            int[] weightArray = new int[marksCount];

            for (int i = 0; i < marksCount; i++)
            {
                while (marksArray[i] <= 0 || weightArray[i] > 5)
                {
                    Console.WriteLine($"Insert {i + 1}. mark, from 1-5:");
                    marksArray[i] = Convert.ToInt32(Console.ReadLine());
                }
                while (weightArray[i] <= 0 || weightArray[i] > 5)
                {
                    Console.WriteLine($"Insert weight of {i + 1}. mark, from 1-5: ", i + 1);
                    weightArray[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Average av = new Average();
            double average;
            average = av.AverageCounting(marksArray, weightArray, marksCount);
            Console.WriteLine($"Your average equals: {average}");
            Console.ReadKey();
        }
    }
}