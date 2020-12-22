using AgeOfVillagers.AbstractClass;
using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.Shape_implementing_Classes
{
    public class InuitHouseIglooShape : Shapes
    {
        private Graphics graphics;
        private Pen pen;
        private Point startingPoint,innerPoint,endPoint,baseStartinPoint;
        private int house_height;
        private int house_width;
        private DrawableShapeFactory drawableShapeFactory;
        private DrawableShapes outterHalfCircle,innerHalfCircle,baseLine;

        public InuitHouseIglooShape(Graphics graphics, Pen pen, Point startingPoint, int house_height, int house_width)
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
            outterHalfCircle = drawableShapeFactory.GetDrawableShape(graphics, pen, startingPoint, DefaultValue.HALF_CIRCLE_STARTING_ANGLE,DefaultValue.HALF_CIRCLE_ENDING_ANGLE,2* house_height,house_width, DefaultValue.CIRCULAR_HINT);
            outterHalfCircle.makeShape();
            
            
            baseStartinPoint = new Point(startingPoint.X, startingPoint.Y + house_height);
            //graphics.DrawRectangle(pen, startingPoint.X, startingPoint.Y, house_width, house_height);
            endPoint = new Point(baseStartinPoint.X + house_width, baseStartinPoint.Y);
            baseLine = drawableShapeFactory.GetDrawableShape(graphics, pen, baseStartinPoint, endPoint, DefaultValue.LINE_HINT);
            baseLine.makeShape();
            innerPoint = new Point(baseStartinPoint.X + house_width / 4, baseStartinPoint.Y - house_height/2 );
            innerHalfCircle = drawableShapeFactory.GetDrawableShape(graphics, pen, innerPoint, DefaultValue.HALF_CIRCLE_STARTING_ANGLE, DefaultValue.HALF_CIRCLE_ENDING_ANGLE, house_height , house_width / 2, DefaultValue.CIRCULAR_HINT);
            innerHalfCircle.makeShape();

        }
    }
}
