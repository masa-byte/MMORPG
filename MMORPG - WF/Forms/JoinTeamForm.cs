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
    public partial class JoinTeamForm : Form
    {
        private bool shouldClose;
        private Player player;
        public JoinTeamForm(Player player)
        {
            InitializeComponent();

            this.player = player;
            this.shouldClose = true;

            listViewJoinableTeams.View = View.Details;

            listViewJoinableTeams.Columns.Add("Id", -2);
            listViewJoinableTeams.Columns.Add("Name", -2);
            listViewJoinableTeams.Columns.Add("Max players", -2);
            listViewJoinableTeams.Columns.Add("Min players", -2);
            listViewJoinableTeams.Columns.Add("Player count", -2);
            listViewJoinableTeams.Columns.Add("Bonus points", -2);
            listViewJoinableTeams.Columns.Add("Placement", -2);

            listViewJoinableTeams.MultiSelect = false;
            listViewJoinableTeams.FullRowSelect = true;

            LoadData();
        }

        private void LoadData()
        {
            listViewJoinableTeams.Items.Clear();

            List<TeamView> teams = DTOManager.ReturnAllJoinableTeams();

            foreach (TeamView team in teams)
            {
                ListViewItem item = new ListViewItem(team.Id.ToString());
                item.SubItems.Add(team.Name);
                item.SubItems.Add(team.MaxPlayers.ToString());
                item.SubItems.Add(team.MinPlayers.ToString());
                item.SubItems.Add(team.PlayerCount.ToString());
                item.SubItems.Add(team.BonusPoints.ToString());
                item.SubItems.Add(team.Placement.ToString());
                listViewJoinableTeams.Items.Add(item);
            }

            listViewJoinableTeams.Refresh();
        }

        private void buttonJoinTeam_Click(object sender, EventArgs e)
        {
            if (listViewJoinableTeams.SelectedIndices.Count != 0)
            {
                int teamId = int.Parse(listViewJoinableTeams.SelectedItems[0].SubItems[0].Text);
                if (DTOManager.JoinTeam(player.Id, teamId))
                {
                    MessageBox.Show("You have joined the team!");
                    shouldClose = false;
                    TeamsForm teamsForm = new TeamsForm(player);
                    teamsForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You could not join the team!");
                }
            }
            else
            {
                MessageBox.Show("You must select a team first!");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            TeamsForm teamsForm = new TeamsForm(player);
            teamsForm.Show();
            this.Close();
        }

        private void JoinTeamForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose == true)
                Application.Exit();
        }
    }
}
