using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{

    public class PlayerStatusLabel : Label, Observer
    {

        private Player player;

        public PlayerStatusLabel(): this(NullPlayer.GetInstance())
        {

        }

        public PlayerStatusLabel(Player player)
        {

            AddPlayer(player);

            update();

        }

        public void AddPlayer(Player player)
        {

            Debug.Assert(player != null);

            this.player = player;

            Debug.Assert(this.player != null);

        }

        public void update()
        {

            // ステータス
            if (player.IsOk())
            {

                Text = "正常";

            }
            else if (player.IsCollapsed())
            {

                Text = "気絶";

            }
            else
            {

                Text = "？？？";

            }

        }

    }

}
