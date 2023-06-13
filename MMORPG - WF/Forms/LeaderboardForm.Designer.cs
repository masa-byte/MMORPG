namespace MMORPG.Forms
{
    partial class LeaderboardForm
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
            label1 = new Label();
            soloBtn = new Button();
            teamBtn = new Button();
            backBtn = new Button();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 239);
            label1.Name = "label1";
            label1.Size = new Size(516, 55);
            label1.TabIndex = 1;
            label1.Text = "CURRENT RANKINGS";
            // 
            // soloBtn
            // 
            soloBtn.BackColor = Color.White;
            soloBtn.FlatStyle = FlatStyle.Popup;
            soloBtn.Font = new Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point);
            soloBtn.Location = new Point(148, 293);
            soloBtn.Margin = new Padding(3, 2, 3, 2);
            soloBtn.Name = "soloBtn";
            soloBtn.Size = new Size(265, 48);
            soloBtn.TabIndex = 2;
            soloBtn.Text = "SOLO";
            soloBtn.UseVisualStyleBackColor = false;
            soloBtn.Click += soloBtn_Click;
            // 
            // teamBtn
            // 
            teamBtn.BackColor = Color.FromArgb(153, 91, 216);
            teamBtn.FlatStyle = FlatStyle.Popup;
            teamBtn.Font = new Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point);
            teamBtn.Location = new Point(148, 357);
            teamBtn.Margin = new Padding(3, 2, 3, 2);
            teamBtn.Name = "teamBtn";
            teamBtn.Size = new Size(265, 48);
            teamBtn.TabIndex = 3;
            teamBtn.Text = "TEAM";
            teamBtn.UseVisualStyleBackColor = false;
            teamBtn.Click += teamBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(68, 34, 94);
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.Font = new Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(148, 420);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(265, 48);
            backBtn.TabIndex = 4;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.white_star;
            pictureBox2.Location = new Point(-24, 303);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.white_star;
            pictureBox3.Location = new Point(394, 420);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(126, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.white_star;
            pictureBox4.Location = new Point(453, 358);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(109, 46);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // LeaderboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(555, 496);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(backBtn);
            Controls.Add(teamBtn);
            Controls.Add(soloBtn);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(571, 535);
            MinimizeBox = false;
            MinimumSize = new Size(571, 535);
            Name = "LeaderboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Leaderboard";
            FormClosed += LeaderboardForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button soloBtn;
        private Button teamBtn;
        private Button backBtn;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}