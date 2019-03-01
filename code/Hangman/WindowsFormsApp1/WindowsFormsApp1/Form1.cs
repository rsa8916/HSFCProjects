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
        string wordToGuess = "";
        int lives = 5;
        bool win = false;
        int orderInWord;
        int orderInStringBuilder;
        string usersGuess;
        int positionInBank;
        int PositionInWord;
        int length;
        StringBuilder letterGuessedCorrect = new StringBuilder();
        StringBuilder letterGuessedIncorrect = new StringBuilder();

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
        public int GetPositionInWord() // function
        {
            length = wordToGuess.Length;
            //put in repeating thing for the entirety of length 

            for (int PositionInWord = 0; PositionInWord < length; PositionInWord++)
            {
                if (usersGuess == wordToGuess.Substring(PositionInWord))
                {

                    return PositionInWord;//returning 
                    letterGuessedCorrect[PositionInWord] = usersGuess;
                }
                
                else
                {
                   lives = lives - 1;
                    if (lives == 0)
                    {
                        win = false;//DEAD
                        
                    }
                    return 999; //error code

                }
               
            }
            return 999;
        }
        //detect a win

        public bool detectWin()
        {
            if (letterGuessedCorrect.Length == wordToGuess.Length ) //if guessed all the letters in the word
            {
                win = true; //WIN!!!!!!!!
                return win;
            }
            else
            {
                return win = false;
            }

           
        
        }

        //displaying the word (the bits gusssed correct)
        private void WordBox_TextChanged(object sender, EventArgs e)
        {

            WordBox.Text = letterGuessedCorrect.ToString();

            for(int orderInWord = 0; orderInWord < length; orderInWord++)
            {
                // ordrering the chars in the builder to the order in the word with the spaces...
               if( wordToGuess.Substring(orderInWord) == letterGuessedCorrect.Substring(orderInStringBuilder))
                {
                    orderInStringBuilder++;

                }
            }
           

        }
        
        //dispaly amount of lives remaining

        // if((letterGuessedCorrect.Length <= wordToGuess.Length) | (lives > 0))
            {
                //i need to display the letters guessed correctly in the order that they are presented in the wore to guess.
              //  if (wordToGuess.Substring(0) == letterGuessedCorrect(0,1)
       // {

       // }
    ///
    //}

    //getting the users choice
    //assinging the users choice
    private void button1_Click(object sender, EventArgs e)//A
        {
            usersGuess = "A" ;
        }

        private void B_Click(object sender, EventArgs e)
        {
            usersGuess = "B";
        }

        private void C_Click(object sender, EventArgs e)
        {
            usersGuess = "C";
        }

        private void D_Click(object sender, EventArgs e)
        {
            usersGuess = "D";
        }

        private void E_Click(object sender, EventArgs e)
        {
            usersGuess = "E";
        }

        private void F_Click(object sender, EventArgs e)
        {
            usersGuess = "F";
        }

        private void G_Click(object sender, EventArgs e)
        {
            usersGuess = "G";
        }

        private void H_Click(object sender, EventArgs e)
        {
            usersGuess = "H";
        }

        private void I_Click(object sender, EventArgs e)
        {
            usersGuess = "I";
        }

        private void J_Click(object sender, EventArgs e)
        {
            usersGuess = "J";
        }

        private void K_Click(object sender, EventArgs e)
        {
            usersGuess = "K";
        }

        private void L_Click(object sender, EventArgs e)
        {
            usersGuess = "L";
        }

        private void M_Click(object sender, EventArgs e)
        {
            usersGuess = "M";
        }

        private void N_Click(object sender, EventArgs e)
        {
            usersGuess = "N";
        }

        private void O_Click(object sender, EventArgs e)
        {
            usersGuess = "O";
        }

        private void P_Click(object sender, EventArgs e)
        {
            usersGuess = "P";
        }

        private void Q_Click(object sender, EventArgs e)
        {
            usersGuess = "Q";
        }

        private void R_Click(object sender, EventArgs e)
        {
            usersGuess = "R";
        }

        private void S_Click(object sender, EventArgs e)
        {
            usersGuess = "S";
        }

        private void T_Click(object sender, EventArgs e)
        {
            usersGuess = "T";
        }

        private void V_Click(object sender, EventArgs e)
        {
            usersGuess = "V";
        }

        private void U_Click(object sender, EventArgs e)
        {
            usersGuess = "U";
        }

        private void W_Click(object sender, EventArgs e)
        {
            usersGuess = "W";
        }

        private void X_Click(object sender, EventArgs e)
        {
            usersGuess = "X";
        }

        private void Y_Click(object sender, EventArgs e)
        {
            usersGuess = "Y";
        }

        private void Z_Click(object sender, EventArgs e)
        {
            usersGuess = "Z";
        }

       
    }
                                         
}
                                                                                                                                                                                                                                                                                                             