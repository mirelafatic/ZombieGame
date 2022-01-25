using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace GameM
{
    class Arrow
    {
        public string direction;
        public int arrowLeft;
        public int arrowTop;
        public int maxLen = 0;

        private int speed = 25;
        private PictureBox arrow = new PictureBox();

        private Timer arrowTimer = new Timer();

        public void MakeArrow(Panel pnl)
        {
            arrow.Image = Properties.Resources.arrow;
            arrow.Size = new Size(26, 10);
            arrow.SizeMode = PictureBoxSizeMode.StretchImage;
            arrow.Left = arrowLeft;
            arrow.Top = arrowTop;
            arrow.Tag = "arrow";
            arrow.BringToFront();

            pnl.Controls.Add(arrow);

            arrowTimer.Interval = speed;
            arrowTimer.Tick += new EventHandler(ArrowTimerEvent);
            arrowTimer.Start();



            maxLen = pnl.Width;
        }

        private void ArrowTimerEvent(object sender, EventArgs e)
        {

            if (direction == "left")
            {
                arrow.Left -= speed;
            }
            if (direction == "right")
            {
                arrow.Left += speed;
            }


            if (arrow.Left > maxLen || arrow.Left < 1)  //kada izadje iz okvira
            {
                arrowTimer.Stop();
                arrowTimer.Dispose();
                arrow.Dispose();
                arrowTimer = null;    
                arrow = null;
            } 

        }

    }
}
