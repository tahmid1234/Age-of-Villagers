using AgeOfVillagers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class CircularShape : DrawableShapes
    {
        Point startingPoint;
        
        Graphics graphics;
       
        int  width;
        Pen pen;
        DrawableShapes arc;
        
        private int height;
        private int startingAngle;
        private int endingAngle;

        public CircularShape(Graphics graphics, Pen pen, Point startingPoint, int height, int width, int startingAngle, int endingAngle)
        {
            this.graphics = graphics;
            this.pen = pen;
            this.startingPoint = startingPoint;
            this.height = height;
            this.width = width;
            this.startingAngle = startingAngle;
            this.endingAngle = endingAngle;
        }

        public override void drawShape()
        {
            arc.drawShape();
        }

        public override void makeShape()
        {
            arc = getArcs(graphics, pen, startingPoint, startingAngle, endingAngle, height, width);
            drawShape();
        }
    }
}
