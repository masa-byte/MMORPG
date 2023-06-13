namespace MMORPG.Forms
{
    partial class GameForm
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
            listViewSolo = new ListView();
            helloLabel = new Label();
            listViewTeam = new ListView();
            label1 = new Label();
            backBtn = new Button();
            comboBoxDifficulty = new ComboBox();
            label2 = new Label();
            playBtn = new Button();
            richTextBoxSolo = new RichTextBox();
            richTextBoxTeam = new RichTextBox();
            listViewCharacter = new ListView();
            listViewTeamChar = new ListView();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            rdbSolo = new RadioButton();
            rdbTeam = new RadioButton();
            pictureBox11 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            SuspendLayout();
            // 
            // listViewSolo
            // 
            listViewSolo.BackColor = Color.FromArgb(213, 184, 242);
            listViewSolo.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listViewSolo.Location = new Point(32, 81);
            listViewSolo.Margin = new Padding(3, 4, 3, 4);
            listViewSolo.Name = "listViewSolo";
            listViewSolo.Size = new Size(371, 267);
            listViewSolo.TabIndex = 2;
            listViewSolo.UseCompatibleStateImageBehavior = false;
            listViewSolo.SelectedIndexChanged += listViewSolo_SelectedIndexChanged;
            // 
            // helloLabel
            // 
            helloLabel.AutoSize = true;
            helloLabel.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            helloLabel.ForeColor = Color.Snow;
            helloLabel.Location = new Point(81, 4);
            helloLabel.Name = "helloLabel";
            helloLabel.Size = new Size(293, 69);
            helloLabel.TabIndex = 29;
            helloLabel.Text = "Solo tracks";
            // 
            // listViewTeam
            // 
            listViewTeam.BackColor = Color.FromArgb(213, 184, 242);
            listViewTeam.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listViewTeam.Location = new Point(449, 81);
            listViewTeam.Margin = new Padding(3, 4, 3, 4);
            listViewTeam.Name = "listViewTeam";
            listViewTeam.Size = new Size(382, 267);
            listViewTeam.TabIndex = 30;
            listViewTeam.UseCompatibleStateImageBehavior = false;
            listViewTeam.SelectedIndexChanged += listViewTeam_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(501, 4);
            label1.Name = "label1";
            label1.Size = new Size(328, 69);
            label1.TabIndex = 31;
            label1.Text = "Team tracks";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(153, 91, 216);
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(14, 963);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(163, 55);
            backBtn.TabIndex = 32;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // comboBoxDifficulty
            // 
            comboBoxDifficulty.Font = new Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxDifficulty.FormattingEnabled = true;
            comboBoxDifficulty.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            comboBoxDifficulty.Location = new Point(483, 859);
            comboBoxDifficulty.Margin = new Padding(3, 4, 3, 4);
            comboBoxDifficulty.Name = "comboBoxDifficulty";
            comboBoxDifficulty.Size = new Size(244, 42);
            comboBoxDifficulty.TabIndex = 72;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Goudy Old Style", 32F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(130, 839);
            label2.Name = "label2";
            label2.Size = new Size(377, 63);
            label2.TabIndex = 73;
            label2.Text = "Difficulty level :";
            // 
            // playBtn
            // 
            playBtn.BackColor = Color.FromArgb(195, 157, 224);
            playBtn.FlatStyle = FlatStyle.Popup;
            playBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            playBtn.Location = new Point(720, 963);
            playBtn.Name = "playBtn";
            playBtn.Size = new Size(163, 55);
            playBtn.TabIndex = 74;
            playBtn.Text = "PLAY";
            playBtn.UseVisualStyleBackColor = false;
            playBtn.Click += playBtn_Click;
            // 
            // richTextBoxSolo
            // 
            richTextBoxSolo.BackColor = Color.FromArgb(128, 128, 255);
            richTextBoxSolo.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxSolo.Location = new Point(32, 357);
            richTextBoxSolo.Margin = new Padding(3, 4, 3, 4);
            richTextBoxSolo.Name = "richTextBoxSolo";
            richTextBoxSolo.ReadOnly = true;
            richTextBoxSolo.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxSolo.Size = new Size(371, 128);
            richTextBoxSolo.TabIndex = 75;
            richTextBoxSolo.Text = "";
            // 
            // richTextBoxTeam
            // 
            richTextBoxTeam.BackColor = Color.FromArgb(128, 128, 255);
            richTextBoxTeam.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxTeam.Location = new Point(449, 357);
            richTextBoxTeam.Margin = new Padding(3, 4, 3, 4);
            richTextBoxTeam.Name = "richTextBoxTeam";
            richTextBoxTeam.ReadOnly = true;
            richTextBoxTeam.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxTeam.Size = new Size(382, 128);
            richTextBoxTeam.TabIndex = 76;
            richTextBoxTeam.Text = "";
            // 
            // listViewCharacter
            // 
            listViewCharacter.BackColor = Color.FromArgb(68, 34, 94);
            listViewCharacter.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listViewCharacter.ForeColor = SystemColors.Window;
            listViewCharacter.Location = new Point(32, 579);
            listViewCharacter.Margin = new Padding(3, 4, 3, 4);
            listViewCharacter.Name = "listViewCharacter";
            listViewCharacter.Size = new Size(371, 207);
            listViewCharacter.TabIndex = 77;
            listViewCharacter.UseCompatibleStateImageBehavior = false;
            // 
            // listViewTeamChar
            // 
            listViewTeamChar.BackColor = Color.FromArgb(68, 34, 94);
            listViewTeamChar.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listViewTeamChar.ForeColor = SystemColors.Window;
            listViewTeamChar.Location = new Point(449, 579);
            listViewTeamChar.Margin = new Padding(3, 4, 3, 4);
            listViewTeamChar.Name = "listViewTeamChar";
            listViewTeamChar.Size = new Size(382, 207);
            listViewTeamChar.TabIndex = 78;
            listViewTeamChar.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Goudy Old Style", 32F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(63, 507);
            label3.Name = "label3";
            label3.Size = new Size(365, 63);
            label3.TabIndex = 79;
            label3.Text = "Characters info";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Goudy Old Style", 32F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(425, 507);
            label4.Name = "label4";
            label4.Size = new Size(490, 63);
            label4.TabIndex = 80;
            label4.Text = "Team characters info";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.white_star;
            pictureBox1.Location = new Point(823, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 81;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.white_star;
            pictureBox2.Location = new Point(854, 81);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 82;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.white_star;
            pictureBox3.Location = new Point(358, -4);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(66, 51);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 83;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.white_star;
            pictureBox4.Location = new Point(411, 29);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(38, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 84;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.white_star;
            pictureBox5.Location = new Point(-6, 868);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(94, 77);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 85;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.white_star;
            pictureBox6.Location = new Point(50, 827);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(38, 33);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 86;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.white_star;
            pictureBox7.Location = new Point(805, 881);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(79, 64);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 87;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.white_star;
            pictureBox8.Location = new Point(847, 827);
            pictureBox8.Margin = new Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(55, 43);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 88;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.white_star;
            pictureBox9.Location = new Point(653, 969);
            pictureBox9.Margin = new Padding(3, 4, 3, 4);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(61, 47);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 89;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.white_star;
            pictureBox10.Location = new Point(-6, -4);
            pictureBox10.Margin = new Padding(3, 4, 3, 4);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(43, 56);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 90;
            pictureBox10.TabStop = false;
            // 
            // rdbSolo
            // 
            rdbSolo.AutoSize = true;
            rdbSolo.Font = new Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point);
            rdbSolo.ForeColor = Color.Snow;
            rdbSolo.Location = new Point(216, 945);
            rdbSolo.Margin = new Padding(3, 4, 3, 4);
            rdbSolo.Name = "rdbSolo";
            rdbSolo.Size = new Size(167, 38);
            rdbSolo.TabIndex = 91;
            rdbSolo.TabStop = true;
            rdbSolo.Text = "Solo Track";
            rdbSolo.UseVisualStyleBackColor = true;
            // 
            // rdbTeam
            // 
            rdbTeam.AutoSize = true;
            rdbTeam.Font = new Font("Goudy Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point);
            rdbTeam.ForeColor = Color.Snow;
            rdbTeam.Location = new Point(425, 945);
            rdbTeam.Margin = new Padding(3, 4, 3, 4);
            rdbTeam.Name = "rdbTeam";
            rdbTeam.Size = new Size(184, 38);
            rdbTeam.TabIndex = 92;
            rdbTeam.TabStop = true;
            rdbTeam.Text = "Team Track";
            rdbTeam.UseVisualStyleBackColor = true;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.white_star;
            pictureBox11.Location = new Point(854, 767);
            pictureBox11.Margin = new Padding(3, 4, 3, 4);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(33, 43);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 93;
            pictureBox11.TabStop = false;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(890, 1021);
            Controls.Add(pictureBox11);
            Controls.Add(rdbTeam);
            Controls.Add(rdbSolo);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listViewTeamChar);
            Controls.Add(listViewCharacter);
            Controls.Add(richTextBoxTeam);
            Controls.Add(richTextBoxSolo);
            Controls.Add(playBtn);
            Controls.Add(label2);
            Controls.Add(comboBoxDifficulty);
            Controls.Add(backBtn);
            Controls.Add(label1);
            Controls.Add(listViewTeam);
            Controls.Add(helloLabel);
            Controls.Add(listViewSolo);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(908, 1068);
            MinimizeBox = false;
            MinimumSize = new Size(908, 1018);
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Form";
            FormClosed += GameForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewSolo;
        private Label helloLabel;
        private ListView listViewTeam;
        private Label label1;
        private Button backBtn;
        private ComboBox comboBoxDifficulty;
        private Label label2;
        private Button playBtn;
        private RichTextBox richTextBoxSolo;
        private RichTextBox richTextBoxTeam;
        private ListView listViewCharacter;
        private ListView listViewTeamChar;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private RadioButton rdbSolo;
        private RadioButton rdbTeam;
        private PictureBox pictureBox11;
    }
}