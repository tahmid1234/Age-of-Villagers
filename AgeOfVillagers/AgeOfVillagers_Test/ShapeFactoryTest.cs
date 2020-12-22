using AgeOfVillagers;
using AgeOfVillagers.IItem_implementing_Classes;
using AgeOfVillagers.Interface;
using AgeOfVillagers.Shape_extended_classes;
using AgeOfVillagers.Shape_implementing_Classes;
using AgeOfVillagers.Village_extended_classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Xunit;

namespace AgeOfVillagers_Test
{
    public class ShapeFactoryTest
    {
        [Fact]
        public void BangladeshiTreeTest()
        {
            Panel panel = new Panel();
            Graphics g = panel.CreateGraphics();
            ShapeFactory shapeFactory = new ShapeFactory();
            Pen pen = new Pen(Color.Black);
            Shapes shape = shapeFactory.GetShape(g,pen,new Point(2,3), "Bangladeshi_Farmer" + ",TREE");

            Assert.IsType<BangladeshiTreeShape>(shape);

        }
        [Fact]
        public void BangladeshiHouseTest()
        {
            Panel panel = new Panel();
            Graphics g = panel.CreateGraphics();
            ShapeFactory shapeFactory = new ShapeFactory();
            Pen pen = new Pen(Color.Black);
            Shapes shape = shapeFactory.GetShape(g, pen, new Point(2, 3), "Bangladeshi_Farmer" + ",HOUSE");

            Assert.IsType<BangladeshiHouseShape>(shape);

        }

        [Fact]
        public void BangladeshiWaterSourceTest()
        {
            Panel panel = new Panel();
            Graphics g = panel.CreateGraphics();
            ShapeFactory shapeFactory = new ShapeFactory();
            Pen pen = new Pen(Color.Black);
            Shapes shape = shapeFactory.GetShape(g, pen, new Point(2, 3), "Bangladeshi_Farmer" + ",WATER SOURCE");

            Assert.IsType<BangladeshiWaterSourceShape>(shape);

        }
        [Fact]
        public void InuitHouseTest()
        {
            Panel panel = new Panel();
            Graphics g = panel.CreateGraphics();
            ShapeFactory shapeFactory = new ShapeFactory();
            Pen pen = new Pen(Color.Black);
            Shapes shape = shapeFactory.GetShape(g, pen, new Point(2, 3), "Inuit Hunters" + ",HOUSE");

            Assert.IsType<InuitHouseIglooShape>(shape);

        }

        [Fact]
        public void EgyptianHouseTest()
        {
            Panel panel = new Panel();
            Graphics g = panel.CreateGraphics();
            ShapeFactory shapeFactory = new ShapeFactory();
            Pen pen = new Pen(Color.Black);
            Shapes shape = shapeFactory.GetShape(g, pen, new Point(2, 3), "EGYPTIAN KING" + ",HOUSE");

            Assert.IsType<EgyptianHouseShape>(shape);

        }
        [Fact]
        public void ArabianHouseTest()
        {
            Panel panel = new Panel();
            Graphics g = panel.CreateGraphics();
            ShapeFactory shapeFactory = new ShapeFactory();
            Pen pen = new Pen(Color.Black);
            Shapes shape = shapeFactory.GetShape(g, pen, new Point(2, 3), "ARAB BEDOUIN" + ",HOUSE");

            Assert.IsType<ArabianHouseShape>(shape);

        }
    }
}

