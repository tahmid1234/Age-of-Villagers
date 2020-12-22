using AgeOfVillagers.AbstractClass;
using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.Shape_implementing_Classes
{
    public class EgyptianTreeShape : Shapes
    {
        private Graphics graphics;
        private Pen pen;
        private Point startingPoint;
        private int tree_height;
        private int tree_width;
        private Point rootLeftPoint, leftBranchLeftPoint, leftBranchRightPoint, leftBranchMidPoint;
        private Point rootRightPoint, rightBranchLeftPoint, righttBranchRightPoint, righttBranchMidPoint;
        private DrawableShapeFactory drawableShapeFactory;
        private DrawableShapes root, leftBranch, leftMidBranch, rightBranch, rightMidBranch;
        private int branchHeight, branchWidth;
        public EgyptianTreeShape(Graphics graphics, Pen pen, Point startingPoint, int tree_height, int tree_width)
        {
            this.graphics = graphics;
            this.pen = pen;
            this.startingPoint = startingPoint;
            this.tree_height = tree_height;
            this.tree_width = tree_width;
            drawableShapeFactory = new DrawableShapeFactory();
        }

        public void makeShape()
        {
            rootRightPoint = new Point(startingPoint.X + (tree_width) / 4, startingPoint.Y - 2*tree_height / 3);
            rootLeftPoint = new Point(startingPoint.X - (tree_width)/4, startingPoint.Y - 2*tree_height / 3);
            root = drawableShapeFactory.GetDrawableShape(graphics, pen, startingPoint, rootRightPoint, rootLeftPoint, DefaultValue.VSHAPE_HINT);
            root.makeShape();
            
            branchHeight = (tree_height -  2*tree_height / 3);
            branchWidth = (tree_width -  tree_width / 2);
            
            
            rightBranchLeftPoint= new Point(rootRightPoint.X -branchWidth/2, rootRightPoint.Y - branchHeight );
            righttBranchRightPoint= new Point(rootRightPoint.X + branchWidth / 2, rootRightPoint.Y - branchHeight );
            righttBranchMidPoint = new Point(startingPoint.X + (tree_width) / 4 , rootRightPoint.Y -  branchHeight );
            rightBranch = drawableShapeFactory.GetDrawableShape(graphics, pen, rootRightPoint, righttBranchRightPoint, rightBranchLeftPoint, DefaultValue.VSHAPE_HINT);
            rightBranch.makeShape();   
            
            rightMidBranch = drawableShapeFactory.GetDrawableShape(graphics, pen,  rootRightPoint, righttBranchMidPoint, DefaultValue.LINE_HINT);
            rightMidBranch.makeShape();

            leftBranchLeftPoint = new Point(rootLeftPoint.X - branchWidth / 2, rootLeftPoint.Y - branchHeight);
            leftBranchRightPoint = new Point(rootLeftPoint.X + branchWidth / 2, rootLeftPoint.Y - branchHeight);
            leftBranchMidPoint = new Point(startingPoint.X - (tree_width) / 4, rootLeftPoint.Y - branchHeight);
            leftBranch = drawableShapeFactory.GetDrawableShape(graphics, pen, rootLeftPoint, leftBranchRightPoint, leftBranchLeftPoint, DefaultValue.VSHAPE_HINT);
            leftBranch.makeShape();

            leftMidBranch = drawableShapeFactory.GetDrawableShape(graphics, pen, rootLeftPoint, leftBranchMidPoint, DefaultValue.LINE_HINT);
            leftMidBranch.makeShape();
            //MessageBox.Show(rightBranchLeftPoint + " " + righttBranchRightPoint + " " + righttBranchMidPoint + " " + rootRightPoint);
        }
    }
}
