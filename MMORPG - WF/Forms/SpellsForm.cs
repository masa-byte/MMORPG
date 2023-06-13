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
    public partial class SpellsForm : Form
    {
        private bool shouldClose;
        public SpellsForm()
        {
            InitializeComponent();
            shouldClose = true;

            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.MultiSelect = false;

            listView.Columns.Add("Id", -2);
            listView.Columns.Add("Name", -2);

            LoadData();

            if (listView.Items.Count > 0)
            {
                // automatically select first item
                listView.Items[0].Selected = true;
                listView.Select();
            }
        }

        private void LoadData()
        {
            listView.Items.Clear();
            List<SpellView> data = DTOManager.ReturnAllSpells().ToList();

            foreach (SpellView s in data)
            {
                ListViewItem item = new ListViewItem(new[] { s.Id.ToString(), s.Name });
                listView.Items.Add(item);
            }
            listView.Refresh();

        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            CreateUpdateSpellForm createForm = new CreateUpdateSpellForm(null);
            createForm.Show();
            this.Close();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                string response = DTOManager.RemoveSpell(int.Parse(listView.SelectedItems[0].Text));
                LoadData();
                MessageBox.Show(response);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                shouldClose = false;
                CreateUpdateSpellForm updateForm = new CreateUpdateSpellForm(int.Parse(listView.SelectedItems[0].Text));
                updateForm.Show();
                this.Close();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            AdministratorForm admForm = new AdministratorForm();
            admForm.Show();
            this.Close();
        }

        private void SpellsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose)
                Application.Exit();
        }
    }
}
