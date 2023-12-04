using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

// Niko Huber
// IGME 201
// Exam 3

namespace BestGuiEver
{
    // Best Gui Ever :)
    public partial class Form1 : Form
    {
        // global form2
        Form2 form2;
        public Form1()
        {
            InitializeComponent();

            //form2 init
            form2 = new Form2(this);

            //button event
            button1.BringToFront();
            button1.Click += new EventHandler(Button__Click);

            // radio event
            radioButton1.CheckedChanged += new EventHandler(Radio1__Check);
            radioButton2.CheckedChanged += new EventHandler(Radio2__Check);
            radioButton3.CheckedChanged += new EventHandler(Radio3__Check);
            radioButton4.CheckedChanged += new EventHandler(Radio4__Check);

            textBox1.TextChanged += new EventHandler(Text__Changed);
        }

        private void Text__Changed(object sender, EventArgs e)
        {
            this.label1.Text += textBox1.Text;
        }

        //
        // radio events
        //
        private void Radio1__Check(object sender, EventArgs e)
        {

            this.BackColor = Color.White;

        }

        private void Radio2__Check(object sender, EventArgs e)
        {

            this.BackColor = Color.Blue;


        }
        private void Radio3__Check(object sender, EventArgs e)
        {
            this.BackColor = Color.Beige;

        }
        private void Radio4__Check(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;

        }

        // button click
        private void Button__Click(object sender, EventArgs e)
        {
            //start timer
            timer1.Start();
            timer1.Tick += new EventHandler(Timer__Tick);
            //bkg color change
            this.BackColor = Color.Pink;
            form2.ShowDialog();
        }

        //timer
        private void Timer__Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value > 0)
            {
                progressBar1.Value--;

            }
            else
            {
                Form3 form3 = new Form3(false);
                timer1.Stop();
                form3.ShowDialog();
                form2.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
