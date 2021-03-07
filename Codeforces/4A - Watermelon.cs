using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4A_Watermelon
{
    class Program
    {
        static void Main(string[] args)
        {
            int weightOfWatermelon = Convert.ToInt32(Console.ReadLine());
            int sumOfPair = 0;
            int NumberOfPairs = 0;

            for (int i = 0; i < weightOfWatermelon; i++)
            {
                for (int j = 0;  j < weightOfWatermelon;  j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        sumOfPair = i + j;
                        if (sumOfPair == weightOfWatermelon)
                        {
                            NumberOfPairs++;
                        }
                    }
                }
            }

            if (NumberOfPairs != 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadLine();
        }
    }
}
