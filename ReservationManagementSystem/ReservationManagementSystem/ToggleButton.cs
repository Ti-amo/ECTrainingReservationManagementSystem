﻿using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ReservationManagementSystem
{
    class ToggleButton : CheckBox
    {
        private Color onBackColor = Color.Green;
        private Color onToggleColor = Color.White;
        private Color offBackColor = Color.WhiteSmoke;
        private Color offToggleColor = Color.White;
        private bool solidStyle = true;

        public Color OnBackColor
        {
            get
            {
                return onBackColor;
            }
            set
            {
                onBackColor = value;
                // invokes the paint event to redraw the control
                this.Invalidate(); 
            }
        }
        public Color OnToggleColor
        {
            get
            {
                return onToggleColor;
            }
            set
            {
                onToggleColor = value;
                this.Invalidate();
            }
        }
        public Color OffBackColor
        {
            get
            {
                return offBackColor;
            }
            set
            {
                offBackColor = value;
                this.Invalidate();
            }
        }
        public Color OffToggleColor 
        {
            get
            {
                return offToggleColor;
            }
            set
            {
                offToggleColor = value;
                this.Invalidate();
            }
        }
        [DefaultValue(true)]
        public bool SolidStyle
        {
            get
            {
                return solidStyle;
            }
            set
            {
                solidStyle = value;
                this.Invalidate();
            }
        }

        public ToggleButton()
        {
            this.MinimumSize = new Size(45, 22);
        }
        private GraphicsPath GetFigurePath()
        {
            int arcSize = (int)this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle((int)this.Width - arcSize - 2, 0, arcSize, arcSize);

            // draw the arc
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = (int)this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked)
            {
                // draw the control surface
                if (solidStyle)
                {
                    pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                }
                else
                {
                    pevent.Graphics.DrawPath(new Pen(onBackColor, 2), GetFigurePath());
                }
                // draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle((int)this.Width - (int)this.Height + 1, 2, toggleSize, toggleSize));
            }
            else
            {
                // draw the control surface
                if (solidStyle)
                {
                    pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                }
                else
                {
                    pevent.Graphics.DrawPath(new Pen(offBackColor, 2), GetFigurePath());
                }
                // draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}
