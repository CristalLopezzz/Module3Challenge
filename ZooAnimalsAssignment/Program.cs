// See https://aka.ms/new-console-template for more information
using System;

namespace ZooAnimalsAssignment
{
    class Program
    {
        static void Main(string[] args)
            {
                Console.Write("Enter the animal's hunger level 1-10: ");
                int hungerLevel = int.Parse(Console.ReadLine());

                if(hungerLevel >= 8)
                {
                    Console.WriteLine("Lion: Roar! I need a big meal!");
                }
                else if(hungerLevel >= 5)
                {
                    Console.WriteLine("Monkey: Ooh ooh! I'll take some bananas.");
                }
                else(hungerLevel < 5)
                {
                    Console.WriteLine("Tortoise: Slow and steady --I'll hahve some lettuce.")
                }
            }
    }
}//Still working on the rest of my code