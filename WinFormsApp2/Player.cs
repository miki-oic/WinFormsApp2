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
        /// 職業を返します
        /// </summary>
        /// <returns>職業名</returns>
        string GetJob();

        ///<summary>
        ///守備力を返します
        ///</summary>
        ///<returns>守備力</returns>
        int GetArmorClass();

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

        /// <summary>
        /// オブザーバーを追加します。
        /// </summary>
        /// <param name="observer"></param>
        /// <returns>オブザーバー</returns>
        Player AddObserver(Observer observer);

        ///<summary>
        ///レベルを返します
        ///</summary>
        ///<returns>レベル</returns>
        int GetLevel();
    }

    public abstract class PlayerModel : PersonModel, Player
    {
        private int level;
        private int hitPoint;
        private int armorClass;
        private string job;
        private List<Observer> observers = new List<Observer>();

        public PlayerModel() : base("ゲストプレイヤー")
        {

            hitPoint = 1000;
            job = "";
            armorClass = 10;

        }

        public PlayerModel(string name, int hitPoint,string job,int armorClass) : base(name)
        {

            this.hitPoint = hitPoint;
            this.job = job;
            this.armorClass = armorClass;

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

        public Player AddObserver(Observer observer)
        {

            observers.Add(observer);

            return this;

        }

        private void notify()
        {

            observers.ForEach(observer =>
            {

                observer.update();

            });

        }

        public string GetJob()
        {
            return job;
        }

        public int GetArmorClass()
        {
            return armorClass;
        }

        public int GetLevel()
        {
            return level;
        }

    }

    public class NullPlayer : Player
    {

        private static Player player = new NullPlayer();

        private NullPlayer()
        {

        }

        public static Player GetInstance() {
            
            return player;

        }

        public Player AddObserver(Observer observer)
        {

            return this;

        }

        public int Attack()
        {

            return int.MinValue;

        }

        public Player DamagedBy(Attacker attacker)
        {

            return this;

        }

        public int GetArmorClass()
        {

            return int.MinValue;

        }

        public int GetHitPoint()
        {

            return int.MinValue;

        }

        public string GetJob()
        {

            return "";

        }

        public int GetLevel()
        {

            return int.MinValue;

        }

        public string GetName()
        {

            return "";

        }

        public bool IsCollapsed()
        {

            return false;

        }

        public bool IsOk()
        {

            return false;

        }

    }

}
