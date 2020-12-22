using AgeOfVillagers.AbstractClass;
using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Shape_implementing_Classes
{
    public class EgyptianHouseShape : Shapes
    {
        private Graphics graphics;
        private Pen pen;
        private Point startingPoint;
        private Point tentBottomPoint;
        private Point tentBottomLeftPoint;
        private Point tentBottomRightPoint;
        private int house_height;
        private int house_width;
        DrawableShapeFactory drawableShapeFactory;
        DrawableShapes tent, frontSide;

        public EgyptianHouseShape(Graphics graphics, Pen pen, Point startingPoint, int house_height, int house_width)
        {
            this.graphics = graphics;
            this.pen = pen;
            this.startingPoint = startingPoint;
            this.house_height = house_height;
            this.house_width = house_width;
            drawableShapeFactory = new DrawableShapeFactory();
        }

        public void makeShape()
        {
            tentBottomPoint = new Point(startingPoint.X + house_width/16, startingPoint.Y+house_height);
            tentBottomRightPoint = new Point(startingPoint.X + house_width / 2, startingPoint.Y + 3 * house_height / 4);
            tentBottomLeftPoint = new Point(startingPoint.X - house_width / 2, startingPoint.Y + 3 * house_height / 4);
            tent = drawableShapeFactory.GetDrawableShape(graphics, pen, startingPoint, tentBottomRightPoint, tentBottomLeftPoint,tentBottomPoint, DefaultValue.RECT_HINT);
            tent.makeShape();
            frontSide = drawableShapeFactory.GetDrawableShape(graphics, pen, startingPoint, tentBottomPoint, DefaultValue.LINE_HINT);
            frontSide.makeShape();

        }
    }
}
