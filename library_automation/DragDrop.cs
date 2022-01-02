using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace library_automation
{
    internal class DragDrop
    {
        // CURRRENT CLOSE FORM BEGIN ------------------------------------------------------
        public void current_exit_form(Form frm)
        {
            frm.Close();
            Application.Exit();
        }
        // CURRRENT CLOSE FORM END ------------------------------------------------------
        // DRAG DROP VERIABLES BEGIN ------------------------------------------------------
        private bool dragging = false;//Sürükleme özelliğimiz
        private Point dragCursorPoint;
        private Point dragFormPoint;
        // DRAG DROP VERIABLES END -------------------------------------------------------
        // FORM DEFAULT LOAD BEGIN
        public void default_form(Form frm)
        {
            frm.TopMost = true;
            frm.BringToFront();
            frm.Text = String.Empty;
            frm.ControlBox = true;
        }
        // FORM DEFAULT LOAD END
        // PANEL DRAG DROP METHOTDS BEGIN ------------------------------------------------------
        public void panel_Down(Form frm)
        //Tıkladığımızda mouse tuşu aşağı doğru hareket edince gerçekleşir.
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = frm.Location;
        }
        public void panel_Up()
        //Mouse tuşu yukarı kalktığında gerçekleşecek ifademiz. 
        {
            dragging = false;
        }
        public void panel_Move(Form frm)
        //Mouse hareket ederse gerçekleşecek ifadeler. Biz basılı iken hareket etmesi için dragging tanımladık.
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                frm.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        // PANEL DRAG DROP METHOTDS END ------------------------------------------------------
        // LABEL DRAG DROP METHOTDS BEGIN ----------------------------------------------------
        public void label_Down(Form frm)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = frm.Location;
        }
        public void label_Move(Form frm)
        //Mouse hareket ederse gerçekleşecek ifadeler. Biz basılı iken hareket etmesi için dragging tanımladık.
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                frm.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        public void label_Up()
        {
            dragging = false;
        }
        // LABEL DRAG DROP METHOTDS END ------------------------------------------------------
    }
}
