using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPattern1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            for(int j = 0; j < i; j++)
            {
                for(int k = 0; k <= j; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
