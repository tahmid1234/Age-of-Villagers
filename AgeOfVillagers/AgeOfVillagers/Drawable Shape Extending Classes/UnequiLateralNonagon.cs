using AgeOfVillagers.AbstractClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class UnequilateralNonagon : DrawableShapes
    {
        Graphics graphics;
        Pen pen;
        Point startingPoint;
        int unitHeight, unitWidth;
        DrawableShapes topLeftLine, topMidLeftLine, topMidRightLine, topRightLine, bottomLeftLine, bottomMidLeftLine, bottomMidRightLine, bottomRightLine,topMidLine,topEndLine,bottomEndLine;
        Point topLeftPoint, topMidLeftPoint, topMidRightPoint,  bottomLeftPoint, bottomMidLeftPoint, bottomMidRightPoint,endPoint,topMidPoint;

        public UnequilateralNonagon(Point startingPoint, Point topLeftPoint, Point topMidLeftPoint, Point topMidPoint, Point topMidRightPoint, Point bottomLeftPoint, Point bottomMidLeftPoint, Point bottomMidRightPoint, Point endPoint, Graphics graphics, Pen pen)
        {
            this.startingPoint = startingPoint;
            this.topLeftPoint = topLeftPoint;
            this.topMidLeftPoint = topMidLeftPoint;
            this.topMidPoint = topMidPoint;
            this.topMidRightPoint = topMidRightPoint;
            this.bottomLeftPoint = bottomLeftPoint;
            this.bottomMidLeftPoint = bottomMidLeftPoint;
            this.bottomMidRightPoint = bottomMidRightPoint;
            this.endPoint = endPoint;
            this.graphics = graphics;
            this.pen = pen;
        }

        public override void drawShape()
        {
            topLeftLine.drawShape();
            topMidLeftLine.drawShape();
            topMidLine.drawShape();
            topMidRightLine.drawShape();
            topEndLine.drawShape();
            bottomLeftLine.drawShape();
            bottomMidLeftLine.drawShape();
            bottomMidRightLine.drawShape();
            bottomEndLine.drawShape();
            


        }

        public override void makeShape()
        {
            
            


            topLeftLine = base.getLines(startingPoint, topLeftPoint,graphics,pen);
            topMidLeftLine = base.getLines(topLeftPoint, topMidLeftPoint, graphics, pen);
            topMidLine = base.getLines(topMidLeftPoint, topMidPoint, graphics, pen);
            topMidRightLine = base.getLines(topMidPoint, topMidRightPoint, graphics, pen);
            topEndLine=base.getLines(topMidRightPoint, endPoint, graphics, pen);
            bottomLeftLine = base.getLines(startingPoint, bottomLeftPoint, graphics, pen);
            bottomMidLeftLine = base.getLines(bottomLeftPoint, bottomMidLeftPoint, graphics, pen);  
            bottomMidRightLine = base.getLines(bottomMidLeftPoint, bottomMidRightPoint, graphics, pen);
            bottomEndLine = base.getLines(bottomMidRightPoint, endPoint, graphics, pen);
            drawShape();





            drawShape();
        }
    }
}
