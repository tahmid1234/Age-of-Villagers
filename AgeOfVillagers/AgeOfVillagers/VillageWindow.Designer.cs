namespace AgeOfVillagers
{
    partial class VillageWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawing_panel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Tree = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.village_name_label = new System.Windows.Forms.Label();
            this.Nation_Name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.villageName_inputField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bangladesh_Nation_radioButton = new System.Windows.Forms.RadioButton();
            this.inuit_nation_radioButton = new System.Windows.Forms.RadioButton();
            this.egypt_nation_radioButton = new System.Windows.Forms.RadioButton();
            this.arab_nation_radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WaterSource = new System.Windows.Forms.RadioButton();
            this.House = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.drawing_panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawing_panel
            // 
            this.drawing_panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drawing_panel.Controls.Add(this.groupBox3);
            this.drawing_panel.Controls.Add(this.panel2);
            this.drawing_panel.Location = new System.Drawing.Point(2, 1);
            this.drawing_panel.Name = "drawing_panel";
            this.drawing_panel.Size = new System.Drawing.Size(600, 400);
            this.drawing_panel.TabIndex = 0;
            this.drawing_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawing_panel_Paint);
            this.drawing_panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawing_panel_MouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(599, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(599, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 367);
            this.panel2.TabIndex = 0;
            // 
            // Tree
            // 
            this.Tree.AutoSize = true;
            this.Tree.Location = new System.Drawing.Point(0, 22);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(47, 19);
            this.Tree.TabIndex = 4;
            this.Tree.TabStop = true;
            this.Tree.Text = "Tree";
            this.Tree.UseVisualStyleBackColor = true;
            this.Tree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_ClickTree);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Age of Villegers";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // village_name
            // 
            this.village_name_label.AutoSize = true;
            this.village_name_label.Location = new System.Drawing.Point(658, 35);
            this.village_name_label.Name = "village_name";
            this.village_name_label.Size = new System.Drawing.Size(0, 15);
            this.village_name_label.TabIndex = 1;
            this.village_name_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.village_name_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nation_Name
            // 
            this.Nation_Name.AutoSize = true;
            this.Nation_Name.Location = new System.Drawing.Point(671, 60);
            this.Nation_Name.Name = "Nation_Name";
            this.Nation_Name.Size = new System.Drawing.Size(0, 15);
            this.Nation_Name.TabIndex = 1;
            this.Nation_Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nation_Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(723, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save Village";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Save_Village);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(658, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Open Village";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Open_village);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(601, 316);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "New Village";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.New_Village);
            // 
            // tbVillageName
            // 
            this.villageName_inputField.BackColor = System.Drawing.SystemColors.HotTrack;
            this.villageName_inputField.Location = new System.Drawing.Point(706, 287);
            this.villageName_inputField.Name = "tbVillageName";
            this.villageName_inputField.Size = new System.Drawing.Size(95, 23);
            this.villageName_inputField.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(601, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Village Name";
            // 
            // BD
            // 
            this.bangladesh_Nation_radioButton.AutoSize = true;
            this.bangladesh_Nation_radioButton.Location = new System.Drawing.Point(0, 22);
            this.bangladesh_Nation_radioButton.Name = "BD";
            this.bangladesh_Nation_radioButton.Size = new System.Drawing.Size(134, 19);
            this.bangladesh_Nation_radioButton.TabIndex = 6;
            this.bangladesh_Nation_radioButton.TabStop = true;
            this.bangladesh_Nation_radioButton.Text = "Bangladeshi Farmers";
            this.bangladesh_Nation_radioButton.UseVisualStyleBackColor = true;
            this.bangladesh_Nation_radioButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Click_Bangladeshi_Farmer);
            // 
            // Hunters
            // 
            this.inuit_nation_radioButton.AutoSize = true;
            this.inuit_nation_radioButton.Location = new System.Drawing.Point(100, 38);
            this.inuit_nation_radioButton.Name = "Hunters";
            this.inuit_nation_radioButton.Size = new System.Drawing.Size(94, 19);
            this.inuit_nation_radioButton.TabIndex = 6;
            this.inuit_nation_radioButton.TabStop = true;
            this.inuit_nation_radioButton.Text = "Inuit Hunters";
            this.inuit_nation_radioButton.UseVisualStyleBackColor = true;
            this.inuit_nation_radioButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Click_Inuit_Hunters);
            // 
            // Egyptians
            // 
            this.egypt_nation_radioButton.AutoSize = true;
            this.egypt_nation_radioButton.Location = new System.Drawing.Point(0, 63);
            this.egypt_nation_radioButton.Name = "Egyptians";
            this.egypt_nation_radioButton.Size = new System.Drawing.Size(103, 19);
            this.egypt_nation_radioButton.TabIndex = 6;
            this.egypt_nation_radioButton.TabStop = true;
            this.egypt_nation_radioButton.Text = "Egyptian Kings";
            this.egypt_nation_radioButton.UseVisualStyleBackColor = true;
            this.egypt_nation_radioButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Click_Egyptian_Kings);
            // 
            // Arabians
            // 
            this.arab_nation_radioButton.AutoSize = true;
            this.arab_nation_radioButton.Location = new System.Drawing.Point(100, 75);
            this.arab_nation_radioButton.Name = "Arabians";
            this.arab_nation_radioButton.Size = new System.Drawing.Size(97, 19);
            this.arab_nation_radioButton.TabIndex = 6;
            this.arab_nation_radioButton.TabStop = true;
            this.arab_nation_radioButton.Text = "Arab Bedouin";
            this.arab_nation_radioButton.UseVisualStyleBackColor = true;
            this.arab_nation_radioButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Click_Arab_Bedouin);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bangladesh_Nation_radioButton);
            this.groupBox1.Controls.Add(this.arab_nation_radioButton);
            this.groupBox1.Controls.Add(this.egypt_nation_radioButton);
            this.groupBox1.Controls.Add(this.inuit_nation_radioButton);
            this.groupBox1.Location = new System.Drawing.Point(601, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Your Nation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.WaterSource);
            this.groupBox2.Controls.Add(this.House);
            this.groupBox2.Controls.Add(this.Tree);
            this.groupBox2.Location = new System.Drawing.Point(601, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 88);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // WaterSource
            // 
            this.WaterSource.AutoSize = true;
            this.WaterSource.Location = new System.Drawing.Point(47, 60);
            this.WaterSource.Name = "WaterSource";
            this.WaterSource.Size = new System.Drawing.Size(95, 19);
            this.WaterSource.TabIndex = 4;
            this.WaterSource.TabStop = true;
            this.WaterSource.Text = "Water Source";
            this.WaterSource.UseVisualStyleBackColor = true;
            this.WaterSource.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_ClickWaterSource);
            // 
            // House
            // 
            this.House.AutoSize = true;
            this.House.Location = new System.Drawing.Point(91, 22);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(59, 19);
            this.House.TabIndex = 4;
            this.House.TabStop = true;
            this.House.Text = "House";
            this.House.UseVisualStyleBackColor = true;
            this.House.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_ClickHouse);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Village:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(601, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nation:";
            // 
            // VillageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 401);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.villageName_inputField);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Nation_Name);
            this.Controls.Add(this.village_name_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.drawing_panel);
            this.Name = "VillageWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VillageWindow_Load);
            this.drawing_panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel drawing_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label village_name_label;
        private System.Windows.Forms.Label Nation_Name;
        
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox villageName_inputField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton bangladesh_Nation_radioButton;
        private System.Windows.Forms.RadioButton inuit_nation_radioButton;
        private System.Windows.Forms.RadioButton egypt_nation_radioButton;
        private System.Windows.Forms.RadioButton arab_nation_radioButton;
        private System.Windows.Forms.GroupBox groupBox1;
       
       
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Tree;
        private System.Windows.Forms.RadioButton WaterSource;
        private System.Windows.Forms.RadioButton House;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

