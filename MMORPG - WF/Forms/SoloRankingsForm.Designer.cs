namespace MMORPG.Forms
{
    partial class SoloRankingsForm
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
            backBtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // listView
            // 
            listView.Alignment = ListViewAlignment.SnapToGrid;
            listView.BackColor = Color.FromArgb(213, 184, 242);
            listView.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listView.FullRowSelect = true;
            listView.Location = new Point(10, 9);
            listView.Margin = new Padding(3, 2, 3, 2);
            listView.MaximumSize = new Size(507, 361);
            listView.MinimumSize = new Size(507, 361);
            listView.Name = "listView";
            listView.Size = new Size(507, 361);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(153, 91, 216);
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(549, 334);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(130, 36);
            backBtn.TabIndex = 1;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.white_star;
            pictureBox1.Location = new Point(590, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.white_star;
            pictureBox2.Location = new Point(523, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.white_star;
            pictureBox3.Location = new Point(514, 36);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(116, 66);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.white_star;
            pictureBox4.Location = new Point(602, 273);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(88, 56);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // SoloRankingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(684, 377);
            Controls.Add(pictureBox1);
            Controls.Add(backBtn);
            Controls.Add(listView);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(700, 416);
            MinimizeBox = false;
            MinimumSize = new Size(700, 416);
            Name = "SoloRankingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "s";
            FormClosed += SoloRankingsForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView;
        private Button backBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}