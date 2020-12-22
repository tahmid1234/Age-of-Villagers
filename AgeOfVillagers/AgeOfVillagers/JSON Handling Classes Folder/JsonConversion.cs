using AgeOfVillagers.Model_Class_Folder;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgeOfVillagers.JSON_Handling_Classes_Folder
{
    public class JsonConversion
    {
        String jsonData;
        public string serialize(State currentState)
        {
            
                var dataString = JsonConvert.SerializeObject(currentState, Formatting.Indented);
                return dataString;
                
            
        }

        public State deserialize(string jsonData)
        {
            var settings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All
            };



            State  previouslySavedState = JsonConvert.DeserializeObject<State>(jsonData, settings);
            return previouslySavedState;
        }
    }
}
