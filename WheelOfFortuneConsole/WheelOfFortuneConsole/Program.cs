using System.Net.Security;

namespace WheelOfFortuneConsole
{
    internal class Program
    {
        //wheel
        //could also do this as a list of ints w/0 and -1 as lose a turn and bankrupt.
        static List<string> wheelValues = new List<string>
        {"bankrupt", "lose a turn", "100", "150", "200", "250", "300", "350",
        "400", "450", "500", "550", "600", "650", "700", "750", "800", "850", "900"};

        //bank for rounds.  The total is just the sum of the below numbers
        decimal[] roundBanks = {0.0M, 0.0M, 0.0M};


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Wheel of Fortune Game!\n");
            Console.WriteLine("Instructions:");

            //initialize variables
            //do we need to put variables within the class or within the main method?



            //while loop to play multiple times
            string choice = "Y";
            while (choice == "Y") {
                //single game vars (like $$)

                //starting the game loop
                for (int i = 0; i < 3; i++)
                {
                    //round loop:
                    //welcome to round messsage
                    // initialize bank
                    // get the roundPhrase
                    //generate hiddenPhrase
                    //display hiddenPhrase (inside while or outside?)

                    //while loop for gameplay (loop until user guesses phrase)
                    //spin, buy a vowel, or guess
                    //if spin:
                    //-spin wheel
                    //--bankrupt
                    //---set roundBalance to 0, continue back to while loop
                    //--lose turn
                    //---continue back to while loop
                    //--$ amount, guess cons.
                    //---if it exists
                    //----resolve letter in hiddenPhrase
                    //----add money to roundBank
                    //---if not
                    //----continue (spin, vowel, solve)
                    //if buy a vowel:
                    //-if enough money, deduct from roundBank, prompt for vowel
                    //--if vowel exists, resolve in word
                    //--if not, continue to while loop
                    //if guess
                    //-if correct, win
                    //-else, continue

                    //loop to control the game/round
                    //initialize round phrase from class
                    //loop for each spin

                    //how to win / lose?
                    //round ends when the phrase is guessed.  roundPhrase?

                }
                choice = promptString("Play again?", ["Y", "N"]);
            }

            Console.WriteLine("Thanks for playing!");
        }

        //wheel of fortune phrases class similar to hangman words
        //get random phrase and remove it once used

        //validation methods?
        private static string promptString(string prompt, string[] validStrings) 
        {
            String goodString = "";
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(prompt);
                goodString = Console.ReadLine().ToUpper();
                foreach (string s in validStrings)
                {
                    if (s == goodString)
                    {
                        isValid = true;
                        break;
                    }
                }
            }

                return goodString;
        }

        //wheel:
        //how to manage wheel values?
        //19 segments - 50, 100, 150, 200, 250, etc. 900
        //lose a turn
        //bankrupt
        //$ - either buy a vowel for 250, guess a consonant for free, or guess the word
        //    If correct, get $

        //bank:
        //how to manage?
        //do round winnings go in master bank or add up over rounds?
        //going to make this an array of decimals
    }
}
