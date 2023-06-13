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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace MMORPG.Forms
{
    public partial class CreateCharacterForm : Form
    {
        private bool shouldClose;
        private Player player;
        private CreateCharacterView createCharacterView;
        public CreateCharacterForm(Player player, bool isAssistant = false)
        {
            InitializeComponent();
            this.player = player;
            shouldClose = true;

            createCharacterView = new CreateCharacterView()
            {
                FatigueLevel = 0,
                HealthLevel = 100,
                Experience = 0,
                Gold = 0,
                Race = string.Empty,
                Assistant = isAssistant ? 'T' : 'F',
            };

            labelEnergyLevel.Enabled = false;
            labelEnergyLevel.Visible = false;
            numericUpDownEnergyLevel.Enabled = false;
            numericUpDownEnergyLevel.Visible = false;

            labelWeaponType.Enabled = false;
            labelWeaponType.Visible = false;
            listBoxWeaponType.Enabled = false;
            listBoxWeaponType.Visible = false;

            labelHidingSkill.Enabled = false;
            labelHidingSkill.Visible = false;
            numericUpDownHidingSkill.Enabled = false;
            numericUpDownHidingSkill.Visible = false;

            if (isAssistant)
            {
                labelNameAssistant.Visible = true;
                labelNameAssistant.Enabled = true;
                textBoxNameAssistant.Visible = true;
                textBoxNameAssistant.Enabled = true;
                labelBonusPoints.Enabled = true;
                labelBonusPoints.Visible = true;
                numericUpDownBonusPoints.Enabled = true;
                numericUpDownBonusPoints.Visible = true;
            }
            else
            {
                labelNameAssistant.Visible = false;
                labelNameAssistant.Enabled = false;
                textBoxNameAssistant.Visible = false;
                textBoxNameAssistant.Enabled = false;
                labelBonusPoints.Enabled = false;
                labelBonusPoints.Visible = false;
                numericUpDownBonusPoints.Enabled = false;
                numericUpDownBonusPoints.Visible = false;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            CharactersForm charactersForm = new CharactersForm(this.player);
            charactersForm.Show();
            this.Close();
        }

        private void CreateCharacterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose)
                Application.Exit();
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {

            if (!((RadioButton)sender).Checked)
                return;

            createCharacterView.Race = (sender as RadioButton)?.Text;

            if (radioButtonElf.Checked || radioButtonDemon.Checked)
            {
                labelEnergyLevel.Enabled = true;
                labelEnergyLevel.Visible = true;
                numericUpDownEnergyLevel.Enabled = true;
                numericUpDownEnergyLevel.Visible = true;
            }
            else
            {
                labelEnergyLevel.Enabled = false;
                labelEnergyLevel.Visible = false;
                numericUpDownEnergyLevel.Enabled = false;
                numericUpDownEnergyLevel.Visible = false;
            }

            if (radioButtonDwarf.Checked || radioButtonOrc.Checked)
            {
                labelWeaponType.Enabled = true;
                labelWeaponType.Visible = true;
                listBoxWeaponType.Enabled = true;
                listBoxWeaponType.Visible = true;
            }
            else
            {
                labelWeaponType.Enabled = false;
                labelWeaponType.Visible = false;
                listBoxWeaponType.Enabled = false;
                listBoxWeaponType.Visible = false;
            }

            if (radioButtonHuman.Checked)
            {
                labelHidingSkill.Enabled = true;
                labelHidingSkill.Visible = true;
                numericUpDownHidingSkill.Enabled = true;
                numericUpDownHidingSkill.Visible = true;
            }
            else
            {
                labelHidingSkill.Enabled = false;
                labelHidingSkill.Visible = false;
                numericUpDownHidingSkill.Enabled = false;
                numericUpDownHidingSkill.Visible = false;
            }

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (createCharacterView.Race.Equals(string.Empty))
            {
                MessageBox.Show("Please select race of your character!");
                return;
            }

            if (createCharacterView.Assistant == 'T' && textBoxNameAssistant.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please enter name of your assistant!");
                return;
            }

            createCharacterView.EnergyLevel = labelEnergyLevel.Enabled ?
                (int)numericUpDownEnergyLevel.Value : null;

            createCharacterView.WeaponType = labelWeaponType.Enabled ?
                listBoxWeaponType.SelectedItem?.ToString() : null;

            createCharacterView.HidingSkill = labelHidingSkill.Enabled ?
                (int)numericUpDownHidingSkill.Value : null;

            createCharacterView.AssistantName = labelNameAssistant.Enabled ?
                textBoxNameAssistant.Text : null;

            createCharacterView.AssistantBonus = labelBonusPoints.Enabled ?
                (int)numericUpDownBonusPoints.Value : null;

            shouldClose = false;
            SelectClassForm createCharacterForm = new SelectClassForm(this.player, this.createCharacterView);
            createCharacterForm.Show();
            this.Close();
        }
    }
}
