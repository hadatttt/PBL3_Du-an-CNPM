﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace PBL3.Views.CustomComponent
{
    public class CustomPanel : Panel
    {
        //Fields
        private int borderRadius = 10;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottonColor = Color.CadetBlue;

        #region -> Properties
        [Category("Custom panel")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }
        [Category("Custom panel")]
        public float GradientAngle
        {
            get => gradientAngle;
            set
            {
                gradientAngle = value;
                this.Invalidate();
            }
        }
        [Category("Custom panel")]
        public Color GradientTopColor
        {
            get => gradientTopColor;
            set
            {
                gradientTopColor = value;
                this.Invalidate();
            }
        }
        [Category("Custom panel")]
        public Color GradientBottonColor
        {
            get => gradientBottonColor;
            set
            {
                gradientBottonColor = value;
                this.Invalidate();
            }
        }
        #endregion

        //Constructor
        public CustomPanel()
        {
            this.Size = new Size(350, 200);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
        }

        //Methods
        private GraphicsPath GetArtanPath(RectangleF rectangle, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            path.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            path.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            //Gradient
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brushArtan = new LinearGradientBrush(this.ClientRectangle, this.GradientTopColor, this.gradientBottonColor, this.gradientAngle);
            Graphics graphicsArtan = pevent.Graphics;
            graphicsArtan.FillRectangle(brushArtan, ClientRectangle);

            //BorderRadius
            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
            if (borderRadius > 2)
            {
                using (GraphicsPath graphicsPath = GetArtanPath(rectangleF, borderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(graphicsPath);
                    pevent.Graphics.DrawPath(pen, graphicsPath);
                }
            }
            else
            {
                this.Region = new Region(rectangleF);
            }
        }
    }
}
