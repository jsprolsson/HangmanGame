using System;
using System.Collections.Generic;
using System.Text;

namespace HängaGubbe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userKnows = false;
            int maxGuesses = 15;
            int numberOfGuesses = 0;
            string randomWord = GetRandomWord();            //Plockar in slumpmässigt ord i variabel.
            char[] randomWordChar = randomWord.ToCharArray();           //Splittar upp sträng-variabeln i chars istället.
            int lengthOfRandomWord = randomWordChar.Length;

            //StringBuilder invisibleLetters = new StringBuilder();
            //invisibleLetters.Append('_', lengthOfRandomWord);               //Skapar "osynliga" bokstäver baserat på hur många chars som finns i slumpordet.
            //Console.WriteLine($"Letters: {invisibleLetters}");
            Console.WriteLine(randomWord);

            //Console.WriteLine("Do you know what the word is?");
            //if (Console.ReadLine().ToUpper() == "YES")
            //{
            //    UserKnows(randomWord);                        //Frågar anv. efter 3 gissningar om den vet ordet. I så fall, kallar på metoden. Om inte - fortsätter gissningarna.
                
            //}
            //else
            //    Console.WriteLine("Okay.");
            


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


        public static void UserKnows(string randomWord)
        {
            Console.WriteLine("What is the correct word?");
            string userWord = Console.ReadLine().ToUpper();

            if (userWord == randomWord)
            {
                Console.WriteLine("Good job!");
            }
            else if(userWord != randomWord)
            {
                Console.WriteLine("Sorry, that is not the word.");
            }
            else
                Console.WriteLine("Invalid input.");
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
