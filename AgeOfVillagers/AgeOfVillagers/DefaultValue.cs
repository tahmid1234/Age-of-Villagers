using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public abstract class DefaultValue
    {
        public static string string_invalid_message = "Please enter all needed information";
        public static string conversion_error_message = "is not available";
        public static string point_invalid_message = "Your Selected Point Is Invalid";
        public static string saving_invalid_message = "To save you have to create or open a villag first";
        public static string creating_invalid_message = "To create your village,you have to give it a name first ";
        public static string opening_invalid_message = "To open your village,you have to choose a nation first ";


        //state elements
        public static string VILLAGE_NAME_ELEMENT_HINT = "Village Name";
        public static string VILLAGE_ITEMS_ELEMENT_HINT = "Village Item";

        //shape hints
        public static string RECT_HINT = "Rectangle";
        public static string TRIANGLE_HINT = "Tryangle";
        public static string CIRCULAR_HINT = "Circular Shape";
        public static string PARALELLOGRAM_HINT = "Paralellogram";
        public static string UNEQUAL_NONAGON_HINT = "Unequal Nonago";
        public static string LINE_HINT = "Line";
        public static string VSHAPE_HINT = "V";





        //house pixell range
        public static int HOUSE_HEIGHT = 16;
        public static int HOUSE_WIDTH = 16;

        //tree pixell range
        public static int TREE_HEIGHT = 24;
        public static int TREE_WIDTH = 16;

        //bangladeshi water source range
        public static int BDWaterSource_HEIGHT = 24;
        public static int BDWATERSOURCE_WIDTH = 16;

        //Arabian water source range
        public static int Egyptian_WATER_SOURCE_HEIGHT = 12;
        public static int Egyptian_WATER_SOURCE_WIDTH = 12;


        //angle range
        public static int FULL_CIRCLE_STARTING_ANGLE = 0;
        public static int FULL_CIRCLE_ENDING_ANGLE = 360;

        public static int HALF_CIRCLE_STARTING_ANGLE = 180;
        public static int HALF_CIRCLE_ENDING_ANGLE = 180;

        //Items
        public static string HOUSE_ITEM = ",HOUSE";
        public static string TREE_ITEM = ",TREE";
        public static string WATER_SOURCE_ITEM = ",WATER SOURCE";

        //Nations

        public static string BD_NATION = "Bangladeshi_Farmer";
        public static string ARAB_NATION = "ARAB BEDOUIN";
        public static string EGYPT_NATION = "EGYPTIAN KING";
        public static string INUIT_NATION = "Inuit Hunters";
        public static string DEFAULT_NATION = "";

        //Shape hints
        public static string BDTREE_HINT = "Bangladeshi_Farmer" + ",TREE";
        public static string BDWATERSOURCE_HINT = "Bangladeshi_Farmer" + ",WATER SOURCE";
        public static string BDHOUSE_HINT = "Bangladeshi_Farmer" + ",HOUSE";
        public static string ARABIAN_HOUSE_HINT = "ARAB BEDOUIN" + ",HOUSE";
        public static string ARABIAN_TREE_HINT = "ARAB BEDOUIN" + ",TREE";
        public static string EGYPTIAN_HOUSE_HINT = "EGYPTIAN KING" + ",HOUSE";
        public static string EGYPTIAN_TREE_HINT = "EGYPTIAN KING" + ",TREE";
        public static string EGYPTIAN_WATER_SOURCE_HINT = "EGYPTIAN KING" + ",WATER SOURCE";
        public static string INUIT_HOUSE_HINT = "Inuit Hunters" + ",HOUSE";



        //Panel Size
        public static int PANEL_LENGTH = 600;
        public static int PANEL_WIDTH = 400;
        public static int PANEL_STARTING_POINT_X = 0;
        public static int PANEL_STARTING_POINT_y = 0;
        public static int PANEL_BORDER = 24;

        //Color
        public static Color BANGLADESHI_COLOR = Color.Green;
        public static Color EGYPTIAN_COLOR = Color.Yellow;
        public static Color INUIT_COLOR = Color.White;
        public static Color ARABIAN_COLOR = Color.LightYellow;
        public static Color DEFAULT_COLOR = Color.White;

        //Key Hints
        public static string NEW_KEY = "New";
        public static string OPEN_KEY = "Open";
        public static string SAVE_KEY = "Save";

        //Element Opener Hints

        public static string VILLAGE_NAME_OPENER = "Village name opener";
        public static string VILLAGE_ITEM_OPENER = "Item opener";

       


    }
}
