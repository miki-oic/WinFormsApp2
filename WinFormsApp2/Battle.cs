using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WinFormsApp2.MockForm;

namespace WinFormsApp2
{

    public class Battle
    {

        private Party party = new Party();
        private Dictionary<int, Monster> enemies = new Dictionary<int, Monster>();
        private Dictionary<Attacker,Monster> targets = new Dictionary<Attacker,Monster>();

        public void AddParty(Party party)
        {

            this.party = party;

        }

        public void AddEnemy(Monster monster)
        {

            enemies.Add(monster.GetId(), monster);

        }
        public void Start()
        {
            targets.ToList().ForEach(targets =>
            {
                targets.Value.DamagedBy(targets.Key);
            });

        }

        public void TargetSetting(Attacker attacker, Monster target)
        {
            targets.Add(attacker, target);
        }

    }

}
