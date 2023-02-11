﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EaseyBudget
{
    public class Gradient : Panel
    {
        public Color TopColor { get; set; }
        public Color BotColor { get; set; }
        public float Angle { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, 
                this.TopColor, this.BotColor, this.Angle);
            
            Graphics g = e.Graphics;
            g.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
