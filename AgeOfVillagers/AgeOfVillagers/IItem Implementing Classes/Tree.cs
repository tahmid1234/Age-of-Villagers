using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.IItem_Implementing_Classes
{
    public class Tree : IItem
    {
        Point point;
        private Graphics graphics;
        private Pen pen;

        ShapeFactory shapeFactory;
        Shapes shape;

        

        public Tree(Point point, Graphics graphics, Pen pen) 
        {
            this.point = point;
            this.graphics = graphics;
            this.pen = pen;
            shapeFactory = new ShapeFactory();
        }

        public void placeItem(string nationHint)
        {
            
            shape = shapeFactory.GetShape(graphics, pen, point, nationHint+DefaultValue.TREE_ITEM);
            shape.makeShape();
        }
    }
}
