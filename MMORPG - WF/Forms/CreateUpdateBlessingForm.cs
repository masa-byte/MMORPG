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
    public partial class CreateUpdateBlessingForm : Form
    {
        private bool shouldClose;
        private BlessingView? blessing;
        public CreateUpdateBlessingForm(int? blessingId)
        {
            InitializeComponent();
            shouldClose = true;

            if (blessingId != null)
            {
                this.blessing = DTOManager.ReturnBlessing((int)blessingId);

                if (blessing == null)
                    throw new ArgumentNullException("Error, spell not found in database!");

                textBoxName.Text = this.blessing.Name;
            }
            else
                this.blessing = null;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            BlessingsForm blessingsForm = new BlessingsForm();
            blessingsForm.Show();
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length == 0)
            {
                MessageBox.Show("Text box is empty!");
            }
            else
            {
                string response;
                if (blessing != null)
                {
                    this.blessing.Name = textBoxName.Text;
                    response = DTOManager.UpdateBlessing(this.blessing);
                }
                else
                {
                    this.blessing = new BlessingView() { Name = textBoxName.Text };
                    response = DTOManager.SaveBlessing(this.blessing);
                    
                }
                MessageBox.Show(response);

                shouldClose = false;
                BlessingsForm blessingsForm = new BlessingsForm();
                blessingsForm.Show();
                this.Close();
            }
        }

        private void CreateUpdateBlessingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose == true)
                Application.Exit();
        }
    }
}
