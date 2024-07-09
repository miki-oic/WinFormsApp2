using System.Diagnostics;

namespace WinFormsApp2
{

    public partial class Form1 : Form
    {

        private FighterForm fighterForm;
        private Fighter fighter;
        private WizardForm wizardForm;
        private Wizard wizard;
        private Field field;

        public Form1()
        {

            InitializeComponent();

            // êÌémÇÃê∂ê¨
            fighter = new FighterModel();
            //fighter = new FighterModel("ÉAÉäÉIÉì", 8000, 2500,"êÌém",8);
            fighterForm = new FighterForm(fighter);
            fighterForm.Show();

            // ñÇñ@égÇ¢ÇÃê∂ê¨
            wizard = new WizardModel();
            //wizard = new WizardModel("ÉèÅ[ÉhÉi", 4000, 5000, "ñÇèpém", 9);
            wizardForm = new WizardForm(wizard);
            wizardForm.Show();

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
