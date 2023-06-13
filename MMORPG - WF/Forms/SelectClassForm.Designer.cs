namespace MMORPG.Forms
{
    partial class SelectClassForm
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
            buttonWizard = new Button();
            buttonFighter = new Button();
            buttonThief = new Button();
            label1 = new Label();
            buttonDefender = new Button();
            buttonArcher = new Button();
            buttonPriest = new Button();
            backBtn = new Button();
            SuspendLayout();
            // 
            // buttonWizard
            // 
            buttonWizard.BackColor = Color.FromArgb(195, 157, 224);
            buttonWizard.FlatStyle = FlatStyle.Popup;
            buttonWizard.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonWizard.Location = new Point(12, 150);
            buttonWizard.Margin = new Padding(3, 2, 3, 2);
            buttonWizard.Name = "buttonWizard";
            buttonWizard.Size = new Size(261, 48);
            buttonWizard.TabIndex = 61;
            buttonWizard.Text = "CREATE WIZARD";
            buttonWizard.UseVisualStyleBackColor = false;
            buttonWizard.Click += buttonWizard_Click;
            // 
            // buttonFighter
            // 
            buttonFighter.BackColor = Color.FromArgb(68, 34, 94);
            buttonFighter.FlatStyle = FlatStyle.Popup;
            buttonFighter.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFighter.ForeColor = SystemColors.ControlLightLight;
            buttonFighter.Location = new Point(12, 227);
            buttonFighter.Margin = new Padding(3, 2, 3, 2);
            buttonFighter.Name = "buttonFighter";
            buttonFighter.Size = new Size(261, 46);
            buttonFighter.TabIndex = 60;
            buttonFighter.Text = "CREATE FIGHTER";
            buttonFighter.UseVisualStyleBackColor = false;
            buttonFighter.Click += buttonFighter_Click;
            // 
            // buttonThief
            // 
            buttonThief.BackColor = Color.White;
            buttonThief.FlatStyle = FlatStyle.Popup;
            buttonThief.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonThief.Location = new Point(12, 76);
            buttonThief.Margin = new Padding(3, 2, 3, 2);
            buttonThief.Name = "buttonThief";
            buttonThief.Size = new Size(261, 46);
            buttonThief.TabIndex = 59;
            buttonThief.Text = "CREATE THIEF";
            buttonThief.UseVisualStyleBackColor = false;
            buttonThief.Click += buttonThief_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Old Style", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(68, 9);
            label1.Name = "label1";
            label1.Size = new Size(449, 55);
            label1.TabIndex = 59;
            label1.Text = "Select Character Class";
            // 
            // buttonDefender
            // 
            buttonDefender.BackColor = Color.FromArgb(195, 157, 224);
            buttonDefender.FlatStyle = FlatStyle.Popup;
            buttonDefender.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDefender.Location = new Point(305, 150);
            buttonDefender.Margin = new Padding(3, 2, 3, 2);
            buttonDefender.Name = "buttonDefender";
            buttonDefender.Size = new Size(261, 48);
            buttonDefender.TabIndex = 64;
            buttonDefender.Text = "CREATE DEFENDER";
            buttonDefender.UseVisualStyleBackColor = false;
            buttonDefender.Click += buttonDefender_Click;
            // 
            // buttonArcher
            // 
            buttonArcher.BackColor = Color.FromArgb(68, 34, 94);
            buttonArcher.FlatStyle = FlatStyle.Popup;
            buttonArcher.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonArcher.ForeColor = SystemColors.ControlLightLight;
            buttonArcher.Location = new Point(305, 227);
            buttonArcher.Margin = new Padding(3, 2, 3, 2);
            buttonArcher.Name = "buttonArcher";
            buttonArcher.Size = new Size(261, 46);
            buttonArcher.TabIndex = 63;
            buttonArcher.Text = "CREATE ARCHER";
            buttonArcher.UseVisualStyleBackColor = false;
            buttonArcher.Click += buttonArcher_Click;
            // 
            // buttonPriest
            // 
            buttonPriest.BackColor = Color.White;
            buttonPriest.FlatStyle = FlatStyle.Popup;
            buttonPriest.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPriest.Location = new Point(305, 76);
            buttonPriest.Margin = new Padding(3, 2, 3, 2);
            buttonPriest.Name = "buttonPriest";
            buttonPriest.Size = new Size(261, 46);
            buttonPriest.TabIndex = 62;
            buttonPriest.Text = "CREATE PRIEST";
            buttonPriest.UseVisualStyleBackColor = false;
            buttonPriest.Click += buttonPriest_Click;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(47, 12, 74);
            backBtn.FlatStyle = FlatStyle.Popup;
            backBtn.Font = new Font("Goudy Old Style", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.ForeColor = SystemColors.ControlLightLight;
            backBtn.Location = new Point(158, 290);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(261, 46);
            backBtn.TabIndex = 65;
            backBtn.Text = "BACK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // SelectClassForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 15, 104);
            ClientSize = new Size(579, 348);
            Controls.Add(backBtn);
            Controls.Add(buttonDefender);
            Controls.Add(buttonArcher);
            Controls.Add(buttonPriest);
            Controls.Add(label1);
            Controls.Add(buttonWizard);
            Controls.Add(buttonFighter);
            Controls.Add(buttonThief);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SelectClassForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Select Class";
            FormClosed += SelectClassForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonWizard;
        private Button buttonFighter;
        private Button buttonThief;
        private Label label1;
        private Button buttonDefender;
        private Button buttonArcher;
        private Button buttonPriest;
        private Button backBtn;
    }
}