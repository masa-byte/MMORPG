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
    public partial class CreatePriest : Form
    {
        private bool shouldClose = true;
        private Player player;
        private CreateCharacterView createCharacterView;
        public CreatePriest(Player player, CreateCharacterView createCharacterView)
        {
            InitializeComponent();
            this.player = player;
            this.createCharacterView = createCharacterView;

            listView.FullRowSelect = true;
            listView.MultiSelect = true;
            listView.View = View.Details;

            listView.Columns.Add("Id", -2);
            listView.Columns.Add("Name", -2);

            LoadData();
        }

        private void LoadData()
        {
            listView.Items.Clear();

            List<BlessingView> data = DTOManager.ReturnAllBlessings().ToList();

            foreach (BlessingView b in data)
            {
                ListViewItem item = new ListViewItem(new[] { b.Id.ToString(), b.Name });
                listView.Items.Add(item);
            }

            listView.Refresh();
        }

        private void CreatePriest_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose)
                Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            SelectClassForm selectClassForm = new SelectClassForm(this.player, this.createCharacterView);
            selectClassForm.Show();
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Priest priest = new Priest()
            {
                FatigueLevel = createCharacterView.FatigueLevel,
                HealthLevel = createCharacterView.HealthLevel,
                Experience = createCharacterView.Experience,
                Gold = createCharacterView.Gold,
                Race = createCharacterView.Race,
                EnergyLevel = createCharacterView.EnergyLevel,
                WeaponType = createCharacterView.WeaponType,
                HidingSkill = createCharacterView.HidingSkill,
                Assistant = createCharacterView.Assistant,
                AssistantName = createCharacterView.AssistantName,
                AssistantBonus = createCharacterView.AssistantBonus,
                Religion = textBoxReligion.Text,
                Heals = checkBoxHeals.Checked ? 'T' : 'F',
            };
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one blessing");
                return;
            }
            foreach (ListViewItem item in listView.SelectedItems)
            {
                Blessing blessing = DTOManager.GetBlessing(int.Parse(item.SubItems[0].Text));
                priest.UsesBlessings.Add(new UsesBlessing()
                {
                    Priest = priest,
                    Blessing = blessing
                });
            }
            string response = DTOManager.SaveCharacter(priest, player.Id);
            if (response != "Error")
            {
                MessageBox.Show("Character saved successfully");
                shouldClose = false;
                CharactersForm charactersForm = new CharactersForm(this.player);
                charactersForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error saving character");
            }
        }
    }
}
