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
    public partial class BlessingsForm : Form
    {
        private bool shouldClose;
        public BlessingsForm()
        {
            InitializeComponent();
            shouldClose = true;

            listView.FullRowSelect = true;
            listView.MultiSelect = false;
            listView.View = View.Details;

            listView.Columns.Add("Id", -2);
            listView.Columns.Add("Name", -2);

            if (listView.Items.Count > 0)
            {
                // automatically select first item
                listView.Items[0].Selected = true;
                listView.Select();
            }

            LoadData();
        }

        private void LoadData()
        {
            listView.Items.Clear();

            List<BlessingView> data = DTOManager.ReturnAllBlessings().ToList();

            foreach (BlessingView b in data)
            {
                ListViewItem item = new ListViewItem(new[] { b.Id.ToString(), b.Name });
                listView.Items.Add(item);
            }

            listView.Refresh();
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            CreateUpdateBlessingForm createForm = new CreateUpdateBlessingForm(null);
            createForm.Show();
            this.Close();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                string response = DTOManager.RemoveBlessing(int.Parse(listView.SelectedItems[0].Text));
                LoadData();

                MessageBox.Show(response);
            }
            else
            {
                MessageBox.Show("Please select a blessing to remove!");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                shouldClose = false;
                CreateUpdateBlessingForm updateForm = new CreateUpdateBlessingForm(int.Parse(listView.SelectedItems[0].Text));
                updateForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a blessing to update!");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            AdministratorForm admForm = new AdministratorForm();
            admForm.Show();
            this.Close();
        }
        private void BlessingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose == true)
                Application.Exit();
        }
    }
}
