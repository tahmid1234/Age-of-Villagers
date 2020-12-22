using AgeOfVillagers.Interface;
using AgeOfVillagers.Model_Class_Folder;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class SaveVillage : IGameControlCommand
    {
        private IGames game;
        private string sVillageName;
        private State currentState;
        

        public SaveVillage(IGames game, string sVillageName, State currentState)
        {
            this.game = game;
            this.sVillageName = sVillageName;
            this.currentState = currentState;
        }

        public State execute()
        {
            return game.saveVillage(currentState, sVillageName);
        }

       
    }
}
