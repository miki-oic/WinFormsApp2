namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            new FighterForm(new Fighter("�A���I��", 2500, 80)).Show();

        }
    }
}
