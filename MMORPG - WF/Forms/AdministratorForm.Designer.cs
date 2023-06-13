namespace MMORPG.Forms
{
    partial class AdministratorForm
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
            itemsBtn = new Button();
            spellsBtn = new Button();
            blessingsBtn = new Button();
            backBtn = new Button();
            tracksBtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // gameName
            // 
            gameName.AutoSize = true;
            gameName.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            gameName.ForeColor = Color.Snow;
            gameName.Location = new Point(47, 40);
            gameName.Name = "gameName";
            gameName.Size = new Size(451, 55);
            gameName.TabIndex = 5;
            gameName.Text = "ADMINISTRATORS";
            // 
            // itemsBtn
            // 
            itemsBtn.BackColor = Color.White;
            itemsBtn.FlatStyle = FlatStyle.Popup;
            itemsBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            itemsBtn.Location = new Point(134, 144);
            itemsBtn.Margin = new Padding(3, 2, 3, 2);
            itemsBtn.Name = "itemsBtn";
            itemsBtn.Size = new Size(278, 46);
            itemsBtn.TabIndex = 6;
            itemsBtn.Text = "ITEMS";
            itemsBtn.UseVisualStyleBackColor = false;
            itemsBtn.Click += itemsBtn_Click;
            // 
            // spellsBtn
            // 
            spellsBtn.BackColor = Color.FromArgb(153, 91, 216);
            spellsBtn.FlatStyle = FlatStyle.Popup;
            spellsBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            spellsBtn.Location = new Point(134, 279);
            spellsBtn.Margin = new Padding(3, 2, 3, 2);
            spellsBtn.Name = "spellsBtn";
            spellsBtn.Size = new Size(278, 46);
            spellsBtn.TabIndex = 7;
            spellsBtn.Text = "SPELLS";
            spellsBtn.UseVisualStyleBackColor = false;
            spellsBtn.Click += spellsBtn_Click;
            // 
            // blessingsBtn
            // 
            blessingsBtn.BackColor = Color.FromArgb(68, 34, 94);
            blessingsBtn.FlatStyle = FlatStyle.Popup;
            blessingsBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            blessingsBtn.Location = new Point(134, 344);
            blessingsBtn.Margin = new Padding(3, 2, 3, 2);
            blessingsBtn.Name = "blessingsBtn";
            blessingsBtn.Size = new Size(278, 46);
            blessingsBtn.TabIndex = 8;
            blessingsBtn.Text = "BLESSINGS";
            blessingsBtn.UseVisualStyleBackColor = false;
            blessingsBtn.Click += blessingsBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(47, 12, 74);
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(134, 410);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(278, 46);
            backBtn.TabIndex = 9;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // tracksBtn
            // 
            tracksBtn.BackColor = Color.FromArgb(195, 157, 224);
            tracksBtn.FlatStyle = FlatStyle.Popup;
            tracksBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            tracksBtn.Location = new Point(134, 212);
            tracksBtn.Margin = new Padding(3, 2, 3, 2);
            tracksBtn.Name = "tracksBtn";
            tracksBtn.Size = new Size(278, 46);
            tracksBtn.TabIndex = 10;
            tracksBtn.Text = "TRACKS";
            tracksBtn.UseVisualStyleBackColor = false;
            tracksBtn.Click += tracksBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.white_star;
            pictureBox1.Location = new Point(431, 410);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.white_star;
            pictureBox2.Location = new Point(474, 344);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.white_star;
            pictureBox3.Location = new Point(-14, 381);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(122, 75);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.white_star;
            pictureBox4.Location = new Point(70, 444);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(69, 41);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.white_star;
            pictureBox5.Location = new Point(463, -5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(122, 75);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.white_star;
            pictureBox6.Location = new Point(12, -5);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(73, 43);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.white_star;
            pictureBox7.Location = new Point(-14, 39);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(63, 31);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 17;
            pictureBox7.TabStop = false;
            // 
            // AdministratorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(547, 495);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(tracksBtn);
            Controls.Add(backBtn);
            Controls.Add(blessingsBtn);
            Controls.Add(spellsBtn);
            Controls.Add(itemsBtn);
            Controls.Add(gameName);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(563, 534);
            MinimizeBox = false;
            MinimumSize = new Size(563, 534);
            Name = "AdministratorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrator";
            FormClosed += AdministratorForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gameName;
        private Button itemsBtn;
        private Button spellsBtn;
        private Button blessingsBtn;
        private Button backBtn;
        private Button tracksBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
    }
}