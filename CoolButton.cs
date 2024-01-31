
using System.Drawing.Drawing2D;

namespace Coursework
{
    public class CoolButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            var graphicsPath = new GraphicsPath();
            graphicsPath.AddRectangle(Rectangle.FromLTRB(0, 0, Width, Height));
            this.Region = new Region(graphicsPath);
            base.OnPaint(e);
        }
    }
}
