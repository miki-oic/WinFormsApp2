using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public interface Priest:Player
    {
        int GetFaithPoint();
    }

    public class PriestModel:PlayerModel,Priest
    {
        private int faithPoint;
        public PriestModel()
        {
            faithPoint = 100;
        }

        public PriestModel(string name, int hitPoint, int faithPoint)
        {
            this.faithPoint = faithPoint;
        }

        public int GetFaithPoint()
        {
            return faithPoint;
        }

        public override int Attack()
        {
            return Faith();
        }

        public int Faith()
        {
            return faithPoint;
        }
    }
}
