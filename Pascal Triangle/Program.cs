using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The number of rows in  Pascal Triangle");
            if (int.TryParse(Console.ReadLine(), out int Rows) )
                if(Rows>0)
            {
                    pascalTriangle(Rows);
                }
                else
                {
                    Console.WriteLine("You entered Negative number, Please enter positive number");
                }
            Console.ReadLine();
        }
        static void pascalTriangle(int Rows)
        {
            for (int i = 0; i < Rows; i++)
            {
                int number = 1;
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number = number * (i - j) / (j + 1);
                }
                Console.WriteLine();
            }
        }

    }
}
