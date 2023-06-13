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
    public partial class AdministratorForm : Form
    {
        private bool shouldClose;
        public AdministratorForm()
        {
            InitializeComponent();
            shouldClose = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        private void blessingsBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            BlessingsForm blessingsForm = new BlessingsForm();
            blessingsForm.Show();
            this.Close();
        }

        private void itemsBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            ItemsForm itemsForm = new ItemsForm();
            itemsForm.Show();
            this.Close();
        }

        private void tracksBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            TracksForm tracksForm = new TracksForm();
            tracksForm.Show();
            this.Close();
        }

        private void spellsBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            SpellsForm spellsForm = new SpellsForm();
            spellsForm.Show();
            this.Close();
        }

        private void AdministratorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose == true)
                Application.Exit();
        }
    }
}
