using System;
using System.Windows.Forms;
using System.Drawing;

namespace RPElite
{
    class RPButton : Control
    {
        // Border.
        private bool drawBorder = true;
        public bool DrawBorder { get { return drawBorder; } set { drawBorder = value; Invalidate(); } }
        private Color BorderColor = Color.Black;
        private Color OnHoverBorderColor = Color.Gray;
        // Text.
        private Color TextColor = Color.White;
        private Color OnHoverTextColor = Color.Gray;
        // Button color up and down.
        private Color CurrentBackColor;
        private readonly Color EliteBackColor = Color.FromArgb(255, 133, 0);
        private readonly Color DownColor = Color.RoyalBlue;
        // Hover.
        private bool IsHovering;
        private Color onHoverBackColor = Color.FromArgb(255, 112, 0);
        public Color OnHoverBackColor { get { return onHoverBackColor; } set { onHoverBackColor = value; Invalidate(); } }
        
        private int BorderThickness = 2;
        private int BorderThicknessByTwo = 1;

        public RPButton()
        {
            DoubleBuffered = true;
            CurrentBackColor = EliteBackColor;
            IsHovering = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            Brush brush;

            // Border.
            if (DrawBorder)
            {
                brush = new SolidBrush(IsHovering ? OnHoverBorderColor : BorderColor);
                g.FillEllipse(brush, 0, 0, Height, Height);
                g.FillEllipse(brush, Width - Height, 0, Height, Height);
                g.FillRectangle(brush, Height / 2, 0, Width - Height, Height);
                brush.Dispose();
            }

            brush = new SolidBrush(CurrentBackColor);

            // Inner part. Button itself
            g.FillEllipse(brush, BorderThicknessByTwo, BorderThicknessByTwo, Height - BorderThickness, Height - BorderThickness);
            g.FillEllipse(brush, (Width - Height) + BorderThicknessByTwo, BorderThicknessByTwo, Height - BorderThickness, Height - BorderThickness);
            g.FillRectangle(brush, Height / 2 + BorderThicknessByTwo, BorderThicknessByTwo, Width - Height - BorderThickness, Height - BorderThickness);

            brush.Dispose();
            brush = new SolidBrush(IsHovering ? OnHoverTextColor : TextColor);

            // Text.
            SizeF stringSize = g.MeasureString(Text, Font);
            g.DrawString(Text, Font, brush, (Width - stringSize.Width) / 2, (Height - stringSize.Height) / 2);
            // Old
            //e.Graphics.FillRectangle(new SolidBrush(CurrentBackColor), 0, 0, Width, Height);
            //TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            //TextRenderer.DrawText(e.Graphics, Text, Font, new Point(Width + 3, Height / 2), ForeColor, flags);
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
