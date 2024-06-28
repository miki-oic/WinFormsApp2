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
    public class Battle:NullObject
    {
        Dictionary<string, string> party = new Dictionary<string, string>();
        Dictionary<string, string> enemy = new Dictionary<string, string>();

        public void AddParty(Party party)
        {

        }
        public void AddEnemy(Monster monster)
        {

        }

        NullBattle nullBattle = NullBattle.getInstance();
    }
}
