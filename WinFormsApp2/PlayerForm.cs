using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{

    public partial class PlayerForm : Form, Observer
    {

        private PlayerStatusLabel playerStatusLabel;
        private Player player;
        private List<Observer> observers = new List<Observer>();

        public PlayerForm(Player player)
        {

            //Debug.Assert(player != null);
            this.player = player;
            //Debug.Assert(this.player != null);

            playerStatusLabel = new PlayerStatusLabel(player);
            playerStatusLabel.AutoSize = true;
            playerStatusLabel.Location = new Point(237, 213);
            playerStatusLabel.Name = "label5";
            playerStatusLabel.Size = new Size(125, 25);
            playerStatusLabel.TabIndex = 7;
            playerStatusLabel.Text = "* 状態の表示 *";
            Controls.Add(playerStatusLabel);

            InitializeComponent();

            observers.Add(playerStatusLabel);

            Initialize();

            UpdateInformation();

        }

        private void Initialize()
        {
            // 名前
            textBox1.Text = player.GetName();
            textBox1.Enabled = false; // 表示のみ
            // 職業
            comboBox1.Enabled = false; // 表示のみ
            // ヒットポイント
            textBox2.Enabled = false; // 表示のみ
            // オブザーバーの追加
            player.AddObserver(this);

        }

        /// <summary>
        /// 最新の情報に更新します。
        /// </summary>
        public void UpdateInformation()
        {

            observers.ForEach(observer =>
            {

                observer.update();

            });

            // ヒットポイント
            textBox2.Text = player.GetHitPoint().ToString();

            // ステータス
            /*
            if (player.IsOk())
            {

                label5.Text = "正常";

            }
            else if (player.IsCollapsed())
            {

                label5.Text = "気絶";

            }
            else
            {

                label5.Text = "？？？";

            }
            */

        }

        protected void AddClassName(string name)
        {

            // 職業
            comboBox1.Text = name;

        }
        public void update()
        {
            UpdateInformation();
        }

    }

}
