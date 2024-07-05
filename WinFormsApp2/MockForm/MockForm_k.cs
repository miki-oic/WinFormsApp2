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
        int count = 0; 

        public MockForm_k()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddLogEntry("よっぴー", "攻撃をした");
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
            AddLogEntry("メンヘラ", "防御を行った");
        }

        private void MockForm_k_Load(object sender, EventArgs e)
        {
            count++;
            label1.Text = count.ToString();
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

        string GetName();

    }

    public interface MockHero : MockPlayer
    {
        int GetSkillDamage();
    }

    public abstract class MockPlayerModel
    {

    }

}
