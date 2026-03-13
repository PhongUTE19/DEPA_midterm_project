using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DEPA_midterm_project
{
    public partial class Form1 : Form
    {
        private Character currentCharacter;

        public Form1()
        {
            InitializeComponent();
            lblAction.Text = "";
        }

        private void CreateAndShowCharacter(CharacterCreator creator)
        {
            lblAction.Text = "";
            currentCharacter = creator.FactoryMethod();

            lblClassName.Text = currentCharacter.Name;
            lblStats.Text = currentCharacter.GetStats();

            string imagePath = Path.Combine(Application.StartupPath, "images", currentCharacter.ImagePath);

            if (File.Exists(imagePath))
            {
                picAvatar.Image = Image.FromFile(imagePath);
            }
        }

        private void btnFighter_Click(object sender, EventArgs e) => CreateAndShowCharacter(new FighterGenerator());
        private void btnRanger_Click(object sender, EventArgs e) => CreateAndShowCharacter(new RangerGenerator());
        private void btnWizard_Click(object sender, EventArgs e) => CreateAndShowCharacter(new WizardGenerator());
        private void btnRogue_Click(object sender, EventArgs e) => CreateAndShowCharacter(new RogueGenerator());
        private void btnCleric_Click(object sender, EventArgs e) => CreateAndShowCharacter(new ClericGenerator());
        private void btnTakeAction_Click(object sender, EventArgs e)
        {
            if (currentCharacter != null)
            {
                lblAction.Text = currentCharacter.TakeAction();
            }
        }
    }
}
