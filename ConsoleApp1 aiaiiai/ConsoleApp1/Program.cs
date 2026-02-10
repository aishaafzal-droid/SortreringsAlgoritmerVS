using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace _50_öre
{
    internal class Program
    {
        private static object unsortedList;

        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            Random rng = new Random();
            int[] unsortedList = new int[10];
            for (int i = 0; i < unsortedList.Length; i++)
            {
                unsortedList[i] = rng.Next(999);
            }
            Console.WriteLine("Detta är osorterade listan");
            Printarray(unsortedList);
           timer.Start();
            int[] sortedlist = UselessSort(unsortedList);
            timer.Stop();
            Console.WriteLine($"Det tog {timer.Elapsed}att sortera");
            Printarray(sortedlist);

            Console.ReadKey();
            



        }

        static void Printarray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]},");
                if (i % 2 == 0)

                {
                    Console.Write("\n");
                }
            }
        }

        static int[] UselessSort(int[] unsorted)
        {
            return unsorted;
        }
    }
}
