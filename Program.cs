using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "";
            Console.WriteLine("Enter your age.");
            x = Console.ReadLine();
            Console.WriteLine($"You are {x} years old.");
        }
    }
}
