using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{

    public class NullBattle : NullObject
    {

        private static NullBattle nullBattle = new NullBattle();

        private NullBattle()
        {
        }

        public static NullBattle getInstance()
        {

            return nullBattle;

        }

    }

}
