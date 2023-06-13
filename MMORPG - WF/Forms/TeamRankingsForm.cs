using MMORPG.Entities;
using NHibernate.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MMORPG.Forms
{
    public partial class TeamRankingsForm : Form
    {
        private bool shouldClose;
        public TeamRankingsForm()
        {
            InitializeComponent();
            shouldClose = true;

            listView.View = View.Details;
            listView.Columns.Add("Id", -2);
            listView.Columns.Add("Name", -2);
            listView.Columns.Add("Bonus points", -2);
            listView.Columns.Add("Total points", -2);

            playerView.View = View.Details;
            playerView.Columns.Add("Id");
            playerView.Columns.Add("Nickname");
            playerView.Columns.Add("Age");
            playerView.Columns.Add("Gender");

            playerView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            LoadData();
        }

        private void LoadData()
        {
            listView.Items.Clear();

            // placement is points
            // for initial load, our dummy teams need to have their points calculated with pre-added transitions
            List<TeamView> data = DTOManager.ReturnAllTeamsRanked().ToList();

            foreach (TeamView t in data)
            {            
                ListViewItem item = new ListViewItem(new[] { t.Id.ToString(), t.Name, t.BonusPoints.ToString(), t.Placement.ToString()});
                listView.Items.Add(item);
            }

            listView.Refresh();
        }

        private void LoadPlayers(int teamId)
        {
            playerView.Items.Clear();

            List<PlayerView> data = DTOManager.ReturnAllPlayersFromTeam(teamId).ToList();

            foreach (PlayerView p in data)
            {
                ListViewItem item = new ListViewItem(new[] { p.Id.ToString(), p.Nickname, p.Age.ToString(), p.Gender });
                playerView.Items.Add(item);

            }

            playerView.Refresh();
            foreach (ColumnHeader column in playerView.Columns)
                column.Width = -2;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            LeaderboardForm leaderboardForm = new LeaderboardForm();
            leaderboardForm.Show();
            this.Close();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                LoadPlayers(int.Parse(listView.SelectedItems[0].Text));
            }
        }

        private void TeamRankingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose == true)
                Application.Exit();
        }
    }
}
