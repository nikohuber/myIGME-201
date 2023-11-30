namespace GuessingGame
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.guessLabel = new System.Windows.Forms.Label();
            this.guessGroupBox = new System.Windows.Forms.GroupBox();
            this.guessGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 191);
            this.progressBar1.Maximum = 50;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(352, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 50;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guess:";
            // 
            // guessTextBox
            // 
            this.guessTextBox.Location = new System.Drawing.Point(174, 49);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(58, 20);
            this.guessTextBox.TabIndex = 2;
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(146, 86);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(75, 23);
            this.guessButton.TabIndex = 3;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.ForeColor = System.Drawing.Color.Red;
            this.guessLabel.Location = new System.Drawing.Point(143, 133);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(0, 13);
            this.guessLabel.TabIndex = 4;
            this.guessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guessGroupBox
            // 
            this.guessGroupBox.Controls.Add(this.guessTextBox);
            this.guessGroupBox.Controls.Add(this.guessLabel);
            this.guessGroupBox.Controls.Add(this.label1);
            this.guessGroupBox.Controls.Add(this.progressBar1);
            this.guessGroupBox.Controls.Add(this.guessButton);
            this.guessGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guessGroupBox.Location = new System.Drawing.Point(0, 0);
            this.guessGroupBox.Name = "guessGroupBox";
            this.guessGroupBox.Size = new System.Drawing.Size(406, 226);
            this.guessGroupBox.TabIndex = 5;
            this.guessGroupBox.TabStop = false;
            this.guessGroupBox.Enter += new System.EventHandler(this.guessGroupBox_Enter);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 226);
            this.Controls.Add(this.guessGroupBox);
            this.Name = "Form2";
            this.Text = "Guesses";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.guessGroupBox.ResumeLayout(false);
            this.guessGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.GroupBox guessGroupBox;
    }
}