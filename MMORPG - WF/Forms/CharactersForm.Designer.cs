namespace MMORPG.Forms
{
    partial class CharactersForm
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
            buttonDeleteCharacter = new Button();
            labelCurrentCharacterInfo = new Label();
            richTextBoxCharacterInfo = new RichTextBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            labelCharacter = new Label();
            backBtn = new Button();
            buttonCreateCharacter = new Button();
            pictureBox4 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            buttonCreateAssistant = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // buttonDeleteCharacter
            // 
            buttonDeleteCharacter.BackColor = Color.FromArgb(68, 34, 94);
            buttonDeleteCharacter.FlatStyle = FlatStyle.Popup;
            buttonDeleteCharacter.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeleteCharacter.Location = new Point(297, 268);
            buttonDeleteCharacter.Margin = new Padding(3, 2, 3, 2);
            buttonDeleteCharacter.Name = "buttonDeleteCharacter";
            buttonDeleteCharacter.Size = new Size(261, 46);
            buttonDeleteCharacter.TabIndex = 55;
            buttonDeleteCharacter.Text = "DELETE CHARACTER";
            buttonDeleteCharacter.UseVisualStyleBackColor = false;
            buttonDeleteCharacter.Click += buttonDeleteCharacter_Click;
            // 
            // labelCurrentCharacterInfo
            // 
            labelCurrentCharacterInfo.AutoSize = true;
            labelCurrentCharacterInfo.Font = new Font("Goudy Old Style", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelCurrentCharacterInfo.ForeColor = Color.Snow;
            labelCurrentCharacterInfo.Location = new Point(61, 317);
            labelCurrentCharacterInfo.Name = "labelCurrentCharacterInfo";
            labelCurrentCharacterInfo.Size = new Size(175, 27);
            labelCurrentCharacterInfo.TabIndex = 54;
            labelCurrentCharacterInfo.Text = "My characters info";
            // 
            // richTextBoxCharacterInfo
            // 
            richTextBoxCharacterInfo.BackColor = Color.FromArgb(128, 128, 255);
            richTextBoxCharacterInfo.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxCharacterInfo.Location = new Point(12, 117);
            richTextBoxCharacterInfo.Name = "richTextBoxCharacterInfo";
            richTextBoxCharacterInfo.ReadOnly = true;
            richTextBoxCharacterInfo.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxCharacterInfo.Size = new Size(269, 197);
            richTextBoxCharacterInfo.TabIndex = 53;
            richTextBoxCharacterInfo.Text = "";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.white_star;
            pictureBox5.Location = new Point(80, 383);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(54, 41);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 52;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.white_star;
            pictureBox3.Location = new Point(140, 363);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 51;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.white_star;
            pictureBox2.Location = new Point(47, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 50;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.white_star;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // labelCharacter
            // 
            labelCharacter.AutoSize = true;
            labelCharacter.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelCharacter.ForeColor = Color.Snow;
            labelCharacter.Location = new Point(109, 15);
            labelCharacter.Name = "labelCharacter";
            labelCharacter.Size = new Size(324, 55);
            labelCharacter.TabIndex = 48;
            labelCharacter.Text = "Character form";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(47, 12, 74);
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(297, 378);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(261, 46);
            backBtn.TabIndex = 45;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // buttonCreateCharacter
            // 
            buttonCreateCharacter.BackColor = Color.White;
            buttonCreateCharacter.FlatStyle = FlatStyle.Popup;
            buttonCreateCharacter.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCreateCharacter.Location = new Point(297, 117);
            buttonCreateCharacter.Margin = new Padding(3, 2, 3, 2);
            buttonCreateCharacter.Name = "buttonCreateCharacter";
            buttonCreateCharacter.Size = new Size(261, 46);
            buttonCreateCharacter.TabIndex = 43;
            buttonCreateCharacter.Text = "CREATE CHARACTER";
            buttonCreateCharacter.UseVisualStyleBackColor = false;
            buttonCreateCharacter.Click += buttonCreateCharacter_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.white_star;
            pictureBox4.Location = new Point(12, 363);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(69, 41);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 47;
            pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.white_star;
            pictureBox6.Location = new Point(477, 47);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(54, 41);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 57;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.white_star;
            pictureBox7.Location = new Point(507, 12);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(51, 29);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 56;
            pictureBox7.TabStop = false;
            // 
            // buttonCreateAssistant
            // 
            buttonCreateAssistant.BackColor = Color.FromArgb(195, 157, 224);
            buttonCreateAssistant.FlatStyle = FlatStyle.Popup;
            buttonCreateAssistant.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCreateAssistant.Location = new Point(297, 191);
            buttonCreateAssistant.Margin = new Padding(3, 2, 3, 2);
            buttonCreateAssistant.Name = "buttonCreateAssistant";
            buttonCreateAssistant.Size = new Size(261, 48);
            buttonCreateAssistant.TabIndex = 58;
            buttonCreateAssistant.Text = "CREATE ASSISTANT";
            buttonCreateAssistant.UseVisualStyleBackColor = false;
            buttonCreateAssistant.Click += removeBtn_Click;
            // 
            // CharactersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(572, 448);
            Controls.Add(buttonCreateAssistant);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox7);
            Controls.Add(buttonDeleteCharacter);
            Controls.Add(labelCurrentCharacterInfo);
            Controls.Add(richTextBoxCharacterInfo);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(labelCharacter);
            Controls.Add(backBtn);
            Controls.Add(buttonCreateCharacter);
            Controls.Add(pictureBox4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CharactersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Characters";
            FormClosed += CharactersForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDeleteCharacter;
        private Label labelCurrentCharacterInfo;
        private RichTextBox richTextBoxCharacterInfo;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label labelCharacter;
        private Button backBtn;
        private Button buttonCreateCharacter;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Button buttonCreateAssistant;
    }
}