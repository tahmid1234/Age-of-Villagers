using AgeOfVillagers.Interface;
using AgeOfVillagers.Model_Class_Folder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    class OpenVillage : IGameControlCommand
    {
        private IGames game;
        private Label villageNameLabel;
        private string selectedNation;
        private State previouslySavedState;
        private Graphics graphics;
        private Pen pen;

        

        public OpenVillage(IGames game, Label villageNameLabel, string selectedNation, Graphics graphics, Pen pen)
        {
            this.game = game;
            this.villageNameLabel = villageNameLabel;
            this.selectedNation = selectedNation;

            this.graphics = graphics;
            this.pen = pen;
        }

        public State execute()
        {
            
           return game.openVillage(selectedNation, villageNameLabel, graphics, pen);
            //MessageBox.Show(previouslySavedState.VillageName);
        }
    }
}
