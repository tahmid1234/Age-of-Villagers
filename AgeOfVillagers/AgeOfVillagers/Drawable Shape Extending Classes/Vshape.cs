using AgeOfVillagers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Drawable_Shape_Extending_Classes
{
    public class Vshape : DrawableShapes
    {
        private Point centerPoint;
        private Point rightPoint;
        private Point leftPoint;
        private Graphics graphics;
        private Pen pen;
        private DrawableShapes rightLine, leftLine;

        public Vshape(Point centerPoint, Point rightPoint, Point leftPoint, Graphics graphics, Pen pen)
        {
            this.centerPoint = centerPoint;
            this.rightPoint = rightPoint;
            this.leftPoint = leftPoint;
            this.graphics = graphics;
            this.pen = pen;
        }

        public override void drawShape()
        {
            rightLine.drawShape();
            leftLine.drawShape();
        }

        public override void makeShape()
        {
            rightLine = base.getLines(rightPoint, centerPoint, graphics, pen);
            leftLine = base.getLines(leftPoint, centerPoint, graphics, pen);
            drawShape();
        }
    }
}
