namespace MMORPG.Forms
{
    partial class CreateFighter
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
            checkBoxTwoHandedWeapon = new CheckBox();
            checkBoxShield = new CheckBox();
            labelName = new Label();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(153, 91, 216);
            saveBtn.FlatStyle = FlatStyle.Popup;
            saveBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.Location = new Point(336, 179);
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
            backBtn.Location = new Point(12, 179);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(153, 38);
            backBtn.TabIndex = 64;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // checkBoxTwoHandedWeapon
            // 
            checkBoxTwoHandedWeapon.AutoSize = true;
            checkBoxTwoHandedWeapon.Font = new Font("Goudy Old Style", 25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxTwoHandedWeapon.ForeColor = SystemColors.ControlLightLight;
            checkBoxTwoHandedWeapon.Location = new Point(85, 78);
            checkBoxTwoHandedWeapon.Name = "checkBoxTwoHandedWeapon";
            checkBoxTwoHandedWeapon.Size = new Size(328, 43);
            checkBoxTwoHandedWeapon.TabIndex = 67;
            checkBoxTwoHandedWeapon.Text = "Two handed weapon?";
            checkBoxTwoHandedWeapon.UseVisualStyleBackColor = true;
            // 
            // checkBoxShield
            // 
            checkBoxShield.AutoSize = true;
            checkBoxShield.Font = new Font("Goudy Old Style", 25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxShield.ForeColor = SystemColors.ControlLightLight;
            checkBoxShield.Location = new Point(174, 127);
            checkBoxShield.Name = "checkBoxShield";
            checkBoxShield.Size = new Size(131, 43);
            checkBoxShield.TabIndex = 68;
            checkBoxShield.Text = "Shield?";
            checkBoxShield.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.SlateBlue;
            labelName.Location = new Point(96, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(285, 55);
            labelName.TabIndex = 69;
            labelName.Text = "Create archer";
            // 
            // CreateFighter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(501, 227);
            Controls.Add(labelName);
            Controls.Add(checkBoxShield);
            Controls.Add(checkBoxTwoHandedWeapon);
            Controls.Add(saveBtn);
            Controls.Add(backBtn);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "CreateFighter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Fighter";
            FormClosed += CreateFighter_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button saveBtn;
        private Button backBtn;
        private CheckBox checkBoxTwoHandedWeapon;
        private CheckBox checkBoxShield;
        private Label labelName;
    }
}