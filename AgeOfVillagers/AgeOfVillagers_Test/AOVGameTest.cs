using AgeOfVillagers;
using AgeOfVillagers.Model_Class_Folder;
using System;
using System.Windows.Forms;
using Xunit;

namespace AgeOfVillagers_Test
{
    public class AOVGameTest
    {
        [Fact]
        public void createVillageTest()
        {
            AOVGame aOVGame = new AOVGame();
            Panel panel = new Panel();
            Label label = new Label();

            State state = aOVGame.createVillage(panel, label, "villageName");
            Assert.Equal("villageName", state.VillageName);


        }
       
    }
}
