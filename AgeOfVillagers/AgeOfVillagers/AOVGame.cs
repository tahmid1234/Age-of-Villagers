using AgeOfVillagers.FactoryClasses;
using AgeOfVillagers.Interface;
using AgeOfVillagers.JSON_Handling_Classes_Folder;
using AgeOfVillagers.Model_Class_Folder;
using AgeOfVillagers.Shape_extended_classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
     public class AOVGame : IGames
    {
        
        private IElementOpener village_itemOpener, village_name_opener;
        private JsonConversion jsonToObejct;
        private JsonConversion objectToJson;
        private ElementOpenerFactory elementOpenerFactory;
        public State gameState;



        public State createVillage(Panel drawing_panel, Label village_name, string villageName_value)
        {
            village_name.Text = villageName_value;
            drawing_panel.Invalidate();
            gameState= new State { VillageName = villageName_value, DrawnItemsInformationList = new List<DrawnItemsInformation>() };
            return gameState;
        }

        public State openVillage(string selectedNation, Label labelVillageName,  Graphics graphics, Pen pen)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "age of villagers file|*.aov";
            openFileDialog.Title = "open village";
            openFileDialog.ShowDialog();
            //exception needed
            if (openFileDialog.FileName != "")
            {
                var dataString = System.IO.File.ReadAllText(openFileDialog.FileName);


                string json = dataString;
                jsonToObejct = new JsonConversion();
                jsonToObejct.deserialize(json);

                gameState = jsonToObejct.deserialize(json);

                elementOpenerFactory = new ElementOpenerFactory();

                village_name_opener = elementOpenerFactory.GetElementOpener(DefaultValue.VILLAGE_NAME_OPENER, labelVillageName, gameState.VillageName);
                village_name_opener.displayElements();
                village_itemOpener = elementOpenerFactory.GetElementOpener(DefaultValue.VILLAGE_ITEM_OPENER, selectedNation, gameState.DrawnItemsInformationList, graphics, pen);
                village_itemOpener.displayElements();

                return gameState;
            }
            else
            {
                gameState = new State { VillageName= "",DrawnItemsInformationList= new List<DrawnItemsInformation>() };
                return gameState;
            }
        }

        public State saveVillage(State currentState, string villageName)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "save village|*.aov";
            saveFileDialog1.Title = "Save village";
            saveFileDialog1.ShowDialog();
            objectToJson = new JsonConversion();

            if (saveFileDialog1.FileName != "")
            {

                string json = objectToJson.serialize(currentState);
                System.IO.File.WriteAllText(saveFileDialog1.FileName, json);
            }

            return currentState;
        }
    }
}
