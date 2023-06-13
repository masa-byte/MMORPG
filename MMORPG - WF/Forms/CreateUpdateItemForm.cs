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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MMORPG.Forms
{
    public partial class CreateUpdateItemForm : Form
    {
        private bool shouldClose;
        private ItemView? item;

        public CreateUpdateItemForm(int? itemId = null)
        {
            InitializeComponent();
            shouldClose = true;
            listBoxWeaponType.Enabled = false;
            numericUpDownAttackPoints.Enabled = false;
            numericUpDownDefensePoints.Enabled = false;

            if (itemId != null)
            {
                this.item = DTOManager.ReturnItem((int)itemId);
                if (item == null)
                    throw new ArgumentNullException("Error, item not found in database!");
                textBoxName.Text = this.item.Name;
                textBoxDescription.Text = this.item.Description;
                numericUpDownBonusPoints.Value = (decimal)this.item.BonusPoints;
                numericUpDownPrice.Value = (decimal)this.item.Price;
                numericUpDownExpNeeded.Value = (decimal)this.item.ExpNeeded;
                foreach (AllowedRaceView allowedRace in this.item.AllowedRaces)
                {
                    switch (allowedRace.RaceName)
                    {
                        case "ELF":
                            checkBoxElf.Checked = true;
                            break;
                        case "DEMON":
                            checkBoxDemon.Checked = true;
                            break;
                        case "DWARF":
                            checkBoxDwarf.Checked = true;
                            break;
                        case "ORC":
                            checkBoxOrc.Checked = true;
                            break;
                        case "HUMAN":
                            checkBoxHuman.Checked = true;
                            break;
                    }
                }
                foreach (AllowedClassView allowedClass in this.item.AllowedClasses)
                {
                    switch (allowedClass.ClassName)
                    {
                        case "THIEF":
                            checkBoxThief.Checked = true;
                            break;
                        case "WIZARD":
                            checkBoxWizard.Checked = true;
                            break;
                        case "FIGHTER":
                            checkBoxFighter.Checked = true;
                            break;
                        case "PRIEST":
                            checkBoxPriest.Checked = true;
                            break;
                        case "DEFENDER":
                            checkBoxDefender.Checked = true;
                            break;
                        case "ARCHER":
                            checkBoxArcher.Checked = true;
                            break;
                    }
                }
                if (this.item.Weapon == 'T')
                {
                    checkBoxWeapon.Checked = true;
                    listBoxWeaponType.Enabled = true;
                    numericUpDownAttackPoints.Enabled = true;
                    listBoxWeaponType.Text = this.item.WeaponType;
                    numericUpDownAttackPoints.Value = (decimal)this.item.AttackPoints;
                }
                if (this.item.Armour == 'T')
                {
                    checkBoxArmour.Checked = true;
                    numericUpDownDefensePoints.Enabled = true;
                    numericUpDownDefensePoints.Value = (decimal)this.item.DefensePoints;
                }
            }
            else
                this.item = null;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            ItemsForm itemsForm = new ItemsForm();
            itemsForm.Show();
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (textBoxName.TextLength == 0)
            {
                MessageBox.Show("Name field empty!");
                return;
            }

            if (textBoxDescription.TextLength == 0)
            {
                MessageBox.Show("Description field empty!");
                return;
            }

            if (numericUpDownBonusPoints.Value <= 0)
            {
                MessageBox.Show("Invalid bonus points! Must be greater than zero.");
                return;
            }

            if (numericUpDownPrice.Value <= 0)
            {
                MessageBox.Show("Invalid price! Must be greater than zero.");
                return;
            }

            if (numericUpDownExpNeeded.Value <= 0)
            {
                MessageBox.Show("Invalid experience! Must be greater than zero.");
                return;
            }

            List<AllowedRaceView> allowedRaces = new List<AllowedRaceView>();

            if (checkBoxElf.Checked)
                allowedRaces.Add(new AllowedRaceView("ELF"));

            if (checkBoxDemon.Checked)
                allowedRaces.Add(new AllowedRaceView("DEMON"));

            if (checkBoxDwarf.Checked)
                allowedRaces.Add(new AllowedRaceView("DWARF"));

            if (checkBoxOrc.Checked)
                allowedRaces.Add(new AllowedRaceView("ORC"));

            if (checkBoxHuman.Checked)
                allowedRaces.Add(new AllowedRaceView("HUMAN"));

            List<AllowedClassView> allowedClasses = new List<AllowedClassView>();

            if (checkBoxThief.Checked)
                allowedClasses.Add(new AllowedClassView("THIEF"));

            if (checkBoxWizard.Checked)
                allowedClasses.Add(new AllowedClassView("WIZARD"));

            if (checkBoxFighter.Checked)
                allowedClasses.Add(new AllowedClassView("FIGHTER"));

            if (checkBoxPriest.Checked)
                allowedClasses.Add(new AllowedClassView("PRIEST"));

            if (checkBoxDefender.Checked)
                allowedClasses.Add(new AllowedClassView("DEFENDER"));

            if (checkBoxArcher.Checked)
                allowedClasses.Add(new AllowedClassView("ARCHER"));

            ItemView itemView = new ItemView()
            {
                Id = item?.Id ?? -1,
                Name = textBoxName.Text,
                Description = textBoxDescription.Text,
                BonusPoints = (double)numericUpDownBonusPoints.Value,
                Price = (double)numericUpDownPrice.Value,
                ExpNeeded = (double)numericUpDownExpNeeded.Value,
                AllowedRaces = allowedRaces,
                AllowedClasses = allowedClasses
            };

            if (checkBoxWeapon.Checked)
            {
                itemView.Weapon = 'T';
                itemView.WeaponType = listBoxWeaponType.Text;
                itemView.AttackPoints = (double)numericUpDownAttackPoints.Value;
            }
            else
            {
                itemView.Weapon = 'F';
                itemView.WeaponType = null;
                itemView.AttackPoints = null;
            }

            if (checkBoxArmour.Checked)
            {
                itemView.Armour = 'T';
                itemView.DefensePoints = (double)numericUpDownDefensePoints.Value;
            }
            else
            {
                itemView.Armour = 'F';
                itemView.DefensePoints = null;
            }

            if (item == null)
            {
                string response = DTOManager.SaveItem(itemView);
                MessageBox.Show(response);
            }
            else
            {
                string response = DTOManager.UpdateItem(itemView);
                MessageBox.Show(response);
            }

            shouldClose = false;
            ItemsForm blessingsForm = new ItemsForm();
            blessingsForm.Show();
            this.Close();
        }

        private void CreateUpdateItemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose == true)
                Application.Exit();
        }

        private void checkBoxIsWeapon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWeapon.Checked)
            {
                listBoxWeaponType.Enabled = true;
                numericUpDownAttackPoints.Enabled = true;
            }
            else
            {
                listBoxWeaponType.Enabled = false;
                numericUpDownAttackPoints.Enabled = false;
            }
        }

        private void checkBoxArmour_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxArmour.Checked)
            {
                numericUpDownDefensePoints.Enabled = true;
            }
            else
            {
                numericUpDownDefensePoints.Enabled = false;
            }
        }
    }
}
