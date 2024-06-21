using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{

    public class PlayerStatusLabel : Label, Observer
    {

        private Player player;

        public PlayerStatusLabel(Player player)
        {

            this.player = player;

            update();

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
