using System;
using System.Collections.Generic;
using System.Text;

namespace NumbersGame
{
    internal class Utilities
    {
        public static bool CheckGuess(int randomNumber, int userSelection)
        {
            bool isGuessCorrect;
            if (userSelection < randomNumber)
            {
                Console.WriteLine("Tyvärr du gissade för lågt");
                isGuessCorrect = false;
                return isGuessCorrect;
            }
            else if (userSelection > randomNumber)
            {
                Console.WriteLine("Tyvärr du gissade för högt");
                isGuessCorrect = false;
                return isGuessCorrect;
            }
            else
            {
                Console.WriteLine("Wohoo! Du gjorde det!");
                isGuessCorrect = true;
                return isGuessCorrect;
            }
        }
    }
}
