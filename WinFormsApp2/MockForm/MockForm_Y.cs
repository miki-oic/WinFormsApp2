﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.MockForm
{
    public partial class MockForm_Y : Form
    {
        MockPlayer1 player1 = new MockPlayer1();
        MockPlayer2 player2 = new MockPlayer2();
        MockPlayer3 player3 = new MockPlayer3();
        MockPlayer4 player4 = new MockPlayer4();

        public MockForm_Y()
        {
            InitializeComponent();

            label1.Text = player1.GetJob() + ":" + player1.GetName() + ":" + player1.GetHitPointForDisplay() + "/" + player1.GetMAXHitPoint();
            label2.Text = player2.GetJob() + ":" + player2.GetName() + ":" + player2.GetHitPointForDisplay() + "/" + player2.GetMAXHitPoint();
            label3.Text = player3.GetJob() + ":" + player3.GetName() + ":" + player3.GetHitPointForDisplay() + "/" + player3.GetMAXHitPoint();
            label4.Text = player4.GetJob() + ":" + player4.GetName() + ":" + player4.GetHitPointForDisplay() + "/" + player4.GetMAXHitPoint();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Statas(player1);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Statas(player2);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Statas(player3);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Statas(player4);
        }

        private void Statas(MockPlayer_Y player)
        {
            label5.Text = player.GetJob();
            label6.Text = player.GetName();
            label7.Text = "Lv:" + player.GetPlayerLv();
            label8.Text = "HP:" + player.GetHitPointForDisplay();
            label9.Text = "AC:" + player.GetACForDisplay();
            //label10.Text = player
            //label11.Text = player
        }

        private void Log(string name, string command)
        {
            listBox1.Items.Add(name+"は"+command+"を使った");
        }
    }
}
