namespace MMORPG.Forms
{
    partial class MainPlayerForm
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
            gameBtn = new Button();
            backBtn = new Button();
            characterBtn = new Button();
            storeBtn = new Button();
            teamsBtn = new Button();
            pictureBox4 = new PictureBox();
            helloLabel = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // gameBtn
            // 
            gameBtn.BackColor = Color.FromArgb(195, 157, 224);
            gameBtn.FlatStyle = FlatStyle.Popup;
            gameBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            gameBtn.Location = new Point(153, 184);
            gameBtn.Margin = new Padding(3, 2, 3, 2);
            gameBtn.Name = "gameBtn";
            gameBtn.Size = new Size(278, 46);
            gameBtn.TabIndex = 19;
            gameBtn.Text = "PLAY GAME";
            gameBtn.UseVisualStyleBackColor = false;
            gameBtn.Click += gameBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(47, 12, 74);
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(153, 382);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(278, 46);
            backBtn.TabIndex = 18;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // characterBtn
            // 
            characterBtn.BackColor = Color.FromArgb(68, 34, 94);
            characterBtn.FlatStyle = FlatStyle.Popup;
            characterBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            characterBtn.Location = new Point(153, 316);
            characterBtn.Margin = new Padding(3, 2, 3, 2);
            characterBtn.Name = "characterBtn";
            characterBtn.Size = new Size(278, 46);
            characterBtn.TabIndex = 17;
            characterBtn.Text = "CHARACTER";
            characterBtn.UseVisualStyleBackColor = false;
            characterBtn.Click += characterBtn_Click;
            // 
            // storeBtn
            // 
            storeBtn.BackColor = Color.FromArgb(153, 91, 216);
            storeBtn.FlatStyle = FlatStyle.Popup;
            storeBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            storeBtn.Location = new Point(153, 251);
            storeBtn.Margin = new Padding(3, 2, 3, 2);
            storeBtn.Name = "storeBtn";
            storeBtn.Size = new Size(278, 46);
            storeBtn.TabIndex = 16;
            storeBtn.Text = "STORE";
            storeBtn.UseVisualStyleBackColor = false;
            storeBtn.Click += storeBtn_Click;
            // 
            // teamsBtn
            // 
            teamsBtn.BackColor = Color.White;
            teamsBtn.FlatStyle = FlatStyle.Popup;
            teamsBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            teamsBtn.Location = new Point(153, 116);
            teamsBtn.Margin = new Padding(3, 2, 3, 2);
            teamsBtn.Name = "teamsBtn";
            teamsBtn.Size = new Size(278, 46);
            teamsBtn.TabIndex = 15;
            teamsBtn.Text = "TEAMS";
            teamsBtn.UseVisualStyleBackColor = false;
            teamsBtn.Click += teamsBtn_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.white_star;
            pictureBox4.Location = new Point(4, 411);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(69, 41);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // helloLabel
            // 
            helloLabel.AutoSize = true;
            helloLabel.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            helloLabel.ForeColor = Color.Snow;
            helloLabel.Location = new Point(106, 40);
            helloLabel.Name = "helloLabel";
            helloLabel.Size = new Size(132, 55);
            helloLabel.TabIndex = 21;
            helloLabel.Text = "Hello";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.white_star;
            pictureBox1.Location = new Point(-9, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.white_star;
            pictureBox2.Location = new Point(26, 69);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.white_star;
            pictureBox3.Location = new Point(53, 376);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.white_star;
            pictureBox5.Location = new Point(72, 431);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(69, 41);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 25;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.white_star;
            pictureBox6.Location = new Point(489, 378);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(97, 74);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 26;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.white_star;
            pictureBox7.Location = new Point(526, 316);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(69, 41);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 27;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.white_star;
            pictureBox8.Location = new Point(538, 251);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(57, 33);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 28;
            pictureBox8.TabStop = false;
            // 
            // MainPlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(583, 464);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(helloLabel);
            Controls.Add(gameBtn);
            Controls.Add(backBtn);
            Controls.Add(characterBtn);
            Controls.Add(storeBtn);
            Controls.Add(teamsBtn);
            Controls.Add(pictureBox4);
            MaximizeBox = false;
            MaximumSize = new Size(599, 503);
            MinimizeBox = false;
            MinimumSize = new Size(599, 503);
            Name = "MainPlayerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Player Form";
            FormClosed += MainPlayerForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button gameBtn;
        private Button backBtn;
        private Button characterBtn;
        private Button storeBtn;
        private Button teamsBtn;
        private PictureBox pictureBox4;
        private Label helloLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
    }
}