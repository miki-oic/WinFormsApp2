using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormsApp2
{

    public interface Player : Person, Attacker
    {

        /// <summary>
        /// 耐久力を返します。
        /// </summary>
        /// <returns>耐久力</returns>
        int getHitPoint();

        /// <summary>
        /// 攻撃を受けます。
        /// </summary>
        /// <param name="attacker"></param>
        /// <returns>自身のオブジェクト</returns>
        Player damagedBy(Attacker attacker);

        /// <summary>
        /// 大丈夫かを返す。
        /// </summary>
        /// <returns>大丈夫な場合 true</returns>
        bool isOk();

        /// <summary>
        /// 気絶しているかを返す。
        /// </summary>
        /// <returns>気絶している場合 true</returns>
        bool isCollapsed();

    }

    public abstract class PlayerModel : PersonModel, Player
    {

        private int hitPoint;

        public PlayerModel() : base("ゲストプレイヤー")
        {

            hitPoint = 100;

        }

        public PlayerModel(string name, int hitPoint) : base(name)
        {

            this.hitPoint = hitPoint;

        }

        public int getHitPoint()
        {

            return hitPoint;

        }

        public abstract int attack();

        public Player damagedBy(Attacker attacker)
        {

            int attackPoint = attacker.attack();
            if (attackPoint < hitPoint)
            {

                hitPoint -= attackPoint;

            }
            else
            { 

                hitPoint = 0;

            }

            return this;

        }

        public bool isOk()
        {

            return hitPoint > 0;

        }

        public bool isCollapsed()
        {

            return !isOk();

        }

    }

    public class Fighter : PlayerModel
    {

        private int strengh;

        public Fighter()
        {

            strengh = 10;

        }

        public Fighter(string name, int hitPoint, int strengh) : base(name, hitPoint)
        {

            this.strengh = strengh;

        }

        public int getStrengh()
        {

            return strengh;

        }

        public override int attack()
        {

            return slash();

        }

        public int slash()
        {

            return strengh;

        }

    }

    public class Wizard : Player
    {

        private int magicPoint;

        public Wizard()
        {

            magicPoint = 10;

        }

        public Wizard(string name, int hitPoint, int magicPoint) : base(name, hitPoint)
        {

            this.magicPoint = magicPoint;

        }

        public int getMagicPoint()
        {

            return magicPoint;

        }

        public override int attack()
        {

            return spell();

        }

        public int spell()
        {

            return magicPoint;

        }

    }

}
