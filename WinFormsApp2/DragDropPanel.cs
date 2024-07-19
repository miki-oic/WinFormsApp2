using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{

    public class DragDropPanel : Panel, ISerializable
    {

        public DragDropPanel()
        {

            // ドラッグ＆ドロップを実行可能にする
            initializeDragDrop();

        }

        private void initializeDragDrop()
        {

            MouseDown += event_MouseDown;

        }

        private void event_MouseDown(object sender, MouseEventArgs e)
        {


            if (e.Button == MouseButtons.Right)
            {

                if (ContextMenuStrip != null)
                {

                    // コンテキストメニューを表示する
                    ContextMenuStrip.Show(this, e.X, e.Y);

                }

            }
            else if (DoDragDrop(this, DragDropEffects.Copy) == DragDropEffects.Copy)
            {

                // ここに複写したときの振る舞いを実装する
                setLocation(e.X, e.Y);

            }
            else if (DoDragDrop(this, DragDropEffects.Move) == DragDropEffects.Move)
            {

                // ここに移動したときの振る舞いを実装する
                //setLocation(e.X, e.Y);

            }

        }

        public DragDropPanel setLocation(int x, int y)
        {

            // 表示位置を指定する
            Location = new Point(x, y);

            return this;

        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {

            // NOP

        }

    }

}
