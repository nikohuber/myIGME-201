using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Niko Huber
// IGME 201
// Exam 3

namespace BestGuiEver
{
    // best gui ever :)
    public partial class Form2 : Form
    {
        // globals
        float ans;
        int userAns;
        CheckBox[] checkBoxes;
        public Form2(Form1 form1)
        {
            InitializeComponent();

            // variable init
            checkBoxes = new CheckBox[8] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8 };
            List<int> boxVals = new List<int>{ 1, 2, 4, 8, 16, 32, 64, 128 };

            Random random = new Random();

            float firstNum = random.Next(0, 50);

            float finalNum = random.Next(50, 100);

            float operand = random.Next(0, 4);

            // setting operation
            if(operand == 0)
            {
                label1.Text = firstNum.ToString() + " + x = " + finalNum.ToString();
                ans = finalNum - firstNum;
            }


            if (operand == 1)
            {
                label1.Text = finalNum.ToString() + " - x = " + firstNum.ToString();
                ans = finalNum + firstNum;
            }

            if (operand == 2)
            {
                label1.Text = finalNum.ToString() + " / x = " + firstNum.ToString();
                ans = finalNum * firstNum;
            }

            if (operand == 3)
            {
                label1.Text = firstNum.ToString() + " * x = "+ finalNum.ToString();
                ans = finalNum / firstNum;
            }

            // set binary tags in checkboxes and also event handler
            foreach(CheckBox checkbox in checkBoxes)
            {
                int temp = boxVals[random.Next(0, boxVals.Count)];
                checkbox.Tag = temp;
                boxVals.Remove(temp);

                checkbox.CheckedChanged += new EventHandler(CheckBox__Checked);
            }

            trackBar1.ValueChanged += new EventHandler(Slider__Changed);

        }

        private void Slider__Changed(object sender, EventArgs e)
        {
            switch (trackBar1.Value.ToString())
            {
                case ("0"): this.BackColor = Color.AliceBlue;
                    break;
                case ("1"): this.BackColor = Color.Red;
                    break;
                case ("2"): this.BackColor = Color.Green;
                    break;
                case ("3"): this.BackColor = Color.Blue;
                    break;
                case ("4"): this.BackColor = Color.Magenta;
                    break;
                case ("5"): this.BackColor = Color.Yellow;
                    break;
                case ("6"): this.BackColor = Color.Orange;
                    break;
                case ("7"): this.BackColor = Color.Orchid;
                    break;
                case ("8"): this.BackColor = Color.PaleGreen;
                    break;
                case ("9"): this.BackColor = Color.PeachPuff;
                    break;
                case ("10"): this.BackColor = Color.Maroon;
                    break;

            }
        }

        // checkbox checked event
        private void CheckBox__Checked(object sender, EventArgs e)
        {
            // user answer calculation based on binary tag
            userAns = 0;
            foreach(CheckBox checkbox in checkBoxes)
            {
                if (checkbox.Checked){
                    userAns += Int32.Parse(checkbox.Tag.ToString()) * (trackBar1.Value);
                }

            }
            label2.Text = "x = " + userAns.ToString();

            //if win
            if (userAns == ans)
            {
                Form3 form3 = new Form3(true);
                form3.ShowDialog();
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
