namespace MMORPG.Forms
{
    partial class StoreForm
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
            listViewItems = new ListView();
            listViewInventory = new ListView();
            richTextBoxItems = new RichTextBox();
            richTextBoxInventory = new RichTextBox();
            backBtn = new Button();
            buyItemBtn = new Button();
            sellItemBtn = new Button();
            helloLabel = new Label();
            label1 = new Label();
            fundsLabel = new Label();
            expLabel = new Label();
            listViewCharacter = new ListView();
            label2 = new Label();
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
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox16 = new PictureBox();
            pictureBox17 = new PictureBox();
            pictureBox18 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            SuspendLayout();
            // 
            // listViewItems
            // 
            listViewItems.BackColor = Color.FromArgb(213, 184, 242);
            listViewItems.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listViewItems.Location = new Point(13, 73);
            listViewItems.Margin = new Padding(3, 4, 3, 4);
            listViewItems.Name = "listViewItems";
            listViewItems.Size = new Size(555, 489);
            listViewItems.TabIndex = 1;
            listViewItems.UseCompatibleStateImageBehavior = false;
            listViewItems.SelectedIndexChanged += listViewItems_SelectedIndexChanged;
            // 
            // listViewInventory
            // 
            listViewInventory.BackColor = Color.FromArgb(213, 184, 242);
            listViewInventory.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listViewInventory.Location = new Point(614, 73);
            listViewInventory.Margin = new Padding(3, 4, 3, 4);
            listViewInventory.Name = "listViewInventory";
            listViewInventory.Size = new Size(555, 489);
            listViewInventory.TabIndex = 2;
            listViewInventory.UseCompatibleStateImageBehavior = false;
            listViewInventory.SelectedIndexChanged += listViewInventory_SelectedIndexChanged;
            // 
            // richTextBoxItems
            // 
            richTextBoxItems.BackColor = Color.FromArgb(128, 128, 255);
            richTextBoxItems.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxItems.Location = new Point(13, 587);
            richTextBoxItems.Margin = new Padding(3, 4, 3, 4);
            richTextBoxItems.Name = "richTextBoxItems";
            richTextBoxItems.ReadOnly = true;
            richTextBoxItems.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxItems.Size = new Size(417, 156);
            richTextBoxItems.TabIndex = 23;
            richTextBoxItems.Text = "";
            // 
            // richTextBoxInventory
            // 
            richTextBoxInventory.BackColor = Color.FromArgb(128, 128, 255);
            richTextBoxInventory.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxInventory.Location = new Point(752, 587);
            richTextBoxInventory.Margin = new Padding(3, 4, 3, 4);
            richTextBoxInventory.Name = "richTextBoxInventory";
            richTextBoxInventory.ReadOnly = true;
            richTextBoxInventory.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxInventory.Size = new Size(417, 156);
            richTextBoxInventory.TabIndex = 24;
            richTextBoxInventory.Text = "";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(153, 91, 216);
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(14, 984);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(163, 71);
            backBtn.TabIndex = 25;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // buyItemBtn
            // 
            buyItemBtn.BackColor = Color.FromArgb(195, 157, 224);
            buyItemBtn.FlatStyle = FlatStyle.Popup;
            buyItemBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buyItemBtn.Location = new Point(454, 587);
            buyItemBtn.Name = "buyItemBtn";
            buyItemBtn.Size = new Size(271, 69);
            buyItemBtn.TabIndex = 26;
            buyItemBtn.Text = "BUY ITEM";
            buyItemBtn.UseVisualStyleBackColor = false;
            buyItemBtn.Click += buyItemBtn_Click;
            // 
            // sellItemBtn
            // 
            sellItemBtn.BackColor = Color.FromArgb(153, 91, 216);
            sellItemBtn.FlatStyle = FlatStyle.Popup;
            sellItemBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            sellItemBtn.Location = new Point(454, 676);
            sellItemBtn.Name = "sellItemBtn";
            sellItemBtn.Size = new Size(271, 68);
            sellItemBtn.TabIndex = 27;
            sellItemBtn.Text = "SELL ITEM";
            sellItemBtn.UseVisualStyleBackColor = false;
            sellItemBtn.Click += sellItemBtn_Click;
            // 
            // helloLabel
            // 
            helloLabel.AutoSize = true;
            helloLabel.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            helloLabel.ForeColor = Color.Snow;
            helloLabel.Location = new Point(114, -4);
            helloLabel.Name = "helloLabel";
            helloLabel.Size = new Size(401, 69);
            helloLabel.TabIndex = 28;
            helloLabel.Text = "Available items";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(767, -4);
            label1.Name = "label1";
            label1.Size = new Size(269, 69);
            label1.TabIndex = 29;
            label1.Text = "Inventory";
            // 
            // fundsLabel
            // 
            fundsLabel.AutoSize = true;
            fundsLabel.Font = new Font("Goudy Old Style", 32F, FontStyle.Bold, GraphicsUnit.Point);
            fundsLabel.ForeColor = Color.Snow;
            fundsLabel.Location = new Point(14, 761);
            fundsLabel.Name = "fundsLabel";
            fundsLabel.Size = new Size(408, 63);
            fundsLabel.TabIndex = 30;
            fundsLabel.Text = "Available funds : ";
            // 
            // expLabel
            // 
            expLabel.AutoSize = true;
            expLabel.Font = new Font("Goudy Old Style", 32F, FontStyle.Bold, GraphicsUnit.Point);
            expLabel.ForeColor = Color.Snow;
            expLabel.Location = new Point(14, 829);
            expLabel.Name = "expLabel";
            expLabel.Size = new Size(265, 63);
            expLabel.TabIndex = 31;
            expLabel.Text = "Exp level : ";
            // 
            // listViewCharacter
            // 
            listViewCharacter.BackColor = Color.FromArgb(68, 34, 94);
            listViewCharacter.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listViewCharacter.ForeColor = SystemColors.Window;
            listViewCharacter.Location = new Point(794, 829);
            listViewCharacter.Margin = new Padding(3, 4, 3, 4);
            listViewCharacter.Name = "listViewCharacter";
            listViewCharacter.Size = new Size(358, 213);
            listViewCharacter.TabIndex = 32;
            listViewCharacter.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Goudy Old Style", 32F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(811, 757);
            label2.Name = "label2";
            label2.Size = new Size(365, 63);
            label2.TabIndex = 33;
            label2.Text = "Characters info";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.white_star;
            pictureBox1.Location = new Point(-2, -4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 82;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.white_star;
            pictureBox2.Location = new Point(676, -4);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 83;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.white_star;
            pictureBox3.Location = new Point(65, -4);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 84;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.white_star;
            pictureBox4.Location = new Point(14, 908);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(79, 69);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 85;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.white_star;
            pictureBox5.Location = new Point(575, 545);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(33, 35);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 86;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.white_star;
            pictureBox6.Location = new Point(99, 934);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(48, 43);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 87;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.white_star;
            pictureBox7.Location = new Point(676, 952);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(102, 90);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 88;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.white_star;
            pictureBox8.Location = new Point(731, 873);
            pictureBox8.Margin = new Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(57, 55);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 89;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.white_star;
            pictureBox9.Location = new Point(614, 920);
            pictureBox9.Margin = new Padding(3, 4, 3, 4);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(55, 43);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 90;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.white_star;
            pictureBox10.Location = new Point(519, 984);
            pictureBox10.Margin = new Padding(3, 4, 3, 4);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(66, 58);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 91;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.white_star;
            pictureBox11.Location = new Point(631, 1001);
            pictureBox11.Margin = new Padding(3, 4, 3, 4);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(22, 24);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 92;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.white_star;
            pictureBox12.Location = new Point(686, 873);
            pictureBox12.Margin = new Padding(3, 4, 3, 4);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(22, 24);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 93;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = Properties.Resources.white_star;
            pictureBox13.Location = new Point(473, 1018);
            pictureBox13.Margin = new Padding(3, 4, 3, 4);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(22, 24);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 94;
            pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.Image = Properties.Resources.white_star;
            pictureBox14.Location = new Point(743, 808);
            pictureBox14.Margin = new Padding(3, 4, 3, 4);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(35, 36);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 95;
            pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            pictureBox15.Image = Properties.Resources.white_star;
            pictureBox15.Location = new Point(731, 41);
            pictureBox15.Margin = new Padding(3, 4, 3, 4);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(22, 24);
            pictureBox15.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox15.TabIndex = 96;
            pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            pictureBox16.Image = Properties.Resources.white_star;
            pictureBox16.Location = new Point(579, 515);
            pictureBox16.Margin = new Padding(3, 4, 3, 4);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(22, 24);
            pictureBox16.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox16.TabIndex = 97;
            pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            pictureBox17.Image = Properties.Resources.white_star;
            pictureBox17.Location = new Point(1128, 9);
            pictureBox17.Margin = new Padding(3, 4, 3, 4);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(41, 33);
            pictureBox17.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox17.TabIndex = 98;
            pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            pictureBox18.Image = Properties.Resources.white_star;
            pictureBox18.Location = new Point(1100, 22);
            pictureBox18.Margin = new Padding(3, 4, 3, 4);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(22, 24);
            pictureBox18.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox18.TabIndex = 99;
            pictureBox18.TabStop = false;
            // 
            // StoreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(1181, 1055);
            Controls.Add(pictureBox18);
            Controls.Add(pictureBox17);
            Controls.Add(pictureBox16);
            Controls.Add(pictureBox14);
            Controls.Add(pictureBox13);
            Controls.Add(pictureBox12);
            Controls.Add(pictureBox11);
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
            Controls.Add(label2);
            Controls.Add(listViewCharacter);
            Controls.Add(expLabel);
            Controls.Add(fundsLabel);
            Controls.Add(label1);
            Controls.Add(helloLabel);
            Controls.Add(sellItemBtn);
            Controls.Add(buyItemBtn);
            Controls.Add(backBtn);
            Controls.Add(richTextBoxInventory);
            Controls.Add(richTextBoxItems);
            Controls.Add(listViewInventory);
            Controls.Add(listViewItems);
            Controls.Add(pictureBox15);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(1199, 1106);
            MinimizeBox = false;
            MinimumSize = new Size(1199, 1018);
            Name = "StoreForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Store";
            FormClosed += StoreForm_FormClosed;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewItems;
        private ListView listViewInventory;
        private RichTextBox richTextBoxItems;
        private RichTextBox richTextBoxInventory;
        private Button backBtn;
        private Button buyItemBtn;
        private Button sellItemBtn;
        private Label helloLabel;
        private Label label1;
        private Label fundsLabel;
        private Label expLabel;
        private ListView listViewCharacter;
        private Label label2;
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
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
    }
}