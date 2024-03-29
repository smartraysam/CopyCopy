﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunnelCopy
{
    public class FunnyPanel : Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(Color.White), 10, 10, this.Width - 20, this.Height-15, 10);
            SolidBrush brush = new SolidBrush(Color.White);
            g.FillRoundedRectangle(brush, 10, 10, this.Width - 24, this.Height-15, 10);
            g.DrawRoundedRectangle(new Pen(ControlPaint.Light(Color.White, 0.00f)), 12, 12, this.Width - 44, this.Height - 20, 10);
            g.FillRoundedRectangle(new SolidBrush(Color.White), 12, 12 + ((this.Height - 60) / 2), this.Width - 44, (this.Height - 20) / 2, 10);


        }
        
    }
}
