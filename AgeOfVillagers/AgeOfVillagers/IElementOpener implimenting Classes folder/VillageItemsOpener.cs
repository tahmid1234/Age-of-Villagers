using AgeOfVillagers.FactoryClasses;
using AgeOfVillagers.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AgeOfVillagers.IStateElements_implimentinf_folder
{
    class VillageItemsOpener : IElementOpener
    {
        List<DrawnItemsInformation> drawnItemsInfoList;
        private string selectedNation;
        
        private Graphics graphics;
        private Pen pen;
        ItemFactory itemFactory;
        IItem item;

        public VillageItemsOpener(List<DrawnItemsInformation> drawnItemsInfoList, string selectedNation, Graphics graphics, Pen pen)
        {
            this.drawnItemsInfoList = drawnItemsInfoList;
            this.selectedNation = selectedNation;
            this.graphics = graphics;
            this.pen = pen;
            itemFactory = new ItemFactory();
        }

        public void displayElements()
        {
            foreach(DrawnItemsInformation drawnItemsInformation in drawnItemsInfoList)
            {
                item = itemFactory.GetItem(drawnItemsInformation.Clicked_point, drawnItemsInformation.Item_type, graphics, pen);
                item.placeItem(selectedNation);
            }
        }
    }
}
