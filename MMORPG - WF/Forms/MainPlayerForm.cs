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
    public partial class MainPlayerForm : Form
    {
        private Player player;
        private bool shouldClose;

        public MainPlayerForm(Player player)
        {
            InitializeComponent();

            helloLabel.Text = "Welcome " + DTOManager.TransformText(player.Name);
            this.player = player;
            shouldClose = true;
        }

        private void teamsBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            TeamsForm teamsForm = new TeamsForm(this.player);
            teamsForm.Show();
            this.Close();
        }

        private void gameBtn_Click(object sender, EventArgs e)
        {
            if (!DTOManager.CheckIfCharacterExists(this.player.Id))
            {
                MessageBox.Show("You must have a character made to access this!");
                return;
            }

            shouldClose = false;
            GameForm gameForm = new GameForm(this.player);
            gameForm.Show();
            this.Close();
        }

        private void storeBtn_Click(object sender, EventArgs e)
        {
            if (!DTOManager.CheckIfCharacterExists(this.player.Id))
            {
                MessageBox.Show("You must have a character made to access this!");
                return;
            }

            shouldClose = false;
            StoreForm storeForm = new StoreForm(this.player);
            storeForm.Show();
            this.Close();
        }

        private void characterBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            CharactersForm characterForm = new CharactersForm(this.player);
            characterForm.Show();
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }
        private void MainPlayerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose == true)
                Application.Exit();
        }
    }
}
