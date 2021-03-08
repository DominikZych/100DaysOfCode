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
            int n = int.Parse(Console.ReadLine());
            int x = 0;
            string s;

            while (n != 0)
            {
                s = Console.ReadLine();
                if(s[1] == '+')
                {
                    x++;
                }
                else
                {
                    x--;
                }
                n--;
            }
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
