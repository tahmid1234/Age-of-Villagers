using AgeOfVillagers.FactoryClasses;
using AgeOfVillagers.IItem_Implementing_Classes;
using AgeOfVillagers.Interface;
using AgeOfVillagers.Shape_implementing_Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Xunit;

namespace AgeOfVillagers_Test
{
    public class ItemFactoryTest
    {
        [Fact]
        public void treeItemTest()
        {
            Panel panel = new Panel();
            Graphics g = panel.CreateGraphics();
            ItemFactory itemFactory = new ItemFactory();
            Pen pen = new Pen(Color.Black);
            IItem item=itemFactory.GetItem(new Point(2, 3), ",TREE", g, pen);

            Assert.IsType<Tree>(item);

        }

        [Fact]
        public void houseItemTest()
        {
            Panel panel = new Panel();
            Graphics g = panel.CreateGraphics();
            ItemFactory itemFactory = new ItemFactory();
            Pen pen = new Pen(Color.Black);
            IItem item = itemFactory.GetItem(new Point(2, 3), ",HOUSE", g, pen);

            Assert.IsType<House>(item);

        }
        [Fact]
        public void waterSourceItemTest()
        {
            Panel panel = new Panel();
            Graphics g = panel.CreateGraphics();
            ItemFactory itemFactory = new ItemFactory();
            Pen pen = new Pen(Color.Black);
            IItem item = itemFactory.GetItem(new Point(2, 3), ",WATER SOURCE", g, pen);

            Assert.IsType<WaterSource>(item);

        }
        [Fact]
        public void nullItemTest()
        {
            Panel panel = new Panel();
            Graphics g = panel.CreateGraphics();
            ItemFactory itemFactory = new ItemFactory();
            Pen pen = new Pen(Color.Black);
            IItem item = itemFactory.GetItem(new Point(2, 3), "", g, pen);

            Assert.IsType<NullClass>(item);

        }

    }
}
