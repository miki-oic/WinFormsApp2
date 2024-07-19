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

            Label(true, 97, 61, "label1", 50, 20, 0, "* 状態の表示 *");
            Label(true, 253, 61, "label2", 50, 20, 1, "label2");
            Label(true, 97, 138, "label3", 50, 20, 2, "label3");
            Label(true, 253, 138, "label4", 50, 20, 3, "label4");
            Label(true, 97, 232, "label5", 50, 20, 4, "label5");
            Label(true, 253, 232, "label6", 50, 20, 5, "label6");

            if (enemyStatusLabel == null) {
                return;
            }

            InitializeComponent();

            observers.Add(enemyStatusLabel);

            Initialize();

            UpdateInformation();
        }

        private void Label(bool autosize,int locateX,int locateY,string name, int sizeX,int sizeY,int tabindex,string text)
        {
            enemyStatusLabel = new EnemyStatusLabel(enemy);
            enemyStatusLabel.AutoSize = autosize;
            enemyStatusLabel.Location = new Point(locateX, locateY);
            enemyStatusLabel.Name = name;
            enemyStatusLabel.Size = new Size(sizeX, sizeY);
            enemyStatusLabel.TabIndex = tabindex;
            enemyStatusLabel.Text = text;
            Controls.Add(enemyStatusLabel);
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


