namespace EniarofWindowsForms
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
            ArucoLabel2 = new Label();
            btnExit = new Button();
            btnStopGrab = new Button();
            btnGrab = new Button();
            ArucoLabel1 = new Label();
            ScoreLabel1 = new Label();
            pictureBox1 = new PictureBox();
            ScoreLabel2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ArucoLabel2
            // 
            ArucoLabel2.AutoSize = true;
            ArucoLabel2.Location = new Point(1462, 616);
            ArucoLabel2.Name = "ArucoLabel2";
            ArucoLabel2.Size = new Size(54, 25);
            ArucoLabel2.TabIndex = 6;
            ArucoLabel2.Text = "Code";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F);
            btnExit.Location = new Point(1372, 650);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(206, 64);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnStopGrab
            // 
            btnStopGrab.Font = new Font("Segoe UI", 12F);
            btnStopGrab.Location = new Point(765, 650);
            btnStopGrab.Name = "btnStopGrab";
            btnStopGrab.Size = new Size(301, 64);
            btnStopGrab.TabIndex = 3;
            btnStopGrab.Text = "Stop Grab";
            btnStopGrab.UseVisualStyleBackColor = true;
            btnStopGrab.Click += btnStopGrab_Click;
            // 
            // btnGrab
            // 
            btnGrab.Font = new Font("Segoe UI", 12F);
            btnGrab.Location = new Point(376, 650);
            btnGrab.Name = "btnGrab";
            btnGrab.Size = new Size(301, 64);
            btnGrab.TabIndex = 1;
            btnGrab.Text = "Grab";
            btnGrab.UseVisualStyleBackColor = true;
            btnGrab.Click += btnGrab_Click;
            // 
            // ArucoLabel1
            // 
            ArucoLabel1.AutoSize = true;
            ArucoLabel1.Location = new Point(83, 616);
            ArucoLabel1.Name = "ArucoLabel1";
            ArucoLabel1.Size = new Size(54, 25);
            ArucoLabel1.TabIndex = 7;
            ArucoLabel1.Text = "Code";
            // 
            // ScoreLabel1
            // 
            ScoreLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ScoreLabel1.AutoSize = true;
            ScoreLabel1.Font = new Font("Segoe UI", 15F);
            ScoreLabel1.Location = new Point(400, 6);
            ScoreLabel1.Name = "ScoreLabel1";
            ScoreLabel1.Size = new Size(34, 41);
            ScoreLabel1.TabIndex = 8;
            ScoreLabel1.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(83, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(665, 563);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ScoreLabel2
            // 
            ScoreLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ScoreLabel2.AutoSize = true;
            ScoreLabel2.Font = new Font("Segoe UI", 15F);
            ScoreLabel2.Location = new Point(1176, 6);
            ScoreLabel2.Name = "ScoreLabel2";
            ScoreLabel2.Size = new Size(34, 41);
            ScoreLabel2.TabIndex = 9;
            ScoreLabel2.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Menu;
            pictureBox2.Location = new Point(851, 50);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(665, 563);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1024);
            Controls.Add(ScoreLabel2);
            Controls.Add(ScoreLabel1);
            Controls.Add(ArucoLabel1);
            Controls.Add(ArucoLabel2);
            Controls.Add(pictureBox2);
            Controls.Add(btnStopGrab);
            Controls.Add(btnExit);
            Controls.Add(btnGrab);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ArucoLabel2;
        private Button btnExit;
        private Button btnStopGrab;
        private Button btnGrab;
        private Label ArucoLabel1;
        private Label ScoreLabel1;
        private PictureBox pictureBox1;
        private Label ScoreLabel2;
        private PictureBox pictureBox2;
    }
}
