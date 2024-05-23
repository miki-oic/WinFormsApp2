using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormsApp2
{

    public abstract class Player : Person, Attacker
    {

        private int hitPoint;

        public Player() : base("ゲストプレイヤー")
        {

            hitPoint = 100;

        }

        public Player(string name, int hitPoint) : base(name)
        {

            this.hitPoint = hitPoint;

        }

        public int getHitPoint()
        {

            return hitPoint;

        }

        public abstract int attack();

        public Player damagedBy(Player enemy)
        {

            int attackPoint = enemy.attack();
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

        /// <summary>
        /// 気力十分かを返す。
        /// </summary>
        /// <returns>気力十分の場合 true</returns>
        public bool isEnergetic()
        {

            return hitPoint > 0;

        }

        /// <summary>
        /// 気絶しているかを返す。
        /// </summary>
        /// <returns>気絶している場合 true</returns>
        public bool isCollapsed()
        {

            return !isEnergetic();

        }

    }

    public class Fighter : Player
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
            throw new NotImplementedException();
        }

        public Fighter slash()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public Wizard spell()
        {
            throw new NotImplementedException();
        }

    }

}
