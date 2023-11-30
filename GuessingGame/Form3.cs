using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form3 : Form
    {
        public Form3(int guessCount, int num, bool win)
        {
            InitializeComponent();
            if (win)
            {
                finalText.Text = "Woohoo, you got it in " + guessCount.ToString() + " guesses!";
            }
            else
            {
                finalText.Text = "Out of time! The answer was " + num.ToString();
            }

            okButton.Click += new EventHandler(OkButton__Click);
        }

        public void OkButton__Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
