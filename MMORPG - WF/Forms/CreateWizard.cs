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
    public partial class CreateWizard : Form
    {
        private bool shouldClose = true;
        private Player player;
        private CreateCharacterView createCharacterView;
        public CreateWizard(Player player, CreateCharacterView createCharacterView)
        {
            InitializeComponent();
            this.player = player;
            this.createCharacterView = createCharacterView;

            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.MultiSelect = true;

            listView.Columns.Add("Id", -2);
            listView.Columns.Add("Name", -2);

            LoadData();
        }

        private void LoadData()
        {
            listView.Items.Clear();
            List<SpellView> data = DTOManager.ReturnAllSpells().ToList();
            foreach (SpellView s in data)
            {
                ListViewItem item = new ListViewItem(new[] { s.Id.ToString(), s.Name });
                listView.Items.Add(item);
            }
            listView.Refresh();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            SelectClassForm selectClassForm = new SelectClassForm(this.player, this.createCharacterView);
            selectClassForm.Show();
            this.Close();
        }

        private void CreateWizard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose)
                Application.Exit();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Wizard wizard = new Wizard()
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
            };
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one spell");
                return;
            }
            foreach (ListViewItem item in listView.SelectedItems)
            {
                Spell spell = DTOManager.GetSpell(int.Parse(item.SubItems[0].Text));
                wizard.CastsSpells.Add(new CastsSpell()
                {
                    Wizard = wizard,
                    Spell = spell
                });
            }
            string response = DTOManager.SaveCharacter(wizard, player.Id);
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
