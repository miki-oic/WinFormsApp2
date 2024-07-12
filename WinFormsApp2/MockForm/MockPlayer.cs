using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2.MockForm
{
    public interface MockPlayer_Y : Player
    {
        //追加分
        string GetMAXHitPoint();

        string GetHitPointForDisplay();

        string GetJob();

        string GetPlayerLv();

        string GetACForDisplay();
    }
}
