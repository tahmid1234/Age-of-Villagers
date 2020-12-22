using AgeOfVillagers.AbstractClass;
using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace AgeOfVillagers.Shape_extended_classes
{
    public class BangladeshiTreeShape : Shapes
    {
        private Graphics graphics;
        private Pen pen;
        private Point startingPoint;
        private Point leafCenterPoint;
        private Point rootTopLeftPoint;
        private Point rootTopRightPoint;
        private Point rootbottomLeftPoint;
        private Point rootBottomRightPoint;
        private int height, width;
        DrawableShapeFactory basicShapeFactory;
   
        public BangladeshiTreeShape(Graphics graphics, Pen pen, Point startingPoint, int height, int width)
        {
            this.pen = pen;
            this.height = height;
            this.width = width;
            this.graphics = graphics;
            this.startingPoint = startingPoint;
            
            basicShapeFactory = new DrawableShapeFactory();
        }

        public void makeShape()
        {
            DrawableShapes leaf = basicShapeFactory.GetDrawableShape(graphics, pen, startingPoint, DefaultValue.FULL_CIRCLE_STARTING_ANGLE, DefaultValue.FULL_CIRCLE_ENDING_ANGLE, 3 * (height / 4), width, DefaultValue.CIRCULAR_HINT);
            leaf.makeShape();
            leafCenterPoint = new Point(startingPoint.X + 3 * (width / 8), startingPoint.Y + width / 2);
            rootTopLeftPoint = leafCenterPoint;
            rootTopRightPoint = new Point(rootTopLeftPoint.X +  (width / 4),rootTopLeftPoint.Y);
            rootbottomLeftPoint= new Point(rootTopLeftPoint.X , rootTopLeftPoint.Y+ 5 * (height / 8));
            rootBottomRightPoint = new Point(rootTopLeftPoint.X + (width / 4), rootTopLeftPoint.Y + 5 * (height / 8));
            DrawableShapes root = basicShapeFactory.GetDrawableShape(graphics, pen, rootTopLeftPoint,rootTopRightPoint,rootbottomLeftPoint,rootBottomRightPoint, DefaultValue.RECT_HINT);
            root.makeShape();
        }

       
    }
}
