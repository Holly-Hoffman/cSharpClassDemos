using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangmanDemo
{
    internal class HangmanWords
    {
        List<string> words = new List<string>();
        public HangmanWords()
        {
            words = new List<string> {
            "rhythm", "calico", "viscount", "tomorrow", "ermine", "fruit", "scar", "scare", "fathom",
            "fatherhood", "endless","gravitas", "war", "piebald","rickets", "spirit", "ray", "silo",
            "highlight", "quest", "jade", "brood","away","riddles","roe"
            };
        }


        public string GetRandomWord()
        {
            Random newWord = new Random();
            return words[newWord.Next(words.Count)];
        }

        public string GetHiddenWord(string word)
        {
            string hiddenWord = "";
            foreach (char c in word)
            {
                hiddenWord += "_";
            }
            return hiddenWord;
        }

        public string DisplayHiddenWord(string hiddenSpacedWord)
        {
            string displayString = "";
            foreach (char c in hiddenSpacedWord)
            {
                displayString += c + " ";
            }
            return displayString;
        }

    }
}
