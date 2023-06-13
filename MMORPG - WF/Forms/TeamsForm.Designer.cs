namespace MMORPG.Forms
{
    partial class TeamsForm
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
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            labelTeams = new Label();
            buttonJoinTeam = new Button();
            backBtn = new Button();
            buttonOrganizeMatch = new Button();
            buttonCreateTeam = new Button();
            pictureBox4 = new PictureBox();
            richTextBoxTeamInfo = new RichTextBox();
            labelCurrentTeamInfo = new Label();
            buttonLeaveCurrentTeam = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.white_star;
            pictureBox5.Location = new Point(80, 359);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(54, 41);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 39;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.white_star;
            pictureBox3.Location = new Point(83, 312);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 38;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.white_star;
            pictureBox2.Location = new Point(47, 61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.white_star;
            pictureBox1.Location = new Point(12, -12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // labelTeams
            // 
            labelTeams.AutoSize = true;
            labelTeams.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelTeams.ForeColor = Color.Snow;
            labelTeams.Location = new Point(140, 9);
            labelTeams.Name = "labelTeams";
            labelTeams.Size = new Size(261, 55);
            labelTeams.TabIndex = 35;
            labelTeams.Text = "Teams form";
            // 
            // buttonJoinTeam
            // 
            buttonJoinTeam.BackColor = Color.FromArgb(195, 157, 224);
            buttonJoinTeam.FlatStyle = FlatStyle.Popup;
            buttonJoinTeam.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonJoinTeam.Location = new Point(297, 134);
            buttonJoinTeam.Margin = new Padding(3, 2, 3, 2);
            buttonJoinTeam.Name = "buttonJoinTeam";
            buttonJoinTeam.Size = new Size(261, 46);
            buttonJoinTeam.TabIndex = 33;
            buttonJoinTeam.Text = "JOIN TEAM";
            buttonJoinTeam.UseVisualStyleBackColor = false;
            buttonJoinTeam.Click += buttonJoinTeam_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(47, 12, 74);
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(297, 354);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(261, 46);
            backBtn.TabIndex = 32;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // buttonOrganizeMatch
            // 
            buttonOrganizeMatch.BackColor = Color.FromArgb(153, 91, 216);
            buttonOrganizeMatch.FlatStyle = FlatStyle.Popup;
            buttonOrganizeMatch.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOrganizeMatch.Location = new Point(297, 205);
            buttonOrganizeMatch.Margin = new Padding(3, 2, 3, 2);
            buttonOrganizeMatch.Name = "buttonOrganizeMatch";
            buttonOrganizeMatch.Size = new Size(261, 46);
            buttonOrganizeMatch.TabIndex = 30;
            buttonOrganizeMatch.Text = "ORGANIZE A MATCH";
            buttonOrganizeMatch.UseVisualStyleBackColor = false;
            buttonOrganizeMatch.Click += buttonOrganizeMatch_Click;
            // 
            // buttonCreateTeam
            // 
            buttonCreateTeam.BackColor = Color.White;
            buttonCreateTeam.FlatStyle = FlatStyle.Popup;
            buttonCreateTeam.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCreateTeam.Location = new Point(297, 66);
            buttonCreateTeam.Margin = new Padding(3, 2, 3, 2);
            buttonCreateTeam.Name = "buttonCreateTeam";
            buttonCreateTeam.Size = new Size(261, 46);
            buttonCreateTeam.TabIndex = 29;
            buttonCreateTeam.Text = "CREATE NEW TEAM";
            buttonCreateTeam.UseVisualStyleBackColor = false;
            buttonCreateTeam.Click += buttonCreateTeam_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.white_star;
            pictureBox4.Location = new Point(12, 339);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(69, 41);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 34;
            pictureBox4.TabStop = false;
            // 
            // richTextBoxTeamInfo
            // 
            richTextBoxTeamInfo.BackColor = Color.FromArgb(128, 128, 255);
            richTextBoxTeamInfo.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxTeamInfo.Location = new Point(12, 124);
            richTextBoxTeamInfo.Name = "richTextBoxTeamInfo";
            richTextBoxTeamInfo.ReadOnly = true;
            richTextBoxTeamInfo.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxTeamInfo.Size = new Size(269, 136);
            richTextBoxTeamInfo.TabIndex = 40;
            richTextBoxTeamInfo.Text = "";
            // 
            // labelCurrentTeamInfo
            // 
            labelCurrentTeamInfo.AutoSize = true;
            labelCurrentTeamInfo.Font = new Font("Goudy Old Style", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelCurrentTeamInfo.ForeColor = Color.Snow;
            labelCurrentTeamInfo.Location = new Point(59, 263);
            labelCurrentTeamInfo.Name = "labelCurrentTeamInfo";
            labelCurrentTeamInfo.Size = new Size(174, 27);
            labelCurrentTeamInfo.TabIndex = 41;
            labelCurrentTeamInfo.Text = "Current team info";
            // 
            // buttonLeaveCurrentTeam
            // 
            buttonLeaveCurrentTeam.BackColor = Color.FromArgb(68, 34, 94);
            buttonLeaveCurrentTeam.FlatStyle = FlatStyle.Popup;
            buttonLeaveCurrentTeam.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLeaveCurrentTeam.Location = new Point(297, 274);
            buttonLeaveCurrentTeam.Margin = new Padding(3, 2, 3, 2);
            buttonLeaveCurrentTeam.Name = "buttonLeaveCurrentTeam";
            buttonLeaveCurrentTeam.Size = new Size(261, 46);
            buttonLeaveCurrentTeam.TabIndex = 42;
            buttonLeaveCurrentTeam.Text = "LEAVE TEAM";
            buttonLeaveCurrentTeam.UseVisualStyleBackColor = false;
            buttonLeaveCurrentTeam.Click += buttonLeaveCurrentTeam_Click;
            // 
            // TeamsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(570, 415);
            Controls.Add(buttonLeaveCurrentTeam);
            Controls.Add(labelCurrentTeamInfo);
            Controls.Add(richTextBoxTeamInfo);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(labelTeams);
            Controls.Add(buttonJoinTeam);
            Controls.Add(backBtn);
            Controls.Add(buttonOrganizeMatch);
            Controls.Add(buttonCreateTeam);
            Controls.Add(pictureBox4);
            MaximizeBox = false;
            MaximumSize = new Size(586, 454);
            MinimizeBox = false;
            MinimumSize = new Size(586, 454);
            Name = "TeamsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teams Form";
            FormClosed += TeamsForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label labelTeams;
        private Button buttonJoinTeam;
        private Button backBtn;
        private Button buttonOrganizeMatch;
        private Button buttonCreateTeam;
        private PictureBox pictureBox4;
        private RichTextBox richTextBoxTeamInfo;
        private Label labelCurrentTeamInfo;
        private Button buttonLeaveCurrentTeam;
    }
}