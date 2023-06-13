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
    public partial class CharactersForm : Form
    {
        private Player player;
        private CharacterView? mainCharacterView;
        private CharacterView? assistantCharacterView;
        private bool shouldClose;

        public CharactersForm(Player player)
        {
            InitializeComponent();
            this.player = player;
            shouldClose = true;

            mainCharacterView = DTOManager.ReturnCharacterForPlayer(player.Id);
            assistantCharacterView = DTOManager.ReturnCharacterForPlayer(player.Id, false);

            if (mainCharacterView == null)
            {
                buttonDeleteCharacter.Enabled = false;
                buttonDeleteCharacter.Visible = false;
            }
            else
            {
                buttonDeleteCharacter.Enabled = true;
                buttonDeleteCharacter.Visible = true;
            }

            LoadCharacterInfo();
        }

        private void LoadCharacterInfo()
        {

            richTextBoxCharacterInfo.Text = "Main character info:\n";
            if (mainCharacterView != null)
            {
                richTextBoxCharacterInfo.Text += $"Class name: {mainCharacterView.ClassName}\n";
                richTextBoxCharacterInfo.Text += $"Race name: {mainCharacterView.RaceName}\n";
                richTextBoxCharacterInfo.Text += $"Gold: {mainCharacterView.Gold}\n";
                richTextBoxCharacterInfo.Text += $"Experience: {mainCharacterView.Exp}";
            }
            else
            {
                richTextBoxCharacterInfo.Text += "You don't have a main character yet!";
            }

            richTextBoxCharacterInfo.Text += "\nAssistant character info:\n";
            if (assistantCharacterView != null)
            {
                richTextBoxCharacterInfo.Text += $"Class name: {assistantCharacterView.ClassName}\n";
                richTextBoxCharacterInfo.Text += $"Race name: {assistantCharacterView.RaceName}\n";
                richTextBoxCharacterInfo.Text += $"Gold: {assistantCharacterView.Gold}\n";
                richTextBoxCharacterInfo.Text += $"Experience: {assistantCharacterView.Exp}";
            }
            else
            {
                richTextBoxCharacterInfo.Text += "You don't have an assistant character yet!";
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            MainPlayerForm mainPlayerForm = new MainPlayerForm(this.player);
            mainPlayerForm.Show();
            this.Close();
        }

        private void CharactersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose)
                Application.Exit();
        }

        private void buttonCreateCharacter_Click(object sender, EventArgs e)
        {
            if (mainCharacterView != null)
            {
                MessageBox.Show("You already have a main character!");
                return;
            }
            shouldClose = false;
            CreateCharacterForm createCharacterForm = new CreateCharacterForm(this.player);
            createCharacterForm.Show();
            this.Close();
        }

        private void buttonDeleteCharacter_Click(object sender, EventArgs e)
        {
            if (mainCharacterView == null)
            {
                MessageBox.Show("Create main character first!");
                return;
            }
            string response = DTOManager.DeleteCharacter(player.Id);
            if (response != "Error")
            {
                MessageBox.Show("Character deleted successfully!");
                mainCharacterView = null;
                assistantCharacterView = null;
                buttonDeleteCharacter.Enabled = false;
                buttonDeleteCharacter.Visible = false;
                LoadCharacterInfo();
            }
            else
            {
                MessageBox.Show("Error while deleting character!");
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (mainCharacterView == null)
            {
                MessageBox.Show("Create main character first!");
                return;
            }
            shouldClose = false;
            CreateCharacterForm createCharacterForm = new CreateCharacterForm(this.player, true);
            createCharacterForm.Show();
            this.Close();
        }
    }
}
