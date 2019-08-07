using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Historieta
{
    class Historieta
    {
        int x, y;
        public PictureBox img;
        public Historieta(int i, int j)
        {
            x = i;
            y = j;
            img = new PictureBox();
            img.Location = new System.Drawing.Point(x * 192, y * 127);
            img.Size = new System.Drawing.Size(190, 125);
            img.Image = Image.FromFile("h" + (x + 1).ToString() + "1.jpg");
        }
        public void hilo()
        {
            int i = 1;
            while (true)
            {
                Thread.Sleep(500);
                i++;
                if (i == 8)
                    i = 1;
                img.Image = Image.FromFile("h" + (x + 1).ToString() + i.ToString() + ".jpg");
            }
        }
    }
}
