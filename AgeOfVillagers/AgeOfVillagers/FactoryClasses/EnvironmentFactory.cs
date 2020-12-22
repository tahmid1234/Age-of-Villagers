using AgeOfVillagers.Environment_extending_Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers.FactoryClasses
{
    public class EnvironmentFactory
    {
        public Environment getEnvironment(Label nation_Name,RadioButton firstNation, RadioButton secondNation, RadioButton thirdNation, RadioButton fourthNation,RadioButton tree,RadioButton house,RadioButton waterSource, Graphics graphics, string selectedNation,Color color)
        {
            if (selectedNation.Equals(DefaultValue.BD_NATION))
                return new BangladeshiEnvironment(nation_Name, firstNation, secondNation, thirdNation, fourthNation, tree, house, waterSource, graphics,selectedNation, color);
            else if(selectedNation.Equals(DefaultValue.ARAB_NATION))
                return new ArabianEnvironmet(nation_Name, firstNation, secondNation, thirdNation, fourthNation, tree, house, waterSource, graphics,selectedNation, color);
            else if(selectedNation.Equals(DefaultValue.EGYPT_NATION))
                return new EgyptianEnvironment(nation_Name, firstNation, secondNation, thirdNation, fourthNation, tree, house, waterSource, graphics,selectedNation, color);
            else if(selectedNation.Equals(DefaultValue.INUIT_NATION))
                return new InuitEnvironment(nation_Name, firstNation, secondNation, thirdNation, fourthNation, tree, house, waterSource, graphics, selectedNation, color);
            return new DefaultEnvironment(nation_Name, firstNation, secondNation, thirdNation, fourthNation, tree, house, waterSource, graphics,selectedNation, color); ;

        }
    }
}
