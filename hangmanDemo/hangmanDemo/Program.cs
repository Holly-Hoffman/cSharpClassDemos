namespace hangmanDemo
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

                //this is the start - they have not guessed any wrong letters or the word.
                int incorrectGuesses = 0;
                bool wordGuessed = false;

                List<string> lettersGuessed = new List<string>();

                while (incorrectGuesses != 6 && !wordGuessed)
                {
                    Console.WriteLine(word);
                    getHangman(incorrectGuesses);
                    Console.WriteLine(words.DisplayHiddenWord(hiddenWord));
                    Console.WriteLine($"Letters guessed: {GetLettersGuessedString(lettersGuessed)}");
                    Console.WriteLine();


                    string letterGuess = PromptInput("Enter a letter: ");
                    //have they used the letter yet?
                    if (lettersGuessed.IndexOf(letterGuess) < 0)
                    {
                        lettersGuessed.Add(letterGuess);
                        if (word.IndexOf(letterGuess) >= 0)
                        {
                            hiddenWord = UpdateHiddenWord(word, hiddenWord, char.Parse(letterGuess));
                            if (hiddenWord.IndexOf('_') < 0)
                            {
                                wordGuessed = true;
                            }
                        }

                        else { incorrectGuesses++; }
                    }


                    else
                    {
                        Console.WriteLine("Letter already guessed - try again.");
                    }
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

        public static string UpdateHiddenWord(string word, string hiddenWord, char letterGuess)
        {
            //accepting hidden word
            //we know the letter is in there
            //loop the word, find where letterGuess is
            //change hiddenWord at those index positions
            char[] wordCharArray = word.ToCharArray();
            char[] hiddenWordCharArray = hiddenWord.ToCharArray();

            for (int i = 0; i < wordCharArray.Length; i++)
            {
                if (wordCharArray[i] == letterGuess)
                {
                    hiddenWordCharArray[i] = letterGuess;
                }
            }
            return new string(hiddenWordCharArray);
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

