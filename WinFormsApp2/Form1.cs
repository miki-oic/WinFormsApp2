using System.Diagnostics;

namespace WinFormsApp2
{

    public partial class Form1 : Form
    {

        private Fighter fighter;
        private Wizard wizard;
        private Field field;

        public Form1()
        {

            InitializeComponent();

            // 戦士の生成
            fighter = new Fighter("アリオン", 8000, 2500);
            new FighterForm(fighter).Show();

            // 魔法使いの生成
            wizard = new Wizard("ワードナ", 4000, 5000);
            new WizardForm(wizard).Show();

            // 闘技場の生成
            field = new Colosseum("闘技場");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            createAttack(fighter, wizard);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            createAttack(wizard, fighter);

        }

        private Attack createAttack(Attacker attacker, Player target)
        {

            return new Attack(attacker, target, field);

        }

    }

}
