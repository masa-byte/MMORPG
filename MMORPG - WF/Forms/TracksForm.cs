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
    public partial class TracksForm : Form
    {
        private bool shouldClose;
        public TracksForm()
        {
            InitializeComponent();
            shouldClose = true;

            listView.View = View.Details;

            listView.FullRowSelect = true;
            listView.MultiSelect = false;

            listView.Columns.Add("Id", -2);
            listView.Columns.Add("Name", -2);
            listView.Columns.Add("Team", -2);
            listView.Columns.Add("Bonus", -2);

            LoadData();
        }

        private void LoadData()
        {
            listView.Items.Clear();

            List<TrackView> data = DTOManager.ReturnAllTracks().ToList();

            foreach (TrackView t in data)
            {
                ListViewItem item = new ListViewItem(new[]
                {
                    t.Id.ToString(), t.Name, t.Team.ToString(), t.Bonus.ToString(),
                    string.Join(", ", t.RequiredRaces.Select(requiredRace => requiredRace.RaceName)),
                    string.Join(", ", t.RequiredClasses.Select(requiredClass => requiredClass.ClassName))
                });
                listView.Items.Add(item);
            }

            if (listView.Items.Count > 0)
            {
                // automatically select first item
                listView.Items[0].Selected = true;
                listView.Select();
            }

            listView.Refresh();
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            CreateUpdateTrackForm createUpdateTrackForm = new CreateUpdateTrackForm();
            createUpdateTrackForm.Show();
            this.Close();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                string response = DTOManager.RemoveTrack(int.Parse(listView.SelectedItems[0].Text));
                LoadData();
                MessageBox.Show(response);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                shouldClose = false;
                CreateUpdateTrackForm updateForm = new CreateUpdateTrackForm(int.Parse(listView.SelectedItems[0].Text));
                updateForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select track to update!");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            AdministratorForm admForm = new AdministratorForm();
            admForm.Show();
            this.Close();
        }

        private void TracksForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose)
                Application.Exit();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
                return;
            ListViewItem track = listView.SelectedItems[0];

            richTextBox.Text = string.Empty;

            if (!track.SubItems[4].Text.Equals(string.Empty))
                richTextBox.Text = $"Required races: {track.SubItems[4].Text}\n";
            if (!track.SubItems[5].Text.Equals(string.Empty))
                richTextBox.Text += $"Required classes: {track.SubItems[5].Text}";

            if (richTextBox.Text.Equals(string.Empty))
                richTextBox.Text = "No requirements.";
        }
    }
}
