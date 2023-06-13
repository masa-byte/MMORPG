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
    public partial class SignInForm : Form
    {
        private bool shouldClose;
        public SignInForm()
        {
            InitializeComponent();
            shouldClose = true;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            PlayerForm playerForm = new PlayerForm();
            playerForm.Show();
            this.Close();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (txtBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("Password field can't be empty!");
                return;
            }
            if (txtBoxNick.Text.Length == 0)
            {
                MessageBox.Show("Username field can't be empty!");
                return;
            }

            Player player = DTOManager.SignInPlayer(txtBoxNick.Text, txtBoxPassword.Text);

            if (player != null)
            {
                shouldClose = false;
                MainPlayerForm mainPlayerForm = new MainPlayerForm(player);
                mainPlayerForm.Show();
                this.Close();
            }
            else
                MessageBox.Show("Invalid credentials!");
        }

        private void SignInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose == true)
                Application.Exit();
        }
    }
}
