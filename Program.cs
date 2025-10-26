// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(1, 101); // Generate a random number between 1 and 100
        int attempts = 0;

        Console.WriteLine("Welcome to my totally hard number guessing game!");
        Console.WriteLine("Hmmm... Okay let's go! ");
        Console.WriteLine("Here's how it works: I've picked a random number between 1 and 100.");
        Console.WriteLine("You try to guess it within 10 attempts");
        Console.WriteLine("Good luck!");

        do
        {
            Console.Write("Enter your guess: ");
            string userInputUnchecked = Console.ReadLine();
            int userInput;
            bool validNumber = int.TryParse(userInputUnchecked, out userInput);
            
            if (!validNumber)
            {
                Console.WriteLine("Not a valid number!");
                continue;
            }

            if (userInput < 1 || userInput > 100)
            {
                Console.WriteLine("Invalid number! Please guess a number between 1 and 100.");
                continue;
            }
            else if (userInput < randomNumber)
            {
                Console.WriteLine("Nice Try, but that's a little low...");
                Console.WriteLine($"You have {10 - attempts} attempts left.");
                attempts++;
                continue;
            }
            else if (userInput > randomNumber)
            {
                Console.WriteLine("Ummm... that's a bit high!");
                Console.WriteLine($"You have {10 - attempts} attempts left.");
                attempts++;
                continue;
            }
            else
            {
                Console.WriteLine("Congratulations! You've guessed the number!");
                break;
            }
        }
        while (attempts <= 10);

        if (attempts > 10)
        {
            Console.WriteLine($"The magic number was {randomNumber}. Better luck next time!");
        }

    }
}