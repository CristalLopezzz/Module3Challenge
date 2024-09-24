// See https://aka.ms/new-console-template for more information
using System;

//namespace
namespace ZooAnimalsAssignment
{
    //Defines main class
    class Program
    {
        static void Main(string[] args)
            {
                //Allows user to put their hunger level in int form
                Console.Write("Enter the animal's hunger level 1-10: ");

                //Converts string to int
                int hungerLevel = int.Parse(Console.ReadLine());

                //If users input is greater than or equal to 8 it will print the following message
                if(hungerLevel >= 8)
                {
                    Console.WriteLine("Lion: Roar! I need a big meal!");

                } //If users input is in between 5-7 it will print the following message
                else if(hungerLevel >= 5)
                {
                    Console.WriteLine("Monkey: Ooh ooh! I'll take some bananas.");

                } //If users input is anything less than 5 it will print the following message
                else
                {
                    Console.WriteLine("Tortoise: Slow and steady --I'll have some lettuce.");
                }

                //Ternary operator that indicates if hunger level is greater than 8, which will then determine the returning message to user 
                string recommendation = (hungerLevel >=8)? "Listen to the Lion: Roar!" : "Listen to the Monkey: Ooh ooh!";

                //Outputs the message depending on hungerLevel
                Console.WriteLine(recommendation);

                //Allows user to input their day of the week as an int
                Console.Write("Enter the day of the week as a number (1-7, 1 is Sunday): ");

                //Converts string to int
                int dayOfWeek = int.Parse(Console.ReadLine());

                //Switch statement that executes a code block from a list of case conditions
                //Depending on user input it will return a specific message 
                switch(dayOfWeek)
                {
                    case 1: //Sunday
                        Console.WriteLine("10% off Family Sundays!");
                        break;
                    case 2: //Monday
                        Console.WriteLine("Free Monkey Show Monday's!");
                        break;
                    case 3: //Tuesday
                        Console.WriteLine("Tortoise Race Tuesday!");
                        break;
                    case 4: //Wednesday
                        Console.WriteLine("Whale Show Wednesdays!");
                        break;
                    case 5: //Thursday
                        Console.WriteLine("Petting Thursday!");
                        break;
                    case 6: //Friday
                        Console.WriteLine("Free Pizza Friday!");
                        break;
                    case 7: //Saturday
                        Console.WriteLine("Penguin Show Saturdays!");
                        break;
            
                }

            } //End main method
    } //End program class
}//End namespace