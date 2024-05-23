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

            // ��m�̐���
            fighter = new Fighter("�A���I��", 8000, 2500);
            new FighterForm(fighter).Show();

            // ���@�g���̐���
            wizard = new Wizard("���[�h�i", 4000, 5000);
            new WizardForm(wizard).Show();

            // ���Z��̐���
            field = new Colosseum("���Z��");

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
