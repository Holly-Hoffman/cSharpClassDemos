using Hangman2.model;

namespace Hangman2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to hangman!\n");
            Console.WriteLine("Rules of the game:");
            HangmanWords words = new HangmanWords();

            string choice = "y";
            while (choice == "y")
            {
                //this gets a random word and its corresponding hidden version
                string word = words.GetRandomWord();
                string hiddenWord = words.GetHiddenWord(word);

                //making everything into char arrays
                char[] wordArray = word.ToCharArray();
                char[] hiddenArray = hiddenWord.ToCharArray();


                //this is the start - they have not guessed any wrong letters or the word.
                int incorrectGuesses = 0;
                bool wordGuessed = false;
                bool inWord = false;
                List<string> lettersGuessed = new List<string>();

                while (incorrectGuesses != 6 && !wordGuessed)
                {
                    //Console.WriteLine(word);
                    getHangman(incorrectGuesses);
                    Console.WriteLine(words.DisplayHiddenWord(new string(hiddenArray)));
                    Console.WriteLine($"Letters guessed: {GetLettersGuessedString(lettersGuessed)}");
                    Console.WriteLine();


                    string letterGuess = PromptInput("Enter a letter: ");
                    //have they used the letter yet?
                    bool contains = lettersGuessed.Contains(letterGuess);
                    //if so:

                    if (contains)
                    {
                        Console.WriteLine("Letter already guessed - try again.");
                    }

                    //if not

                    else
                    {
                        for (int i = 0; i < wordArray.Length; i++)
                        {
                            if (wordArray[i] == letterGuess.ToCharArray()[0])
                            {
                                //the letter is in the word:
                                inWord = true;

                                //update hidden word with the guessed letter
                                hiddenArray[i] = letterGuess.ToCharArray()[0];
                                string updatedWord = new string(hiddenArray);

                                //if no underscores remain, set wordguess = true
                                if (word == updatedWord)
                                { wordGuessed = true; }
                            }
                        }

                        if (inWord == false)
                        {
                            Console.WriteLine($"{letterGuess} is not in the word.");
                            incorrectGuesses++;
                            //Console.WriteLine(incorrectGuesses);
                        }

                        lettersGuessed.Add(letterGuess);
                    }
;
                    Console.WriteLine();
                    inWord = false;

                }

                if (incorrectGuesses == 6)
                {
                    getHangman(6);
                    Console.WriteLine($"YOU'VE KILLED HIM!\nCause of death: {word}");
                }

                else if (wordGuessed == true)
                {
                    Console.WriteLine($"Nice job! You saved him from {word}!");
                }

                choice = PromptInput("Play again? (y/n): ");
            }

            Console.WriteLine("\nThanks for playing!");


        }

        //keeping track of the guessed letters
        public static string GetLettersGuessedString(List<string> lettersGuessed)
        {
            string str = "";
            if (lettersGuessed.Count != 0)
            {
                foreach (string s in lettersGuessed)
                { str += (s + " "); }

            }
            return str;
        }

        public static string PromptInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }

        //this calls the image of the hangman
        public static void getHangman(int incorrectGuesses)
        {
            string[] hangedMan = new string[]
            {"------",
             "|    |",
             "|    O",
             "|   /|\\",
             "|   / \\",
             "|",
             "----",
             "|   /|",
             "|   /",
            };


            if (incorrectGuesses == 0)
            {
                Console.WriteLine(hangedMan[0]);
                Console.WriteLine(hangedMan[1]);
                Console.WriteLine(hangedMan[5]);
                Console.WriteLine(hangedMan[5]);
                Console.WriteLine(hangedMan[5]);
                Console.WriteLine(hangedMan[5]);
                Console.WriteLine(hangedMan[6]);
            }

            else if (incorrectGuesses == 1)
            {
                Console.WriteLine(hangedMan[0]);
                Console.WriteLine(hangedMan[1]);
                Console.WriteLine(hangedMan[2]);
                Console.WriteLine(hangedMan[5]);
                Console.WriteLine(hangedMan[5]);
                Console.WriteLine(hangedMan[5]);
                Console.WriteLine(hangedMan[6]);
            }

            else if (incorrectGuesses == 2)
            {
                Console.WriteLine(hangedMan[0]);
                Console.WriteLine(hangedMan[1]);
                Console.WriteLine(hangedMan[2]);
                Console.WriteLine(hangedMan[1]);
                Console.WriteLine(hangedMan[5]);
                Console.WriteLine(hangedMan[5]);
                Console.WriteLine(hangedMan[6]);
            }

            else if (incorrectGuesses == 3)
            {
                Console.WriteLine(hangedMan[0]);
                Console.WriteLine(hangedMan[1]);
                Console.WriteLine(hangedMan[2]);
                Console.WriteLine(hangedMan[7]);
                Console.WriteLine(hangedMan[5]);
                Console.WriteLine(hangedMan[5]);
                Console.WriteLine(hangedMan[6]);
            }

            else if (incorrectGuesses == 4)
            {
                Console.WriteLine(hangedMan[0]);
                Console.WriteLine(hangedMan[1]);
                Console.WriteLine(hangedMan[2]);
                Console.WriteLine(hangedMan[3]);
                Console.WriteLine(hangedMan[5]);
                Console.WriteLine(hangedMan[5]);
                Console.WriteLine(hangedMan[6]);
            }

            else if (incorrectGuesses == 5)
            {
                Console.WriteLine(hangedMan[0]);
                Console.WriteLine(hangedMan[1]);
                Console.WriteLine(hangedMan[2]);
                Console.WriteLine(hangedMan[3]);
                Console.WriteLine(hangedMan[8]);
                Console.WriteLine(hangedMan[5]);
                Console.WriteLine(hangedMan[6]);
            }
            else if (incorrectGuesses == 6)
            {
                Console.WriteLine(hangedMan[0]);
                Console.WriteLine(hangedMan[1]);
                Console.WriteLine(hangedMan[2]);
                Console.WriteLine(hangedMan[3]);
                Console.WriteLine(hangedMan[4]);
                Console.WriteLine(hangedMan[5]);
                Console.WriteLine(hangedMan[6]);
            }
        }




    }
}
