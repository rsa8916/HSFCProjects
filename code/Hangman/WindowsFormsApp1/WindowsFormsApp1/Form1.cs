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
        string[] wordbank = { "pink", "germany", "dog", "computer", "lampost" , "algorithms","flamingo" }; // a array for the words to guess
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
        int PositionInWord ;
        
        private void LetterGuessedBox_TextChanged(object sender, EventArgs e)
        {
            usersGuess = Console.ReadLine();

        }
        //randomly generate word

        public void  Wordbank()
        {
            positionInBank = rnd.Next(0, 7);
            wordToGuess = wordbank[positionInBank];
        }
        //get length of word
        
            
       //checking each letter of the random word. Searching for the same letter.
       public int PositionInWord()
        {
            length = wordToGuess.Length;
            //put in repeating thing for the entirety of length 
       
            for (int positionInWord = 0; positionInWord < length; positionInWord++)
            {
                if (usersGuess == wordToGuess.Substring(positionInWord))
                {
                    return positionInWord;//returning 
                }
                
                else
                {
                   lives = lives - 1;
                    if (lives == 0)
                    {
                        win = false;//DEAD
                        
                    }
                    return -1; //error code

                }
               
            }
            
        }
        //detect a win

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
                                         
}
                                                                                                                                                                                                                                                                                                             