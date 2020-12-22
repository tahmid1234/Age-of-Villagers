using AgeOfVillagers.Model_Class_Folder;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers
{
    public class GameKeyInvoker
    {
        IGameControlCommand theCommand;
        
        public GameKeyInvoker(IGameControlCommand theCommand)
        {
            this.theCommand = theCommand;
        }

        public State click()
        {
            return theCommand.execute();
        }
    }
}
