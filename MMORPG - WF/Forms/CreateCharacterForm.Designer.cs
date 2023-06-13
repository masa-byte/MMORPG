namespace MMORPG.Forms
{
    partial class CreateCharacterForm
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
            backBtn = new Button();
            nextBtn = new Button();
            groupBoxRace = new GroupBox();
            radioButtonHuman = new RadioButton();
            radioButtonOrc = new RadioButton();
            radioButtonDwarf = new RadioButton();
            radioButtonDemon = new RadioButton();
            radioButtonElf = new RadioButton();
            labelWeaponType = new Label();
            listBoxWeaponType = new ListBox();
            labelBonusPoints = new Label();
            numericUpDownBonusPoints = new NumericUpDown();
            textBoxNameAssistant = new TextBox();
            labelNameAssistant = new Label();
            labelEnergyLevel = new Label();
            numericUpDownEnergyLevel = new NumericUpDown();
            labelHidingSkill = new Label();
            numericUpDownHidingSkill = new NumericUpDown();
            groupBoxRace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBonusPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEnergyLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHidingSkill).BeginInit();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.Window;
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.ForeColor = Color.Black;
            backBtn.Location = new Point(12, 395);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(153, 38);
            backBtn.TabIndex = 59;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // nextBtn
            // 
            nextBtn.BackColor = Color.FromArgb(153, 91, 216);
            nextBtn.FlatStyle = FlatStyle.Popup;
            nextBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            nextBtn.Location = new Point(351, 394);
            nextBtn.Margin = new Padding(3, 2, 3, 2);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(153, 39);
            nextBtn.TabIndex = 60;
            nextBtn.Text = "NEXT";
            nextBtn.UseVisualStyleBackColor = false;
            nextBtn.Click += nextBtn_Click;
            // 
            // groupBoxRace
            // 
            groupBoxRace.Controls.Add(radioButtonHuman);
            groupBoxRace.Controls.Add(radioButtonOrc);
            groupBoxRace.Controls.Add(radioButtonDwarf);
            groupBoxRace.Controls.Add(radioButtonDemon);
            groupBoxRace.Controls.Add(radioButtonElf);
            groupBoxRace.ForeColor = Color.FromArgb(35, 15, 104);
            groupBoxRace.ImeMode = ImeMode.Off;
            groupBoxRace.Location = new Point(12, 12);
            groupBoxRace.Name = "groupBoxRace";
            groupBoxRace.Size = new Size(153, 378);
            groupBoxRace.TabIndex = 81;
            groupBoxRace.TabStop = false;
            // 
            // radioButtonHuman
            // 
            radioButtonHuman.AutoSize = true;
            radioButtonHuman.Font = new Font("Goudy Old Style", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonHuman.ForeColor = SystemColors.Control;
            radioButtonHuman.Location = new Point(22, 305);
            radioButtonHuman.Name = "radioButtonHuman";
            radioButtonHuman.Size = new Size(114, 30);
            radioButtonHuman.TabIndex = 82;
            radioButtonHuman.TabStop = true;
            radioButtonHuman.Text = "HUMAN";
            radioButtonHuman.UseVisualStyleBackColor = true;
            radioButtonHuman.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // radioButtonOrc
            // 
            radioButtonOrc.AutoSize = true;
            radioButtonOrc.Font = new Font("Goudy Old Style", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonOrc.ForeColor = SystemColors.Control;
            radioButtonOrc.Location = new Point(22, 231);
            radioButtonOrc.Name = "radioButtonOrc";
            radioButtonOrc.Size = new Size(77, 30);
            radioButtonOrc.TabIndex = 81;
            radioButtonOrc.TabStop = true;
            radioButtonOrc.Text = "ORC";
            radioButtonOrc.UseVisualStyleBackColor = true;
            radioButtonOrc.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // radioButtonDwarf
            // 
            radioButtonDwarf.AutoSize = true;
            radioButtonDwarf.Font = new Font("Goudy Old Style", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonDwarf.ForeColor = SystemColors.Control;
            radioButtonDwarf.Location = new Point(22, 160);
            radioButtonDwarf.Name = "radioButtonDwarf";
            radioButtonDwarf.Size = new Size(107, 30);
            radioButtonDwarf.TabIndex = 80;
            radioButtonDwarf.TabStop = true;
            radioButtonDwarf.Text = "DWARF";
            radioButtonDwarf.UseVisualStyleBackColor = true;
            radioButtonDwarf.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // radioButtonDemon
            // 
            radioButtonDemon.AutoSize = true;
            radioButtonDemon.Font = new Font("Goudy Old Style", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonDemon.ForeColor = SystemColors.Control;
            radioButtonDemon.Location = new Point(22, 90);
            radioButtonDemon.Name = "radioButtonDemon";
            radioButtonDemon.Size = new Size(111, 30);
            radioButtonDemon.TabIndex = 79;
            radioButtonDemon.TabStop = true;
            radioButtonDemon.Text = "DEMON";
            radioButtonDemon.UseVisualStyleBackColor = true;
            radioButtonDemon.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // radioButtonElf
            // 
            radioButtonElf.AutoSize = true;
            radioButtonElf.Font = new Font("Goudy Old Style", 16F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonElf.ForeColor = SystemColors.Control;
            radioButtonElf.Location = new Point(22, 22);
            radioButtonElf.Name = "radioButtonElf";
            radioButtonElf.Size = new Size(66, 30);
            radioButtonElf.TabIndex = 78;
            radioButtonElf.TabStop = true;
            radioButtonElf.Text = "ELF";
            radioButtonElf.UseVisualStyleBackColor = true;
            radioButtonElf.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // labelWeaponType
            // 
            labelWeaponType.AutoSize = true;
            labelWeaponType.Font = new Font("Goudy Old Style", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelWeaponType.ForeColor = Color.Snow;
            labelWeaponType.Location = new Point(171, 77);
            labelWeaponType.Name = "labelWeaponType";
            labelWeaponType.Size = new Size(132, 26);
            labelWeaponType.TabIndex = 83;
            labelWeaponType.Text = "Weapon type:";
            // 
            // listBoxWeaponType
            // 
            listBoxWeaponType.Font = new Font("Goudy Old Style", 16F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxWeaponType.FormattingEnabled = true;
            listBoxWeaponType.ItemHeight = 25;
            listBoxWeaponType.Items.AddRange(new object[] { "HAMMER", "SWORD", "STAFF", "AXE", "BOW", "CROSSBOW", "DAGGER", "MACE", "SPEAR", "FLAIL", "RAPIER", "KATANA", "GREATSWORD", "SCIMITAR", "JAVELIN", "HALBERD", "WHIP", "CLAYMORE", "TRIDENT" });
            listBoxWeaponType.Location = new Point(312, 77);
            listBoxWeaponType.Name = "listBoxWeaponType";
            listBoxWeaponType.Size = new Size(153, 29);
            listBoxWeaponType.TabIndex = 82;
            // 
            // labelBonusPoints
            // 
            labelBonusPoints.AutoSize = true;
            labelBonusPoints.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelBonusPoints.ForeColor = Color.DarkOrchid;
            labelBonusPoints.Location = new Point(186, 259);
            labelBonusPoints.Name = "labelBonusPoints";
            labelBonusPoints.Size = new Size(281, 55);
            labelBonusPoints.TabIndex = 87;
            labelBonusPoints.Text = "Bonus points";
            // 
            // numericUpDownBonusPoints
            // 
            numericUpDownBonusPoints.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownBonusPoints.Location = new Point(214, 326);
            numericUpDownBonusPoints.Name = "numericUpDownBonusPoints";
            numericUpDownBonusPoints.Size = new Size(221, 27);
            numericUpDownBonusPoints.TabIndex = 86;
            // 
            // textBoxNameAssistant
            // 
            textBoxNameAssistant.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNameAssistant.Location = new Point(214, 219);
            textBoxNameAssistant.Name = "textBoxNameAssistant";
            textBoxNameAssistant.Size = new Size(221, 27);
            textBoxNameAssistant.TabIndex = 85;
            // 
            // labelNameAssistant
            // 
            labelNameAssistant.AutoSize = true;
            labelNameAssistant.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelNameAssistant.ForeColor = Color.SlateBlue;
            labelNameAssistant.Location = new Point(171, 161);
            labelNameAssistant.Name = "labelNameAssistant";
            labelNameAssistant.Size = new Size(316, 55);
            labelNameAssistant.TabIndex = 84;
            labelNameAssistant.Text = "Assistant name";
            // 
            // labelEnergyLevel
            // 
            labelEnergyLevel.AutoSize = true;
            labelEnergyLevel.Font = new Font("Goudy Old Style", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelEnergyLevel.ForeColor = Color.Snow;
            labelEnergyLevel.Location = new Point(171, 38);
            labelEnergyLevel.Name = "labelEnergyLevel";
            labelEnergyLevel.Size = new Size(122, 26);
            labelEnergyLevel.TabIndex = 89;
            labelEnergyLevel.Text = "Energy level:";
            // 
            // numericUpDownEnergyLevel
            // 
            numericUpDownEnergyLevel.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownEnergyLevel.Location = new Point(312, 39);
            numericUpDownEnergyLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownEnergyLevel.Name = "numericUpDownEnergyLevel";
            numericUpDownEnergyLevel.Size = new Size(153, 27);
            numericUpDownEnergyLevel.TabIndex = 88;
            numericUpDownEnergyLevel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelHidingSkill
            // 
            labelHidingSkill.AutoSize = true;
            labelHidingSkill.Font = new Font("Goudy Old Style", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelHidingSkill.ForeColor = Color.Snow;
            labelHidingSkill.Location = new Point(171, 117);
            labelHidingSkill.Name = "labelHidingSkill";
            labelHidingSkill.Size = new Size(118, 26);
            labelHidingSkill.TabIndex = 91;
            labelHidingSkill.Text = "HidingSkill:";
            // 
            // numericUpDownHidingSkill
            // 
            numericUpDownHidingSkill.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownHidingSkill.Location = new Point(312, 118);
            numericUpDownHidingSkill.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownHidingSkill.Name = "numericUpDownHidingSkill";
            numericUpDownHidingSkill.Size = new Size(153, 27);
            numericUpDownHidingSkill.TabIndex = 90;
            numericUpDownHidingSkill.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // CreateCharacterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(516, 444);
            Controls.Add(labelHidingSkill);
            Controls.Add(numericUpDownHidingSkill);
            Controls.Add(labelEnergyLevel);
            Controls.Add(numericUpDownEnergyLevel);
            Controls.Add(labelBonusPoints);
            Controls.Add(numericUpDownBonusPoints);
            Controls.Add(textBoxNameAssistant);
            Controls.Add(labelNameAssistant);
            Controls.Add(labelWeaponType);
            Controls.Add(listBoxWeaponType);
            Controls.Add(groupBoxRace);
            Controls.Add(nextBtn);
            Controls.Add(backBtn);
            Name = "CreateCharacterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Character";
            FormClosed += CreateCharacterForm_FormClosed;
            groupBoxRace.ResumeLayout(false);
            groupBoxRace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBonusPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEnergyLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHidingSkill).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button backBtn;
        private Button nextBtn;
        private GroupBox groupBoxRace;
        private RadioButton radioButtonHuman;
        private RadioButton radioButtonOrc;
        private RadioButton radioButtonDwarf;
        private RadioButton radioButtonDemon;
        private RadioButton radioButtonElf;
        private Label labelWeaponType;
        private ListBox listBoxWeaponType;
        private Label labelBonusPoints;
        private NumericUpDown numericUpDownBonusPoints;
        private TextBox textBoxNameAssistant;
        private Label labelNameAssistant;
        private Label labelEnergyLevel;
        private NumericUpDown numericUpDownEnergyLevel;
        private Label labelHidingSkill;
        private NumericUpDown numericUpDownHidingSkill;
    }
}