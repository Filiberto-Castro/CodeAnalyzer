using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeAnalyzer
{
    internal class MoverComponente
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public void Attach(Control control)
        {
            control.MouseDown += StartDrag;
            control.MouseMove += ContinueDrag;
            control.MouseUp += EndDrag;
        }

        private void StartDrag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = ((Control)sender).FindForm().Location;
            }
        }

        private void ContinueDrag(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point newCursorPoint = Cursor.Position;
                ((Control)sender).FindForm().Location = new Point(dragFormPoint.X + (newCursorPoint.X - dragCursorPoint.X), dragFormPoint.Y + (newCursorPoint.Y - dragCursorPoint.Y));
            }
        }

        private void EndDrag(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                dragging = false;
        }
    }
}
