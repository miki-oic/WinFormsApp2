using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Party
    {
        private int id;
        private Dictionary<int,Player> member = new Dictionary<int, Player>();

        public int GetId()
        {
            return id;
        }
        public Player GetPlayer(int id)
        {
            return member[id];
        }
    }
    
}
