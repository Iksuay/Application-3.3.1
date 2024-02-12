using Microsoft.VisualBasic;
using System;

namespace FirstApplication.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            byte Age = 25;
            string Name = "Tamer";
            bool Pet = true;
            double foot = 42.5;

            Console.WriteLine("My name is " + Name);
            Console.WriteLine("My age " + Age);
            Console.WriteLine("Do i have a pet: " + Pet);
            Console.WriteLine("My shoe size is " + foot);

        }
    }
}
