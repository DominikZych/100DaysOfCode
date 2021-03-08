using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 71A_Way_Too_Long_Words

class Program
{
    static void Main(string[] args)
    {
        int n;
        string line;
        n = Convert.ToInt32(Console.ReadLine());
        int sumOfSolutions;

        while (n != 0)
        {
            line = Console.ReadLine();
            int[] numbers = line.Split(" ");
            int NumberOfSolutions = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    NumberOfSolutions++;
                }
                if (NumberOfSolutions >= 2)
                {
                    sumOfSolutions++;
                }
            }
            n--;
        }
        Console.WriteLine(sumOfSolutions);

        Console.ReadLine();
    }
}
}
