using System;

namespace helloworld
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dog jakob = new Dog();
            jakob.BarkCount = 5;
            jakob.Bark();
        }
    }
}
