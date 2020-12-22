using AgeOfVillagers.Interface;
using AgeOfVillagers.IStateElements_implimentinf_folder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.FactoryClasses
{
    public class ElementOpenerFactory
    {
        public IElementOpener GetElementOpener(String hint,String selectedNation, List<DrawnItemsInformation> drawnItemsInfoList, Graphics graphics,Pen pen)
        {
            return new VillageItemsOpener(drawnItemsInfoList, selectedNation, graphics, pen);
        }
        public IElementOpener GetElementOpener(String hint,Label VillageNameLabel,String villageName)
        {
            return new VillageNameOpener(VillageNameLabel, villageName);
        }
    }
}
