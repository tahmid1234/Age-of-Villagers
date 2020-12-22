using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.AbstractClass
{
    public abstract class DrawableShapes : Shapes
    {
        public abstract void drawShape();

        public void setDrawingElement( Graphics g, Pen p)
        {
            
        }


        internal DrawableShapes getLines(Point start, Point end,Graphics g,Pen pen)
        {
            return new Line(start, end,g,pen);
        }

        internal DrawableShapes getArcs(Graphics g, Pen pen, Point point, int startAng, int endAng, int lenght, int width)
        {
            
            return new Arc(g,pen,point,startAng,endAng,lenght,width);
        }

        

        public abstract void makeShape();
        
    }
}
