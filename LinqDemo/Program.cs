using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lstNumber = new List<int>();
            lstNumber.Add(10);
            lstNumber.Add(21);
            lstNumber.Add(30);
            lstNumber.Add(44);
            lstNumber.Add(57);
            lstNumber.Add(60);
            lstNumber.Add(71);
            lstNumber.Add(81);
            lstNumber.Add(90);
            lstNumber.Add(102);

            var lstEvenNumners = lstNumber.Where(i => i % 2 == 0);
            Console.WriteLine("The even numbers in the list are:");
            foreach(int value in lstEvenNumners)
            {
                Console.WriteLine(value);
            }
            var sumOfEvenNumbers =lstNumber.Where(i => i % 2 == 0).Sum();
            Console.WriteLine($"Addition of even numbers from the list is {sumOfEvenNumbers}.");

            var lstOddNumbers = lstNumber.Where(i => i % 2 != 0);
            Console.WriteLine("The odd numbers in the list are:");
            foreach(int value in lstOddNumbers)
            {
                Console.WriteLine($"{value}");
            }
            var sumOfOddNumbers = lstNumber.Where(i => i % 2 != 0).Sum();
            Console.WriteLine($"Addition of odd numbers from the list is {sumOfOddNumbers}.");

            var averageOfOddNumbers = lstOddNumbers.Average();
            Console.WriteLine($"Average of odd numbers is:{averageOfOddNumbers} ");

            var lstNumbersInDescendingOrder = lstNumber.OrderByDescending( n => n);
            Console.WriteLine("The list in descending order:");
            foreach(int value in lstNumbersInDescendingOrder) { Console.WriteLine(value); }

            Console.ReadLine();
        }
    }
}
