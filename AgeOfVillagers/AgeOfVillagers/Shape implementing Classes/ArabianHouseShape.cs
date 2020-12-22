using AgeOfVillagers.AbstractClass;
using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Shape_implementing_Classes
{
    public class ArabianHouseShape :Shapes
    {
        private Graphics graphics;
        private Pen pen;
        private Point startingPoint;
        private int house_height;
        private int house_width;
        private Point frontTopPoint, frontRightPoint;
        private Point backTopLeftPoint, backTopRightPoint, backBottomLeftPoint, backBottomRightPoint;
        DrawableShapeFactory drawableShapeFactory;
        private DrawableShapes frontSide, backSide;


        public ArabianHouseShape(Graphics g, Pen pen, Point point, int house_height, int house_width)
        {
            this.graphics = g;
            this.pen = pen;
            this.startingPoint = point;
            this.house_height = house_height;
            this.house_width = house_width;
            drawableShapeFactory = new DrawableShapeFactory();
        }

        public void makeShape()
        {
            frontRightPoint = new Point(startingPoint.X + 2 * (house_width / 5), startingPoint.Y);
            frontTopPoint = new Point((startingPoint.X + frontRightPoint.X) / 2, startingPoint.Y - house_height);
            frontSide=drawableShapeFactory.GetDrawableShape(graphics, pen, frontTopPoint, frontRightPoint, startingPoint, DefaultValue.TRIANGLE_HINT);
            frontSide.makeShape();
            backBottomLeftPoint = frontRightPoint;
            backTopLeftPoint = frontTopPoint;
            backTopRightPoint = new Point(backTopLeftPoint.X + 3 * (house_width / 5), backTopLeftPoint.Y);
            backBottomRightPoint = new Point(backBottomLeftPoint.X + 3 * (house_width / 5), backBottomLeftPoint.Y);
            backSide=drawableShapeFactory.GetDrawableShape(graphics, pen, backTopLeftPoint, backTopRightPoint, backBottomLeftPoint, backBottomRightPoint, DefaultValue.RECT_HINT);
            backSide.makeShape();




        }
    }
}
