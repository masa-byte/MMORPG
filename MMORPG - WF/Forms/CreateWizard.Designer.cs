namespace MMORPG.Forms
{
    partial class CreateWizard
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
            listView = new ListView();
            labelName = new Label();
            labelChooseSpell = new Label();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(153, 91, 216);
            saveBtn.FlatStyle = FlatStyle.Popup;
            saveBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.Location = new Point(201, 482);
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
            backBtn.Location = new Point(12, 482);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(153, 38);
            backBtn.TabIndex = 61;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // listView
            // 
            listView.Alignment = ListViewAlignment.SnapToGrid;
            listView.BackColor = Color.FromArgb(213, 184, 242);
            listView.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listView.FullRowSelect = true;
            listView.Location = new Point(58, 105);
            listView.Margin = new Padding(3, 2, 3, 2);
            listView.MaximumSize = new Size(507, 361);
            listView.Name = "listView";
            listView.Size = new Size(245, 361);
            listView.TabIndex = 63;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.SlateBlue;
            labelName.Location = new Point(37, 9);
            labelName.Name = "labelName";
            labelName.Size = new Size(290, 55);
            labelName.TabIndex = 70;
            labelName.Text = "Create wizard";
            // 
            // labelChooseSpell
            // 
            labelChooseSpell.AutoSize = true;
            labelChooseSpell.Font = new Font("Goudy Old Style", 25F, FontStyle.Regular, GraphicsUnit.Point);
            labelChooseSpell.ForeColor = Color.Snow;
            labelChooseSpell.Location = new Point(46, 64);
            labelChooseSpell.Name = "labelChooseSpell";
            labelChooseSpell.Size = new Size(267, 39);
            labelChooseSpell.TabIndex = 71;
            labelChooseSpell.Text = "Choose your spells";
            // 
            // CreateWizard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(366, 535);
            Controls.Add(labelChooseSpell);
            Controls.Add(labelName);
            Controls.Add(listView);
            Controls.Add(saveBtn);
            Controls.Add(backBtn);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateWizard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Wizard";
            FormClosed += CreateWizard_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button saveBtn;
        private Button backBtn;
        private ListView listView;
        private Label labelName;
        private Label labelChooseSpell;
    }
}