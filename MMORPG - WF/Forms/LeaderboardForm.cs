using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMORPG.Forms
{
    public partial class LeaderboardForm : Form
    {
        private bool shouldClose;
        public LeaderboardForm()
        {
            InitializeComponent();
            shouldClose = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        private void soloBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            SoloRankingsForm soloRankingsForm = new SoloRankingsForm();
            soloRankingsForm.Show();
            this.Close();
        }

        private void teamBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            TeamRankingsForm teamRankingsForm = new TeamRankingsForm();
            teamRankingsForm.Show();
            this.Close();
        }

        private void LeaderboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose == true) 
                Application.Exit();
        }
    }
}
