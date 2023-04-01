using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
            Console.ReadLine();
        }
    }
}
