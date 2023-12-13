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
    // Form3
    public partial class Form3 : Form
    {
        // init
        public Form3(string name, int correct, int qNum)
        {
            InitializeComponent();

            // percentage calc
            double dCorrect = correct;
            double dQNum = qNum;
            double percentage = dCorrect / dQNum;
            percentage = Math.Round(percentage * 100, 1);

            // change label text
            this.label1.Text = name + ", your final score was: " + correct + " out of " + qNum;
            this.label2.Text = "or, " + percentage + "%";

            // chang background color based on final score
            if(percentage > 90)
            {
                this.BackColor = Color.Green;
            }
            else if (percentage > 75)
            {
                this.BackColor = Color.Yellow;
            }
            else
            {
                this.BackColor = Color.Red;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
