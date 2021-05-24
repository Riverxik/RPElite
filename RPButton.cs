using System;
using System.Windows.Forms;
using System.Drawing;

namespace RPElite
{
    class RPButton : Control
    {
        private readonly Color EliteBackColor = Color.FromArgb(255, 133, 0);
        private readonly Color DownColor = Color.RoyalBlue;
        private Color CurrentBackColor;
        private Color onHoverBackColor = Color.FromArgb(255, 112, 0);
        public Color OnHoverBackColor { get { return onHoverBackColor; } set { onHoverBackColor = value; Invalidate(); } }

        public RPButton()
        {
            CurrentBackColor = EliteBackColor;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(new SolidBrush(CurrentBackColor), 0, 0, Width, Height);
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(e.Graphics, Text, Font, new Point(Width + 3, Height / 2), ForeColor, flags);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            CurrentBackColor = onHoverBackColor;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            CurrentBackColor = EliteBackColor;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            CurrentBackColor = DownColor;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            CurrentBackColor = EliteBackColor;
            Invalidate();
        }
    }
}
