namespace GuessingGame
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lowNumberTextBox = new System.Windows.Forms.TextBox();
            this.highNumberTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.labelBox = new System.Windows.Forms.GroupBox();
            this.labelBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Range of Values to Guess";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Low Number:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "High Number:";
            // 
            // lowNumberTextBox
            // 
            this.lowNumberTextBox.Location = new System.Drawing.Point(129, 48);
            this.lowNumberTextBox.Name = "lowNumberTextBox";
            this.lowNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.lowNumberTextBox.TabIndex = 3;
            this.lowNumberTextBox.Text = "1";
            // 
            // highNumberTextBox
            // 
            this.highNumberTextBox.Location = new System.Drawing.Point(129, 82);
            this.highNumberTextBox.Name = "highNumberTextBox";
            this.highNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.highNumberTextBox.TabIndex = 4;
            this.highNumberTextBox.Text = "100";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(93, 130);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // labelBox
            // 
            this.labelBox.Controls.Add(this.lowNumberTextBox);
            this.labelBox.Controls.Add(this.label1);
            this.labelBox.Controls.Add(this.startButton);
            this.labelBox.Controls.Add(this.highNumberTextBox);
            this.labelBox.Controls.Add(this.label2);
            this.labelBox.Controls.Add(this.label3);
            this.labelBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBox.Location = new System.Drawing.Point(0, 0);
            this.labelBox.Name = "labelBox";
            this.labelBox.Size = new System.Drawing.Size(272, 186);
            this.labelBox.TabIndex = 6;
            this.labelBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 186);
            this.Controls.Add(this.labelBox);
            this.Name = "Form1";
            this.Text = "Guessing Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.labelBox.ResumeLayout(false);
            this.labelBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lowNumberTextBox;
        private System.Windows.Forms.TextBox highNumberTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox labelBox;
    }
}

