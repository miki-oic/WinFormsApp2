using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.Utilities
{
    public partial class DebugForm : Form
    {
        private Fighter fighter;
        private Wizard wizard;
        private Field field;

        private Player player;

        public DebugForm()
        {
            InitializeComponent();

            // 戦士の生成
            fighter = new FighterModel();

            // 魔法使いの生成
            wizard = new WizardModel();
            // 闘技場の生成
            field = new ColosseumModel("闘技場");

            player = fighter;
            playerLabel1.Text = fighter.GetName();
            playerLabel2.Text = wizard.GetName();
            HPLabel1.Text = fighter.GetHitPoint().ToString();
            HPLabel2.Text = wizard.GetHitPoint().ToString();
        }

        private void DebugForm_Load(object sender, EventArgs e)
        {

        }

        private void nameInputLabel_Click(object sender, EventArgs e)
        {

        }

        private void playerLabel1_Click(object sender, EventArgs e)
        {
            player = fighter;
        }
        private void playerLabel2_Click(object sender, EventArgs e)
        {
            player = wizard;
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            if (player == null) { return; }
            if (player == fighter)
            {
                AddLogEntry("戦士", "攻撃を行った！");
            }
            else
            {
                AddLogEntry("魔法使い", "攻撃を行った！");
            }
        }

        public void AddLogEntry(string name, string command)
        {
            string log = name + "は" + command;
            listBox1.Items.Add(log);
        }

        private void guridButton_Click(object sender, EventArgs e)
        {
            if(player == null) { return; }
            if (player == fighter)
            {
                AddLogEntry("戦士", "防御を行った！");
            }
            else
            {
                AddLogEntry("魔法使い", "防御を行った！");
            }
        }

    }
}
