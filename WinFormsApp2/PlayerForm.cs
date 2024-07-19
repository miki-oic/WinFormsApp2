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

            // ドラッグ＆ドロップを実行可能にする
            initializeDragDrop();

        }

        private void initializeDragDrop()
        {

            DragOver += event_DragOver;
            DragDrop += event_DragDrop;
            DragEnter += event_DragEnter;
            AllowDrop = true;

        }

        private void event_DragOver(object sender, DragEventArgs e)
        {

            e.Effect = DragDropEffects.Copy;
            //e.Effect = DragDropEffects.Move;

        }

        private void event_DragDrop(object sender, DragEventArgs e)
        {

            object obj = e.Data.GetData(DataFormats.Serializable);
            if (obj is DragDropPanel)
            {

                PlayerDragDropPanel playerDragDropPanel = (obj as PlayerDragDropPanel);

                new Attack(playerDragDropPanel.GetPlayer(), player, new ColosseumModel("闘技場"));

                //MessageBox.Show(playerDragDropPanel.GetPlayer().GetName() + "がドロップされました");
                /*
                if (!Controls.Contains(dragDropPanel))
                {

                    Controls.Add(dragDropPanel);

                }
                */

                e.Effect = DragDropEffects.Copy;
                //e.Effect = DragDropEffects.Move;

            }

        }

        private void event_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.Serializable))
            {

                e.Effect = DragDropEffects.Copy;
                //e.Effect = DragDropEffects.Move;

            }
            else
            {

                e.Effect = DragDropEffects.None;

            }

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

        public PlayerForm AddPlayer(Player player)
        {

            this.player = player;

            panel1.AddPlayer(player);

            // 職業
            AddClassName(player.GetJobName());

            return this;

        }

        private void AddClassName(string name)
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
