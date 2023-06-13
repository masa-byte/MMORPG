namespace MMORPG.Forms
{
    partial class CreateUpdateTrackForm
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
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            saveBtn = new Button();
            backBtn = new Button();
            labelBonusPoints = new Label();
            numericUpDownBonusPoints = new NumericUpDown();
            textBoxName = new TextBox();
            labelName = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            checkBoxArcher = new CheckBox();
            checkBoxDefender = new CheckBox();
            checkBoxPriest = new CheckBox();
            checkBoxFighter = new CheckBox();
            checkBoxWizard = new CheckBox();
            labelRequiredClasses = new Label();
            checkBoxThief = new CheckBox();
            checkBoxHuman = new CheckBox();
            checkBoxOrc = new CheckBox();
            checkBoxDwarf = new CheckBox();
            checkBoxDemon = new CheckBox();
            labelRequiredRace = new Label();
            checkBoxElf = new CheckBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            radioButtonTeam = new RadioButton();
            radioButtonSolo = new RadioButton();
            groupBoxTeamSolo = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBonusPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            groupBoxTeamSolo.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.white_star;
            pictureBox3.Location = new Point(371, 30);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(89, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.white_star;
            pictureBox2.Location = new Point(78, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.white_star;
            pictureBox1.Location = new Point(12, 240);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(153, 91, 216);
            saveBtn.FlatStyle = FlatStyle.Popup;
            saveBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.Location = new Point(317, 611);
            saveBtn.Margin = new Padding(3, 2, 3, 2);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(153, 39);
            saveBtn.TabIndex = 16;
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
            backBtn.Location = new Point(12, 611);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(153, 38);
            backBtn.TabIndex = 15;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // labelBonusPoints
            // 
            labelBonusPoints.AutoSize = true;
            labelBonusPoints.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelBonusPoints.ForeColor = Color.DarkOrchid;
            labelBonusPoints.Location = new Point(92, 192);
            labelBonusPoints.Name = "labelBonusPoints";
            labelBonusPoints.Size = new Size(281, 55);
            labelBonusPoints.TabIndex = 27;
            labelBonusPoints.Text = "Bonus points";
            // 
            // numericUpDownBonusPoints
            // 
            numericUpDownBonusPoints.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownBonusPoints.Location = new Point(164, 256);
            numericUpDownBonusPoints.Name = "numericUpDownBonusPoints";
            numericUpDownBonusPoints.Size = new Size(120, 27);
            numericUpDownBonusPoints.TabIndex = 26;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(83, 97);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(306, 27);
            textBoxName.TabIndex = 25;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.SlateBlue;
            labelName.Location = new Point(105, 43);
            labelName.Name = "labelName";
            labelName.Size = new Size(259, 55);
            labelName.TabIndex = 24;
            labelName.Text = "Track name";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.white_star;
            pictureBox4.Location = new Point(197, 599);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 60;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.white_star;
            pictureBox5.Location = new Point(371, 543);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(74, 31);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 61;
            pictureBox5.TabStop = false;
            // 
            // checkBoxArcher
            // 
            checkBoxArcher.AutoSize = true;
            checkBoxArcher.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxArcher.ForeColor = SystemColors.ButtonFace;
            checkBoxArcher.Location = new Point(250, 559);
            checkBoxArcher.Name = "checkBoxArcher";
            checkBoxArcher.Size = new Size(74, 25);
            checkBoxArcher.TabIndex = 74;
            checkBoxArcher.Text = "Archer";
            checkBoxArcher.UseVisualStyleBackColor = true;
            // 
            // checkBoxDefender
            // 
            checkBoxDefender.AutoSize = true;
            checkBoxDefender.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxDefender.ForeColor = SystemColors.ButtonFace;
            checkBoxDefender.Location = new Point(250, 528);
            checkBoxDefender.Name = "checkBoxDefender";
            checkBoxDefender.Size = new Size(90, 25);
            checkBoxDefender.TabIndex = 73;
            checkBoxDefender.Text = "Defender";
            checkBoxDefender.UseVisualStyleBackColor = true;
            // 
            // checkBoxPriest
            // 
            checkBoxPriest.AutoSize = true;
            checkBoxPriest.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxPriest.ForeColor = SystemColors.ButtonFace;
            checkBoxPriest.Location = new Point(250, 497);
            checkBoxPriest.Name = "checkBoxPriest";
            checkBoxPriest.Size = new Size(64, 25);
            checkBoxPriest.TabIndex = 72;
            checkBoxPriest.Text = "Priest";
            checkBoxPriest.UseVisualStyleBackColor = true;
            // 
            // checkBoxFighter
            // 
            checkBoxFighter.AutoSize = true;
            checkBoxFighter.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxFighter.ForeColor = SystemColors.ButtonFace;
            checkBoxFighter.Location = new Point(116, 559);
            checkBoxFighter.Name = "checkBoxFighter";
            checkBoxFighter.Size = new Size(75, 25);
            checkBoxFighter.TabIndex = 71;
            checkBoxFighter.Text = "Fighter";
            checkBoxFighter.UseVisualStyleBackColor = true;
            // 
            // checkBoxWizard
            // 
            checkBoxWizard.AutoSize = true;
            checkBoxWizard.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxWizard.ForeColor = SystemColors.ButtonFace;
            checkBoxWizard.Location = new Point(116, 528);
            checkBoxWizard.Name = "checkBoxWizard";
            checkBoxWizard.Size = new Size(74, 25);
            checkBoxWizard.TabIndex = 70;
            checkBoxWizard.Text = "Wizard";
            checkBoxWizard.UseVisualStyleBackColor = true;
            // 
            // labelRequiredClasses
            // 
            labelRequiredClasses.AutoSize = true;
            labelRequiredClasses.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelRequiredClasses.ForeColor = Color.BlueViolet;
            labelRequiredClasses.Location = new Point(67, 439);
            labelRequiredClasses.Name = "labelRequiredClasses";
            labelRequiredClasses.Size = new Size(339, 55);
            labelRequiredClasses.TabIndex = 69;
            labelRequiredClasses.Text = "Required classes";
            // 
            // checkBoxThief
            // 
            checkBoxThief.AutoSize = true;
            checkBoxThief.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxThief.ForeColor = SystemColors.ButtonFace;
            checkBoxThief.Location = new Point(115, 497);
            checkBoxThief.Name = "checkBoxThief";
            checkBoxThief.Size = new Size(64, 25);
            checkBoxThief.TabIndex = 68;
            checkBoxThief.Text = "Thief";
            checkBoxThief.UseVisualStyleBackColor = true;
            // 
            // checkBoxHuman
            // 
            checkBoxHuman.AutoSize = true;
            checkBoxHuman.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxHuman.ForeColor = SystemColors.ButtonFace;
            checkBoxHuman.Location = new Point(248, 392);
            checkBoxHuman.Name = "checkBoxHuman";
            checkBoxHuman.Size = new Size(78, 25);
            checkBoxHuman.TabIndex = 67;
            checkBoxHuman.Text = "Human";
            checkBoxHuman.UseVisualStyleBackColor = true;
            // 
            // checkBoxOrc
            // 
            checkBoxOrc.AutoSize = true;
            checkBoxOrc.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxOrc.ForeColor = SystemColors.ButtonFace;
            checkBoxOrc.Location = new Point(248, 361);
            checkBoxOrc.Name = "checkBoxOrc";
            checkBoxOrc.Size = new Size(54, 25);
            checkBoxOrc.TabIndex = 66;
            checkBoxOrc.Text = "Orc";
            checkBoxOrc.UseVisualStyleBackColor = true;
            // 
            // checkBoxDwarf
            // 
            checkBoxDwarf.AutoSize = true;
            checkBoxDwarf.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxDwarf.ForeColor = SystemColors.ButtonFace;
            checkBoxDwarf.Location = new Point(116, 411);
            checkBoxDwarf.Name = "checkBoxDwarf";
            checkBoxDwarf.Size = new Size(69, 25);
            checkBoxDwarf.TabIndex = 65;
            checkBoxDwarf.Text = "Dwarf";
            checkBoxDwarf.UseVisualStyleBackColor = true;
            // 
            // checkBoxDemon
            // 
            checkBoxDemon.AutoSize = true;
            checkBoxDemon.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxDemon.ForeColor = SystemColors.ButtonFace;
            checkBoxDemon.Location = new Point(115, 380);
            checkBoxDemon.Name = "checkBoxDemon";
            checkBoxDemon.Size = new Size(78, 25);
            checkBoxDemon.TabIndex = 64;
            checkBoxDemon.Text = "Demon";
            checkBoxDemon.UseVisualStyleBackColor = true;
            // 
            // labelRequiredRace
            // 
            labelRequiredRace.AutoSize = true;
            labelRequiredRace.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelRequiredRace.ForeColor = Color.BlueViolet;
            labelRequiredRace.Location = new Point(77, 286);
            labelRequiredRace.Name = "labelRequiredRace";
            labelRequiredRace.Size = new Size(312, 55);
            labelRequiredRace.TabIndex = 63;
            labelRequiredRace.Text = "Required races";
            // 
            // checkBoxElf
            // 
            checkBoxElf.AutoSize = true;
            checkBoxElf.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxElf.ForeColor = SystemColors.ButtonFace;
            checkBoxElf.Location = new Point(115, 349);
            checkBoxElf.Name = "checkBoxElf";
            checkBoxElf.Size = new Size(47, 25);
            checkBoxElf.TabIndex = 62;
            checkBoxElf.Text = "Elf";
            checkBoxElf.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.white_star;
            pictureBox6.Location = new Point(12, 30);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(73, 50);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 75;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.white_star;
            pictureBox7.Location = new Point(371, 411);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(89, 42);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 76;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.white_star;
            pictureBox8.Location = new Point(6, 497);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(48, 25);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 77;
            pictureBox8.TabStop = false;
            // 
            // radioButtonTeam
            // 
            radioButtonTeam.AutoSize = true;
            radioButtonTeam.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonTeam.ForeColor = SystemColors.Control;
            radioButtonTeam.Location = new Point(22, 22);
            radioButtonTeam.Name = "radioButtonTeam";
            radioButtonTeam.Size = new Size(101, 25);
            radioButtonTeam.TabIndex = 78;
            radioButtonTeam.TabStop = true;
            radioButtonTeam.Text = "Team track";
            radioButtonTeam.UseVisualStyleBackColor = true;
            // 
            // radioButtonSolo
            // 
            radioButtonSolo.AutoSize = true;
            radioButtonSolo.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonSolo.ForeColor = SystemColors.Control;
            radioButtonSolo.Location = new Point(189, 22);
            radioButtonSolo.Name = "radioButtonSolo";
            radioButtonSolo.Size = new Size(92, 25);
            radioButtonSolo.TabIndex = 79;
            radioButtonSolo.TabStop = true;
            radioButtonSolo.Text = "Solo track";
            radioButtonSolo.UseVisualStyleBackColor = true;
            // 
            // groupBoxTeamSolo
            // 
            groupBoxTeamSolo.Controls.Add(radioButtonTeam);
            groupBoxTeamSolo.Controls.Add(radioButtonSolo);
            groupBoxTeamSolo.ForeColor = Color.FromArgb(35, 15, 104);
            groupBoxTeamSolo.ImeMode = ImeMode.Off;
            groupBoxTeamSolo.Location = new Point(83, 130);
            groupBoxTeamSolo.Name = "groupBoxTeamSolo";
            groupBoxTeamSolo.Size = new Size(306, 59);
            groupBoxTeamSolo.TabIndex = 80;
            groupBoxTeamSolo.TabStop = false;
            groupBoxTeamSolo.Paint += groupBoxTeamSolo_Paint;
            // 
            // CreateUpdateTrackForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(476, 658);
            Controls.Add(groupBoxTeamSolo);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(checkBoxArcher);
            Controls.Add(checkBoxDefender);
            Controls.Add(checkBoxPriest);
            Controls.Add(checkBoxFighter);
            Controls.Add(checkBoxWizard);
            Controls.Add(labelRequiredClasses);
            Controls.Add(checkBoxThief);
            Controls.Add(checkBoxHuman);
            Controls.Add(checkBoxOrc);
            Controls.Add(checkBoxDwarf);
            Controls.Add(checkBoxDemon);
            Controls.Add(labelRequiredRace);
            Controls.Add(checkBoxElf);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(labelBonusPoints);
            Controls.Add(numericUpDownBonusPoints);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(saveBtn);
            Controls.Add(backBtn);
            MaximizeBox = false;
            MaximumSize = new Size(492, 697);
            MinimizeBox = false;
            MinimumSize = new Size(492, 697);
            Name = "CreateUpdateTrackForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Update Track";
            FormClosed += CreateUpdateTrackForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBonusPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            groupBoxTeamSolo.ResumeLayout(false);
            groupBoxTeamSolo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button saveBtn;
        private Button backBtn;
        private Label labelBonusPoints;
        private NumericUpDown numericUpDownBonusPoints;
        private TextBox textBoxName;
        private Label labelName;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private CheckBox checkBoxArcher;
        private CheckBox checkBoxDefender;
        private CheckBox checkBoxPriest;
        private CheckBox checkBoxFighter;
        private CheckBox checkBoxWizard;
        private Label labelRequiredClasses;
        private CheckBox checkBoxThief;
        private CheckBox checkBoxHuman;
        private CheckBox checkBoxOrc;
        private CheckBox checkBoxDwarf;
        private CheckBox checkBoxDemon;
        private Label labelRequiredRace;
        private CheckBox checkBoxElf;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private RadioButton radioButtonTeam;
        private RadioButton radioButtonSolo;
        private GroupBox groupBoxTeamSolo;
    }
}