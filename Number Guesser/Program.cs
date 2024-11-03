// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        {
            Random random = new Random();
            int returnValue = random.Next(1, 100);
            int Guess = 0;
            Console.WriteLine("I am thinking of a number between 1-100. If you can guess what it is, you'll win a prize!");
            while (Guess != returnValue)
            {
                Guess = Convert.ToInt32(Console.ReadLine());
                if (Guess < returnValue) 
                {
                    Console.WriteLine("Nah bro, the number I'm thinkin is higher than " + Guess + ". Keep tryin!");
                }
        else if (Guess > returnValue)
                {
                    Console.WriteLine("Too high my guy, the number on my mind is lower than " + Guess + ". You got this!");
                }
            }

            Console.WriteLine("Well done broski! The answer was " + returnValue);
            Console.ReadLine();
        }
    }
}