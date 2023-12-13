using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

// Niko Huber
// IGME 201
// WinMath
namespace WinMath
{
    // form2
    public partial class Form2 : Form
    {
        // globals
        string name;
        int qNum;
        int difficulty;
        int time;
        int ans;
        int boxTick = 0;
        int correct = 0;
        int qTotal;

        // init
        public Form2(string name, int qNum, int difficulty, int time)
        {
            // set progress bar defauts and start timer
            InitializeComponent();
            progressBar1.Value = time;
            progressBar1.Maximum = time;
            TimerStart();

            // first question
            GenerateQuestion();

            // set globals
            this.name = name;
            this.qNum = qNum;
            this.qTotal = qNum;
            this.difficulty = difficulty;
            this.time = time;

            this.button1.Click += new EventHandler(SubmitButton__Click);

        }
        
        // question generation
        private void GenerateQuestion()
        {
            // variables / random
            Random random = new Random();

            int rand1, rand2, operand;

            this.ans = 0;
            rand1 = 0;
            rand2 = 0;
            operand = 1;

            // given difficulty, change questions
            if (difficulty == 0)
            {
                rand1 = random.Next(10, 20);
                rand2 = random.Next(1, 10);
            }
            else if (difficulty == 1)
            {
                rand1 = random.Next(20, 40);
                rand2 = random.Next(1, 20);
            }
            else if (difficulty == 2)
            {
                rand1 = random.Next(30, 60);
                rand2 = random.Next(1, 30);
            }

            // pick operand
            operand = random.Next(1, 4);

            // switch for operands
            switch (operand)
            {
                case (1):
                    label1.Text = "What is: " + rand1 + " + " + rand2;
                    ans = rand1 + rand2;
                    break;
                case (2):
                    label1.Text = "What is: " + rand1 + " - " + rand2;
                    ans = rand1 - rand2;
                    break;
                case (3):
                    label1.Text = "What is: " + rand1 + " * " + rand2;
                    ans = rand1 * rand2;
                    break;
            }
        }

        // sumbit button event
        private void SubmitButton__Click(object sender, EventArgs e)
        {
            // parse input answer
            int userAns = 0;
            boxTick = 2;
            try
            {
                userAns = Int32.Parse(textBox1.Text);
            }
            catch
            {

            }
            // if correct show box
            if(userAns == ans)
            {
                correct++;
                label3.Text = "Nice Job " + this.name + "!!";
                pictureBox1.ImageLocation = "https://cdn.pixabay.com/photo/2017/04/08/18/17/correct-2214020_960_720.png";
                groupBox1.Visible = true;
            }
            // if incorrect show box
            else
            {
                label3.Text = "Sorry, That is not Correct...";
                pictureBox1.ImageLocation = "https://i.pinimg.com/736x/3c/00/b9/3c00b93b0df45bd32d2c2701f89dcc60.jpg";
                groupBox1.Visible = true;
            }
            // subtract one question from total
            qNum--;
            // if total is not zero, start over
            if (qNum > 0)
            {
                GenerateQuestion();
            }
            // else show ending dialog
            else
            {
                Form3 form3 = new Form3(name, correct, qTotal);
                this.Close();
                form3.ShowDialog();
            }
        }

        // timer init
        private void TimerStart()
        {
            timer1.Start();
            timer1.Tick += new EventHandler(Timer__Tick);
        }

        // timer tick event
        private void Timer__Tick(object sender, EventArgs e)
        {
            // subtract progress bar
            if(progressBar1.Value > 0)
            {
                progressBar1.Value -= 1;
            }
            // if no time, show ran out of time dialog
            else
            {
                qNum--;
                boxTick = 3;
                label3.Text = "You Ran Out of Time!!!";
                pictureBox1.ImageLocation = "https://i.pinimg.com/736x/3c/00/b9/3c00b93b0df45bd32d2c2701f89dcc60.jpg";
                groupBox1.Visible = true;

            }
            // for making correct / incorrect dialogs dissapear
            if (boxTick != 0)
            {
                boxTick--;
                progressBar1.Value = time;
                progressBar1.Maximum = time;
            }
            // hide box dialog
            else
            {
                groupBox1.Visible = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
