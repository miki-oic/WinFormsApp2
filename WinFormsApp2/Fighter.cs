using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{

    public interface Fighter : Player
    {

        /// <summary>
        /// 切りつけます。
        /// </summary>
        /// <returns>効果の値</returns>
        int Slash();

    }

    public class FighterModel : PlayerModel, Fighter
    {

        private int strengh;

        public FighterModel()
        {

            strengh = 100;

        }

        public FighterModel(string name, int hitPoint, int strengh) : base(name, hitPoint)
        {

            this.strengh = strengh;

        }

        /// <summary>
        /// 力強さを返します。
        /// </summary>
        /// <returns>力強さ</returns>
        public int GetStrengh()
        {

            return strengh;

        }

        public override int Attack()
        {

            return Slash();

        }

        public int Slash()
        {

            return strengh;

        }

    }

}
