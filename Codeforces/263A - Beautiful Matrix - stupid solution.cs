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
            int[,] array = new int[5, 5];
            int rowOfOne = -1, columnOfOne = -1;
            bool isBreak = false;
            int numberOfMovesOnRow = 0;
            int numberOfMovesOnColumn = 0;

            for (int i = 0; i < 5; i++)
            {
                string[] inputArray = Console.ReadLine().Split(' ');

                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = Convert.ToInt32(inputArray[j]);
                    if(array[i,j] == 1)
                    {
                        rowOfOne = i;
                        columnOfOne = j;
                        isBreak = true;
                        break;
                    }
                }

                if (isBreak == true)
                {
                    break;
                }
            }

            if(rowOfOne == 2 && columnOfOne == 2)
            {
                numberOfMovesOnRow = 0;
                numberOfMovesOnColumn = 0;
            }
            else if(rowOfOne < 2 && columnOfOne < 2)
            {
                while(rowOfOne != 2)
                {
                    numberOfMovesOnRow++;
                    rowOfOne++;
                }
                while (columnOfOne != 2)
                {
                    numberOfMovesOnColumn++;
                    columnOfOne++;
                }
            }
            else if (rowOfOne > 2 && columnOfOne > 2)
            {
                while (rowOfOne != 2)
                {
                    numberOfMovesOnRow++;
                    rowOfOne--;
                }
                while (columnOfOne != 2)
                {
                    numberOfMovesOnColumn++;
                    columnOfOne--;
                }
            }
            else if (rowOfOne < 2 && columnOfOne > 2)
            {
                while (rowOfOne != 2)
                {
                    numberOfMovesOnRow++;
                    rowOfOne++;
                }
                while (columnOfOne != 2)
                {
                    numberOfMovesOnColumn++;
                    columnOfOne--;
                }
            }
            else if (rowOfOne > 2 && columnOfOne < 2)
            {
                while (rowOfOne != 2)
                {
                    numberOfMovesOnRow++;
                    rowOfOne--;
                }
                while (columnOfOne != 2)
                {
                    numberOfMovesOnColumn++;
                    columnOfOne++;
                }
            }
            else if (rowOfOne == 2 && columnOfOne < 2)
            {
                while (columnOfOne != 2)
                {
                    numberOfMovesOnColumn++;
                    columnOfOne++;
                }
            }
            else if (rowOfOne == 2 && columnOfOne > 2)
            {
                while (columnOfOne != 2)
                {
                    numberOfMovesOnColumn++;
                    columnOfOne--;
                }
            }
            else if (rowOfOne > 2 && columnOfOne == 2)
            {
                while (rowOfOne != 2)
                {
                    numberOfMovesOnRow++;
                    rowOfOne--;
                }
            }
            else if (rowOfOne < 2 && columnOfOne == 2)
            {
                while (rowOfOne != 2)
                {
                    numberOfMovesOnRow++;
                    rowOfOne++;
                }
            }


            Console.WriteLine(numberOfMovesOnColumn + numberOfMovesOnRow);
            Console.ReadLine();
        }
    }
}
