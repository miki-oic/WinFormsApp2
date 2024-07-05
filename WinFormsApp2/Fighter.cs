using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{

    /// <summary>
    /// 戦士
    /// </summary>
    public interface Fighter : Player
    {

        /// <summary>
        /// 切りつけます。
        /// </summary>
        /// <returns>効果の値</returns>
        int Slash();
        int GetStrengh();
    }

    public class FighterMock : PlayerModel, Fighter
    {
        public override int Attack()
        {
            return Slash();
        }

        public int GetStrengh()
        {
            return 100;
        }

        public int Slash()
        {
            return 100;
        }
    }

    public class FighterModel : PlayerModel, Fighter
    {

        private int strengh;

        public FighterModel()
        {

            strengh = 100;

        }

        public FighterModel(string name, int hitPoint, int strengh,int armorClass) : base(name, hitPoint,armorClass)
        {

            this.strengh = strengh;

        }
        public string GetJobName()
        {
            return "戦士";
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
