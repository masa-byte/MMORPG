namespace MMORPG.Forms
{
    partial class TracksForm
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
            updateBtn = new Button();
            removeBtn = new Button();
            addNewBtn = new Button();
            backBtn = new Button();
            listView = new ListView();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            richTextBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(68, 34, 94);
            updateBtn.FlatStyle = FlatStyle.Popup;
            updateBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            updateBtn.Location = new Point(487, 167);
            updateBtn.Margin = new Padding(3, 2, 3, 2);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(231, 47);
            updateBtn.TabIndex = 19;
            updateBtn.Text = "Update selected";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // removeBtn
            // 
            removeBtn.BackColor = Color.FromArgb(195, 157, 224);
            removeBtn.FlatStyle = FlatStyle.Popup;
            removeBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            removeBtn.Location = new Point(487, 95);
            removeBtn.Margin = new Padding(3, 2, 3, 2);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(231, 48);
            removeBtn.TabIndex = 18;
            removeBtn.Text = "Remove selected";
            removeBtn.UseVisualStyleBackColor = false;
            removeBtn.Click += removeBtn_Click;
            // 
            // addNewBtn
            // 
            addNewBtn.BackColor = Color.White;
            addNewBtn.FlatStyle = FlatStyle.Popup;
            addNewBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            addNewBtn.Location = new Point(487, 28);
            addNewBtn.Margin = new Padding(3, 2, 3, 2);
            addNewBtn.Name = "addNewBtn";
            addNewBtn.Size = new Size(231, 46);
            addNewBtn.TabIndex = 17;
            addNewBtn.Text = "Add new track";
            addNewBtn.UseVisualStyleBackColor = false;
            addNewBtn.Click += addNewBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(153, 91, 216);
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(588, 334);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(130, 36);
            backBtn.TabIndex = 16;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // listView
            // 
            listView.Alignment = ListViewAlignment.SnapToGrid;
            listView.BackColor = Color.FromArgb(213, 184, 242);
            listView.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listView.FullRowSelect = true;
            listView.Location = new Point(12, 11);
            listView.Margin = new Padding(3, 2, 3, 2);
            listView.MaximumSize = new Size(507, 361);
            listView.Name = "listView";
            listView.Size = new Size(345, 358);
            listView.TabIndex = 15;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.white_star;
            pictureBox3.Location = new Point(363, 304);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(116, 66);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.white_star;
            pictureBox1.Location = new Point(376, 252);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.white_star;
            pictureBox2.Location = new Point(363, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(116, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.white_star;
            pictureBox4.Location = new Point(419, 202);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(51, 33);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.white_star;
            pictureBox5.Location = new Point(376, 145);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // richTextBox
            // 
            richTextBox.BackColor = Color.FromArgb(128, 128, 255);
            richTextBox.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox.Location = new Point(487, 235);
            richTextBox.Name = "richTextBox";
            richTextBox.ReadOnly = true;
            richTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox.Size = new Size(231, 73);
            richTextBox.TabIndex = 25;
            richTextBox.Text = "";
            // 
            // TracksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(731, 382);
            Controls.Add(richTextBox);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(updateBtn);
            Controls.Add(removeBtn);
            Controls.Add(addNewBtn);
            Controls.Add(backBtn);
            Controls.Add(listView);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MaximumSize = new Size(747, 421);
            MinimizeBox = false;
            MinimumSize = new Size(747, 421);
            Name = "TracksForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tracks";
            FormClosed += TracksForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button updateBtn;
        private Button removeBtn;
        private Button addNewBtn;
        private Button backBtn;
        private ListView listView;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private RichTextBox richTextBox;
    }
}