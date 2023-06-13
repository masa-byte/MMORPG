namespace MMORPG
{
    partial class MainPage
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
            pictureBox1 = new PictureBox();
            administratorsBtn = new Button();
            leaderboardBtn = new Button();
            playerBtn = new Button();
            gameName = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.game_background;
            pictureBox1.Location = new Point(10, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(528, 228);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // administratorsBtn
            // 
            administratorsBtn.BackColor = Color.FromArgb(68, 34, 94);
            administratorsBtn.FlatStyle = FlatStyle.Popup;
            administratorsBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            administratorsBtn.Location = new Point(136, 421);
            administratorsBtn.Margin = new Padding(3, 2, 3, 2);
            administratorsBtn.Name = "administratorsBtn";
            administratorsBtn.Size = new Size(278, 46);
            administratorsBtn.TabIndex = 1;
            administratorsBtn.Text = "ADMINISTRATORS";
            administratorsBtn.UseVisualStyleBackColor = false;
            administratorsBtn.Click += administratorsBtn_Click;
            // 
            // leaderboardBtn
            // 
            leaderboardBtn.BackColor = Color.FromArgb(153, 91, 216);
            leaderboardBtn.FlatStyle = FlatStyle.Popup;
            leaderboardBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            leaderboardBtn.Location = new Point(136, 359);
            leaderboardBtn.Margin = new Padding(3, 2, 3, 2);
            leaderboardBtn.Name = "leaderboardBtn";
            leaderboardBtn.Size = new Size(278, 46);
            leaderboardBtn.TabIndex = 2;
            leaderboardBtn.Text = "LEADERBOARD";
            leaderboardBtn.UseVisualStyleBackColor = false;
            leaderboardBtn.Click += leaderboardBtn_Click;
            // 
            // playerBtn
            // 
            playerBtn.BackColor = Color.White;
            playerBtn.FlatStyle = FlatStyle.Popup;
            playerBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            playerBtn.Location = new Point(136, 296);
            playerBtn.Margin = new Padding(3, 2, 3, 2);
            playerBtn.Name = "playerBtn";
            playerBtn.Size = new Size(278, 46);
            playerBtn.TabIndex = 3;
            playerBtn.Text = "PLAYERS";
            playerBtn.UseVisualStyleBackColor = false;
            playerBtn.Click += playerBtn_Click;
            // 
            // gameName
            // 
            gameName.AutoSize = true;
            gameName.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            gameName.ForeColor = Color.Snow;
            gameName.Location = new Point(149, 239);
            gameName.Name = "gameName";
            gameName.Size = new Size(255, 55);
            gameName.TabIndex = 4;
            gameName.Text = "MMO RPG";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.white_star;
            pictureBox2.Location = new Point(-8, 429);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.white_star;
            pictureBox3.Location = new Point(46, 387);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(66, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.white_star;
            pictureBox4.Location = new Point(487, 447);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(66, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(551, 493);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(gameName);
            Controls.Add(playerBtn);
            Controls.Add(leaderboardBtn);
            Controls.Add(administratorsBtn);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(571, 536);
            MinimizeBox = false;
            MinimumSize = new Size(571, 536);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Page";
            FormClosing += MainPage_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button administratorsBtn;
        private Button leaderboardBtn;
        private Button playerBtn;
        private Label gameName;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}