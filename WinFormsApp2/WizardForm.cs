﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class WizardForm : PlayerForm
    {

        public WizardForm(WizardModel wizard) : base(wizard)
        {

            // 職業
            addClassName("魔法使い");

        }

    }

}
