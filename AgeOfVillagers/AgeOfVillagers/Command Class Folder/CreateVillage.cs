using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using AgeOfVillagers.Model_Class_Folder;


namespace AgeOfVillagers
{
    class CreateVillage : IGameControlCommand
    {
        public IGames game;
        Panel drawing_panel;
        System.Windows.Forms.Label village_name;
        string sVillageName;
        public CreateVillage(IGames game, Panel drawing_panel, System.Windows.Forms.Label village_name,string sVillageName)
        {
            this.game = game;
            this.village_name = village_name;
            this.drawing_panel = drawing_panel;
            this.sVillageName = sVillageName;
        }

        

        public State execute()
        {
            return game.createVillage(drawing_panel, village_name,sVillageName);
        }
    }
}
