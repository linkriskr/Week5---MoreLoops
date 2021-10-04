using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //I will not skateboard in the halls.

            string message = "I will not skateboard in the halls.".ToUpper();

            for (int i = 0; i < 10; i++) //int i = 0; - start; i < 10; - end; i++ = i = i +1 - step
            {
                Console.WriteLine($"{i+1}. I will not skateboard in the halls.".ToUpper());
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
