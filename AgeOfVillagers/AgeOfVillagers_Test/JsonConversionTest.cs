using AgeOfVillagers.JSON_Handling_Classes_Folder;
using AgeOfVillagers.Model_Class_Folder;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AgeOfVillagers_Test
{
    public class JsonConversionTest
    {
        [Fact]
        public void serializeTest()
        {
            JsonConversion jsonConversion = new JsonConversion();
            State state = new State
            {
                VillageName = "villageName",
                DrawnItemsInformationList = new List<AgeOfVillagers.DrawnItemsInformation>()
                
            };
            
            Assert.IsType<String>(jsonConversion.serialize(state));
        }
        
       
    }
}
