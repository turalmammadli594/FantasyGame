using FantasyGame.Models;
namespace FantasyGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Heroes hero = new Heroes();
        int enemySoul;

        private void btnChoose_Click(object sender, EventArgs e)
        {
            hero.SetCharacters(comboBox1.Text);
            txtName.Text = hero.Name;
            txtBranch.Text = hero.Branch;
            txtPhylo.Text = hero.Phylo;
            txtWeapon.Text = hero.Weapon;
            MessageBox.Show($"You choose the hero {hero.Name}");
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            enemySoul = lblEnemySoul.Width;
            hero.Attack();
            enemySoul -= hero.AttackPower;
            lblEnemySoul.Width = enemySoul;
            MessageBox.Show($"You inflicted -{hero.AttackPower} blows on the enemy.");

            if (enemySoul <= 0)
            {
                MessageBox.Show("You won the Enemy");
            }
        }
    }
}
