using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace CustomUiControls { 
    public class VerticalToggleButton : CheckBox
    {

        public enum ToggleOnPositionEnum : int {BOTTOM = 0, TOP=1};

        //Fields
        private Color onBackColor = Color.Green;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        private bool solidStyle = true;
        private ToggleOnPositionEnum toggleOnPosition = ToggleOnPositionEnum.BOTTOM;        

        //Properties
        [Category("Custom")]
        public Color OnBackColor
        {
            get
            {
                return onBackColor;
            }

            set
            {
                onBackColor = value;
                this.Invalidate();
            }
        }

        [Category("Custom")]
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

        [Category("Custom")]
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

        [Category("Custom")]
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

        [Browsable(false)]
        public override string Text
        {
            get
            {
                return base.Text;
            }

            set
            {
                //
            }
        }

        [Category("Custom")]
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

        [Category("Custom")]
        public ToggleOnPositionEnum ToggleOnPosition { get => toggleOnPosition; set => toggleOnPosition = value; }        

        //Constructor
        public VerticalToggleButton()
        {
            this.MinimumSize = new Size(22, 50);           
        }

        //Methods
        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Width - 1;
            Rectangle topArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle bottomArc = new Rectangle(0, this.Height - arcSize - 2, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(topArc, 180, 180);
            path.AddArc(bottomArc, 0, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Width - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked) //ON
            {
                //Draw the control surface
                if (solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                else 
                    pevent.Graphics.DrawPath(new Pen(onBackColor,2), GetFigurePath());

                //Draw the toggle
                if (toggleOnPosition == ToggleOnPositionEnum.BOTTOM )                
                    pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(2, this.Height - this.Width + 1, toggleSize, toggleSize));
                else
                    pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
            }
            else //OFF
            {
                //Draw the control surface
                if(solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                else 
                    pevent.Graphics.DrawPath(new Pen(offBackColor, 2), GetFigurePath());
                //Draw the toggle
                if (toggleOnPosition == ToggleOnPositionEnum.BOTTOM)
                    pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
                else
                    pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, this.Height - this.Width + 1, toggleSize, toggleSize));
            }
        }
    }
}
