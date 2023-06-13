namespace MMORPG.Forms
{
    partial class PlayerForm
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
            gameName = new Label();
            backBtn = new Button();
            signUpBtn = new Button();
            signInBtn = new Button();
            pictureBox5 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // gameName
            // 
            gameName.AutoSize = true;
            gameName.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            gameName.ForeColor = Color.Snow;
            gameName.Location = new Point(129, 69);
            gameName.Name = "gameName";
            gameName.Size = new Size(228, 55);
            gameName.TabIndex = 6;
            gameName.Text = "PLAYERS";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.White;
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(129, 290);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(228, 47);
            backBtn.TabIndex = 7;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // signUpBtn
            // 
            signUpBtn.BackColor = Color.FromArgb(153, 91, 216);
            signUpBtn.FlatStyle = FlatStyle.Popup;
            signUpBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            signUpBtn.Location = new Point(129, 220);
            signUpBtn.Margin = new Padding(3, 2, 3, 2);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(228, 51);
            signUpBtn.TabIndex = 8;
            signUpBtn.Text = "SIGN UP";
            signUpBtn.UseVisualStyleBackColor = false;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // signInBtn
            // 
            signInBtn.BackColor = Color.FromArgb(195, 157, 224);
            signInBtn.FlatStyle = FlatStyle.Popup;
            signInBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            signInBtn.Location = new Point(129, 155);
            signInBtn.Margin = new Padding(3, 2, 3, 2);
            signInBtn.Name = "signInBtn";
            signInBtn.Size = new Size(228, 50);
            signInBtn.TabIndex = 11;
            signInBtn.Text = "SIGN IN";
            signInBtn.UseVisualStyleBackColor = false;
            signInBtn.Click += signInBtn_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.white_star;
            pictureBox5.Location = new Point(-16, 1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(113, 66);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.white_star;
            pictureBox7.Location = new Point(34, 82);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(63, 31);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 18;
            pictureBox7.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.white_star;
            pictureBox2.Location = new Point(392, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.white_star;
            pictureBox1.Location = new Point(392, 361);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.white_star;
            pictureBox3.Location = new Point(422, 331);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.white_star;
            pictureBox4.Location = new Point(346, 361);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // PlayerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(471, 427);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox5);
            Controls.Add(signInBtn);
            Controls.Add(signUpBtn);
            Controls.Add(backBtn);
            Controls.Add(gameName);
            MaximizeBox = false;
            MaximumSize = new Size(487, 466);
            MinimizeBox = false;
            MinimumSize = new Size(487, 466);
            Name = "PlayerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Player Form";
            FormClosing += PlayerForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gameName;
        private Button backBtn;
        private Button signUpBtn;
        private Button signInBtn;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}