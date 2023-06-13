using MMORPG.Entities;
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
    public partial class CreateTeamForm : Form
    {
        private bool shouldClose;
        private Player player;
        public CreateTeamForm(Player player)
        {
            InitializeComponent();
            shouldClose = true;
            this.player = player;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            TeamsForm teamsForm = new TeamsForm(player);
            teamsForm.Show();
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length == 0)
            {
                MessageBox.Show("Name field can't be empty!");
                return;
            }
            TeamView teamView = new TeamView();
            teamView.Name = textBoxName.Text;
            teamView.MaxPlayers = (int)numericUpDownMaxPlayers.Value;
            teamView.MinPlayers = (int)numericUpDownMinPlayers.Value;
            teamView.BonusPoints = (int)numericUpDownBonusPoints.Value;

            string response = DTOManager.SaveTeam(teamView);
            if (response == "Team successfully created!")
            {
                MessageBox.Show("Team created successfully!");
                shouldClose = false;
                TeamsForm teamsForm = new TeamsForm(player);
                teamsForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(response);
            }
        }

        private void CreateUpdateTeamForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose == true)
                Application.Exit();
        }
    }
}
