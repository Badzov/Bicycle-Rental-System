using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    public static class FormDragHelper
    {
        public static void EnableDragging(Control control)
        {
            bool mouseDown = false;
            Point lastLocation = Point.Empty;

            control.MouseDown += (s, e) =>
            {
                mouseDown = true;
                lastLocation = e.Location;
                control.Capture = true; 
            };

            control.MouseMove += (s, e) =>
            {
                if (mouseDown)
                {
                    var form = control.FindForm();
                    form.Location = new Point(
                        form.Location.X - lastLocation.X + e.X,
                        form.Location.Y - lastLocation.Y + e.Y);
                }
            };

            control.MouseUp += (s, e) =>
            {
                mouseDown = false;
                control.Capture = false;
            };
        }
    }

}
