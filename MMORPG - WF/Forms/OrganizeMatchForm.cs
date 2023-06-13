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

    public partial class OrganizeMatchForm : Form
    {
        private bool shouldClose;
        private Player player;
        private TeamView teamView;
        public OrganizeMatchForm(Player player, TeamView teamView)
        {
            InitializeComponent();
            shouldClose = true;
            this.player = player;
            this.teamView = teamView;

            listViewFightableTeams.View = View.Details;

            listViewFightableTeams.Columns.Add("Id", -2);
            listViewFightableTeams.Columns.Add("Name", -2);
            listViewFightableTeams.Columns.Add("Player count", -2);
            listViewFightableTeams.Columns.Add("Bonus points", -2);
            listViewFightableTeams.Columns.Add("Placement", -2);

            listViewFightableTeams.MultiSelect = false;
            listViewFightableTeams.FullRowSelect = true;

            LoadTeams();
        }

        private void LoadTeams()
        {
            listViewFightableTeams.Items.Clear();

            List<TeamView> teams = DTOManager.ReturnAllFightableTeams(teamView);

            foreach (TeamView team in teams)
            {
                ListViewItem item = new ListViewItem(team.Id.ToString());
                item.SubItems.Add(team.Name);
                item.SubItems.Add(team.MaxPlayers.ToString());
                item.SubItems.Add(team.MinPlayers.ToString());
                item.SubItems.Add(team.PlayerCount.ToString());
                item.SubItems.Add(team.BonusPoints.ToString());
                item.SubItems.Add(team.Placement.ToString());
                listViewFightableTeams.Items.Add(item);
            }

            listViewFightableTeams.Refresh();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            TeamsForm teamsForm = new TeamsForm(player);
            teamsForm.Show();
            this.Close();
        }

        private void OrganizeMatchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose)
                Application.Exit();
        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            if (listViewFightableTeams.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a team to fight against.");
                return;
            }
            if (dateTimePickerTimeHeld.Value < DateTime.Now)
            {
                MessageBox.Show("Please select a time in the future.");
                return;
            }
            int opponentTeamId = int.Parse(listViewFightableTeams.SelectedItems[0].SubItems[0].Text);
            TeamView opponentTeamView = DTOManager.ReturnTeam(opponentTeamId);
            if (opponentTeamView == null)
            {
                MessageBox.Show("Team not found.");
                return;
            }
            FightsView fightsView = new FightsView
            {
                Bonus = teamView.BonusPoints + opponentTeamView.BonusPoints,
                TimeHeld = dateTimePickerTimeHeld.Value,
                WinningTeam = null,
                Team1 = teamView,
                Team2 = opponentTeamView
            };
            string response = DTOManager.ScheduleTeamFight(fightsView);
            if (!response.Equals("Error"))
            {
                MessageBox.Show("Fight scheduled.");
                shouldClose = false;
                TeamsForm teamsForm = new TeamsForm(player);
                teamsForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Fight could not be scheduled.");
            }
        }
    }
}

