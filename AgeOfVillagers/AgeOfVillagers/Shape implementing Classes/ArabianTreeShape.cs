using AgeOfVillagers.AbstractClass;
using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.Shape_implementing_Classes
{
    public class ArabianTreeShape : Shapes
    {
        private Graphics graphics;
        private Pen pen;
        private Point startingPoint;
        private int tREE_HEIGHT;
        private int tREE_WIDTH;
        private DrawableShapeFactory drawableShapeFactory;
        private DrawableShapes root, leftBranch, leftMidBranch,midBranch, rightMidBranch, rightBranch;
        private Point rootPoint, leftPoint, leftMidPoint,midPoint, rightMidPoint, rightPoint;

        public ArabianTreeShape(Graphics graphics, Pen pen, Point startingPoint, int tREE_HEIGHT, int tREE_WIDTH)
        {
            this.graphics = graphics;
            this.pen = pen;
            this.startingPoint = startingPoint;
            this.tREE_HEIGHT = tREE_HEIGHT;
            this.tREE_WIDTH = tREE_WIDTH;
            drawableShapeFactory = new DrawableShapeFactory();
        }

        public void makeShape()
        {
            rootPoint = new Point(startingPoint.X, startingPoint.Y + 2*tREE_HEIGHT/3);
            root = drawableShapeFactory.GetDrawableShape(graphics, pen, startingPoint, rootPoint, DefaultValue.LINE_HINT);
            root.makeShape();
            int branch_height = tREE_HEIGHT/3;
            
            leftPoint = new Point(startingPoint.X-tREE_HEIGHT/2, startingPoint.Y - branch_height/3);
            leftBranch=drawableShapeFactory.GetDrawableShape(graphics, pen, startingPoint, leftPoint, DefaultValue.LINE_HINT);
            leftBranch.makeShape();
            rightPoint = new Point(startingPoint.X + tREE_HEIGHT / 2, startingPoint.Y - branch_height / 3);
            rightBranch= drawableShapeFactory.GetDrawableShape(graphics, pen, startingPoint, rightPoint, DefaultValue.LINE_HINT);
            rightBranch.makeShape();
            leftMidPoint = new Point(startingPoint.X - tREE_HEIGHT / 2, startingPoint.Y -2* branch_height / 3);
            leftMidBranch= drawableShapeFactory.GetDrawableShape(graphics, pen, startingPoint, leftMidPoint, DefaultValue.LINE_HINT);
            leftMidBranch.makeShape();
            rightMidPoint = new Point(startingPoint.X + tREE_HEIGHT / 2, startingPoint.Y - 2 * branch_height / 3);
            rightMidBranch= drawableShapeFactory.GetDrawableShape(graphics, pen, startingPoint, rightMidPoint, DefaultValue.LINE_HINT);
            rightMidBranch.makeShape();
            midPoint = new Point(startingPoint.X + 1, startingPoint.Y - branch_height );
            midBranch= drawableShapeFactory.GetDrawableShape(graphics, pen, startingPoint, midPoint, DefaultValue.LINE_HINT);
            midBranch.makeShape();
        }
    }
}
