namespace BinaryThresholdDemo
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
            this.sourceFramePictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryFramePictureBox = new System.Windows.Forms.PictureBox();
            this.binaryThresholdTrackbar = new System.Windows.Forms.TrackBar();
            this.grayscalePictureBox = new System.Windows.Forms.PictureBox();
            this.thresholdLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sourceFramePictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binaryFramePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryThresholdTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscalePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceFramePictureBox
            // 
            this.sourceFramePictureBox.Location = new System.Drawing.Point(12, 31);
            this.sourceFramePictureBox.Name = "sourceFramePictureBox";
            this.sourceFramePictureBox.Size = new System.Drawing.Size(338, 297);
            this.sourceFramePictureBox.TabIndex = 0;
            this.sourceFramePictureBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // binaryFramePictureBox
            // 
            this.binaryFramePictureBox.Location = new System.Drawing.Point(751, 31);
            this.binaryFramePictureBox.Name = "binaryFramePictureBox";
            this.binaryFramePictureBox.Size = new System.Drawing.Size(338, 297);
            this.binaryFramePictureBox.TabIndex = 2;
            this.binaryFramePictureBox.TabStop = false;
            // 
            // binaryThresholdTrackbar
            // 
            this.binaryThresholdTrackbar.Location = new System.Drawing.Point(13, 335);
            this.binaryThresholdTrackbar.Maximum = 255;
            this.binaryThresholdTrackbar.Name = "binaryThresholdTrackbar";
            this.binaryThresholdTrackbar.Size = new System.Drawing.Size(1076, 56);
            this.binaryThresholdTrackbar.TabIndex = 3;
            this.binaryThresholdTrackbar.Scroll += new System.EventHandler(this.binaryThresholdTrackbar_Scroll);
            // 
            // grayscalePictureBox
            // 
            this.grayscalePictureBox.Location = new System.Drawing.Point(383, 32);
            this.grayscalePictureBox.Name = "grayscalePictureBox";
            this.grayscalePictureBox.Size = new System.Drawing.Size(338, 297);
            this.grayscalePictureBox.TabIndex = 5;
            this.grayscalePictureBox.TabStop = false;
            // 
            // thresholdLbl
            // 
            this.thresholdLbl.AutoSize = true;
            this.thresholdLbl.Location = new System.Drawing.Point(13, 373);
            this.thresholdLbl.Name = "thresholdLbl";
            this.thresholdLbl.Size = new System.Drawing.Size(46, 17);
            this.thresholdLbl.TabIndex = 6;
            this.thresholdLbl.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 450);
            this.Controls.Add(this.thresholdLbl);
            this.Controls.Add(this.grayscalePictureBox);
            this.Controls.Add(this.binaryThresholdTrackbar);
            this.Controls.Add(this.binaryFramePictureBox);
            this.Controls.Add(this.sourceFramePictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Binary Threshold Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sourceFramePictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binaryFramePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryThresholdTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscalePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sourceFramePictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox binaryFramePictureBox;
        private System.Windows.Forms.TrackBar binaryThresholdTrackbar;
        private System.Windows.Forms.PictureBox grayscalePictureBox;
        private System.Windows.Forms.Label thresholdLbl;
    }
}

