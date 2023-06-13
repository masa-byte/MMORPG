namespace MMORPG.Forms
{
    partial class ItemsForm
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
            listView = new ListView();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            updateBtn = new Button();
            removeBtn = new Button();
            addNewBtn = new Button();
            backBtn = new Button();
            richTextBox = new RichTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listView
            // 
            listView.BackColor = Color.FromArgb(213, 184, 242);
            listView.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listView.Location = new Point(12, 12);
            listView.Name = "listView";
            listView.Size = new Size(486, 368);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.white_star;
            pictureBox3.Location = new Point(537, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(68, 66);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.white_star;
            pictureBox2.Location = new Point(504, 77);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(68, 34, 94);
            updateBtn.FlatStyle = FlatStyle.Popup;
            updateBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            updateBtn.Location = new Point(675, 145);
            updateBtn.Margin = new Padding(3, 2, 3, 2);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(205, 47);
            updateBtn.TabIndex = 20;
            updateBtn.Text = "Update selected";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // removeBtn
            // 
            removeBtn.BackColor = Color.FromArgb(195, 157, 224);
            removeBtn.FlatStyle = FlatStyle.Popup;
            removeBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            removeBtn.Location = new Point(675, 77);
            removeBtn.Margin = new Padding(3, 2, 3, 2);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(205, 48);
            removeBtn.TabIndex = 19;
            removeBtn.Text = "Remove selected";
            removeBtn.UseVisualStyleBackColor = false;
            removeBtn.Click += removeBtn_Click;
            // 
            // addNewBtn
            // 
            addNewBtn.BackColor = Color.White;
            addNewBtn.FlatStyle = FlatStyle.Popup;
            addNewBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            addNewBtn.Location = new Point(675, 12);
            addNewBtn.Margin = new Padding(3, 2, 3, 2);
            addNewBtn.Name = "addNewBtn";
            addNewBtn.Size = new Size(205, 46);
            addNewBtn.TabIndex = 18;
            addNewBtn.Text = "Add new item";
            addNewBtn.UseVisualStyleBackColor = false;
            addNewBtn.Click += addNewBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(153, 91, 216);
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(773, 347);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(107, 36);
            backBtn.TabIndex = 21;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // richTextBox
            // 
            richTextBox.BackColor = Color.FromArgb(128, 128, 255);
            richTextBox.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox.Location = new Point(515, 210);
            richTextBox.Name = "richTextBox";
            richTextBox.ReadOnly = true;
            richTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox.Size = new Size(365, 118);
            richTextBox.TabIndex = 22;
            richTextBox.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.white_star;
            pictureBox1.Location = new Point(537, 138);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // ItemsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(892, 394);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox);
            Controls.Add(backBtn);
            Controls.Add(updateBtn);
            Controls.Add(removeBtn);
            Controls.Add(addNewBtn);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(listView);
            MaximizeBox = false;
            MaximumSize = new Size(908, 433);
            MinimizeBox = false;
            MinimumSize = new Size(908, 433);
            Name = "ItemsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Items";
            FormClosed += ItemsForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button updateBtn;
        private Button removeBtn;
        private Button addNewBtn;
        private Button backBtn;
        private RichTextBox richTextBox;
        private PictureBox pictureBox1;
    }
}