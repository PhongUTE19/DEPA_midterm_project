using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEPA_midterm_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateAndShowCharacter(CharacterCreator creator)
        {
            Character character = creator.FactoryMethod();

            lblClassName.Text = character.Name;
            lblStats.Text = character.GetStats();

            string imagePath = Path.Combine(Application.StartupPath, "images", character.ImagePath);
            if (File.Exists(imagePath))
            {
                picAvatar.Image = Image.FromFile(imagePath);
            }
        }

        private void btnWarrior_Click(object sender, EventArgs e) => CreateAndShowCharacter(new WarriorGenerator());
        private void btnArcher_Click(object sender, EventArgs e) => CreateAndShowCharacter(new ArcherGenerator());
        private void btnWizard_Click(object sender, EventArgs e) => CreateAndShowCharacter(new WizardGenerator());
        private void btnAssassin_Click(object sender, EventArgs e) => CreateAndShowCharacter(new AssassinGenerator());
    }
}
