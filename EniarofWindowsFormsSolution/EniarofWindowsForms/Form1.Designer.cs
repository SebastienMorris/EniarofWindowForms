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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ArucoLabel2 = new Label();
            btnExit = new Button();
            btnStopGrab = new Button();
            btnGrab = new Button();
            ArucoLabel1 = new Label();
            ScoreLabel1 = new Label();
            pictureBox1 = new PictureBox();
            ScoreLabel2 = new Label();
            pictureBox2 = new PictureBox();
            Restart = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ArucoLabel2
            // 
            ArucoLabel2.AutoSize = true;
            ArucoLabel2.Location = new Point(1023, 370);
            ArucoLabel2.Margin = new Padding(2, 0, 2, 0);
            ArucoLabel2.Name = "ArucoLabel2";
            ArucoLabel2.Size = new Size(35, 15);
            ArucoLabel2.TabIndex = 6;
            ArucoLabel2.Text = "Code";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F);
            btnExit.Location = new Point(960, 390);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(144, 38);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnMenu_Click;
            // 
            // btnStopGrab
            // 
            btnStopGrab.Font = new Font("Segoe UI", 12F);
            btnStopGrab.Location = new Point(536, 390);
            btnStopGrab.Margin = new Padding(2);
            btnStopGrab.Name = "btnStopGrab";
            btnStopGrab.Size = new Size(211, 38);
            btnStopGrab.TabIndex = 3;
            btnStopGrab.Text = "Stop Grab";
            btnStopGrab.UseVisualStyleBackColor = true;
            btnStopGrab.Click += btnStopGrab_Click;
            // 
            // btnGrab
            // 
            btnGrab.Font = new Font("Segoe UI", 12F);
            btnGrab.Location = new Point(263, 390);
            btnGrab.Margin = new Padding(2);
            btnGrab.Name = "btnGrab";
            btnGrab.Size = new Size(211, 38);
            btnGrab.TabIndex = 1;
            btnGrab.Text = "Grab";
            btnGrab.UseVisualStyleBackColor = true;
            btnGrab.Click += btnGrab_Click;
            // 
            // ArucoLabel1
            // 
            ArucoLabel1.AutoSize = true;
            ArucoLabel1.Location = new Point(58, 370);
            ArucoLabel1.Margin = new Padding(2, 0, 2, 0);
            ArucoLabel1.Name = "ArucoLabel1";
            ArucoLabel1.Size = new Size(35, 15);
            ArucoLabel1.TabIndex = 7;
            ArucoLabel1.Text = "Code";
            // 
            // ScoreLabel1
            // 
            ScoreLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ScoreLabel1.AutoSize = true;
            ScoreLabel1.Font = new Font("Segoe UI", 15F);
            ScoreLabel1.Location = new Point(280, 4);
            ScoreLabel1.Margin = new Padding(2, 0, 2, 0);
            ScoreLabel1.Name = "ScoreLabel1";
            ScoreLabel1.Size = new Size(23, 28);
            ScoreLabel1.TabIndex = 8;
            ScoreLabel1.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(58, 30);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(466, 338);
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
            ScoreLabel2.Location = new Point(823, 4);
            ScoreLabel2.Margin = new Padding(2, 0, 2, 0);
            ScoreLabel2.Name = "ScoreLabel2";
            ScoreLabel2.Size = new Size(23, 28);
            ScoreLabel2.TabIndex = 9;
            ScoreLabel2.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Menu;
            pictureBox2.Location = new Point(596, 30);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(466, 338);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Restart
            // 
            Restart.Font = new Font("Segoe UI", 12F);
            Restart.Location = new Point(941, 472);
            Restart.Margin = new Padding(2);
            Restart.Name = "Restart";
            Restart.Size = new Size(144, 38);
            Restart.TabIndex = 10;
            Restart.Text = "Restart";
            Restart.UseVisualStyleBackColor = true;
            Restart.Click += btnRestart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1467, 623);
            Controls.Add(Restart);
            Controls.Add(ScoreLabel2);
            Controls.Add(ScoreLabel1);
            Controls.Add(ArucoLabel1);
            Controls.Add(ArucoLabel2);
            Controls.Add(pictureBox2);
            Controls.Add(btnStopGrab);
            Controls.Add(btnExit);
            Controls.Add(btnGrab);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Margin = new Padding(2);
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
        private Button Restart;
    }
}
