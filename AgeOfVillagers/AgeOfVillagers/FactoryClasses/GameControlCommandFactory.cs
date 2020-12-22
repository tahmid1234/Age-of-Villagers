using AgeOfVillagers.Interface;
using AgeOfVillagers.Model_Class_Folder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class GameControlCommandFactory
    {
        public IGameControlCommand GetGameControlCommand(String hint, IGames game, Panel drawing_panel, Label village_name,string sVillageName)
        {

            return new CreateVillage(game, drawing_panel, village_name,sVillageName);
        }

        public IGameControlCommand GetGameControlCommand(String hint, IGames game, string sVillageName,State currentState)
        {

            return new SaveVillage(game, sVillageName, currentState);
        }

        public IGameControlCommand GetGameControlCommand(String hint, IGames game, Label villageNameLabel, string selectedNation,Graphics graphics, Pen pen)
        {

            return new OpenVillage(game, villageNameLabel, selectedNation, graphics, pen);
        }

    }
}
