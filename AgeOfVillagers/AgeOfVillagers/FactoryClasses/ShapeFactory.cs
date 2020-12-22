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

namespace AgeOfVillagers
{
    public class ShapeFactory
    {
        public  Shapes GetShape(Graphics graphics, Pen pen, Point startingPoint,string hint)
        {


            if (hint.Equals(DefaultValue.BDTREE_HINT))
            {
                return new BangladeshiTreeShape(graphics, pen, startingPoint, DefaultValue.TREE_HEIGHT, DefaultValue.TREE_WIDTH);
            }
            else if (hint.Equals(DefaultValue.BDWATERSOURCE_HINT))
            {

                return new BangladeshiWaterSourceShape(graphics, pen, startingPoint, DefaultValue.BDWaterSource_HEIGHT, DefaultValue.BDWATERSOURCE_WIDTH);
            }
            else if (hint.Equals(DefaultValue.BDHOUSE_HINT))
                return new BangladeshiHouseShape(graphics, pen, startingPoint, DefaultValue.HOUSE_HEIGHT, DefaultValue.HOUSE_WIDTH);

            else if (hint.Equals(DefaultValue.ARABIAN_HOUSE_HINT))
                return new ArabianHouseShape(graphics, pen, startingPoint, DefaultValue.HOUSE_HEIGHT, DefaultValue.HOUSE_WIDTH);

            else if (hint.Equals(DefaultValue.ARABIAN_TREE_HINT))
                return new ArabianTreeShape(graphics, pen, startingPoint, DefaultValue.TREE_HEIGHT, DefaultValue.TREE_WIDTH);
            else if (hint.Equals(DefaultValue.EGYPTIAN_HOUSE_HINT))
                return new EgyptianHouseShape(graphics, pen, startingPoint, DefaultValue.HOUSE_HEIGHT, DefaultValue.HOUSE_WIDTH);
            else if (hint.Equals(DefaultValue.EGYPTIAN_TREE_HINT))
            {
                return new EgyptianTreeShape(graphics, pen, startingPoint, DefaultValue.TREE_HEIGHT, DefaultValue.TREE_WIDTH);
            }
            else if (hint.Equals(DefaultValue.EGYPTIAN_WATER_SOURCE_HINT))
            {
                return new EgyptianWaterSourceShape(graphics, pen, startingPoint, DefaultValue.Egyptian_WATER_SOURCE_HEIGHT, DefaultValue.Egyptian_WATER_SOURCE_WIDTH);
            }

            else if (hint.Equals(DefaultValue.INUIT_HOUSE_HINT))
            {
                return new InuitHouseIglooShape(graphics, pen, startingPoint, DefaultValue.HOUSE_HEIGHT, DefaultValue.HOUSE_WIDTH);
            }

            return new NullClass(hint);
        }

       
    }
}
