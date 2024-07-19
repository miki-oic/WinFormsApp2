using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.MockForm;

namespace WinFormsApp2.Utilities
{

    public partial class DebugForm : Form
    {

        public DebugForm()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            new MockForm_k().Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            new Form1().Show();

        }

    }

}
