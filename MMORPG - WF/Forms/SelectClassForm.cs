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
    public partial class SelectClassForm : Form
    {
        private bool shouldClose;
        private Player player;
        private CreateCharacterView createCharacterView;

        public SelectClassForm(Player player, CreateCharacterView createCharacterView)
        {
            InitializeComponent();
            shouldClose = true;
            this.player = player;
            this.createCharacterView = createCharacterView;
        }

        private void buttonThief_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            CreateThief createThief = new CreateThief(this.player, this.createCharacterView);
            createThief.Show();
            this.Close();
        }

        private void buttonWizard_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            CreateWizard createWizard = new CreateWizard(this.player, this.createCharacterView);
            createWizard.Show();
            this.Close();
        }

        private void buttonFighter_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            CreateFighter createFighter = new CreateFighter(this.player, this.createCharacterView);
            createFighter.Show();
            this.Close();
        }

        private void buttonPriest_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            CreatePriest createPriest = new CreatePriest(this.player, this.createCharacterView);
            createPriest.Show();
            this.Close();
        }

        private void buttonDefender_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            CreateDefender createDefender = new CreateDefender(this.player, this.createCharacterView);
            createDefender.Show();
            this.Close();
        }

        private void buttonArcher_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            CreateArcher createArcher = new CreateArcher(this.player, this.createCharacterView);
            createArcher.Show();
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            CreateCharacterForm createCharacterForm = new CreateCharacterForm(this.player, createCharacterView.Assistant == 'T');
            createCharacterForm.Show();
            this.Close();
        }

        private void SelectClassForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose)
                Application.Exit();
        }
    }


}
