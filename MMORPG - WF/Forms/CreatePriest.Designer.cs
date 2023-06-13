namespace MMORPG.Forms
{
    partial class CreatePriest
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
            labelChooseBlessing = new Label();
            labelName = new Label();
            listView = new ListView();
            saveBtn = new Button();
            backBtn = new Button();
            checkBoxHeals = new CheckBox();
            textBoxReligion = new TextBox();
            labelReligion = new Label();
            SuspendLayout();
            // 
            // labelChooseBlessing
            // 
            labelChooseBlessing.AutoSize = true;
            labelChooseBlessing.Font = new Font("Goudy Old Style", 25F, FontStyle.Regular, GraphicsUnit.Point);
            labelChooseBlessing.ForeColor = Color.Snow;
            labelChooseBlessing.Location = new Point(12, 85);
            labelChooseBlessing.Name = "labelChooseBlessing";
            labelChooseBlessing.Size = new Size(311, 39);
            labelChooseBlessing.TabIndex = 76;
            labelChooseBlessing.Text = "Choose your blessings";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.SlateBlue;
            labelName.Location = new Point(168, 18);
            labelName.Name = "labelName";
            labelName.Size = new Size(269, 55);
            labelName.TabIndex = 75;
            labelName.Text = "Create priest";
            // 
            // listView
            // 
            listView.Alignment = ListViewAlignment.SnapToGrid;
            listView.BackColor = Color.FromArgb(213, 184, 242);
            listView.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listView.FullRowSelect = true;
            listView.Location = new Point(40, 126);
            listView.Margin = new Padding(3, 2, 3, 2);
            listView.MaximumSize = new Size(507, 361);
            listView.Name = "listView";
            listView.Size = new Size(245, 361);
            listView.TabIndex = 74;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(153, 91, 216);
            saveBtn.FlatStyle = FlatStyle.Popup;
            saveBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.Location = new Point(425, 521);
            saveBtn.Margin = new Padding(3, 2, 3, 2);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(153, 39);
            saveBtn.TabIndex = 73;
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
            backBtn.Location = new Point(12, 521);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(153, 38);
            backBtn.TabIndex = 72;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // checkBoxHeals
            // 
            checkBoxHeals.AutoSize = true;
            checkBoxHeals.CheckAlign = ContentAlignment.BottomCenter;
            checkBoxHeals.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxHeals.ForeColor = Color.BlueViolet;
            checkBoxHeals.Location = new Point(358, 314);
            checkBoxHeals.Name = "checkBoxHeals";
            checkBoxHeals.Size = new Size(152, 73);
            checkBoxHeals.TabIndex = 77;
            checkBoxHeals.Text = "Heals?";
            checkBoxHeals.TextAlign = ContentAlignment.MiddleRight;
            checkBoxHeals.UseVisualStyleBackColor = true;
            // 
            // textBoxReligion
            // 
            textBoxReligion.Font = new Font("Goudy Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxReligion.Location = new Point(292, 223);
            textBoxReligion.Name = "textBoxReligion";
            textBoxReligion.Size = new Size(294, 27);
            textBoxReligion.TabIndex = 79;
            // 
            // labelReligion
            // 
            labelReligion.AutoSize = true;
            labelReligion.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelReligion.ForeColor = Color.SlateBlue;
            labelReligion.Location = new Point(340, 165);
            labelReligion.Name = "labelReligion";
            labelReligion.Size = new Size(188, 55);
            labelReligion.TabIndex = 78;
            labelReligion.Text = "Religion";
            // 
            // CreatePriest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(590, 570);
            Controls.Add(textBoxReligion);
            Controls.Add(labelReligion);
            Controls.Add(checkBoxHeals);
            Controls.Add(labelChooseBlessing);
            Controls.Add(labelName);
            Controls.Add(listView);
            Controls.Add(saveBtn);
            Controls.Add(backBtn);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreatePriest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Priest";
            FormClosed += CreatePriest_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelChooseBlessing;
        private Label labelName;
        private ListView listView;
        private Button saveBtn;
        private Button backBtn;
        private CheckBox checkBoxHeals;
        private TextBox textBoxReligion;
        private Label labelReligion;
    }
}