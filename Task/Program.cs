using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArithProgression arithProgression = new ArithProgression();
            arithProgression.SetStart(3);
            GeomProgression geomProgression = new GeomProgression();
            geomProgression.SetStart(3);


            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{arithProgression.GetNext()} ");
                if (i == 4) { arithProgression.Reset(); }
            }
            Console.WriteLine($"\nНачальный челен последовательности: {arithProgression.Start}");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{geomProgression.GetNext()} ");
                if (i == 4) { geomProgression.Reset(); }
            }          
            Console.WriteLine($"\nНачальный челен последовательности: {geomProgression.Start}");

            Console.ReadKey();
        }
    }
}
