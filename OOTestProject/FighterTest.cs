﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2;

namespace OOTestProject
{
    [TestClass]
    public class FighterTest
    {
        [TestMethod]
        public void GetNameTest01()
        {
            Fighter fighter = new FighterModel();
            Assert.AreEqual("ゲストプレイヤー", fighter.GetName());
        }

        [TestMethod]
        public void GetNameTest02()
        {
            Fighter fighter = new FighterModel(1, "Fighter", 2000, 300, 0);
            Assert.AreEqual("Fighter", fighter.GetName());
        }

        [TestMethod]
        public void GetNameTest03()
        {
            Fighter fighter = new FighterModel(1, "Fighter", 2000, 300, 0);
            Assert.AreEqual(2000, fighter.GetHitPoint());
        }

        [TestMethod]
        public void GetNameTest04()
        {
            Fighter fighter = new FighterModel(1, "Fighter", 2000, 300, 0);
            Assert.AreEqual(300, fighter.GetStrengh());
        }

        public void GetNameTest05()
        {
            Fighter fighter = new FighterModel(1, "Fighter", 2000, 300, 0);
            Assert.AreEqual(10, fighter.GetLevel());
        }
        public void GetNameTest06()
        {
            Fighter fighter = new FighterModel(1, "Fighter", 2000, 300, 0);
            Assert.AreEqual(10, fighter.GetArmorClass());
        }
    }
}