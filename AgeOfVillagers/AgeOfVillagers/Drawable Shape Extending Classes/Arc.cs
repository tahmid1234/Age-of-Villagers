using AgeOfVillagers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class Arc : DrawableShapes
    {
        Point start;
        Pen p;
        Graphics g;
        int startAng, endAng;
        int lenght, width;

        public Arc (Graphics g, Pen p, Point start, int startAng,int endAng,int lenght,int width)
        {
            this.g = g;
            this.p = p;
            this.start = start;
            this.startAng = startAng;
            this.endAng = endAng;
            this.lenght = lenght;
            this.width = width;
        }

        public override void drawShape()
        {
            g.DrawArc(p, start.X, start.Y, width,lenght, startAng,endAng);
        }

        public override void makeShape()
        {
            drawShape();
        }
    }
}
