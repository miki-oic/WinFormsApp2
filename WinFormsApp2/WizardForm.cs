using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class WizardForm : PlayerForm
    {

        public WizardForm(Wizard wizard) : base(wizard)
        {

            // 職業
            AddPlayer(wizard);

        }

    }

}
