namespace MMORPG.Forms
{
    partial class CreateDefender
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
            numericUpDownMaxArmourWeight = new NumericUpDown();
            labelName = new Label();
            labelArmorWeight = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxArmourWeight).BeginInit();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(153, 91, 216);
            saveBtn.FlatStyle = FlatStyle.Popup;
            saveBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.Location = new Point(267, 178);
            saveBtn.Margin = new Padding(3, 2, 3, 2);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(153, 39);
            saveBtn.TabIndex = 65;
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
            backBtn.Location = new Point(12, 178);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(153, 38);
            backBtn.TabIndex = 64;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // numericUpDownMaxArmourWeight
            // 
            numericUpDownMaxArmourWeight.Font = new Font("Goudy Old Style", 16F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownMaxArmourWeight.Location = new Point(137, 117);
            numericUpDownMaxArmourWeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownMaxArmourWeight.Name = "numericUpDownMaxArmourWeight";
            numericUpDownMaxArmourWeight.Size = new Size(141, 33);
            numericUpDownMaxArmourWeight.TabIndex = 67;
            numericUpDownMaxArmourWeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.SlateBlue;
            labelName.Location = new Point(43, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(334, 55);
            labelName.TabIndex = 69;
            labelName.Text = "Create defender";
            // 
            // labelArmorWeight
            // 
            labelArmorWeight.AutoSize = true;
            labelArmorWeight.Font = new Font("Goudy Old Style", 25F, FontStyle.Regular, GraphicsUnit.Point);
            labelArmorWeight.ForeColor = Color.Snow;
            labelArmorWeight.Location = new Point(84, 75);
            labelArmorWeight.Name = "labelArmorWeight";
            labelArmorWeight.Size = new Size(262, 39);
            labelArmorWeight.TabIndex = 70;
            labelArmorWeight.Text = "Max armor weight";
            // 
            // CreateDefender
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(433, 229);
            Controls.Add(labelArmorWeight);
            Controls.Add(labelName);
            Controls.Add(numericUpDownMaxArmourWeight);
            Controls.Add(saveBtn);
            Controls.Add(backBtn);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateDefender";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Defender";
            FormClosed += CreateDefender_FormClosed;
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxArmourWeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelThief;
        private Button saveBtn;
        private Button backBtn;
        private Label labelArmorWeight;
        private NumericUpDown numericUpDownMaxArmourWeight;
        private Label labelName;
    }
}