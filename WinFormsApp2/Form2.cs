using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public class EnemyMock : Enemy
        {
            public Enemy AddObserver(Observer observer)
            {
                return this;
            }

            public int Attack()
            {
                return 1;
            }

            public Enemy DamagedBy(Attacker attacker)
            {
                return this;
            }

            public int GetHitPoint()
            {
                return 2;
            }

            public bool IsCollapsed()
            {
                return false;
            }

            public bool IsOk()
            {
                return true;
            }

        }

        public class EnemyDTOModel : EnemyDTO
        {
            public string GetHitPoint()
            {
                return "222";
            }

            public string GetName()
            {
                return "name";
            }

            public string SetHitPoint(string hitpoint)
            {
                return "222";
            }

            public string SetName(string name)
            {
                return "name";
            }
        }


    }
}


