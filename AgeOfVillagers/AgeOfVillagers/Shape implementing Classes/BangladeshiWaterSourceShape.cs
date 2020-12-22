using AgeOfVillagers.AbstractClass;
using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.IItem_implementing_Classes
{
    public class BangladeshiWaterSourceShape : Shapes
    {
        Graphics graphics;
        Pen pen;
        private Point startingPoint,endPoint;
        private Point topLeftPoint, topMidLeftPoint, topMidPoint, topMidRightPoint;
        private Point bottomLeftPoint, bottomMidLeftPoint, bottomMidRightPoint;
        int height, width;
        DrawableShapeFactory basicShapeFactory;
        public BangladeshiWaterSourceShape(Graphics graphics, Pen pen, Point startingPoint, int length, int width)
        {
            this.pen = pen;
            this.height = length;
            this.width = width;
            this.graphics = graphics;
            this.startingPoint = startingPoint;
            basicShapeFactory = new DrawableShapeFactory();
        }

        public void makeShape()
        {
            int unitWidth = width / 8;
            int unitHeight = height / 8;
            topLeftPoint = new Point(startingPoint.X + 3 * unitWidth, startingPoint.Y - 2 * unitHeight);
            topMidLeftPoint = new Point(topLeftPoint.X + unitWidth, startingPoint.Y - 3 * unitHeight);
            topMidPoint = new Point(topMidLeftPoint.X, startingPoint.Y - unitHeight);
            topMidRightPoint = new Point(topMidPoint.X + 2 * unitWidth, startingPoint.Y - 4 * unitHeight);
            bottomLeftPoint = new Point(startingPoint.X + 3 * unitWidth, startingPoint.Y + 4 * unitHeight);
            bottomMidLeftPoint = new Point(bottomLeftPoint.X + unitWidth, startingPoint.Y + unitHeight);
            bottomMidRightPoint = new Point(bottomMidLeftPoint.X + unitWidth, startingPoint.Y + 3 * unitHeight);
            endPoint = new Point(startingPoint.X + 8 * unitWidth, startingPoint.Y);
            DrawableShapes nonagon = basicShapeFactory.GetDrawableShape(graphics, pen, startingPoint, topLeftPoint, topMidLeftPoint, topMidPoint, topMidRightPoint, bottomLeftPoint, bottomMidLeftPoint, bottomMidRightPoint, endPoint, DefaultValue.UNEQUAL_NONAGON_HINT);
            nonagon.makeShape();
        }

       
    }
}
