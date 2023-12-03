using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.WebRequestMethods;

// Niko Huber
// Exam 3
// IGME 201

namespace PresidentsApp
{

    // Presidents App
    public partial class Form1 : Form
    {
        // Global variables and arrays
        TextBox[] inputs;
        int[] answers;
        PictureBox[] wrongImages;
        bool timerStarted = false;
        RadioButton[] radios;

        // Form1
        public Form1()
        {
            InitializeComponent();

            // disable exit button
            button1.Enabled = false;

            // populate lists with textboxes, answers, incorrect images, and radios
            inputs = new TextBox[16] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox10, textBox11, textBox12, textBox13, textBox14, textBox15, textBox16, textBox17};
            answers = new int[16] { 23, 32, 42, 15, 14, 43, 44, 35, 25, 40, 34, 8, 1, 2, 26, 3};
            wrongImages = new PictureBox[16] { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15, pictureBox16, pictureBox17 };
            radios = new RadioButton[16] { BenjaminHarrison, FranklinDRoosevelt, WilliamJClinton, JamesBuchanan, FranklinPierce, GeorgeWBush, BarackObama, JohnFKennedy, WilliamMcKinley, RonaldReagan, DwightDEisenhower, MartinVanBuren, GeorgeWashington, JohnAdams, TheodoreRoosevelt, ThomasJefferson };

            // event handlers for filter radios
            filterAll.CheckedChanged += new EventHandler(FilterAll__Checked);
            filterDemocrat.CheckedChanged += new EventHandler(FilterDemocrat__Checked);
            filterRepublican.CheckedChanged += new EventHandler(FilterRepublican__Checked);
            filterDemocratRepublican.CheckedChanged += new EventHandler(FilterDemocratRepublican__Checked);
            filterFederalist.CheckedChanged += new EventHandler(FilterFederalist__Checked);

            // registry key / security stuff
            try
            {
                // Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident / 7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; wbx 1.0.0)
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }
            webBrowser1.ScriptErrorsSuppressed = true;

            // event handler for text changing
            foreach(TextBox input in inputs)
            {
                toolTip1.SetToolTip(input, "Which # President?");

                input.TextChanged += new EventHandler(TextBox__TextChanged);
            }

            // event handlers for president radios
            BenjaminHarrison.CheckedChanged += new EventHandler(BenjaminHarrison__Checked);
            FranklinDRoosevelt.CheckedChanged += new EventHandler(FranklinDRoosevelt__Checked);
            WilliamJClinton.CheckedChanged += new EventHandler(WilliamJClinton__Checked);
            JamesBuchanan.CheckedChanged += new EventHandler(JamesBuchanan__Checked);
            FranklinPierce.CheckedChanged += new EventHandler(FranklinPierce__Checked);
            GeorgeWBush.CheckedChanged += new EventHandler(GeorgeWBush__Checked);
            BarackObama.CheckedChanged += new EventHandler(BarackObama__Checked);
            JohnFKennedy.CheckedChanged += new EventHandler(JohnFKennedy__Checked);
            WilliamMcKinley.CheckedChanged += new EventHandler(WilliamMcKinley__Checked);
            RonaldReagan.CheckedChanged += new EventHandler(RonaldReagan__Checked);
            DwightDEisenhower.CheckedChanged += new EventHandler(DwightDEisenhower__Checked);
            MartinVanBuren.CheckedChanged += new EventHandler(MartinVanBuren__Checked);
            GeorgeWashington.CheckedChanged += new EventHandler(GeorgeWashington__Checked);
            JohnAdams.CheckedChanged += new EventHandler(JohnAdams__Checked);
            TheodoreRoosevelt.CheckedChanged += new EventHandler(TheodoreRoosevelt__Checked);
            ThomasJefferson.CheckedChanged += new EventHandler(ThomasJefferson__Checked);

            // MouseOver

            pictureBox1.MouseEnter += new EventHandler(Picture__MouseHover);
            pictureBox1.MouseLeave += new EventHandler(Picture__MouseLeave);

            toolTip1.SetToolTip(webBrowser1, "Professor Schuh for President!");

        }

        private void Picture__MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
            pictureBox1.Size = new Size(pictureBox1.Width * 2, pictureBox1.Height * 2);
        }
        private void Picture__MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(pictureBox1.Width / 2, pictureBox1.Height / 2);
        }
        // filter all
        private void FilterAll__Checked(object sender, EventArgs e)
        {

            foreach(RadioButton r in radios)
            {
                r.Show();
            }

        }
        // filter democrat
        private void FilterDemocrat__Checked(object sender, EventArgs e)
        {
            foreach (RadioButton r in radios)
            {
                if(r.Tag.ToString() == "Democrat")
                {
                    r.Show();
                }
                else
                {
                    r.Hide();
                }
            }

        }
        // filter republican
        private void FilterRepublican__Checked(object sender, EventArgs e)
        {
            foreach (RadioButton r in radios)
            {
                if (r.Tag.ToString() == "Republican")
                {
                    r.Show();
                }
                else
                {
                    r.Hide();
                }
            }
        }
        // filter rep-dem
        private void FilterDemocratRepublican__Checked(object sender, EventArgs e)
        {
            foreach (RadioButton r in radios)
            {
                if (r.Tag.ToString() == "DemocratRepublican")
                {
                    r.Show();
                }
                else
                {
                    r.Hide();
                }
            }
        }
        // filter federalist
        private void FilterFederalist__Checked(object sender, EventArgs e)
        {
            foreach (RadioButton r in radios)
            {
                if (r.Tag.ToString() == "Federalist")
                {
                    r.Show();
                }
                else
                {
                    r.Hide();
                }
            }
        }
        

        //
        // President Event handlers
        //
        private void RonaldReagan__Checked(object sender, EventArgs e)
        {
            ChangeImage(RonaldReagan.Name);
            ChangeWebPage("Ronald_Reagan");
        }
        private void DwightDEisenhower__Checked(object sender, EventArgs e)
        {
            ChangeImage(DwightDEisenhower.Name);
            ChangeWebPage("Dwight_D_Eisenhower");
        }
        private void MartinVanBuren__Checked(object sender, EventArgs e)
        {
            ChangeImage(MartinVanBuren.Name);
            ChangeWebPage("Martin_Van_Buren");
        }
        private void GeorgeWashington__Checked(object sender, EventArgs e)
        {
            ChangeImage(GeorgeWashington.Name);
            ChangeWebPage("George_Washington");
        }
        private void JohnAdams__Checked(object sender, EventArgs e)
        {
            ChangeImage(BenjaminHarrison.Name);
            ChangeWebPage("Benjamin_Harrison");
        }
        private void TheodoreRoosevelt__Checked(object sender, EventArgs e)
        {
            ChangeImage(TheodoreRoosevelt.Name);
            ChangeWebPage("Theodore_Roosevelt");

        }
        private void BenjaminHarrison__Checked(object sender, EventArgs e)
        {
            ChangeImage(BenjaminHarrison.Name);
            ChangeWebPage("Benjamin_Harrison");

        }
        private void ThomasJefferson__Checked(object sender, EventArgs e)
        {
            ChangeImage(ThomasJefferson.Name);
            ChangeWebPage("Thomas_Jefferson");

        }

        private void WilliamMcKinley__Checked(object sender, EventArgs e)
        {
            ChangeImage(WilliamMcKinley.Name);
            ChangeWebPage("William_McKinley");

        }
        private void FranklinDRoosevelt__Checked(object sender, EventArgs e)
        {
            ChangeImage(FranklinDRoosevelt.Name);
            ChangeWebPage("Franklin_D_Roosevelt");

        }
        private void WilliamJClinton__Checked(object sender, EventArgs e)
        {
            ChangeImage(WilliamJClinton.Name);
            ChangeWebPage("William_J_Clinton");

        }
        private void JamesBuchanan__Checked(object sender, EventArgs e)
        {
            ChangeImage(JamesBuchanan.Name);
            ChangeWebPage("James_Buchanan");

        }
        private void FranklinPierce__Checked(object sender, EventArgs e)
        {
            ChangeImage(FranklinPierce.Name);
            ChangeWebPage("Franklin_Pierce");


        }
        private void GeorgeWBush__Checked(object sender, EventArgs e)
        {
            ChangeImage(GeorgeWBush.Name);
            ChangeWebPage("George_W_Bush");


        }
        private void BarackObama__Checked(object sender, EventArgs e)
        {
            ChangeImage(BarackObama.Name);
            ChangeWebPage("Barack_Obama");


        }
        private void JohnFKennedy__Checked(object sender, EventArgs e)
        {
            ChangeImage(JohnFKennedy.Name);
            ChangeWebPage("John_F_Kennedy");


        }

        // Changes shown image
        private void ChangeImage(string presidentName)
        {
            pictureBox1.ImageLocation = "https://people.rit.edu/dxsigm/" + presidentName;
        }

        // Changes shown web page
        private void ChangeWebPage(string name)
        { 
            string url = "https://en.m.wikepedia.org/wiki/" + name;
            groupBox1.Text = url;
            webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/" + name);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // Text Box changes
        private void TextBox__TextChanged(object sender, EventArgs e)
        {
            if (!timerStarted)
            {
                timerStarted = true;
                timer1.Enabled = true;
                timer1.Interval = 1000;
                timer1.Tick += new EventHandler(Timer__Tick);
                timer1.Start();
            }

            int correct = 0;
            foreach (TextBox input in inputs)
            {
                for (int i = 0; i < inputs.Length; i++)
                {
                    if (input.Text == answers[i].ToString())
                    {
                        correct++;
                        //wrongImages[i].Visible = true;
                    }

                    // tried to get the red check marks funcitonal... for the sake of time and thoroughness I had to forgo it t-t

                    /*else if (input.Text != "0" && input.Text != answers[i].ToString())
                    {
                        wrongImages[i].Visible = true;
                    }*/
                }
                if (correct == inputs.Length)
                {
                    button1.Enabled = true;
                }
            }

        }

        // Timer
        private void Timer__Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
            {
                progressBar1.Value--;
            }
            else
            {
                timer1.Stop();
                foreach (TextBox input in inputs)
                {
                    input.Text = "0";
                }

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
