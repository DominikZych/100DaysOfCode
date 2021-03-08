using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);
            Console.WriteLine(m * n / 2);
            Console.ReadLine();
        }
    }
}
