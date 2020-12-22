using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public class InputValidation
    {
        
        public Boolean checkStringInput(String inputString)
        {
            

            
            if (inputString=="" || inputString==null)
            {

                
                return true;
            }
            return false;
        }

        public Boolean checkPoints(Point point)
        {
            if(point.X<DefaultValue.PANEL_BORDER || point.X>DefaultValue.PANEL_LENGTH - DefaultValue.PANEL_BORDER ||point.Y< DefaultValue.PANEL_BORDER || point.Y> DefaultValue.PANEL_WIDTH - DefaultValue.PANEL_BORDER)
            {
                
                return true;
            }
            return false;
        }

    }
}
