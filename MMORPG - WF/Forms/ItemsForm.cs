using NHibernate.Util;
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
    public partial class ItemsForm : Form
    {
        public bool shouldClose;
        public ItemsForm()
        {
            InitializeComponent();
            shouldClose = true;

            listView.View = View.Details;

            listView.FullRowSelect = true;
            listView.MultiSelect = false;

            listView.Columns.Add("Id", -2);
            listView.Columns.Add("Name", -2);
            listView.Columns.Add("Bonus Points", -2);
            listView.Columns.Add("Price", -2);
            listView.Columns.Add("Exp needed", -2);

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

            List<ItemView> data = DTOManager.ReturnAllItems().ToList();

            foreach (ItemView i in data)
            {
                ListViewItem item = new ListViewItem(new[]
                {
                    i.Id.ToString(), i.Name, i.BonusPoints.ToString(), i.Price.ToString(), i.ExpNeeded.ToString(),
                    i.Description, i.Weapon.ToString(), i.WeaponType,
                    i.AttackPoints.ToString(), i.Armour.ToString(), i.DefensePoints.ToString(),
                    string.Join(", ", i.AllowedRaces.Select(allowedRace => allowedRace.RaceName)),
                    string.Join(", ", i.AllowedClasses.Select(allowedClass => allowedClass.ClassName))
                });
                listView.Items.Add(item);
            }

            listView.Refresh();
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            CreateUpdateItemForm createUpdateItemForm = new CreateUpdateItemForm();
            createUpdateItemForm.Show();
            this.Close();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                bool successful = DTOManager.RemoveItem(int.Parse(listView.SelectedItems[0].Text));
                LoadData();
                if (successful == true)
                    MessageBox.Show("Successful!");
                else
                    MessageBox.Show("Unsuccessful!");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                shouldClose = false;
                CreateUpdateItemForm updateForm = new CreateUpdateItemForm(int.Parse(listView.SelectedItems[0].Text));
                updateForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select item to update!");
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            AdministratorForm admForm = new AdministratorForm();
            admForm.Show();
            this.Close();
        }

        private void ItemsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose)
                Application.Exit();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
                return;
            ListViewItem item = listView.SelectedItems[0];

            // Potential fix:
            // not really a great solution hardcoding
            // indices, should have created custom ListViewItem
            // derived from ListViewItem, and added custom properties
            richTextBox.Text = $"Item description: \"{item.SubItems[5].Text}.\"";
            if (item.SubItems[6].Text.Equals("T"))
                richTextBox.Text += string.Format("\nWeapon type: {0}\nAttack points: {1}",
                    item.SubItems[7].Text, item.SubItems[8].Text);
            if (item.SubItems[9].Text.Equals("T"))
                richTextBox.Text += $"\nDefense points: {item.SubItems[10].Text}";
            if (!item.SubItems[11].Text.Equals(string.Empty))
                richTextBox.Text += $"\nAllowed races: {item.SubItems[11].Text}";
            if (!item.SubItems[12].Text.Equals(string.Empty))
                richTextBox.Text += $"\nAllowed classes: {item.SubItems[12].Text}";
        }
    }
}
