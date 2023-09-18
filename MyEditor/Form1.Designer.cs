namespace MyEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.boldToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.italicsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mSSansSerifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesNewRomanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.underlineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&file";
            this.fileToolStripMenuItem.ToolTipText = "file";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&new";
            this.newToolStripMenuItem.ToolTipText = "new";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&open";
            this.openToolStripMenuItem.ToolTipText = "open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.ToolTipText = "save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.ToolTipText = "exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&edit";
            this.editToolStripMenuItem.ToolTipText = "edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "&copy";
            this.copyToolStripMenuItem.ToolTipText = "copy";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "&cut";
            this.cutToolStripMenuItem.ToolTipText = "cut";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "&paste";
            this.pasteToolStripMenuItem.ToolTipText = "paste";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.toolStrip);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.richTextBox);
            this.splitContainer.Size = new System.Drawing.Size(800, 426);
            this.splitContainer.SplitterDistance = 25;
            this.splitContainer.TabIndex = 1;
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(800, 397);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldToolStripButton,
            this.italicsToolStripButton,
            this.underlineToolStripButton,
            this.colorToolStripButton,
            this.toolStripButton4});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // boldToolStripButton
            // 
            this.boldToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("boldToolStripButton.Image")));
            this.boldToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldToolStripButton.Name = "boldToolStripButton";
            this.boldToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.boldToolStripButton.Text = "toolStripButton1";
            this.boldToolStripButton.ToolTipText = "bold";
            // 
            // italicsToolStripButton
            // 
            this.italicsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("italicsToolStripButton.Image")));
            this.italicsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicsToolStripButton.Name = "italicsToolStripButton";
            this.italicsToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.italicsToolStripButton.Text = "toolStripButton2";
            this.italicsToolStripButton.ToolTipText = "italics";
            // 
            // colorToolStripButton
            // 
            this.colorToolStripButton.BackColor = System.Drawing.Color.Black;
            this.colorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorToolStripButton.Name = "colorToolStripButton";
            this.colorToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.colorToolStripButton.Text = "toolStripButton3";
            this.colorToolStripButton.ToolTipText = "color";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSSansSerifToolStripMenuItem,
            this.timesNewRomanToolStripMenuItem});
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 22);
            this.toolStripButton4.Text = "fontToolStripButton";
            this.toolStripButton4.ToolTipText = "font";
            // 
            // mSSansSerifToolStripMenuItem
            // 
            this.mSSansSerifToolStripMenuItem.Name = "mSSansSerifToolStripMenuItem";
            this.mSSansSerifToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mSSansSerifToolStripMenuItem.Text = "MS Sans Serif";
            this.mSSansSerifToolStripMenuItem.ToolTipText = "MS Sans Serif";
            // 
            // timesNewRomanToolStripMenuItem
            // 
            this.timesNewRomanToolStripMenuItem.Name = "timesNewRomanToolStripMenuItem";
            this.timesNewRomanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.timesNewRomanToolStripMenuItem.Text = "Times New Roman";
            this.timesNewRomanToolStripMenuItem.ToolTipText = "Times New Roman";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "rtf";
            this.openFileDialog.Filter = "Rich Text Files|*.rtf|Plain Text Files|*.txt|All Files|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "rtf";
            this.saveFileDialog.Filter = "Rich Text Files|*.rtf|Plain Text Files|*.txt|All Files|*.*";
            // 
            // underlineToolStripButton
            // 
            this.underlineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("underlineToolStripButton.Image")));
            this.underlineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineToolStripButton.Name = "underlineToolStripButton";
            this.underlineToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.underlineToolStripButton.Text = "underline";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton boldToolStripButton;
        private System.Windows.Forms.ToolStripButton italicsToolStripButton;
        private System.Windows.Forms.ToolStripButton colorToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem mSSansSerifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timesNewRomanToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripButton underlineToolStripButton;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

