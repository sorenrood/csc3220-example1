using System;

namespace helloworld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog.BarkCount = 5;
            Dog.BarkMessage = "Ruff";
            Dog.Bark();
        }
    }
}
