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
    public partial class TeamsForm : Form
    {
        private Player player;
        private TeamView teamView;
        private bool shouldClose;

        public TeamsForm(Player player, TeamView? teamView = null)
        {
            InitializeComponent();
            this.player = player;
            shouldClose = true;

            if (teamView == null)
            {
                this.teamView = DTOManager.ReturnTeamForPlayer(player.Id);
            }
            else
            {
                this.teamView = teamView;
            }
            LoadCurrentTeamInfo();
        }

        private void LoadCurrentTeamInfo()
        {
            richTextBoxTeamInfo.Text = string.Empty;
            if (teamView != null)
            {
                richTextBoxTeamInfo.Text = $"Team name: {teamView.Name}\n";
                richTextBoxTeamInfo.Text += $"Max players: {teamView.MaxPlayers}\n";
                richTextBoxTeamInfo.Text += $"Min players: {teamView.MinPlayers}\n";
                richTextBoxTeamInfo.Text += $"Current players: {teamView.PlayerCount}\n";
                richTextBoxTeamInfo.Text += $"Bonus points: {teamView.BonusPoints}\n";
                richTextBoxTeamInfo.Text += $"Placement: {teamView.Placement}";
                buttonLeaveCurrentTeam.Enabled = true;
                buttonLeaveCurrentTeam.Visible = true;
            }
            else
            {
                richTextBoxTeamInfo.Text = "You are not in a team!";
                buttonLeaveCurrentTeam.Enabled = false;
                buttonLeaveCurrentTeam.Visible = false;
            }
        }

        private void buttonCreateTeam_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            CreateTeamForm createTeamForm = new CreateTeamForm(player);
            createTeamForm.Show();
            this.Close();
        }

        private void buttonJoinTeam_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            JoinTeamForm joinTeamForm = new JoinTeamForm(player);
            joinTeamForm.Show();
            this.Close();
        }

        private void buttonOrganizeMatch_Click(object sender, EventArgs e)
        {
            if (teamView == null)
            {
                MessageBox.Show("Join a team first!");
                return;
            }
            if (teamView.PlayerCount < teamView.MinPlayers)
            {
                MessageBox.Show("Your team is too weak, more players need to join!");
                return;
            }
            shouldClose = false;
            OrganizeMatchForm organizeMatchForm = new OrganizeMatchForm(player, teamView);
            organizeMatchForm.Show();
            this.Close();
        }

        private void TeamsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose == true)
                Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            MainPlayerForm mainPlayerForm = new MainPlayerForm(this.player);
            mainPlayerForm.Show();
            this.Close();
        }

        private void buttonLeaveCurrentTeam_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to leave {teamView.Name}?", "Leave team", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("You have left the team!");
                teamView = null;
                DTOManager.LeaveTeam(player.Id);
                buttonLeaveCurrentTeam.Enabled = false;
                buttonLeaveCurrentTeam.Visible = false;
                LoadCurrentTeamInfo();
            }
        }
    }
}
