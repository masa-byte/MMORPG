namespace MMORPG.Forms
{
    partial class CreateUpdateBlessingForm
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
            blessingText = new Label();
            textBoxName = new TextBox();
            backBtn = new Button();
            saveBtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // blessingText
            // 
            blessingText.AutoSize = true;
            blessingText.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            blessingText.ForeColor = Color.Snow;
            blessingText.Location = new Point(75, 21);
            blessingText.Name = "blessingText";
            blessingText.Size = new Size(311, 55);
            blessingText.TabIndex = 6;
            blessingText.Text = "Blessing Name";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(12, 98);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(407, 27);
            textBoxName.TabIndex = 7;
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.Window;
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.ForeColor = Color.Black;
            backBtn.Location = new Point(12, 162);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(153, 38);
            backBtn.TabIndex = 8;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(153, 91, 216);
            saveBtn.FlatStyle = FlatStyle.Popup;
            saveBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.Location = new Point(266, 161);
            saveBtn.Margin = new Padding(3, 2, 3, 2);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(153, 39);
            saveBtn.TabIndex = 9;
            saveBtn.Text = "SAVE";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.white_star;
            pictureBox1.Location = new Point(-19, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.white_star;
            pictureBox2.Location = new Point(60, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.white_star;
            pictureBox3.Location = new Point(360, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(89, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // CreateUpdateBlessingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(433, 211);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(saveBtn);
            Controls.Add(backBtn);
            Controls.Add(textBoxName);
            Controls.Add(blessingText);
            ForeColor = Color.Snow;
            MaximizeBox = false;
            MaximumSize = new Size(449, 250);
            MinimizeBox = false;
            MinimumSize = new Size(449, 250);
            Name = "CreateUpdateBlessingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Update Blessing";
            FormClosed += CreateUpdateBlessingForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label blessingText;
        private TextBox textBoxName;
        private Button backBtn;
        private Button saveBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}