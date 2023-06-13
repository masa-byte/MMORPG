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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MMORPG.Forms
{
    public partial class GameForm : Form
    {
        private bool shouldClose;
        private Player player;
        Dictionary<int, double> transitions;
        DateTime startTime;
        DateTime endTime;

        public GameForm(Player player)
        {
            InitializeComponent();

            shouldClose = true;
            this.player = player;
            rdbSolo.Checked = true;
            transitions = new Dictionary<int, double>();
            startTime = DateTime.Now;

            comboBoxDifficulty.SelectedIndex = 0;
            LoadSoloTracks();
            LoadTeamTracks();
            FillListViewCharacters();
            FillListViewTeamCharacters();
        }

        private void LoadSoloTracks()
        {
            listViewSolo.View = View.Details;

            listViewSolo.FullRowSelect = true;
            listViewSolo.MultiSelect = false;

            listViewSolo.Columns.Add("Id", -2);
            listViewSolo.Columns.Add("Name", -2);
            listViewSolo.Columns.Add("Bonus", -2);

            listViewSolo.Items.Clear();

            List<TrackView> data = DTOManager.ReturnAllTracks().ToList();

            foreach (TrackView t in data)
            {
                if (t.Team == 'F')
                {
                    ListViewItem item = new ListViewItem(new[]
                {
                    t.Id.ToString(), t.Name, t.Bonus.ToString(),
                    string.Join(", ", t.RequiredRaces.Select(requiredRace => requiredRace.RaceName)),
                    string.Join(", ", t.RequiredClasses.Select(requiredClass => requiredClass.ClassName))
                });
                    listViewSolo.Items.Add(item);
                }
            }

            listViewSolo.Refresh();

            if (listViewSolo.Items.Count > 0)
            {
                listViewSolo.Items[0].Selected = true;
                listViewSolo.Select();
            }
        }

        private void LoadTeamTracks()
        {
            listViewTeam.View = View.Details;

            listViewTeam.FullRowSelect = true;
            listViewTeam.MultiSelect = false;

            listViewTeam.Columns.Add("Id", -2);
            listViewTeam.Columns.Add("Name", -2);
            listViewTeam.Columns.Add("Bonus", -2);

            listViewTeam.Items.Clear();

            List<TrackView> data = DTOManager.ReturnAllTracks().ToList();

            foreach (TrackView t in data)
            {
                if (t.Team == 'T')
                {
                    ListViewItem item = new ListViewItem(new[]
                {
                    t.Id.ToString(), t.Name, t.Bonus.ToString(),
                    string.Join(", ", t.RequiredRaces.Select(requiredRace => requiredRace.RaceName)),
                    string.Join(", ", t.RequiredClasses.Select(requiredClass => requiredClass.ClassName))
                });
                    listViewTeam.Items.Add(item);
                }
            }

            listViewTeam.Refresh();

            if (listViewTeam.Items.Count > 0)
            {
                listViewTeam.Items[0].Selected = true;
                listViewTeam.Select();
            }
        }

        private void FillListViewCharacters()
        {
            listViewCharacter.View = View.Details;

            listViewCharacter.FullRowSelect = true;
            listViewCharacter.MultiSelect = false;

            listViewCharacter.Columns.Add("Id", -2);
            listViewCharacter.Columns.Add("Class", -2);
            listViewCharacter.Columns.Add("Race", -2);
            listViewCharacter.Columns.Add("Gold", -2);
            listViewCharacter.Columns.Add("Exp", -2);

            listViewCharacter.Items.Clear();

            List<CharacterView> data = DTOManager.ReturnAllPlayerCharacters(this.player.Id).ToList();

            foreach (CharacterView c in data)
            {
                ListViewItem item = new ListViewItem(new[]
                {
                    c.Id.ToString(), c.ClassName, c.RaceName, c.Gold.ToString(), c.Exp.ToString()
                });
                listViewCharacter.Items.Add(item);
            }

            listViewCharacter.Refresh();
        }

        private void FillListViewTeamCharacters()
        {
            TeamView teamView = DTOManager.ReturnTeamForPlayer(this.player.Id);
            List<PlayerView> players = teamView != null ?
                DTOManager.ReturnAllPlayersFromTeam(teamView.Id) : new List<PlayerView>();

            listViewTeamChar.View = View.Details;

            listViewTeamChar.FullRowSelect = true;
            listViewTeamChar.MultiSelect = false;

            listViewTeamChar.Columns.Add("Id", -2);
            listViewTeamChar.Columns.Add("Class", -2);
            listViewTeamChar.Columns.Add("Race", -2);
            listViewTeamChar.Columns.Add("Gold", -2);
            listViewTeamChar.Columns.Add("Exp", -2);

            listViewTeamChar.Items.Clear();

            foreach (PlayerView p in players)
            {
                List<CharacterView> data = DTOManager.ReturnAllPlayerCharacters(p.Id).ToList();

                foreach (CharacterView c in data)
                {
                    ListViewItem item = new ListViewItem(new[]
                    {
                    c.Id.ToString(), c.ClassName, c.RaceName, c.Gold.ToString(), c.Exp.ToString()
                    });
                    listViewTeamChar.Items.Add(item);
                }
            }

            listViewTeamChar.Refresh();
        }
        private void playBtn_Click(object sender, EventArgs e)
        {
            if (this.player.Team == null && rdbTeam.Checked == true)
            {
                MessageBox.Show("Join a team first!");
                return;
            }
            if (comboBoxDifficulty.Text.Length == 0)
            {
                MessageBox.Show("Select a difficulty!");
                return;
            }

            int trackId, transitId;
            if (rdbSolo.Checked == true)
                trackId = int.Parse(listViewSolo.SelectedItems[0].Text);
            else
                trackId = int.Parse(listViewTeam.SelectedItems[0].Text);

            string response = DTOManager.PlayGame(this.player.Id, comboBoxDifficulty.Text, trackId);

            if (int.TryParse(response, out transitId))
            {
                transitions.Add(transitId, comboBoxDifficulty.SelectedIndex * 0.5 + 1);
                Transit transit = DTOManager.ReturnTransit(transitId);

                if (rdbTeam.Checked == true)
                {
                    TeamView team = DTOManager.ReturnTeamForPlayer(this.player.Id);

                    team.Placement += transit.EnemiesDefeated * transitions[transitId] + team.BonusPoints;
                }

                if (transit.Successful == 'T')
                    MessageBox.Show("You have successfully completed the game! Enemies defeated : " + transit.EnemiesDefeated);
                else
                    MessageBox.Show("Unfortunately, you failed to complete the game! Enemies defeated : " + transit.EnemiesDefeated);
            }
            else
                MessageBox.Show(response);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            endTime = DateTime.Now;

            if (transitions.Count > 0)
            {
                string response = DTOManager.SaveSession(this.player.Id, transitions, startTime, endTime);
                MessageBox.Show(response);
            }

            shouldClose = false;
            MainPlayerForm mainPlayerForm = new MainPlayerForm(this.player);
            mainPlayerForm.Show();
            this.Close();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose == true)
                Application.Exit();
        }

        private void listViewSolo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSolo.SelectedItems.Count == 0)
                return;
            ListViewItem item = listViewSolo.SelectedItems[0];

            richTextBoxSolo.Text = "";
            if (!item.SubItems[3].Text.Equals(string.Empty))
                richTextBoxSolo.Text += $"Required races: {item.SubItems[3].Text}";
            if (!item.SubItems[4].Text.Equals(string.Empty))
                richTextBoxSolo.Text += $"\nRequired classes: {item.SubItems[4].Text}";
        }

        private void listViewTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTeam.SelectedItems.Count == 0)
                return;
            ListViewItem item = listViewTeam.SelectedItems[0];

            richTextBoxTeam.Text = "";
            if (!item.SubItems[3].Text.Equals(string.Empty))
                richTextBoxTeam.Text += $"Required races: {item.SubItems[3].Text}";
            if (!item.SubItems[4].Text.Equals(string.Empty))
                richTextBoxTeam.Text += $"\nRequired classes: {item.SubItems[4].Text}";
        }

    }
}
