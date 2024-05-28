using System.Diagnostics;

namespace WinFormsApp2
{

    public partial class Form1 : Form
    {

        private FighterForm fighterForm;
        private WizardForm wizardForm;
        private Fighter fighter;
        private WizardModel wizard;
        private Field field;

        public Form1()
        {

            InitializeComponent();

            // ��m�̐���
            fighter = new FighterModel("�A���I��", 8000, 2500);
            fighterForm = new FighterForm(fighter);
            fighterForm.Show();

            // ���@�g���̐���
            wizard = new WizardModel("���[�h�i", 4000, 5000);
            wizardForm = new WizardForm(wizard);
            wizardForm.Show();

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

        private void button3_Click(object sender, EventArgs e)
        {

            fighterForm.update();
            wizardForm.update();

        }

    }

}
