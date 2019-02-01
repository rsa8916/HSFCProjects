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
        Random ran = new Random();
        string wordToGuess = "";
        int lives = 5;
        bool win = false;
        string lettersRevealed = "";
        string letteresGuessed  = "";
        string usersGuess;
        int length;                           

        private void LetterGuessedBox_TextChanged(object sender, EventArgs e)
        {                    
            usersGuess = Console.ReadLine();
            
        }                                      
                                                                                                                                                           
                                                                                                 

                                                                                                                            
                                    
                                
    }
                                         
}
                                                                                                                                                                                                                                                                                                             