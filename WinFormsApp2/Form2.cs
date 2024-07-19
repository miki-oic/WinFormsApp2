using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        private EnemyStatusLabel enemyStatusLabel;
        private Enemy enemy;
        private List<Observer> observers = new List<Observer>();

        public Form2(Enemy enemy)
        {
            this.enemy = enemy;

            enemyStatusLabel = new EnemyStatusLabel(enemy);
            enemyStatusLabel.AutoSize = true;
            enemyStatusLabel.Location = new Point(97, 61);
            enemyStatusLabel.Name = "label1";
            enemyStatusLabel.Size = new Size(50, 20);
            enemyStatusLabel.TabIndex = 0;
            enemyStatusLabel.Text = "* 状態の表示 *";
            Controls.Add(enemyStatusLabel);

            InitializeComponent();

            observers.Add(enemyStatusLabel);

            Initialize();

            UpdateInformation();
        }

        private void Initialize()
        {
            //// 名前
            //label2.Text = enemyStatusLabel.Name;
            //textBox1.Enabled = false; // 表示のみ
            //// 職業
            //comboBox1.Enabled = false; // 表示のみ
            //// ヒットポイント
            //textBox2.Enabled = false; // 表示のみ
            //// オブザーバーの追加
            //player.AddObserver(this);

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

        public void UpdateInformation()
        {

            observers.ForEach(observer =>
            {
                observer.update();

            });

            // ヒットポイント
            //textBox2.Text = player.GetHitPoint().ToString();

           

        }

        public void update()
        {
            UpdateInformation();
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


