﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GifFinder
{
    public partial class SearchForm : Form
    {

        public string response;
        public string searchTerm;
        public int maxItems;

        public SearchForm()
        {
            InitializeComponent();

            this.maxItemTextBox.KeyPress += new KeyPressEventHandler(MaxItemTextBox__KeyPress);
            this.okButton.Click += new EventHandler(OKButton__Click);
            this.cancelButton.Click += new EventHandler(CancelButton__Click);

        }

        private void MaxItemTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if(Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        private void OKButton__Click(object sender, EventArgs e)
        {
            this.response = "OK";

            this.searchTerm = searchTermTextBox.Text;
            maxItems = Convert.ToInt32(maxItemTextBox.Text);
            this.Hide();
        }

        private void CancelButton__Click(object sender, EventArgs e)
        {
            this.response = "Cancel";
            this.Hide();
        }
    }
}
