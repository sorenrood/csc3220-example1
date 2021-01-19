using System;
using System.Collections.Generic;
using System.Text;

// static keyword defines a class variable.
// You do not need to instantiate to interact with static vars/methods.

namespace helloworld
{
    class Dog
    {
        public static string BarkMessage = "Ruff";
        public static int BarkCount = 1;
        public static void Bark()
        {
            for (int count = 0; count < BarkCount; count++)
            {
                Console.WriteLine(BarkMessage);
            }
        }
    }
}
