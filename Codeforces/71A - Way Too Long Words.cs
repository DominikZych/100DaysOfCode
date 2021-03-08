using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string line;
            n = Convert.ToInt32(Console.ReadLine());
            int sumOfSolutions = 0;

            while (n != 0)
            {
                line = Console.ReadLine();
                string[] numbers = line.Split(' ');
                int NumberOfSolutions = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (Convert.ToInt32(numbers[i]) != 0)
                    {
                        NumberOfSolutions++;
                    }
                    if (NumberOfSolutions > 1)
                    {
                        sumOfSolutions++;
                        break;
                    }

                }
                n--;
            }
            Console.WriteLine(sumOfSolutions);

            Console.ReadLine();
        }
    }
}
