namespace MMORPG.Forms
{
    partial class CreateTeamForm
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
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            saveBtn = new Button();
            backBtn = new Button();
            labelMaxPlayers = new Label();
            numericUpDownMaxPlayers = new NumericUpDown();
            labelMinPlayers = new Label();
            numericUpDownMinPlayers = new NumericUpDown();
            labelBonusPoints = new Label();
            numericUpDownBonusPoints = new NumericUpDown();
            textBoxName = new TextBox();
            labelName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxPlayers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinPlayers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBonusPoints).BeginInit();
            SuspendLayout();
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.white_star;
            pictureBox10.Location = new Point(435, 198);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(24, 28);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 60;
            pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.white_star;
            pictureBox11.Location = new Point(382, 216);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(34, 28);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 59;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.Image = Properties.Resources.white_star;
            pictureBox12.Location = new Point(171, 199);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(92, 49);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 58;
            pictureBox12.TabStop = false;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(153, 91, 216);
            saveBtn.FlatStyle = FlatStyle.Popup;
            saveBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.Location = new Point(499, 205);
            saveBtn.Margin = new Padding(3, 2, 3, 2);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(153, 39);
            saveBtn.TabIndex = 57;
            saveBtn.Text = "SAVE";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.Window;
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.ForeColor = Color.Black;
            backBtn.Location = new Point(12, 199);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(153, 38);
            backBtn.TabIndex = 56;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // labelMaxPlayers
            // 
            labelMaxPlayers.AutoSize = true;
            labelMaxPlayers.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelMaxPlayers.ForeColor = Color.DarkOrchid;
            labelMaxPlayers.Location = new Point(360, 93);
            labelMaxPlayers.Name = "labelMaxPlayers";
            labelMaxPlayers.Size = new Size(255, 55);
            labelMaxPlayers.TabIndex = 68;
            labelMaxPlayers.Text = "Max players";
            // 
            // numericUpDownMaxPlayers
            // 
            numericUpDownMaxPlayers.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownMaxPlayers.Location = new Point(372, 151);
            numericUpDownMaxPlayers.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownMaxPlayers.Name = "numericUpDownMaxPlayers";
            numericUpDownMaxPlayers.Size = new Size(120, 27);
            numericUpDownMaxPlayers.TabIndex = 67;
            // 
            // labelMinPlayers
            // 
            labelMinPlayers.AutoSize = true;
            labelMinPlayers.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelMinPlayers.ForeColor = Color.DarkOrchid;
            labelMinPlayers.Location = new Point(12, 93);
            labelMinPlayers.Name = "labelMinPlayers";
            labelMinPlayers.Size = new Size(257, 55);
            labelMinPlayers.TabIndex = 66;
            labelMinPlayers.Text = "Min Players";
            // 
            // numericUpDownMinPlayers
            // 
            numericUpDownMinPlayers.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownMinPlayers.Location = new Point(24, 151);
            numericUpDownMinPlayers.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownMinPlayers.Name = "numericUpDownMinPlayers";
            numericUpDownMinPlayers.Size = new Size(120, 27);
            numericUpDownMinPlayers.TabIndex = 65;
            // 
            // labelBonusPoints
            // 
            labelBonusPoints.AutoSize = true;
            labelBonusPoints.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelBonusPoints.ForeColor = Color.SlateBlue;
            labelBonusPoints.Location = new Point(360, 5);
            labelBonusPoints.Name = "labelBonusPoints";
            labelBonusPoints.Size = new Size(281, 55);
            labelBonusPoints.TabIndex = 64;
            labelBonusPoints.Text = "Bonus points";
            // 
            // numericUpDownBonusPoints
            // 
            numericUpDownBonusPoints.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownBonusPoints.Location = new Point(372, 63);
            numericUpDownBonusPoints.Name = "numericUpDownBonusPoints";
            numericUpDownBonusPoints.Size = new Size(120, 27);
            numericUpDownBonusPoints.TabIndex = 63;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(25, 63);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(294, 27);
            textBoxName.TabIndex = 62;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.SlateBlue;
            labelName.Location = new Point(12, 9);
            labelName.MaximumSize = new Size(256, 55);
            labelName.MinimumSize = new Size(256, 55);
            labelName.Name = "labelName";
            labelName.Size = new Size(256, 55);
            labelName.TabIndex = 61;
            labelName.Text = "Team name";
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(664, 253);
            Controls.Add(labelMaxPlayers);
            Controls.Add(numericUpDownMaxPlayers);
            Controls.Add(labelMinPlayers);
            Controls.Add(numericUpDownMinPlayers);
            Controls.Add(labelBonusPoints);
            Controls.Add(numericUpDownBonusPoints);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox12);
            Controls.Add(saveBtn);
            Controls.Add(backBtn);
            MaximizeBox = false;
            MaximumSize = new Size(680, 292);
            MinimizeBox = false;
            MinimumSize = new Size(680, 292);
            Name = "CreateTeamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Update Team";
            FormClosed += CreateUpdateTeamForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxPlayers).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinPlayers).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBonusPoints).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private Button saveBtn;
        private Button backBtn;
        private Label labelMaxPlayers;
        private NumericUpDown numericUpDownMaxPlayers;
        private Label labelMinPlayers;
        private NumericUpDown numericUpDownMinPlayers;
        private Label labelBonusPoints;
        private NumericUpDown numericUpDownBonusPoints;
        private TextBox textBoxName;
        private Label labelName;
    }
}