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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">名前</param>
        /// <param name="hitPoint">体力</param>
        /// <param name="strengh">攻撃力</param>
        /// <param name="job">職業</param>
        /// <param name="armorClass">防御力</param>
       
        public FighterModel(string name, int hitPoint, int strengh, string job,int armorClass) : base(name, hitPoint,job,armorClass)
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
