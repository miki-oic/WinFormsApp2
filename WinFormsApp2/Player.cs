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
        int GetHitPoint();

        /// <summary>
        /// 指定された攻撃者からのダメージを受けます。
        /// </summary>
        /// <param name="attacker">攻撃者</param>
        /// <returns>このオブジェクト</ret urns>
        Player DamagedBy(Attacker attacker);

        /// <summary>
        /// 大丈夫かどうかを返す。
        /// </summary>
        /// <returns>大丈夫な場合 true</returns>
        bool IsOk();

        /// <summary>
        /// 気絶しているかどうかを返す。
        /// </summary>
        /// <returns>気絶している場合 true</returns>
        bool IsCollapsed();


        Player AddObserber(Observer observer);

       
    }

    public abstract class PlayerModel : PersonModel, Player
    {

        private int hitPoint;
        private List<Observer> observers = new List<Observer>();

        public PlayerModel() : base("ゲストプレイヤー")
        {

            hitPoint = 1000;

        }

        public PlayerModel(string name, int hitPoint) : base(name)
        {

            this.hitPoint = hitPoint;

        }

        public int GetHitPoint()
        {

            return hitPoint;

        }

        public abstract int Attack();

        public Player DamagedBy(Attacker attacker)
        {

            if (attacker.Attack() < hitPoint)
            {

                hitPoint -= attacker.Attack();

            }
            else
            { 

                hitPoint = 0;

            }

            notify();

            return this;

        }

        public bool IsOk()
        {

            return hitPoint > 0;

        }

        public bool IsCollapsed()
        {

            return !IsOk();

        }

        public Player AddObserber(Observer observer)
        {
            observers.Add(observer);
            return this;
        }
        public void notify()
        {

            observers.ForEach(observer =>
            {

                observer.update();

            });

        }

    }

}
