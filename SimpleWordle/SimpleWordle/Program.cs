using System;

namespace SimpleWordle
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            var words = new[]{ "ROBOT", "HELLO", "AUDIO", "VIDEO", "MUSIC", "POINT" };

            Random random = new Random();
            ConsoleKeyInfo cki = new ConsoleKeyInfo();

            string actual = words[random.Next(0,words.Length)];
            char firstWord = actual[0];
            char lastWord = actual[actual.Length - 1];
            Console.WriteLine("Welcome to the Simple Wordle");
            Console.WriteLine("You have 6 guesses to find a word that contains 5 letters.\n");
            Console.WriteLine("The first letter of the word is: " + firstWord);
            Console.WriteLine("The last letter of the word is: " + lastWord);
            string guess = "";
            int guessCount = 0;

            while (guess != actual && guessCount < 6)
            {
                int correctCount = 0;
                guessCount++;

                Console.Write("\nEnter your guess: ");
                guess = Console.ReadLine();
                guess = guess.ToUpper();

                if (guess.Length > 5)
                {
                    Console.WriteLine("Input must be within 5 letters.");
                }

                else
                {

                    for (int i = 0; i < guess.Length; i++)
                    {
                        if (guess[i] == actual[i])
                        {
                            correctCount++;

                        }
                    }

                    if (guess == actual)
                    {
                        Console.WriteLine("\nCongratulations! You have guessed the word correctly.");
                        return;
                    }

                    Console.WriteLine("\nYou have guessed " + correctCount + " letters of the word correctly.");
                    Console.WriteLine("Remaining attempts: " + (6 - guessCount) + ". Try again.");
                }
            }

            Console.WriteLine("\nSorry! You couldn't guess the word correctly. Better luck next time.");
            Console.WriteLine("Want to play again?\nPress Y to play again.\nPress X or any other key to quit.");

            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.Y)
            {
                Console.WriteLine();
                Console.WriteLine();
                Main(null);
            }
            else if (cki.Key == ConsoleKey.X)
            {
                return;
            }

        }
    }
}
