using AgeOfVillagers.Environment_extending_Classes;
using AgeOfVillagers.FactoryClasses;
using AgeOfVillagers.Interface;
using AgeOfVillagers.Model_Class_Folder;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfVillagers
{
    public partial class VillageWindow : Form
    {
        Graphics g;
        Pen pen;
        String selectedItem, selectedNation,selectedNationforOpening;
        ShapeFactory shapeFactory;
        ItemFactory itemFactory;

        GameControlCommandFactory commandFactory;
        GameFactory gameFactory;

        EnvironmentFactory environmentFactory;
        Environment environment;

        IGames game;

        State gameState;
        Label l;

        

        InputValidation inputValidation;

        DrawnItemsInformation drawnItemsInfo;
        List<DrawnItemsInformation> drawnItemsInfosList;

       
        public VillageWindow()
        {
            InitializeComponent();

            g = drawing_panel.CreateGraphics();
            pen = new Pen(Color.Black);

            shapeFactory = new ShapeFactory();
            itemFactory = new ItemFactory();
            environmentFactory = new EnvironmentFactory();
            commandFactory = new GameControlCommandFactory();
            gameFactory = new GameFactory();

            inputValidation = new InputValidation();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Save_Village(object sender, EventArgs e)
        {
            if (inputValidation.checkStringInput(village_name_label.Text))
            {
                MessageBox.Show(DefaultValue.saving_invalid_message);
                return;
            }

            game = gameFactory.getGame();
            IGameControlCommand onCommand = commandFactory.GetGameControlCommand(DefaultValue.SAVE_KEY, game, village_name_label.Text, gameState);
            GameKeyInvoker gameKeyInvoker = new GameKeyInvoker(onCommand);
            gameKeyInvoker.click();
            
        }
        
        private void New_Village(object sender, EventArgs e)
        {

            selectedNationforOpening = "";
            if (inputValidation.checkStringInput(villageName_inputField.Text))
            {
                MessageBox.Show(DefaultValue.creating_invalid_message);
                return;
            }

            environment = environmentFactory.getEnvironment(Nation_Name, bangladesh_Nation_radioButton, egypt_nation_radioButton, arab_nation_radioButton, inuit_nation_radioButton, Tree, House, WaterSource, g, DefaultValue.DEFAULT_NATION, DefaultValue.DEFAULT_COLOR);
            environment.setEnvironment();

            
            game = gameFactory.getGame();
            
            IGameControlCommand onCommand = commandFactory.GetGameControlCommand(DefaultValue.NEW_KEY, game, drawing_panel, village_name_label,villageName_inputField.Text);
            GameKeyInvoker gameKeyInvoker = new GameKeyInvoker(onCommand);
            gameState=gameKeyInvoker.click();
            drawnItemsInfosList = gameState.DrawnItemsInformationList;

    }
        


        private void Open_village(object sender, EventArgs e)
        {
            
            if (inputValidation.checkStringInput(selectedNationforOpening))
            {
                environment = environmentFactory.getEnvironment(Nation_Name, bangladesh_Nation_radioButton, egypt_nation_radioButton, arab_nation_radioButton, inuit_nation_radioButton, Tree, House, WaterSource, g, DefaultValue.DEFAULT_NATION, DefaultValue.DEFAULT_COLOR);
                environment.setEnvironment();
                MessageBox.Show(DefaultValue.opening_invalid_message);
                return;
            }
            game = gameFactory.getGame();

            IGameControlCommand onCommand = commandFactory.GetGameControlCommand(DefaultValue.OPEN_KEY, game, village_name_label, selectedNationforOpening, g, pen);
            GameKeyInvoker gameKeyInvoker = new GameKeyInvoker(onCommand);

            gameState = gameKeyInvoker.click();
           
            drawnItemsInfosList =gameState.DrawnItemsInformationList;
            
            selectedNationforOpening = "";

        }

        private void drawing_panel_MouseClick(object sender, MouseEventArgs e)
        {
            selectedNationforOpening = "";
            Point point = new Point(e.X, e.Y);

            if ( inputValidation.checkStringInput(village_name_label.Text) || inputValidation.checkStringInput(selectedNation) || inputValidation.checkStringInput(selectedItem))
            {
                MessageBox.Show(DefaultValue.string_invalid_message);
                return;
            }
            if (inputValidation.checkPoints(point))
            {
                MessageBox.Show(DefaultValue.point_invalid_message);
                return;
            }

            drawnItemsInfo = new DrawnItemsInformation
            {
                Item_type = selectedItem,
                Clicked_point=point
            };
            IItem item = itemFactory.GetItem(drawnItemsInfo.Clicked_point, drawnItemsInfo.Item_type,g,pen);
            item.placeItem(selectedNation); ;
            drawnItemsInfosList.Add(drawnItemsInfo);
            
  
        }

        private void Mouse_Click_Bangladeshi_Farmer(object sender, MouseEventArgs e)
        {
            selectedNation = DefaultValue.BD_NATION;
            selectedNationforOpening = selectedNation;
            environment = environmentFactory.getEnvironment(Nation_Name, bangladesh_Nation_radioButton, egypt_nation_radioButton, arab_nation_radioButton, inuit_nation_radioButton, Tree, House, WaterSource, g, selectedNation,DefaultValue.BANGLADESHI_COLOR);
            environment.setEnvironment();

        }

        private void Mouse_Click_Inuit_Hunters(object sender, MouseEventArgs e)
        {
            selectedNation = DefaultValue.INUIT_NATION;
            selectedNationforOpening = selectedNation;
            environment = environmentFactory.getEnvironment(Nation_Name, inuit_nation_radioButton, bangladesh_Nation_radioButton, egypt_nation_radioButton, arab_nation_radioButton, Tree, House, WaterSource, g, selectedNation, DefaultValue.INUIT_COLOR);
            environment.setEnvironment();

        }

        private void Mouse_Click_Egyptian_Kings(object sender, MouseEventArgs e)
        {
            selectedNation = DefaultValue.EGYPT_NATION;
            selectedNationforOpening = selectedNation;
            environment = environmentFactory.getEnvironment(Nation_Name, egypt_nation_radioButton, inuit_nation_radioButton, bangladesh_Nation_radioButton, arab_nation_radioButton, Tree, House, WaterSource, g, selectedNation, DefaultValue.EGYPTIAN_COLOR);
            environment.setEnvironment();
        }

        private void Mouse_ClickTree(object sender, MouseEventArgs e)
        {
            selectedItem = DefaultValue.TREE_ITEM;
        }

        private void Mouse_ClickHouse(object sender, MouseEventArgs e)
        {
            selectedItem = DefaultValue.HOUSE_ITEM;
        }

        private void Mouse_ClickWaterSource(object sender, MouseEventArgs e)
        {
            selectedItem = DefaultValue.WATER_SOURCE_ITEM;
        }

        private void Mouse_Click_Arab_Bedouin(object sender, MouseEventArgs e)
        {
            selectedNation = DefaultValue.ARAB_NATION;
            selectedNationforOpening = selectedNation;
            environment = environmentFactory.getEnvironment(Nation_Name, arab_nation_radioButton, egypt_nation_radioButton, inuit_nation_radioButton, bangladesh_Nation_radioButton, Tree, House, WaterSource, g, selectedNation, DefaultValue.ARABIAN_COLOR);
            environment.setEnvironment();
        }

        private void drawing_panel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void VillageWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
