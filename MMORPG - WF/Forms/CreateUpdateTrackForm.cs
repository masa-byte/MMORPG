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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MMORPG.Forms
{
    public partial class CreateUpdateTrackForm : Form
    {
        private bool shouldClose;
        private TrackView? track;
        public CreateUpdateTrackForm(int? trackId = null)
        {
            InitializeComponent();
            shouldClose = true;

            if (trackId != null)
            {
                this.track = DTOManager.ReturnTrack((int)trackId);
                if (track == null)
                    throw new ArgumentNullException("Error, track not found in database!");
                textBoxName.Text = this.track.Name;
                if (track.Team.Equals("T"))
                    radioButtonTeam.Checked = true;
                else
                    radioButtonSolo.Checked = true;
                numericUpDownBonusPoints.Value = (decimal)this.track.Bonus;
                foreach (RequiredRaceView requiredRace in this.track.RequiredRaces)
                {
                    switch (requiredRace.RaceName)
                    {
                        case "ELF":
                            checkBoxElf.Checked = true;
                            break;
                        case "DEMON":
                            checkBoxDemon.Checked = true;
                            break;
                        case "DWARF":
                            checkBoxDwarf.Checked = true;
                            break;
                        case "ORC":
                            checkBoxOrc.Checked = true;
                            break;
                        case "HUMAN":
                            checkBoxHuman.Checked = true;
                            break;
                    }
                }
                foreach (RequiredClassView requiredClass in this.track.RequiredClasses)
                {
                    switch (requiredClass.ClassName)
                    {
                        case "THIEF":
                            checkBoxThief.Checked = true;
                            break;
                        case "WIZARD":
                            checkBoxWizard.Checked = true;
                            break;
                        case "FIGHTER":
                            checkBoxFighter.Checked = true;
                            break;
                        case "PRIEST":
                            checkBoxPriest.Checked = true;
                            break;
                        case "DEFENDER":
                            checkBoxDefender.Checked = true;
                            break;
                        case "ARCHER":
                            checkBoxArcher.Checked = true;
                            break;
                    }
                }

            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (textBoxName.TextLength == 0)
            {
                MessageBox.Show("Name field empty!");
                return;
            }

            if (numericUpDownBonusPoints.Value <= 0)
            {
                MessageBox.Show("Invalid bonus! Must be greater than zero.");
                return;
            }

            List<RequiredRaceView> requiredRaces = new List<RequiredRaceView>();

            if (checkBoxElf.Checked)
                requiredRaces.Add(new RequiredRaceView("ELF"));

            if (checkBoxDemon.Checked)
                requiredRaces.Add(new RequiredRaceView("DEMON"));

            if (checkBoxDwarf.Checked)
                requiredRaces.Add(new RequiredRaceView("DWARF"));

            if (checkBoxOrc.Checked)
                requiredRaces.Add(new RequiredRaceView("ORC"));

            if (checkBoxHuman.Checked)
                requiredRaces.Add(new RequiredRaceView("HUMAN"));

            List<RequiredClassView> requiredClasses = new List<RequiredClassView>();

            if (checkBoxThief.Checked)
                requiredClasses.Add(new RequiredClassView("THIEF"));

            if (checkBoxWizard.Checked)
                requiredClasses.Add(new RequiredClassView("WIZARD"));

            if (checkBoxFighter.Checked)
                requiredClasses.Add(new RequiredClassView("FIGHTER"));

            if (checkBoxPriest.Checked)
                requiredClasses.Add(new RequiredClassView("PRIEST"));

            if (checkBoxDefender.Checked)
                requiredClasses.Add(new RequiredClassView("DEFENDER"));

            if (checkBoxArcher.Checked)
                requiredClasses.Add(new RequiredClassView("ARCHER"));

            TrackView trackView = new TrackView()
            {
                Id = this.track?.Id ?? 0,
                Name = textBoxName.Text,
                Bonus = (double)numericUpDownBonusPoints.Value,
                Team = radioButtonTeam.Checked ? 'T' : 'F',
                RequiredRaces = requiredRaces,
                RequiredClasses = requiredClasses
            };

            if (track == null)
            {
                string response = DTOManager.SaveTrack(trackView);
                MessageBox.Show(response);
            }
            else
            {
                string response = DTOManager.UpdateTrack(trackView);
                MessageBox.Show(response);
            }

            shouldClose = false;
            TracksForm tracksForm = new TracksForm();
            tracksForm.Show();
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            TracksForm tracksForm = new TracksForm();
            tracksForm.Show();
            this.Close();
        }

        private void CreateUpdateTrackForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose == true)
                Application.Exit();
        }

        // Changing border color
        private void groupBoxTeamSolo_Paint(object sender, PaintEventArgs e)
        {
            GroupBox? groupBoxTeamSolo = sender as GroupBox;

            if (groupBoxTeamSolo == null)
                return;

            using (var pen = new Pen(Color.FromArgb(0, 35, 15, 104)))
            {
                e.Graphics.Clear(this.BackColor);
                e.Graphics.DrawRectangle(pen, 0, 0, groupBoxTeamSolo.Width - 1, groupBoxTeamSolo.Height - 1);
            }
        }
    }
}
