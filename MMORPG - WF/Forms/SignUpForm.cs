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
    public partial class SignUpForm : Form
    {
        private bool shouldClose;

        public SignUpForm()
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
            if (txtBoxName.TextLength == 0)
            {
                MessageBox.Show("Name field empty!");
                return;
            }
            if (txtBoxSurname.TextLength == 0)
            {
                MessageBox.Show("Surname field empty!");
                return;
            }
            if (numUpDownAge.Value < 18)
            {
                MessageBox.Show("Invalid age. Must be at least 18 years old!");
                return;
            }
            if (txtBoxPassword.Text.Length == 0)
            {
                MessageBox.Show("Password field empty!");
                return;
            }
            if (txtBoxNick.Text.Length == 0)
            {
                MessageBox.Show("Username field empty!");
                return;
            }
            if (comboBoxGender.Text.Length == 0)
            {
                MessageBox.Show("Gender field empty!")
                    ;
                return;
            }

            bool checkNicknameUnique = DTOManager.CheckNicknameUnique(txtBoxNick.Text);
            if (checkNicknameUnique == false)
            {
                MessageBox.Show("This nickname already exists! Please choose another one or sign in if it's yours!");
                return;
            }

            PlayerView playerView = new PlayerView(0, txtBoxNick.Text, txtBoxName.Text, txtBoxSurname.Text, comboBoxGender.Text, (int)numUpDownAge.Value);

            Player player = DTOManager.SignUpPlayer(playerView, txtBoxPassword.Text);

            shouldClose = false;
            MainPlayerForm mainPlayerForm = new MainPlayerForm(player);
            mainPlayerForm.Show();
            this.Close();
        }

        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose == true)
                Application.Exit();
        }
    }
}
