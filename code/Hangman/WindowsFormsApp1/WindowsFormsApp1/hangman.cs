using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class hangman
    {
        string[] wordbank = { "pink", "elephant", "dog", "cherry", "lampost" }; // a array for the words to guess
        Random ran = new Random();
        string wordToGuess = wordbank[];
        int lives = 5;
        bool win = false;
        int lettersRevealed;
        int letteresGuessed;
        char usersGuess;

        char[] guess = new char[wordToGuess.Length];


       
    }
}
