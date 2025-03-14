namespace GoldenRush
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            StartBtn = new Button();
            Hourse1 = new PictureBox();
            Hourse2 = new PictureBox();
            Hourse3 = new PictureBox();
            checkedListBox1 = new CheckedListBox();
            StopBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Hourse1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Hourse2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Hourse3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2025_03_14_011155;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(768, 336);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // StartBtn
            // 
            StartBtn.Location = new Point(345, 354);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(66, 58);
            StartBtn.TabIndex = 1;
            StartBtn.Text = "Start";
            StartBtn.UseVisualStyleBackColor = true;
            StartBtn.Click += StartBtn_Click;
            // 
            // Hourse1
            // 
            Hourse1.BackColor = Color.Olive;
            Hourse1.Image = (Image)resources.GetObject("Hourse1.Image");
            Hourse1.Location = new Point(23, 59);
            Hourse1.Name = "Hourse1";
            Hourse1.Size = new Size(65, 48);
            Hourse1.TabIndex = 3;
            Hourse1.TabStop = false;
            // 
            // Hourse2
            // 
            Hourse2.BackColor = Color.Olive;
            Hourse2.Image = (Image)resources.GetObject("Hourse2.Image");
            Hourse2.Location = new Point(23, 156);
            Hourse2.Name = "Hourse2";
            Hourse2.Size = new Size(65, 48);
            Hourse2.TabIndex = 3;
            Hourse2.TabStop = false;
            // 
            // Hourse3
            // 
            Hourse3.BackColor = Color.Olive;
            Hourse3.Image = (Image)resources.GetObject("Hourse3.Image");
            Hourse3.Location = new Point(23, 260);
            Hourse3.Name = "Hourse3";
            Hourse3.Size = new Size(65, 48);
            Hourse3.TabIndex = 3;
            Hourse3.TabStop = false;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.Olive;
            checkedListBox1.ForeColor = SystemColors.ActiveCaptionText;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Horse 1", "Horse 2", "Horse 3" });
            checkedListBox1.Location = new Point(216, 354);
            checkedListBox1.MaximumSize = new Size(82, 58);
            checkedListBox1.MinimumSize = new Size(82, 58);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(82, 58);
            checkedListBox1.TabIndex = 4;
            // 
            // StopBtn
            // 
            StopBtn.Location = new Point(345, 354);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(66, 58);
            StopBtn.TabIndex = 5;
            StopBtn.Text = "Stop";
            StopBtn.UseVisualStyleBackColor = true;
            StopBtn.Click += StopBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 0);
            ClientSize = new Size(813, 434);
            Controls.Add(StopBtn);
            Controls.Add(checkedListBox1);
            Controls.Add(Hourse3);
            Controls.Add(Hourse2);
            Controls.Add(Hourse1);
            Controls.Add(StartBtn);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(829, 473);
            MinimumSize = new Size(829, 473);
            Name = "Form1";
            Text = "Golden rush";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Hourse1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Hourse2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Hourse3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Button StartBtn;
        private PictureBox Hourse1;
        private PictureBox Hourse2;
        private PictureBox Hourse3;
        private CheckedListBox checkedListBox1;
        private Button StopBtn;
    }
}
