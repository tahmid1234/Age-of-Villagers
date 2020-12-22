using AgeOfVillagers.AbstractClass;
using AgeOfVillagers.Environment_extending_Classes;
using AgeOfVillagers.Interface;
using AgeOfVillagers.Model_Class_Folder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AgeOfVillagers.Shape_implementing_Classes
{
    public class NullClass : DrawableShapes, Shapes, IItem
    {
        private string hint;
        private string[] splittedHints;
        

        public NullClass(string hint)
        {
            this.hint = hint;
        }

       
        public override void drawShape()
        {
            //cant draw
        }

       

       
        public override void makeShape()
        {
            //cant make shape
            splittedHints = hint.Split(",");
            // MessageBox.Show(splittedHints[1] + Constants.conversion_error_message + splittedHints[0] );
        }

        public void placeItem(string nationHint)
        {
            //cant place item
        }

       
    }
}
