namespace MMORPG.Forms
{
    partial class OrganizeMatchForm
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
            labelClash = new Label();
            listViewFightableTeams = new ListView();
            buttonSchedule = new Button();
            dateTimePickerTimeHeld = new DateTimePicker();
            labelPickYourOpponent = new Label();
            labelDate = new Label();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.Window;
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.ForeColor = Color.Black;
            backBtn.Location = new Point(12, 372);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(153, 38);
            backBtn.TabIndex = 57;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // labelClash
            // 
            labelClash.AutoSize = true;
            labelClash.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelClash.ForeColor = Color.Snow;
            labelClash.Location = new Point(30, 9);
            labelClash.Name = "labelClash";
            labelClash.Size = new Size(557, 55);
            labelClash.TabIndex = 58;
            labelClash.Text = "SET UP A TEAM CLASH!";
            // 
            // listViewFightableTeams
            // 
            listViewFightableTeams.Alignment = ListViewAlignment.SnapToGrid;
            listViewFightableTeams.BackColor = Color.FromArgb(213, 184, 242);
            listViewFightableTeams.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listViewFightableTeams.FullRowSelect = true;
            listViewFightableTeams.Location = new Point(12, 98);
            listViewFightableTeams.Margin = new Padding(3, 2, 3, 2);
            listViewFightableTeams.Name = "listViewFightableTeams";
            listViewFightableTeams.Size = new Size(595, 178);
            listViewFightableTeams.TabIndex = 59;
            listViewFightableTeams.UseCompatibleStateImageBehavior = false;
            listViewFightableTeams.View = View.Details;
            // 
            // buttonSchedule
            // 
            buttonSchedule.BackColor = Color.FromArgb(153, 91, 216);
            buttonSchedule.FlatStyle = FlatStyle.Popup;
            buttonSchedule.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSchedule.Location = new Point(454, 372);
            buttonSchedule.Margin = new Padding(3, 2, 3, 2);
            buttonSchedule.Name = "buttonSchedule";
            buttonSchedule.Size = new Size(153, 39);
            buttonSchedule.TabIndex = 60;
            buttonSchedule.Text = "SCHEDULE";
            buttonSchedule.UseVisualStyleBackColor = false;
            buttonSchedule.Click += buttonSchedule_Click;
            // 
            // dateTimePickerTimeHeld
            // 
            dateTimePickerTimeHeld.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePickerTimeHeld.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerTimeHeld.Format = DateTimePickerFormat.Custom;
            dateTimePickerTimeHeld.Location = new Point(208, 313);
            dateTimePickerTimeHeld.Name = "dateTimePickerTimeHeld";
            dateTimePickerTimeHeld.Size = new Size(186, 27);
            dateTimePickerTimeHeld.TabIndex = 61;
            // 
            // labelPickYourOpponent
            // 
            labelPickYourOpponent.AutoSize = true;
            labelPickYourOpponent.Font = new Font("Goudy Old Style", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelPickYourOpponent.ForeColor = Color.Snow;
            labelPickYourOpponent.Location = new Point(184, 64);
            labelPickYourOpponent.Name = "labelPickYourOpponent";
            labelPickYourOpponent.Size = new Size(235, 32);
            labelPickYourOpponent.TabIndex = 62;
            labelPickYourOpponent.Text = "Pick your opponent";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Goudy Old Style", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelDate.ForeColor = Color.Snow;
            labelDate.Location = new Point(234, 278);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(136, 32);
            labelDate.TabIndex = 63;
            labelDate.Text = "Pick a date";
            // 
            // OrganizeMatchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(619, 421);
            Controls.Add(labelDate);
            Controls.Add(labelPickYourOpponent);
            Controls.Add(dateTimePickerTimeHeld);
            Controls.Add(buttonSchedule);
            Controls.Add(listViewFightableTeams);
            Controls.Add(labelClash);
            Controls.Add(backBtn);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OrganizeMatchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Organize Match";
            FormClosed += OrganizeMatchForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backBtn;
        private Label labelClash;
        private ListView listViewFightableTeams;
        private Button buttonSchedule;
        private DateTimePicker dateTimePickerTimeHeld;
        private Label labelPickYourOpponent;
        private Label labelDate;
    }
}