namespace MMORPG.Forms
{
    partial class CreateArcher
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
            labelName = new Label();
            groupBoxBowCrossBow = new GroupBox();
            radioButtonCrossbow = new RadioButton();
            radioButtonBow = new RadioButton();
            groupBoxBowCrossBow.SuspendLayout();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(153, 91, 216);
            saveBtn.FlatStyle = FlatStyle.Popup;
            saveBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.Location = new Point(194, 182);
            saveBtn.Margin = new Padding(3, 2, 3, 2);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(153, 39);
            saveBtn.TabIndex = 62;
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
            backBtn.Location = new Point(12, 182);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(153, 38);
            backBtn.TabIndex = 61;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.SlateBlue;
            labelName.Location = new Point(32, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(285, 55);
            labelName.TabIndex = 65;
            labelName.Text = "Create archer";
            // 
            // groupBoxBowCrossBow
            // 
            groupBoxBowCrossBow.Controls.Add(radioButtonCrossbow);
            groupBoxBowCrossBow.Controls.Add(radioButtonBow);
            groupBoxBowCrossBow.Location = new Point(32, 67);
            groupBoxBowCrossBow.Name = "groupBoxBowCrossBow";
            groupBoxBowCrossBow.Size = new Size(285, 96);
            groupBoxBowCrossBow.TabIndex = 66;
            groupBoxBowCrossBow.TabStop = false;
            // 
            // radioButtonCrossbow
            // 
            radioButtonCrossbow.AutoSize = true;
            radioButtonCrossbow.CheckAlign = ContentAlignment.BottomCenter;
            radioButtonCrossbow.Font = new Font("Goudy Old Style", 25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonCrossbow.ForeColor = SystemColors.ControlLightLight;
            radioButtonCrossbow.Location = new Point(127, 22);
            radioButtonCrossbow.Name = "radioButtonCrossbow";
            radioButtonCrossbow.Size = new Size(152, 56);
            radioButtonCrossbow.TabIndex = 67;
            radioButtonCrossbow.TabStop = true;
            radioButtonCrossbow.Text = "Crossbow";
            radioButtonCrossbow.UseVisualStyleBackColor = true;
            // 
            // radioButtonBow
            // 
            radioButtonBow.AutoSize = true;
            radioButtonBow.CheckAlign = ContentAlignment.BottomCenter;
            radioButtonBow.Font = new Font("Goudy Old Style", 25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonBow.ForeColor = SystemColors.ControlLightLight;
            radioButtonBow.Location = new Point(16, 22);
            radioButtonBow.Name = "radioButtonBow";
            radioButtonBow.Size = new Size(81, 56);
            radioButtonBow.TabIndex = 67;
            radioButtonBow.TabStop = true;
            radioButtonBow.Text = "Bow";
            radioButtonBow.UseVisualStyleBackColor = true;
            // 
            // CreateArcher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(360, 231);
            Controls.Add(groupBoxBowCrossBow);
            Controls.Add(labelName);
            Controls.Add(saveBtn);
            Controls.Add(backBtn);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateArcher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Archer";
            FormClosed += CreateArcher_FormClosed;
            groupBoxBowCrossBow.ResumeLayout(false);
            groupBoxBowCrossBow.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button saveBtn;
        private Button backBtn;
        private Label labelName;
        private GroupBox groupBoxBowCrossBow;
        private RadioButton radioButtonCrossbow;
        private RadioButton radioButtonBow;
    }
}