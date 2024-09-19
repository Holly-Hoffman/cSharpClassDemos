using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelOfFortuneConsole.model
{
    public class WoFPhrases
    {
        private static List<string> phrases = new List<string> 
        {
         "HOLD ONTO YOUR BUTTS", "MAY THE FORCE BE WITH YOU", "MAKE IT SO", "WHAT IN THE WIDE WIDE WORLD OF SPORTS IS GOING ON HERE",
         "HOUSTON WE HAVE A PROBLEM", "SAY HELLO TO MY LITTLE FRIEND", "TO INFINITY AND BEYOND", "NOBODY CALLS ME CHICKEN", "YOU TALKING TO ME",
         "YOU HAD ME AT HELLO", "I SEE DEAD PEOPLE", "NOBODY PUTS BABY IN A CORNER", "LIFE IS LIKE A BOX OF CHOCOLATES", "I AM SPARTICUS",
         "YOU MAKE ME WANT TO BE A BETTER MAN", "GO AHEAD MAKE MY DAY", "THERE IS NO WAR IN BA SING SE"
        };
        public static string GetPhrase()
        {
            //getting the phrase
            Random random = new Random();
            int idx = random.Next(phrases.Count);
            string phrase = phrases[idx];

            //removing the phrase for as long as it is running.
            phrases.RemoveAt(idx);
            return phrase;
        }
    }
}
