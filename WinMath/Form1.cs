using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Niko Huber
// IGME 201
// WinMath 
namespace WinMath
{
    // form1
    public partial class Form1 : Form
    {
        // init
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += new EventHandler(GoButton__Click);
        }

        // go button click
        private void GoButton__Click(object sender, EventArgs e)
        {
            // set defaults and radio
            int difficulty = 0;
            if (radioButton2.Checked)
            {
                difficulty = 1;
            }
            if (radioButton3.Checked)
            {
                difficulty = 2;
            }

            // set defaults and amount of questions
            int qNum = 1;
            try
            {
                qNum = Int32.Parse(textBox2.Text);
            }
            catch{

            }

            // set defaults and input time
            int time = 100;
            try
            {
                time = Int32.Parse(textBox3.Text);
            }
            catch{

            }

            // open form2
            Form2 form2 = new Form2(textBox1.Text, qNum, difficulty, time);
            form2.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
