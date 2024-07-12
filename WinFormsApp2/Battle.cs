using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WinFormsApp2
{

    public class Battle
    {

        private Party party = null;
        private Dictionary<int, Monster> enemies = new Dictionary<int, Monster>();

        public void AddParty(Party party)
        {
            this.party = party;
        }

        public void AddEnemy(Monster monster)
        {
            enemies.Add(monster.GetId(),monster)
        }

    }

}
