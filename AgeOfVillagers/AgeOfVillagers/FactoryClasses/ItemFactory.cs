using AgeOfVillagers.IItem_Implementing_Classes;
using AgeOfVillagers.Interface;
using AgeOfVillagers.Shape_implementing_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.FactoryClasses
{
    public class ItemFactory
    {
        public IItem GetItem(Point point,string hint,Graphics graphics,Pen pen)
        {
           
            if (hint.Equals(DefaultValue.TREE_ITEM))
            {
                return new Tree(point,graphics,pen);
            }
            else if (hint.Equals(DefaultValue.HOUSE_ITEM))
                return new House(point, graphics, pen);
            else if (hint.Equals(DefaultValue.WATER_SOURCE_ITEM))
                return new WaterSource(point, graphics, pen);
            return new NullClass(hint);
        }
    }
}
