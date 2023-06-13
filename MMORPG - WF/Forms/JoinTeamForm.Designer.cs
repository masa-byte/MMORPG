namespace MMORPG.Forms
{
    partial class JoinTeamForm
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
            buttonJoinTeam = new Button();
            backBtn = new Button();
            listViewJoinableTeams = new ListView();
            SuspendLayout();
            // 
            // buttonJoinTeam
            // 
            buttonJoinTeam.BackColor = Color.FromArgb(153, 91, 216);
            buttonJoinTeam.FlatStyle = FlatStyle.Popup;
            buttonJoinTeam.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonJoinTeam.Location = new Point(410, 401);
            buttonJoinTeam.Margin = new Padding(3, 2, 3, 2);
            buttonJoinTeam.Name = "buttonJoinTeam";
            buttonJoinTeam.Size = new Size(153, 39);
            buttonJoinTeam.TabIndex = 37;
            buttonJoinTeam.Text = "JOIN";
            buttonJoinTeam.UseVisualStyleBackColor = false;
            buttonJoinTeam.Click += buttonJoinTeam_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = SystemColors.Window;
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.ForeColor = Color.Black;
            backBtn.Location = new Point(12, 401);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(153, 38);
            backBtn.TabIndex = 36;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // listViewJoinableTeams
            // 
            listViewJoinableTeams.Alignment = ListViewAlignment.SnapToGrid;
            listViewJoinableTeams.BackColor = Color.FromArgb(213, 184, 242);
            listViewJoinableTeams.Font = new Font("Goudy Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listViewJoinableTeams.FullRowSelect = true;
            listViewJoinableTeams.Location = new Point(12, 38);
            listViewJoinableTeams.Margin = new Padding(3, 2, 3, 2);
            listViewJoinableTeams.Name = "listViewJoinableTeams";
            listViewJoinableTeams.Size = new Size(551, 306);
            listViewJoinableTeams.TabIndex = 38;
            listViewJoinableTeams.UseCompatibleStateImageBehavior = false;
            listViewJoinableTeams.View = View.Details;
            // 
            // JoinTeamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(574, 450);
            Controls.Add(listViewJoinableTeams);
            Controls.Add(buttonJoinTeam);
            Controls.Add(backBtn);
            Name = "JoinTeamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Join Team";
            FormClosed += JoinTeamForm_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonJoinTeam;
        private Button backBtn;
        private ListView listViewJoinableTeams;
    }
}