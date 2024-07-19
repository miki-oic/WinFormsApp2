using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.MockForm
{
    public partial class MockForm_k : Form
    {
        private Fighter fighter;
        private Wizard wizard;

        private Player statePlayer;


        int count = 0;

        bool changePlayer = false;
        int changeCount = 0;

        private MockPlayer player;

        MockPlayer.CharaTag charaTag = MockPlayer.CharaTag.Player1;

        private Command command;

        public MockForm_k()
        {
            InitializeComponent();

            player = new HeroModel();

            fighter = new FighterModel(1, "アリオン", 8000, 2500, 8);
            name1.Text = fighter.GetName();
            hp1.Text = fighter.GetHitPoint().ToString();
            wizard = new WizardModel(2, "ワードナ", 4000, 5000, 9);
            name2.Text = wizard.GetName();
            hp2.Text = wizard.GetHitPoint().ToString();

            statePlayer = fighter;

            name.Text = statePlayer.GetName();
            hp.Text = statePlayer.GetHitPoint().ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            command = new Attack();
            AddLogEntry(statePlayer.GetName(), command.GetCommand());
            ChangePlayer();
        }

        public void AddLogEntry(string name, string command)
        {
            string log = name + "は" + command;
            listBox1.Items.Add(log);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            command = new Gurid();
            AddLogEntry(statePlayer.GetName(), command.GetCommand());
            ChangePlayer();
        }

        private void MockForm_k_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            command = new Magic();
            AddLogEntry(statePlayer.GetName(), command.GetCommand());
            ChangePlayer();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            command = new Escape();
            AddLogEntry(statePlayer.GetName(), command.GetCommand());
            ChangePlayer();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            command = new CurseUnLock();
            AddLogEntry(statePlayer.GetName(), command.GetCommand());
            ChangePlayer();
        }

        private void ChangePlayer()
        {
            switch (changeCount)
            {
                case 0:
                    statePlayer = wizard;
                    break;
                case 1:
                    statePlayer = fighter;
                    break;
            }
            name.Text = statePlayer.GetName();
            hp.Text = statePlayer.GetHitPoint().ToString();
            changeCount++;
            if(changeCount > 1)
            {
                changeCount = 0;
            }
        }

        private void name1_Click(object sender, EventArgs e)
        {

        }
    }

    public interface MockPlayer
    {
        enum CharaTag
        {
            Null = -1,
            Player1,
            Player2,
            DataEnd
        }
        /// <summary>
        /// HPを返す
        /// </summary>
        /// <returns></returns>
        int GetHP();

        /// <summary>
        /// 名前を返す
        /// </summary>
        /// <returns></returns>
        string GetName();


    }

    public abstract class MockPlayerModel : MockPlayer
    {
        int hp = 100;
        string name = "名無し";

        public MockPlayerModel(string _name)
        {
            name = _name;
        }

        public int GetHP() { return hp; }

        public string GetName() { return name; }
    }

    public interface Hero : MockPlayer
    {

    }

    public class HeroModel : MockPlayerModel, Hero
    {
        public HeroModel() : base("勇者")
        {

        }
    }

    public interface Samurai : MockPlayer
    {

    }

    public class SamuraiModel : MockPlayerModel, Samurai
    {
        public SamuraiModel() : base("侍")
        {

        }
    }

    public interface Thief : MockPlayer
    {

    }

    public class ThiefModel : MockPlayerModel, Thief
    {
        public ThiefModel() : base("盗賊")
        {

        }
    }
}
