using System.Diagnostics;

namespace WinFormsApp2
{

    public partial class Form1 : Form
    {

        private FighterForm fighterForm;
        private Fighter fighter;
        private WizardForm wizardForm;
        private Wizard wizard;
        private Enemy enemy;
        private Field field;

        private Form2 form2;

        public Form1()
        {

            InitializeComponent();

            // êÌémÇÃê∂ê¨
            fighter = new FighterModel(1,"ÉAÉäÉIÉì", 8000, 2500,8);
            fighterForm = new FighterForm(fighter);
            fighterForm.Show();

            // ñÇñ@égÇ¢ÇÃê∂ê¨
            wizard = new WizardModel(2,"ÉèÅ[ÉhÉi", 4000, 5000, 9);
            wizardForm = new WizardForm(wizard);
            wizardForm.Show();
            //ìGÇÃê∂ê¨
            enemy = new EnemyModel(3, "ìG", 5000, 3000, 200);
            form2 = new Form2(enemy);
            form2.Show();

            // ì¨ãZèÍÇÃê∂ê¨
            field = new ColosseumModel("ì¨ãZèÍ");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            createAttack(fighter, wizard);

            //            wizardForm.UpdateInformation();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            createAttack(wizard, fighter);

            //            fighterForm.UpdateInformation();

        }

        private Attack createAttack(Attacker attacker, Player target)
        {
            
           
            return new Attack(attacker, target, field);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //            fighterForm.UpdateInformation();
            //            wizardForm.UpdateInformation();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
