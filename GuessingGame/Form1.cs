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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            startButton.Click += new EventHandler(StartButton__Click);

        }

        public void StartButton__Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int number = random.Next(Int32.Parse(lowNumberTextBox.Text), Int32.Parse(highNumberTextBox.Text));
            Form2 form2 = new Form2(number);
            form2.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
