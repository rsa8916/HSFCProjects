using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;


namespace pictureBoxGameBreakout
{
    public class GameObject
    {
        protected bool blnIsVisible;
        protected Rectangle recPosition;
        protected System.Drawing.Brush drawingBrushColour;

        public GameObject(int x, int y, 
                          int width, int height, 
                          bool blnIsVisable, Brush drawingBrushColour)
        {
            this.blnIsVisible = blnIsVisible;//this. refers to to the property of blnIsVisible
            recPosition = new Rectangle(x, y, width, height);
            this.drawingBrushColour = drawingBrushColour;
        }

        public bool GetBlnIsVisible()
        {
            return blnIsVisible;
        }
        public Rectangle GetRecPosition()
        {
            return recPosition;
        }
        public Brush GetDrawingsBrushColour()
        {
            return drawingBrushColour;
        }
        public void SetBlnIsVisible(bool isVisible)
        {
            blnIsVisible = isVisible;
        }
        public void SetRecPosition(Rectangle position)
        {
            recPosition = position;
        }
        public void SetDrawings
    }
}
