using System;
using System.Collections.Generic;

namespace HängaGubbe
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxGuesses = 15;
            int numberOfGuesses = 0;
            string randomWord = GetRandomWord();            //Plockar in slumpmässigt ord i variabel.
            char[] randomWordChar = randomWord.ToCharArray();           //Splittar upp sträng-variabeln i chars istället.

            Console.WriteLine(randomWord);


            for (int i = 0; i < maxGuesses; i++)
            {
                Console.WriteLine($"Guess count: {numberOfGuesses}\n---------------------------------------");

                Console.Write("Write your guess: ");
                char userGuess = Convert.ToChar(Console.ReadLine().ToUpper());

                for (int j = 0; j < randomWordChar.Length; j++)
                {

                    if (userGuess == randomWordChar[j])
                    {
                        Console.Clear();
                        Console.WriteLine("Correct!");
                        break;
                    }
                    else if (userGuess != randomWordChar[j])
                    {
                        Console.Clear();
                        Console.WriteLine("Not a letter in the word.");
                    }

                }
                numberOfGuesses++;
            }

           

        }






        public static string GetRandomWord()
        {
            Random random = new Random();
            int randomWordNumber = random.Next(1, 10);
            Dictionary<int, string> wordChoices = new Dictionary<int, string>();
            wordChoices.Add(1, "SPÄNNANDE");
            wordChoices.Add(2, "BERGET");
            wordChoices.Add(3, "KONSOL");
            wordChoices.Add(4, "GITARR");
            wordChoices.Add(5, "TAKLAMPA");                                         //Metod för slumpmässigt val av ord.
            wordChoices.Add(6, "GASSPIS");
            wordChoices.Add(7, "SKOHYLLA");
            wordChoices.Add(8, "BALKONG");
            wordChoices.Add(9, "HÖRLURAR");
            wordChoices.Add(10, "KLUMPIG");


            return wordChoices[randomWordNumber];
        }
    }
}
