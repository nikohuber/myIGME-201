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
// Exam 3

namespace BestGuiEver
{
    // Best Gui Ever :)
    public partial class Form3 : Form
    {
        // Form 3 (end)
        public Form3(bool win)
        {
            InitializeComponent();

            if (win)
            {
                label1.Text = ":)";
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
