using MMORPG.Entities;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MMORPG.Forms
{
    public partial class SoloRankingsForm : Form
    {
        private bool shouldClose;
        public SoloRankingsForm()
        {
            InitializeComponent();
            shouldClose = true;

            listView.View = View.Details;

            listView.Columns.Add("Id", -2);
            listView.Columns.Add("Nickname", -2);
            listView.Columns.Add("Name", -2);
            listView.Columns.Add("Surname", -2);
            listView.Columns.Add("Age", -2);
            listView.Columns.Add("Gender", -2);
            listView.Columns.Add("Total", -2);

            LoadData();
        }

        private void LoadData()
        {
            listView.Items.Clear();

            List<PlayerView> data = DTOManager.ReturnAllPlayersRanked().ToList();

            foreach (PlayerView p in data)
            {
                double points = DTOManager.ReturnPlayerPoints(p.Id);
                ListViewItem item = new ListViewItem(new[] { p.Id.ToString(), p.Nickname, p.Name, p.Surname, p.Age.ToString(), p.Gender, points.ToString() });
                listView.Items.Add(item);
            }

            listView.Refresh();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            LeaderboardForm leaderboardForm = new LeaderboardForm();
            leaderboardForm.Show();
            this.Close();
        }

        private void SoloRankingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose == true)
                Application.Exit();
        }
    }
}
