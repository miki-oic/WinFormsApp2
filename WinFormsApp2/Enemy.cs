namespace WinFormsApp2
{
    public interface Enemy : Attacker
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
        Enemy DamagedBy(Attacker attacker);

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
        Enemy AddObserver(Observer observer);


    }

    public class NullEnemy : Enemy
    {

        private static Enemy enemy = new NullEnemy();

        private NullEnemy()
        {

        }

        public static Enemy GetInstance()
        {

            return enemy;

        }

        public Enemy AddObserver(Observer observer)
        {

            return this;

        }

        public int Attack()
        {
            throw new NotImplementedException();
        }

        public Enemy DamagedBy(Attacker attacker)
        {
            return this;
        }

        public int GetHitPoint()
        {
            throw new NotImplementedException();
        }

        public bool IsCollapsed()
        {
            throw new NotImplementedException();
        }

        public bool IsOk()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {

            return "name";

        }


        //public class Enemy
        //{

        //}
    }
}