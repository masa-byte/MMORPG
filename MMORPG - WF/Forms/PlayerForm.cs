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
    public partial class PlayerForm : Form
    {
        private bool shouldClose;
        public PlayerForm()
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

        private void signInBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
            this.Close();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Close();
        }
        private void PlayerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (shouldClose)
                Application.Exit();
        }
    }
}
