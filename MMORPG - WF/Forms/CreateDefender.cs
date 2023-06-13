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
    public partial class CreateDefender : Form
    {
        private bool shouldClose = true;
        private Player player;
        private CreateCharacterView createCharacterView;
        public CreateDefender(Player player, CreateCharacterView createCharacterView)
        {
            InitializeComponent();
            this.player = player;
            this.createCharacterView = createCharacterView;
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
            Defender defender = new Defender()
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
                MaxArmourWeight = (double)numericUpDownMaxArmourWeight.Value,
            };
            string response = DTOManager.SaveCharacter(defender, player.Id);
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

        private void CreateDefender_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose)
                Application.Exit();
        }
    }
}
