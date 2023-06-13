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
    public partial class CreateUpdateSpellForm : Form
    {
        private bool shouldClose;
        private SpellView? spell;
        public CreateUpdateSpellForm(int? spellId = null)
        {
            InitializeComponent();
            shouldClose = true;

            if (spellId != null)
            {
                this.spell = DTOManager.ReturnSpell((int)spellId);

                if (spell == null)
                    throw new ArgumentNullException("Error, spell not found in database!");

                textBoxName.Text = this.spell.Name;
            }
            else
                this.spell = null;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string response;

            if (spell == null)
            {
                spell = new SpellView()
                {
                    Name = textBoxName.Text,
                };
                response = DTOManager.SaveSpell(spell);
            }
            else
            {
                spell = new SpellView()
                {
                    Id = spell.Id,
                    Name = textBoxName.Text,
                };
                response = DTOManager.UpdateSpell(spell);
            }

            MessageBox.Show(response);

            shouldClose = false;
            SpellsForm spellsForm = new SpellsForm();
            spellsForm.Show();
            this.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            shouldClose = false;
            SpellsForm spellsForm = new SpellsForm();
            spellsForm.Show();
            this.Close();
        }

        private void CreateUpdateSpellForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (shouldClose == true)
                Application.Exit();
        }
    }
}
