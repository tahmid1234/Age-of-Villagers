using AgeOfVillagers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers
{
    public class Quadrangle : DrawableShapes
    {
        private Point topLeftPoint,topRightPoint,bottomRightPoint,bottomLeftPoint;
        DrawableShapes upLine,downLine,leftLine,rightLine;
       
        private Graphics graphics;
        private Pen pen;

        public Quadrangle(Point topLeftPoint, Point topRightPoint, Point bottomLeftPoint, Point bottomRightPoint, Graphics graphics, Pen pen)
        {
            this.topLeftPoint = topLeftPoint;
            this.topRightPoint = topRightPoint;
            this.bottomLeftPoint = bottomLeftPoint;
            this.bottomRightPoint = bottomRightPoint;
            this.graphics = graphics;
            this.pen = pen;
        }

        public override void drawShape()
        {
            upLine.drawShape();
            downLine.drawShape();
            leftLine.drawShape();
            rightLine.drawShape();
        }
      

        public override void makeShape()
        {
            
            upLine = base.getLines(topLeftPoint, topRightPoint, graphics, pen);
            downLine = base.getLines(bottomLeftPoint, bottomRightPoint, graphics, pen);
            rightLine = base.getLines(topRightPoint, bottomRightPoint, graphics, pen);
            leftLine = base.getLines(topLeftPoint, bottomLeftPoint, graphics, pen);
            drawShape();
        }
    }
}
