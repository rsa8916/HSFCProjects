using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        string[] wordbank = { "pink", "elephant", "dog", "cherry", "lampost" }; // a array for the words to guess
        Random rnd = new Random();
        Button[] alphabetButtons;
        string wordToGuess = "";
        int lives = 5;
        bool win = false;
        string lettersRevealed = "";
        string letteresGuessed = "";
        string usersGuess;
        int length;
        int positionInBank;

        private void LetterGuessedBox_TextChanged(object sender, EventArgs e)
        {
            usersGuess = Console.ReadLine();

        }
        //randomly generate word

        public void  Wordbank()
        {
            positionInBank = rnd.Next(0, 5);
            wordToGuess = wordbank[positionInBank];
        }
        //get length of word
        
            
       //checking each letter of the random word. Searching for the same letter.
       private void LettersRevealed()
        {
            //put in repeating thing for the entirety of length 
            
            //allocating every letter to a positon
            wordToGuess.Substring(0, 1);
        }
    }
                                         
}
                                                                                                                                                                                                                                                                                                             