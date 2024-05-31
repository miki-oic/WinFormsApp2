using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{

    public class FighterForm : PlayerForm
    {

        public FighterForm(Fighter fighter) : base(fighter)
        {

            // 職業
            AddClassName("戦士");
        }

    }

}
