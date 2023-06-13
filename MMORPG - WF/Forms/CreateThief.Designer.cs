namespace MMORPG.Forms
{
    partial class CreateThief
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
            saveBtn = new Button();
            backBtn = new Button();
            checkBoxTrapRemoval = new CheckBox();
            labelNoiseLevel = new Label();
            numericUpDownNoiseLevel = new NumericUpDown();
            labelName = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNoiseLevel).BeginInit();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(153, 91, 216);
            saveBtn.FlatStyle = FlatStyle.Popup;
            saveBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.Location = new Point(335, 174);
            saveBtn.Margin = new Padding(3, 2, 3, 2);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(153, 39);
            saveBtn.TabIndex = 18;
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
            backBtn.Location = new Point(12, 174);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(153, 38);
            backBtn.TabIndex = 17;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // checkBoxTrapRemoval
            // 
            checkBoxTrapRemoval.AutoSize = true;
            checkBoxTrapRemoval.CheckAlign = ContentAlignment.BottomCenter;
            checkBoxTrapRemoval.Font = new Font("Goudy Old Style", 25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxTrapRemoval.ForeColor = SystemColors.ButtonFace;
            checkBoxTrapRemoval.Location = new Point(12, 79);
            checkBoxTrapRemoval.Name = "checkBoxTrapRemoval";
            checkBoxTrapRemoval.Size = new Size(211, 57);
            checkBoxTrapRemoval.TabIndex = 59;
            checkBoxTrapRemoval.Text = "Trap removal?";
            checkBoxTrapRemoval.TextAlign = ContentAlignment.BottomCenter;
            checkBoxTrapRemoval.UseVisualStyleBackColor = true;
            // 
            // labelNoiseLevel
            // 
            labelNoiseLevel.AutoSize = true;
            labelNoiseLevel.Font = new Font("Goudy Old Style", 25F, FontStyle.Regular, GraphicsUnit.Point);
            labelNoiseLevel.ForeColor = Color.Snow;
            labelNoiseLevel.Location = new Point(304, 67);
            labelNoiseLevel.Name = "labelNoiseLevel";
            labelNoiseLevel.Size = new Size(162, 39);
            labelNoiseLevel.TabIndex = 61;
            labelNoiseLevel.Text = "Noise level";
            // 
            // numericUpDownNoiseLevel
            // 
            numericUpDownNoiseLevel.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownNoiseLevel.Location = new Point(313, 109);
            numericUpDownNoiseLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownNoiseLevel.Name = "numericUpDownNoiseLevel";
            numericUpDownNoiseLevel.Size = new Size(141, 27);
            numericUpDownNoiseLevel.TabIndex = 60;
            numericUpDownNoiseLevel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.SlateBlue;
            labelName.Location = new Point(115, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(251, 55);
            labelName.TabIndex = 62;
            labelName.Text = "Create thief";
            // 
            // CreateThief
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(500, 223);
            Controls.Add(labelName);
            Controls.Add(labelNoiseLevel);
            Controls.Add(numericUpDownNoiseLevel);
            Controls.Add(checkBoxTrapRemoval);
            Controls.Add(saveBtn);
            Controls.Add(backBtn);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateThief";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Thief";
            FormClosed += CreateThief_FormClosed;
            ((System.ComponentModel.ISupportInitialize)numericUpDownNoiseLevel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveBtn;
        private Button backBtn;
        private CheckBox checkBoxTrapRemoval;
        private Label labelNoiseLevel;
        private NumericUpDown numericUpDownNoiseLevel;
        private Label labelName;
    }
}