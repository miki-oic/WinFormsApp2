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

    public partial class PlayerForm : Form
    {

        private Player player;

        public PlayerForm(Player player)
        {

            //Debug.Assert(player != null);

            InitializeComponent();

            this.player = player;

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

        }

        /// <summary>
        /// 最新の情報に更新します。
        /// </summary>
        public void UpdateInformation()
        {

            // ヒットポイント
            textBox2.Text = player.GetHitPoint().ToString();

            // ステータス
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

        }

        protected void AddClassName(string name)
        {

            // 職業
            comboBox1.Text = name;

        }

    }

}
