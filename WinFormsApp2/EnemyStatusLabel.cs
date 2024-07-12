using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class EnemyStatusLabel:Label,Observer
    {
        private Enemy enemy;

        public EnemyStatusLabel() : this(NullEnemy.GetInstance())
        {

        }

        public EnemyStatusLabel(Enemy enemy)
        {

            AddEnemy(enemy);

            update();

        }

        public void AddEnemy(Enemy enemy)
        {

            Debug.Assert(enemy != null);

            this.enemy = enemy;

            Debug.Assert(this.enemy != null);

        }

        public void update()
        {

        }
    }
}
