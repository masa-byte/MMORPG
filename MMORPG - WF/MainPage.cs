using MMORPG.Forms;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMORPG
{
    public partial class MainPage : Form
    {
        private bool shouldClose = true;
        public MainPage()
        {
            InitializeComponent();
            shouldClose = true;

            DTOManager.ExecuteAllPendingTeamFights();

            ISession s = DataLayer.GetSession();
            s.Flush();
            s.Close();
        }

        private void leaderboardBtn_Click(object sender, EventArgs e)
        {
            LeaderboardForm leaderboardForm = new LeaderboardForm();
            leaderboardForm.Show();
            this.Hide();
        }

        private void playerBtn_Click(object sender, EventArgs e)
        {
            PlayerForm playerForm = new PlayerForm();
            playerForm.Show();
            this.Hide();
        }

        private void administratorsBtn_Click(object sender, EventArgs e)
        {
            AdministratorForm administratorForm = new AdministratorForm();
            administratorForm.Show();
            this.Hide();
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (shouldClose == true)
                Application.Exit();
        }
    }
}
