using MMORPG.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MMORPG.Forms
{
    public partial class StoreForm : Form
    {
        private bool shouldClose;
        private Player player;

        public StoreForm(Player player)
        {
            InitializeComponent();

            shouldClose = true;
            this.player = player;

            listViewItems.View = View.Details;

            listViewItems.FullRowSelect = true;
            listViewItems.MultiSelect = false;

            listViewItems.Columns.Add("Id", -2);
            listViewItems.Columns.Add("Name", -2);
            listViewItems.Columns.Add("Bonus Points", -2);
            listViewItems.Columns.Add("Price", -2);
            listViewItems.Columns.Add("Exp needed", -2);

            FillListViewItems();

            listViewInventory.View = View.Details;

            listViewInventory.FullRowSelect = true;
            listViewInventory.MultiSelect = false;

            listViewInventory.Columns.Add("Id", -2);
            listViewInventory.Columns.Add("Name", -2);
            listViewInventory.Columns.Add("Bonus Points", -2);
            listViewInventory.Columns.Add("Price", -2);
            listViewInventory.Columns.Add("Exp needed", -2);

            FillListViewInventory();

            listViewCharacter.View = View.Details;

            listViewCharacter.FullRowSelect = true;
            listViewCharacter.MultiSelect = false;

            listViewCharacter.Columns.Add("Id", -2);
            listViewCharacter.Columns.Add("Class", -2);
            listViewCharacter.Columns.Add("Race", -2);
            listViewCharacter.Columns.Add("Gold", -2);
            listViewCharacter.Columns.Add("Exp", -2);

            FillListViewCharacters();
            FillLabel();

            expLabel.Text = "Exp level : " + DTOManager.GetExperience(this.player.Id);
        }

        private void FillLabel()
        {
            fundsLabel.Text = "Available funds : " + DTOManager.GetAvailableFunds(this.player.Id);
        }

        private void FillListViewItems()
        {
            listViewItems.Items.Clear();

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
                listViewItems.Items.Add(item);
            }

            listViewItems.Refresh();
        }

        private void FillListViewInventory()
        {
            listViewInventory.Items.Clear();

            List<ItemView> data = DTOManager.ReturnAllPlayerItems(this.player.Id).ToList();

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
                listViewInventory.Items.Add(item);
            }

            listViewInventory.Refresh();
        }

        private void FillListViewCharacters()
        {
            listViewCharacter.Items.Clear();

            List<CharacterView> data = DTOManager.ReturnAllPlayerCharacters(this.player.Id).ToList();

            foreach (CharacterView c in data)
            {
                ListViewItem item = new ListViewItem(new[]
                {
                    c.Id.ToString(), c.ClassName, c.RaceName, c.Gold.ToString(), c.Exp.ToString()
                });
                listViewCharacter.Items.Add(item);
            }

            listViewCharacter.Refresh();
        }

        private void buyItemBtn_Click(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count > 0)
            {
                string response = DTOManager.BuyItem(this.player.Id, int.Parse(listViewItems.SelectedItems[0].Text));
                MessageBox.Show(response);
                FillListViewInventory();
                FillLabel();
            }
            else
                MessageBox.Show("Please select an item to buy!");
        }

        private void sellItemBtn_Click(object sender, EventArgs e)
        {
            if (listViewInventory.SelectedItems.Count > 0)
            {
                string response = DTOManager.SellItem(this.player.Id, int.Parse(listViewInventory.SelectedItems[0].Text));
                MessageBox.Show(response);
                FillListViewInventory();
                FillLabel();
            }
            else
                MessageBox.Show("Please select an item to sell!");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            MainPlayerForm mainPlayerForm = new MainPlayerForm(this.player);
            mainPlayerForm.Show();
            this.Close();
        }

        private void StoreForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose == true)
                Application.Exit();
        }

        private void listViewItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewItems.SelectedItems.Count == 0)
                return;
            ListViewItem item = listViewItems.SelectedItems[0];

            richTextBoxItems.Text = $"Item description: \"{item.SubItems[5].Text}.\"";
            if (item.SubItems[6].Text.Equals("T"))
                richTextBoxItems.Text += string.Format("\nWeapon type: {0}\nAttack points: {1}",
                    item.SubItems[7].Text, item.SubItems[8].Text);
            if (item.SubItems[9].Text.Equals("T"))
                richTextBoxItems.Text += $"\nDefense points: {item.SubItems[10].Text}";
            if (!item.SubItems[11].Text.Equals(string.Empty))
                richTextBoxItems.Text += $"\nAllowed races: {item.SubItems[11].Text}";
            if (!item.SubItems[12].Text.Equals(string.Empty))
                richTextBoxItems.Text += $"\nAllowed classes: {item.SubItems[12].Text}";
        }

        private void listViewInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewInventory.SelectedItems.Count == 0)
                return;
            ListViewItem item = listViewInventory.SelectedItems[0];

            richTextBoxInventory.Text = $"Item description: \"{item.SubItems[5].Text}.\"";
            if (item.SubItems[6].Text.Equals("T"))
                richTextBoxInventory.Text += string.Format("\nWeapon type: {0}\nAttack points: {1}",
                    item.SubItems[7].Text, item.SubItems[8].Text);
            if (item.SubItems[9].Text.Equals("T"))
                richTextBoxInventory.Text += $"\nDefense points: {item.SubItems[10].Text}";
            if (!item.SubItems[11].Text.Equals(string.Empty))
                richTextBoxInventory.Text += $"\nAllowed races: {item.SubItems[11].Text}";
            if (!item.SubItems[12].Text.Equals(string.Empty))
                richTextBoxInventory.Text += $"\nAllowed classes: {item.SubItems[12].Text}";
        }

    }
}
