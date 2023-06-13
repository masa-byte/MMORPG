namespace MMORPG.Forms
{
    partial class SignUpForm
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
            label1 = new Label();
            backBtn = new Button();
            saveBtn = new Button();
            txtBoxNick = new TextBox();
            txtBoxPassword = new TextBox();
            labelName = new Label();
            label2 = new Label();
            txtBoxName = new TextBox();
            txtBoxSurname = new TextBox();
            numUpDownAge = new NumericUpDown();
            labelExpNeeded = new Label();
            label3 = new Label();
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
            comboBoxGender = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numUpDownAge).BeginInit();
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
            SuspendLayout();
            // 
            // gameName
            // 
            gameName.AutoSize = true;
            gameName.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            gameName.ForeColor = Color.Snow;
            gameName.Location = new Point(107, 26);
            gameName.Name = "gameName";
            gameName.Size = new Size(283, 55);
            gameName.TabIndex = 8;
            gameName.Text = "NICKNAME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(153, 91, 216);
            label1.Location = new Point(107, 131);
            label1.Name = "label1";
            label1.Size = new Size(288, 55);
            label1.TabIndex = 29;
            label1.Text = "PASSWORD";
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.Window;
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.ForeColor = Color.Black;
            backBtn.Location = new Point(12, 515);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(153, 38);
            backBtn.TabIndex = 35;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(153, 91, 216);
            saveBtn.FlatStyle = FlatStyle.Popup;
            saveBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.Location = new Point(345, 514);
            saveBtn.Margin = new Padding(3, 2, 3, 2);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(153, 39);
            saveBtn.TabIndex = 36;
            saveBtn.Text = "SAVE";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // txtBoxNick
            // 
            txtBoxNick.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxNick.Location = new Point(97, 84);
            txtBoxNick.Name = "txtBoxNick";
            txtBoxNick.Size = new Size(306, 27);
            txtBoxNick.TabIndex = 37;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxPassword.Location = new Point(97, 189);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(306, 27);
            txtBoxPassword.TabIndex = 38;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.SlateBlue;
            labelName.Location = new Point(66, 240);
            labelName.Name = "labelName";
            labelName.Size = new Size(141, 55);
            labelName.TabIndex = 39;
            labelName.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SlateBlue;
            label2.Location = new Point(284, 240);
            label2.Name = "label2";
            label2.Size = new Size(200, 55);
            label2.TabIndex = 40;
            label2.Text = "Surname";
            // 
            // txtBoxName
            // 
            txtBoxName.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxName.Location = new Point(47, 311);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(170, 27);
            txtBoxName.TabIndex = 41;
            // 
            // txtBoxSurname
            // 
            txtBoxSurname.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSurname.Location = new Point(284, 311);
            txtBoxSurname.Name = "txtBoxSurname";
            txtBoxSurname.Size = new Size(200, 27);
            txtBoxSurname.TabIndex = 42;
            // 
            // numUpDownAge
            // 
            numUpDownAge.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numUpDownAge.Location = new Point(284, 410);
            numUpDownAge.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numUpDownAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUpDownAge.Name = "numUpDownAge";
            numUpDownAge.Size = new Size(200, 27);
            numUpDownAge.TabIndex = 58;
            numUpDownAge.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelExpNeeded
            // 
            labelExpNeeded.AutoSize = true;
            labelExpNeeded.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelExpNeeded.ForeColor = Color.DarkOrchid;
            labelExpNeeded.Location = new Point(47, 352);
            labelExpNeeded.Name = "labelExpNeeded";
            labelExpNeeded.Size = new Size(170, 55);
            labelExpNeeded.TabIndex = 59;
            labelExpNeeded.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkOrchid;
            label3.Location = new Point(335, 352);
            label3.Name = "label3";
            label3.Size = new Size(98, 55);
            label3.TabIndex = 60;
            label3.Text = "Age";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.white_star;
            pictureBox1.Location = new Point(-15, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 61;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.white_star;
            pictureBox2.Location = new Point(-4, 63);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 62;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.white_star;
            pictureBox3.Location = new Point(412, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(105, 57);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 63;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.white_star;
            pictureBox4.Location = new Point(433, 75);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(84, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 64;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.white_star;
            pictureBox5.Location = new Point(372, -2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(34, 28);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 65;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.white_star;
            pictureBox6.Location = new Point(412, 173);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(34, 28);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 66;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.white_star;
            pictureBox7.Location = new Point(173, 460);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(34, 28);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 67;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.white_star;
            pictureBox8.Location = new Point(204, 478);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(59, 47);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 68;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.white_star;
            pictureBox9.Location = new Point(464, 478);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(34, 28);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 69;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.white_star;
            pictureBox10.Location = new Point(19, 122);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(34, 28);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 70;
            pictureBox10.TabStop = false;
            // 
            // comboBoxGender
            // 
            comboBoxGender.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "M", "F" });
            comboBoxGender.Location = new Point(47, 410);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(170, 29);
            comboBoxGender.TabIndex = 71;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(510, 575);
            Controls.Add(comboBoxGender);
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
            Controls.Add(label3);
            Controls.Add(labelExpNeeded);
            Controls.Add(numUpDownAge);
            Controls.Add(txtBoxSurname);
            Controls.Add(txtBoxName);
            Controls.Add(label2);
            Controls.Add(labelName);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxNick);
            Controls.Add(saveBtn);
            Controls.Add(backBtn);
            Controls.Add(label1);
            Controls.Add(gameName);
            MaximizeBox = false;
            MaximumSize = new Size(526, 614);
            MinimizeBox = false;
            MinimumSize = new Size(526, 614);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up Form";
            FormClosed += SignUpForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)numUpDownAge).EndInit();
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gameName;
        private Label label1;
        private Button backBtn;
        private Button saveBtn;
        private TextBox txtBoxNick;
        private TextBox txtBoxPassword;
        private Label labelName;
        private Label label2;
        private TextBox txtBoxName;
        private TextBox txtBoxSurname;
        private NumericUpDown numUpDownAge;
        private Label labelExpNeeded;
        private Label label3;
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
        private ComboBox comboBoxGender;
    }
}