using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking.usercontrol
{
    [DefaultEvent("Click")]
    public partial class CustomButton : UserControl
    {
        int wh = 20; float ang = 45;
        Color c10 = Color.Blue, cli = Color.Orange;
        Timer t = new Timer();
        String txt = "LOGIN";
        public CustomButton()
        {
            DoubleBuffered = true;
            t.Interval = 60;
            t.Start();
            t.Tick += (s, e) => { Angle = Angle % 360 + 1; };
            ForeColor = Color.White;
        }
        public float Angle
        {
            get { return ang; }
            set { ang = value; Invalidate(); }
        }
        public int BorderRadius
        {
            get { return wh; }
            set { wh = value; Invalidate(); }
        }
        public Color Color0
        {
            get { return c10; }
            set { c10 = value; Invalidate(); }
        }
        public Color Color1
        {
            get { return cli; }
            set { cli = value; Invalidate(); }

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(new Rectangle(0, 0, wh, wh), 180, 90);
            gp.AddArc(new Rectangle(Width - wh, 0, wh, wh), -90, 90);
            gp.AddArc(new Rectangle(Width - wh, Height - wh, wh, wh), 0, 90);
            gp.AddArc(new Rectangle(0, Height - wh, wh, wh), 90, 90);
            e.Graphics.FillPath(new LinearGradientBrush(ClientRectangle, c10, cli, 45), gp);
            e.Graphics.DrawString(txt, Font, new SolidBrush(ForeColor), ClientRectangle, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
            base.OnPaint(e);
        }
    }
}
