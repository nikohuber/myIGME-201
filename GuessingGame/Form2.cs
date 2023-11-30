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
    public partial class Form2 : Form
    {
        int num;
        int guessCount = 0;
        bool win = true;

        public Form2(int number)
        {
            InitializeComponent();

            num = number;

            guessButton.Click += new EventHandler(GuessButton__Click);
            this.guessTextBox.KeyPress += new KeyPressEventHandler(Enter__KeyPress);           
        }

        public void Enter__KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                guessCount++;
                int guess = Int32.Parse(guessTextBox.Text);

                guessTextBox.Text = "";

                if (guess < num)
                {
                    guessLabel.Text = guess + " is too low.";
                }
                else if (guess > num)
                {
                    guessLabel.Text = guess + " is too high.";
                }
                else
                {
                    Form3 form3 = new Form3(guessCount, num, win);
                    form3.ShowDialog();
                    this.Close();

                }

                e.Handled = true;

            }
        }

        public void GuessButton__Click(object sender, EventArgs e)
        {
            guessCount++;
            int guess = Int32.Parse(guessTextBox.Text);

            guessTextBox.Text = "";

            if (guess < num)
            {
                guessLabel.Text = guess + " is too low.";
            }
            else if(guess > num)
            {
                guessLabel.Text = guess + " is too high.";
            }
            else
            {
                Form3 form3 = new Form3(guessCount, num, win);
                form3.ShowDialog();
                this.Close();

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            timer1.Interval = (1000);
            timer1.Tick += new EventHandler(Timer__Tick);
            timer1.Start();

        }

        public void Timer__Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value > 0)
            {
                progressBar1.Value--;
            }
            else
            {
                timer1.Stop();
                win = false;
                Form3 form3 = new Form3(guessCount, num, win);
                form3.ShowDialog();
                this.Close();

            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void guessGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
