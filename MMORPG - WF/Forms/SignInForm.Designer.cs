namespace MMORPG.Forms
{
    partial class SignInForm
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
            txtBoxNick = new TextBox();
            txtBoxPassword = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            backBtn = new Button();
            signInBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // gameName
            // 
            gameName.AutoSize = true;
            gameName.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            gameName.ForeColor = Color.Snow;
            gameName.Location = new Point(128, 39);
            gameName.Name = "gameName";
            gameName.Size = new Size(283, 55);
            gameName.TabIndex = 7;
            gameName.Text = "NICKNAME";
            // 
            // txtBoxNick
            // 
            txtBoxNick.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxNick.Location = new Point(117, 97);
            txtBoxNick.Name = "txtBoxNick";
            txtBoxNick.Size = new Size(306, 27);
            txtBoxNick.TabIndex = 26;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPassword.Location = new Point(117, 216);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(306, 27);
            txtBoxPassword.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(153, 91, 216);
            label1.Location = new Point(128, 158);
            label1.Name = "label1";
            label1.Size = new Size(288, 55);
            label1.TabIndex = 28;
            label1.Text = "PASSWORD";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.white_star;
            pictureBox1.Location = new Point(-15, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.white_star;
            pictureBox2.Location = new Point(457, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.white_star;
            pictureBox3.Location = new Point(445, 57);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(72, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.white_star;
            pictureBox4.Location = new Point(12, 175);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(63, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 32;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.white_star;
            pictureBox5.Location = new Point(39, 130);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 33;
            pictureBox5.TabStop = false;
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.Window;
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.ForeColor = Color.Black;
            backBtn.Location = new Point(12, 274);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(153, 38);
            backBtn.TabIndex = 34;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // signInBtn
            // 
            signInBtn.BackColor = Color.FromArgb(153, 91, 216);
            signInBtn.FlatStyle = FlatStyle.Popup;
            signInBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            signInBtn.Location = new Point(381, 274);
            signInBtn.Margin = new Padding(3, 2, 3, 2);
            signInBtn.Name = "signInBtn";
            signInBtn.Size = new Size(153, 39);
            signInBtn.TabIndex = 35;
            signInBtn.Text = "SIGN IN";
            signInBtn.UseVisualStyleBackColor = false;
            signInBtn.Click += saveBtn_Click;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(546, 324);
            Controls.Add(signInBtn);
            Controls.Add(backBtn);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxNick);
            Controls.Add(gameName);
            MaximizeBox = false;
            MaximumSize = new Size(562, 363);
            MinimizeBox = false;
            MinimumSize = new Size(562, 363);
            Name = "SignInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In Form";
            FormClosed += SignInForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gameName;
        private TextBox txtBoxNick;
        private TextBox txtBoxPassword;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button backBtn;
        private Button signInBtn;
    }
}