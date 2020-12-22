using AgeOfVillagers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class Triangle : DrawableShapes
    {
        private Point  rightPoint, topPoint;
        DrawableShapes rightLine,leftLine,baseLine;
        private Point leftPoint;
        private Graphics graphics;
        private Pen pen;

        public Triangle(Point topPoint, Point rightPoint, Point leftPoint, Graphics graphics, Pen pen)
        {
            this.topPoint = topPoint;
            this.rightPoint = rightPoint;
            this.leftPoint = leftPoint;
            this.graphics = graphics;
            this.pen = pen;
        }

        public override void drawShape()
        {
            rightLine.drawShape();
            leftLine.drawShape();
            baseLine.drawShape();
        }

       

        public override void makeShape()
        {
            
           

            rightLine = base.getLines(rightPoint, topPoint, graphics, pen);
            leftLine = base.getLines(leftPoint, topPoint, graphics, pen);
            baseLine = base.getLines(leftPoint, rightPoint, graphics, pen);

            drawShape();
        }

        
    }
}
