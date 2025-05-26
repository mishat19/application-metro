using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application_metro
{
    public static class GroupBoxBordure
    {
        public static void ApplyCustomStyle(GroupBox box, PaintEventArgs e, int borderRadius = 12, int borderWidth = 5, Color? borderColor = null)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color color = borderColor ?? Color.FromArgb(205, 33, 42);
            Rectangle rect = box.ClientRectangle;
            rect.Width -= 2;
            rect.Height -= 2;

            using (Pen pen = new Pen(color, borderWidth))
            using (GraphicsPath path = GetRoundedRect(rect, borderRadius))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private static GraphicsPath GetRoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(bounds.Left, bounds.Top, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Top, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
