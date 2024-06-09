
/*
 *  
 *  
 *  Create Panel for new charges
 *  Create Panel for Paying Bills- create a input box that searches with each keystroke using the AutoComplete functions of the text box
 *          Add the Cash check or charge logo buttons and a Masked text box for amount.
 *          
 *          Add a transactions panel with a datagrid view and ability to search using a calendar control with options this should be similar to GURU Quote with search boxes ontop of every field
 *          
 *          lastly create a panel with the main functions as buttons 
 *          
 *          Add tutorial walk through with opur squerrels pics
 *  
 *   create SQL statments for all inputs and serches
 *   add chart builder functions from GUI Demo project
 *   
 *   add payoff stack to right side
 *  
 *  Create Setup form for New Users
 */
















//using Steam_Roller_Financial_Application;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using Button = System.Windows.Forms.Button;
//using ComboBox = System.Windows.Forms.ComboBox;
//using TextBox = System.Windows.Forms.TextBox;
using System.Data.SQLite;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Microsoft.VisualBasic.Logging;
using static System.Collections.Specialized.BitVector32;


namespace Steamroller_Financial_Application
{

    public partial class frmMain : Form
    {

        //CalendarControl myCalendar = new CalendarControl();
        //public int leftSideBarWidth = 0;
        //public int rightSideBarWidth = 0;
        //Color CalendarDayMouseEnterOriginalColor;

        GlobalDataAndFunctions globals = new GlobalDataAndFunctions();

        private SQL_Database db = new SQL_Database(); //db = new SQL_Database();


        private ComboBox comboBoxBudgetDataCategories;

        //List of Control Objects for Derived Controls //Usage : Button submitButton = xButtons.Find(b => b.Name == "submitButton");
        private List<Panel> xPanels = new List<Panel>();
        private List<Button> xButtons = new List<Button>();
        private List<ComboBox> xComboBoxes = new List<ComboBox>();
        private List<TextBox> xTextBoxs = new List<TextBox>();
        private List<Label> xLabels = new List<Label>();
        private List<TreeView> xTreeViews = new List<TreeView>();
        private Dictionary<string, string> dictVariables = new Dictionary<string, string>();



        public frmMain()
        {
            InitializeComponent();
            dictVariables = globals.LoadDictionary();//Load Global Variables
            dictVariables["intLeftSideBarWidth"] = spnl_LeftSideBar.Width.ToString();
            dictVariables["intRightSideBarWidth"] = spnl_RightSideBar.Width.ToString();
            pnlBottom.Height = 331;


        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Center_Object(pnlMainMenu,EventArgs.Empty,0,-600);
            pnlMainMenu.Visible = true;
            pnlMainMenu.Height = 35;
        }

        public void CustomExceptionHandler()
        {


            pnlerrorPanel.Visible = true;
            pnlerrorPanel.Size = new Size(803, 572);
            pnlerrorPanel.BringToFront();
            errorPanelLabel.Text = "Oops this feature is still under cinstruction";

            Center_Object(pnlerrorPanel, EventArgs.Empty);

        }












        private void button1_Click(object sender, EventArgs e)// Test Button
        {
            // PopulateBudgetTree(ref treeView_BudgetData, "HOUSING");
            //Center_Object(pnlMainMenu, EventArgs.Empty, 0, -730);

            frmSplashScreen sp = new frmSplashScreen();
            sp.Show();

        }

        #region "Common Functions"
        private void Close_Object(object sender, EventArgs e)//Uneversal Closing Method for Panels and additional forms
        {
            if (!(sender is Button)) { return; }

            Button myButton = sender as Button;

            if (myButton != null)
            {
                Control parent = myButton.Parent;
                if (parent != null)
                {
                    switch (parent)
                    {
                        case Form form:

                            form.Close();
                            break;
                        case Panel panel:

                            if (panel.Tag != null && panel.Tag.ToString() == "Permanant")
                            {
                                panel.Hide();
                            }
                            else
                            {
                                panel.Dispose();
                            }
                            break;

                        default:

                            break;
                    }
                }

            }






        }
        public void Center_Object(object sender, EventArgs e, int xOffset = 0, int yOffset = 0)//Uneversal Centering Method for Panels and additional forms
        {

            if (!(sender is Panel || sender is Form)) { return; }

            Control myControl = sender as Control;


            Form frm = Application.OpenForms["frmMain"];

            if (frm != null && myControl != null)
            {
                int x = (frm.Width - myControl.Width) / 2 + xOffset;
                int y = (frm.Height - myControl.Height) / 2 + yOffset;

                myControl.Location = new Point(x, y);

            }
        }

        /// <summary>
        /// Assign Controls to List of Control Types so they can be refrenced by Name using the built in find function
        /// </summary>
        /// <param name="parent"></param>
        public void AssignControls(Control parent)
        {
            foreach (Control myControl in parent.Controls)
            {

                switch (myControl.GetType().Name)
                {
                    case "Panel":
                        xPanels.Add(myControl as Panel);
                        break;
                    case "Button":
                        xButtons.Add(myControl as Button);
                        break;
                    case "ComboBox":
                        xComboBoxes.Add(myControl as ComboBox);
                        break;
                    case "TextBox":
                        xTextBoxs.Add(myControl as TextBox);
                        break;
                    case "Label":
                        xLabels.Add(myControl as Label);
                        break;
                    case "TreeView":
                        xTreeViews.Add(myControl as TreeView);
                        break;
                }

                // If the control has child controls, recursively process them
                if (myControl.HasChildren)
                {
                    AssignControls(myControl);
                }
            }
        }

        public void InputBox(string header, Action<string> callback)
        {
            Center_Object(pnlInputBox, EventArgs.Empty);
            InputBoxHeader.Text = header;
            pnlInputBox.Show();

            btnInputPanelOK.Click += (sender, e) =>
            {
                callback(txtInputBox_Reply.Text);
                pnlInputBox.Visible = false;
            };

        }
        private void btnInputPanelOK_Click(object sender, EventArgs e)
        {

        }

        private void tmrMainForm_Tick(object sender, EventArgs e)
        {
            int SizeMode = int.Parse(dictVariables["intSizeMode"]);
            int StepSize = int.Parse(dictVariables["intStepSize"]);
            bool HorizontalDirection = bool.Parse(dictVariables["boolHorizontalDirection"]);
            int EndSize = int.Parse(dictVariables["intEndSize"]);

            Control myControl = null;
            dictVariables.TryGetValue("myControl", out string controlName);

            Control[] allControlsOnForm = this.Controls.Find(controlName, true);
            if (allControlsOnForm.Length > 0)//Get and Assign Control type
            {
                if (allControlsOnForm[0] is Panel)
                {
                    myControl = (Panel)allControlsOnForm[0];

                }
                else if (allControlsOnForm[0] is Form)
                {
                    myControl = (Form)allControlsOnForm[0];

                }
                else if (allControlsOnForm[0] is SplitContainer)
                {
                    myControl = (SplitContainer)allControlsOnForm[0];

                }
                else
                {
                    tmrMainForm.Enabled = false;
                    return;
                }


            }

            if (myControl == null) { return; }// null check



            //Panel myControl = (Panel)sender;

            if (SizeMode == 1)//Increase Size
            {
                if (HorizontalDirection == true)//Width
                {
                    if (myControl.Width >= EndSize)
                    {
                        myControl.Width = EndSize; tmrMainForm.Enabled = false;
                    }
                    else
                    {
                        myControl.Width += StepSize;
                    }
                }
                else//Height
                {
                    if (myControl.Height >= EndSize)
                    {
                        myControl.Height = EndSize; tmrMainForm.Enabled = false;
                    }
                    else
                    {
                        myControl.Height += StepSize;
                    }

                }
            }
            else if (SizeMode == 2)//Decrease Size
            {
                if (HorizontalDirection == true)//Width
                {
                    if (myControl.Width <= EndSize)
                    {
                        myControl.Width = EndSize; tmrMainForm.Enabled = false;
                    }
                    else
                    {
                        myControl.Width -= StepSize;
                    }
                }
                else//Height
                {
                    if (myControl.Height <= EndSize)
                    {
                        myControl.Height = EndSize; tmrMainForm.Enabled = false;
                    }
                    else
                    {
                        myControl.Height -= StepSize;
                    }

                }


            }
        }
        private void TogglePanel_Slider_Click(object sender, EventArgs e)
        {
            if (!(sender is Label))
            {
                return;
            }
            Label slider = (Label)sender;

            slider.Dock = (slider.Dock == DockStyle.Left) ? DockStyle.Right : DockStyle.Left;



        }


        private void pnlerrorPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlerrorPanel.Visible == false) { pnlMainMenu.Visible = true; }
        }


        #endregion


        #region "Calendar"

        #region "Calendar Controls"
        private void CreateCalendar(int Month = -1, int Year = -1)
        {


            if (Month == -1) { Month = DateTime.Now.Month; }
            if (Year == -1) { Year = DateTime.Now.Year; }

            pnlBottom.Controls.Clear();//Remove any Controls currently in panel
            pnlBottom.Tag = string.Format("{0}||{1}", Month, Year);//Used to track displayed Month and Year for Buttons

            //frmMain xForm = new frmMain();
            Panel xPanel = new Panel();// Main Panel to contain other controls
            Panel xTopPanel = new Panel();// Top Panel with two buttons and Lable of Date
            Panel xSideBarPanel = new Panel();// Lable with Date - Add List of Bills Due
            Label xLabel = new Label(); //Generic Lable place holder for various labels
            Label xDayLabel = new Label();
            Button xButton = new Button();
            //DateTime xDate = DateTime.Now;
            string HeaderText = new DateTime(2024, Month, 1).ToString("MMMM") + " " + Year.ToString();//Output is Month Name and Year

            int DayLabelWidth = 0;
            Color currentWeekDayBackColor = Color.DarkSlateGray;
            Color notAvaiable = Color.FromKnownColor(KnownColor.ControlDark);
            Color isAvaiable = Color.FromKnownColor(KnownColor.Control);
            string[] weekDays = new string[] { "Sunday", "Monday", "Tuesday", "Wendsday", "Thursday", "Friday", "Saturday" };
            int DayPanelHeight = 0;
            int R_Step = 0;
            int C_Step = 0;
            int startingPoint = 0;
            int startingDay = 0;
            int endingDay = 0;
            bool flag = false;
            int DayCounter = 1;
            int Day = DateTime.Today.Day; //Get Current Day and Change Lable Text Color to Red
            int DayOfWeek = 0;

            #region "Hidden Code"

            //Create ToolTip for these controls
            System.Windows.Forms.ToolTip info = new System.Windows.Forms.ToolTip();
            info.AutomaticDelay = 5000;
            info.InitialDelay = 1000;
            info.ReshowDelay = 500;
            info.ShowAlways = false;


            //Create Panels
            //Base            
            xPanel.Dock = DockStyle.Fill;
            //xPanel.Height = this.Height / 2;
            xPanel.Name = "Base";
            xPanel.Visible = true;
            xPanel.BackColor = Color.DarkGray;
            xPanel.BorderStyle = BorderStyle.FixedSingle;

            //Generate Events for Base Panel
            xPanel.Resize += xPanel_Resize;
            xPanel.Click += xPanel_Click;

            pnlBottom.Controls.Add(xPanel);//Add Base Panelk to Bottom Panel


            //Add Inner SideBar Panel
            //xSideBarPanel.Location = new Point(xPanel.Width - 219, xTopPanel.Height + 2);
            xSideBarPanel.Dock = DockStyle.Right;
            xSideBarPanel.Width = 216; // Needs added to Resize Event of xPanel to calculate 22%
            //xSideBarPanel.Height = xPanel.Height - xTopPanel.Height - 2;
            xSideBarPanel.Name = "SideBar";
            xSideBarPanel.Visible = true;
            xSideBarPanel.BorderStyle = BorderStyle.FixedSingle;
            xSideBarPanel.BackColor = Color.FromKnownColor(KnownColor.Control);

            xPanel.Controls.Add(xSideBarPanel);//Add to Parent

            xSideBarPanel.Resize += xPanel_Resize;
            xSideBarPanel.Click += xPanel_Click;

            //Add Label Control to SideBarPanel
            xLabel = new Label();
            xLabel.AutoSize = false;
            xLabel.Name = "lblSideBarHeader";
            xLabel.Dock = DockStyle.Top;
            xLabel.Height = 35;
            xLabel.Text = "Bills Due";
            xLabel.Visible = true;
            xLabel.TextAlign = ContentAlignment.MiddleCenter;
            xLabel.ForeColor = Color.Black;
            xLabel.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
            xLabel.BorderStyle = BorderStyle.FixedSingle;
            xSideBarPanel.Controls.Add(xLabel);// Add to xSideBarPanel
            xLabel.BringToFront();


            //  xTopPanel
            xTopPanel.Location = new Point(0, 0);
            //xTopPanel.Dock = DockStyle.Top;
            xTopPanel.Height = 35;
            xTopPanel.Width = 7 * ((xSideBarPanel.Left - 2) / 7); //Truncates to integer then multiply out to width desired
            xTopPanel.Name = "TopBar";
            xTopPanel.Visible = true;
            xTopPanel.BackColor = Color.Black;
            xTopPanel.AutoSize = false;
            xPanel.Controls.Add(xTopPanel);//Add to Parent
            //Generate Events for Base Panel
            xTopPanel.Resize += xTopPanel_Resize;
            xTopPanel.Click += xTopPanel_Click;


            // Add Controls to TopBar
            //New xButton for Left Side
            xButton = new Button();
            xButton.Dock = DockStyle.Left;
            xButton.Name = "btnPreviousMonth";
            xButton.BackgroundImage = Properties.Resources.Left_Pointer_Black;
            xButton.BackgroundImageLayout = ImageLayout.Zoom;
            xButton.Width = 35; //Only width, Heght to be controled by Containing Control
            xButton.BackColor = Color.FromKnownColor(KnownColor.Control);
            xButton.BackgroundImage = Properties.Resources.Left_Pointer_Black;
            xButton.BackgroundImageLayout = ImageLayout.Zoom;
            info.SetToolTip(xButton, "Previous Month");
            xTopPanel.Controls.Add(xButton);// Add to TopBar

            //xButton Events
            xButton.Click += xButton_Click;
            xButton.MouseEnter += XButton_MouseEnter;
            xButton.MouseLeave += XButton_MouseLeave;

            //New xButton for Right Side
            xButton = new Button();
            xButton.Dock = DockStyle.Right;
            xButton.Name = "btnNextMonth";
            xButton.BackgroundImage = Properties.Resources.Right_Pointer_Black;
            xButton.BackgroundImageLayout = ImageLayout.Zoom;
            xButton.Width = 35;//Only width, Heght to be controled by Containing Control
            xButton.BackColor = Color.FromKnownColor(KnownColor.Control);
            xButton.BackgroundImage = Properties.Resources.Right_Pointer_Black;
            xButton.BackgroundImageLayout = ImageLayout.Zoom;
            info.SetToolTip(xButton, "Next Month");

            xTopPanel.Controls.Add(xButton);// Add to TopBar

            //xButton Events
            xButton.Click += xButton_Click;
            xButton.MouseEnter += XButton_MouseEnter;
            xButton.MouseLeave += XButton_MouseLeave;

            //Add xLable to TopBar
            xLabel = new Label();
            xLabel.Name = "lblTopBarHeader";
            xLabel.Location = new Point(38, 0);
            xLabel.AutoSize = false;
            ////  xLabel.Width = xPanel.Width - 76;
            xLabel.Width = xTopPanel.Width - 4 - (xButton.Width * 2);
            xLabel.Height = xTopPanel.Height;
            xLabel.Font = new Font("Segoe UI", 12);
            xLabel.Text = HeaderText;
            xLabel.TextAlign = ContentAlignment.MiddleCenter;
            xLabel.ForeColor = Color.White;

            xLabel.Click += xLabel_Click;
            xTopPanel.Controls.Add(xLabel);// Add to TopBar
                                           //   xLabel.BringToFront();




            #endregion


            //Perform Calculation to determine width and height of Day Panels and Day Labels

            DayLabelWidth = (xSideBarPanel.Left - 2) / 7;
            DayOfWeek = DayOfMonth(Month, Year, DateTime.Now.Day, false);

            if (DayOfWeek == 7) { DayOfWeek = 0; }//WeekDays start on Monday as 1 and Sunday as 7

            for (int i = 0; i < 7; i++)
            {
                xLabel = new Label();
                xLabel.Name = "lbl_WeekDay_" + i;
                xLabel.Location = new Point(DayLabelWidth * i, 36);//One Lower than Height of Top Bar
                xLabel.Height = 20;
                xLabel.Width = DayLabelWidth;
                xLabel.Text = weekDays[i];
                xLabel.TextAlign = ContentAlignment.MiddleCenter;
                xLabel.ForeColor = Color.White;
                xLabel.BackColor = i == DayOfWeek ? currentWeekDayBackColor : Color.FromArgb(64, 64, 64);
                xLabel.BorderStyle = BorderStyle.FixedSingle;

                xPanel.Controls.Add(xLabel);// Add to xPanel

            }
            startingPoint = xLabel.Bottom + 1;
            C_Step = DayLabelWidth;

            startingDay = DayOfMonth(Month, Year);//Gets the starting Day of the Current Month for the Day Labels
            endingDay = DayOfMonth(Month, Year, 1, true);

            DayPanelHeight = (xPanel.Height - (xTopPanel.Height + xLabel.Height + 2)) / 5;





            flag = false;//Set or Reset Flag condition
            for (int R = 0; R < 5; R++) //Rows
            {
                for (int C = 0; C < 7; C++) //Columns
                {
                    if (flag) { DayCounter++; }
                    if (flag == false && R == 0 && startingDay == C) { flag = true; }//First day was found
                    else if (flag == true && DayCounter > endingDay) { flag = false; }//Last Day of Month was passed



                    Panel pnlDay = new Panel();
                    pnlDay.Height = DayPanelHeight;
                    pnlDay.Width = DayLabelWidth;
                    pnlDay.Name = "DayPanel_R" + R + "C" + C;//lbl_R0C0
                    pnlDay.Visible = true;
                    pnlDay.BorderStyle = BorderStyle.FixedSingle;
                    pnlDay.Location = new Point(C_Step * C, startingPoint + 1 + R_Step);
                    pnlDay.BackColor = flag ? isAvaiable : notAvaiable; //sets Colors based on flag state                    
                    xPanel.Controls.Add(pnlDay);// Add Panel to xPanel

                    xDayLabel = new Label();
                    xDayLabel.Height = 18;
                    xDayLabel.Width = 21;
                    xDayLabel.Name = "lbl_R" + R + "C" + C;//lbl_R0C0
                    xDayLabel.Visible = flag;
                    xDayLabel.BackColor = Color.FromKnownColor(KnownColor.Transparent);
                    xDayLabel.ForeColor = DayCounter == Day ? Color.Maroon : Color.Black;
                    xDayLabel.BorderStyle = BorderStyle.None;
                    xDayLabel.Location = new Point(0, 0);
                    xDayLabel.Font = new Font("Segoe UI", 9);
                    xDayLabel.TextAlign = ContentAlignment.TopLeft;
                    xDayLabel.Text = flag ? DayCounter.ToString() : ""; //Either add in the day or nothing                     
                    pnlDay.Controls.Add(xDayLabel);// Add to pnlDay

                    pnlDay.Click += Day_Click;
                    pnlDay.MouseEnter += Day_MouseEnter;
                    pnlDay.MouseLeave += Day_MouseLeave;
                }

                R_Step += DayPanelHeight;
            }




            /*
             Todo

            Generate List of what Days Items are due this month and add PictureBoxe or lables to each Pannel with Spicific Dolar Sign Emblem
             
             
             
             
             */











        }

        private void xLabel_Click(object? sender, EventArgs e)
        {
            CreateCalendar();//Reset Calendar
        }

        /// <summary>
        ///  Given the Month,Year,Day and bool for last day. Return the Day of the week (1-7) the Day falls on, if looking for last day of month retuns the Day # 28,29,30,31 Depends on Month and LeapYear
        /// </summary>
        /// <param name="iMonth"></param>
        /// <param name="iYear"></param>
        /// <param name="iDay"></param>
        /// <param name="isEndOfMonth"></param>
        /// <returns>Week Day # 1-7 or the Last day of the Specified Month & Year</returns>
        public int DayOfMonth(int iMonth, int iYear, int iDay = 1, bool isEndOfMonth = false)
        {
            DateTime DayOfMonth;
            int returnDay = 0;

            if (isEndOfMonth == false)
            {
                DayOfMonth = new DateTime(iYear, iMonth, iDay);
                returnDay = (int)DayOfMonth.DayOfWeek;
            }
            else
            {
                returnDay = DateTime.DaysInMonth(iYear, iMonth);
            }

            return returnDay;
        }


        #endregion


        #region "Calendar Events"

        private void Day_MouseLeave(object? sender, EventArgs e)
        {
            Panel myPanel = sender as Panel;
            if (sender != null) { myPanel.BackColor = globals.CalendarDayMouseEnterOriginalColor; }
        }

        private void Day_MouseEnter(object? sender, EventArgs e)
        {
            Panel myPanel = sender as Panel;

            if (sender != null) //USing Known Color values and changeing the alpha channel to make it transparentish
            {
                globals.CalendarDayMouseEnterOriginalColor = myPanel.BackColor;//Sets Original Color for mouse Leave event
                int A = 255; //0 = Clear to 255 Solid
                int R = Color.GreenYellow.R;
                int G = Color.GreenYellow.G;
                int B = Color.GreenYellow.B;

                myPanel.BackColor = Color.FromArgb(A, R, G, B);
            }

        }

        private void Day_Click(object? sender, EventArgs e)
        {
            /*Note
             
             Pull Data to generate List of what is Due on selected Date
             
             
             */
        }

        private void xTopPanel_Click(object? sender, EventArgs e)
        {

        }

        private void xTopPanel_Resize(object? sender, EventArgs e)
        {

        }

        private void XButton_MouseLeave(object? sender, EventArgs e)
        {

        }

        private void XButton_MouseEnter(object? sender, EventArgs e)
        {

        }

        private void xButton_Click(object? sender, EventArgs e)
        {
            Button myButton = sender as Button;
            int mm = 0;
            if (myButton != null)
            {
                if (myButton.Name == "btnPreviousMonth")
                {
                    mm -= 1;
                }
                else if (myButton.Name == "btnNextMonth")
                {
                    mm += 1;
                }


                if (myButton.Name == "btnPreviousMonth" || myButton.Name == "btnNextMonth")
                {
                    string[] xString = pnlBottom.Tag.ToString().Split(new string[] { "||" }, StringSplitOptions.RemoveEmptyEntries);
                    int month = int.Parse(xString[0]);
                    int year = int.Parse(xString[1]);
                    month += mm;

                    //Year and Month Wrapping
                    if (month == 0) { year -= 1; month = 12; }
                    else if (month == 13) { year += 1; month = 1; }

                    CreateCalendar(month, year);

                }

            }












        }

        private void xPanel_Click(object? sender, EventArgs e)
        {

        }

        private void xPanel_Resize(object? sender, EventArgs e)
        {

        }
        private void mnuViewCalendar_Click(object sender, EventArgs e)
        {
            CreateCalendar();
        }

        #endregion
        #endregion

        #region "Budget Panel"

        private Panel Create_BudgetEditorPanel()
        {
            // db = new SQL_Database();//Setup new Data Class Object

            Panel xPanel = new Panel();// Main Panel to contain other controls


            Label xLabel = new Label(); //Generic Lable place holder for various labels

            Button xButton = new Button();

            ComboBox xCombobox = new ComboBox();

            CheckedListBox xListbox = new CheckedListBox();

            RichTextBox xRichTextBox = new RichTextBox();

            TextBox xTextBox = new TextBox();

            TreeView xTreeView = new TreeView();

            // Create Panel
            xPanel.Dock = DockStyle.None;
            xPanel.BackColor = SystemColors.Control;
            xPanel.BorderStyle = BorderStyle.FixedSingle;
            xPanel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xPanel.Location = new Point(517, 231);
            xPanel.Name = "pnlBudgetEditor";
            xPanel.Size = new Size(627, 453);
            xPanel.Visible = true;

            //Generate Events for Base Panel
            xPanel.Resize += xPanel_Resize;
            xPanel.Click += xPanel_Click;

            this.Controls.Add(xPanel);//Add Base Panelk to Bottom Panel


            //Add  Labels

            // lblTextBox
            xLabel = new Label();
            xLabel.AutoSize = true;
            xLabel.Location = new Point(44, 132);
            xLabel.Name = "lblTextBox";
            xLabel.Size = new Size(237, 21);
            xLabel.TabIndex = 12;
            xLabel.Text = "Add New Item to Selected Group";

            xPanel.Controls.Add(xLabel);

            // lblGroups

            xLabel = new Label();
            xLabel.AutoSize = true;
            xLabel.Location = new Point(282, 66);
            xLabel.Name = "lblGroups";
            xLabel.Size = new Size(61, 21);
            xLabel.TabIndex = 9;
            xLabel.Text = "Groups";

            xPanel.Controls.Add(xLabel);

            // lblItems
            xLabel = new Label();
            xLabel.AutoSize = true;
            xLabel.Location = new Point(378, 132);
            xLabel.Name = "lblItems";
            xLabel.Size = new Size(175, 21);
            xLabel.TabIndex = 8;
            xLabel.Text = "Items in Selected Group";

            xPanel.Controls.Add(xLabel);


            //lblHeader
            xLabel = new Label();
            xLabel.BackColor = SystemColors.MenuHighlight;
            xLabel.Dock = DockStyle.Top;
            xLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            xLabel.ForeColor = Color.Black;
            xLabel.Location = new Point(0, 0);
            xLabel.Name = "label2";
            xLabel.Size = new Size(625, 33);
            xLabel.TabIndex = 0;
            xLabel.Text = "Budget Editor";
            xLabel.TextAlign = ContentAlignment.MiddleCenter;

            xPanel.Controls.Add(xLabel);

            //Add Textbox
            // txtAddNewItem           
            xTextBox.Location = new Point(34, 156);
            xTextBox.Name = "txtAddNewItem";
            xTextBox.Size = new Size(257, 29);
            xTextBox.TabIndex = 5;

            xPanel.Controls.Add(xTextBox);

            //Add rtbInstructions

            xRichTextBox.BackColor = SystemColors.Control;
            xRichTextBox.BorderStyle = BorderStyle.None;
            xRichTextBox.Location = new Point(40, 195);
            xRichTextBox.Name = "rtbInstructions";
            xRichTextBox.Size = new Size(255, 201);
            xRichTextBox.TabIndex = 13;
            xRichTextBox.Text = "Add additional items to selected group. Items in groups cannot be removed.\nUncheck any items which you do not want selectable for your budget. These can be reverted back at any time.";

            xPanel.Controls.Add(xRichTextBox);

            //Add ComboBox
            //cmbGroups
            xCombobox.FormattingEnabled = true;
            xCombobox.Location = new Point(208, 90);
            xCombobox.Name = "cmbGroups";
            xCombobox.Size = new Size(208, 29);
            xCombobox.TabIndex = 2;

            xPanel.Controls.Add(xCombobox);
            comboBoxBudgetDataCategories = xCombobox;
            //Add Data to ComboBox



            using (SQLiteDataReader reader = db.FetchData(db.sqlCommands(sqlCode: "Budget_1")))
            {
                while (reader.Read())
                {
                    xCombobox.Items.Add(reader["Group"].ToString());
                }
            }

            xCombobox.SelectedIndexChanged += XCombobox_SelectedIndexChanged;




            // treeView_BudgetData
            // 
            xTreeView.CheckBoxes = true;
            xTreeView.Location = new Point(339, 156);
            xTreeView.Name = "treeView_BudgetData";
            xTreeView.Size = new Size(252, 220);
            xTreeView.TabIndex = 12;
            xTreeView.Enabled = true;
            xTreeView.Visible = true;
            xPanel.Controls.Add(xTreeView);
            // treeViewBudgetData = xTreeView;
            //Add Data to xTreeView





            //Add Buttons
            // btnCloseBudgetEditior

            xButton = new Button();
            xButton.BackColor = SystemColors.MenuHighlight;
            xButton.BackgroundImage = Properties.Resources.Cancel1;
            xButton.BackgroundImageLayout = ImageLayout.Zoom;
            xButton.FlatAppearance.BorderSize = 0;
            xButton.FlatStyle = FlatStyle.Flat;
            xButton.Location = new Point(600, 3);
            xButton.Name = "btnCloseBudgetEditior";
            xButton.Size = new Size(22, 20);
            xButton.Tag = "Budget Editior";
            xButton.UseVisualStyleBackColor = false;

            xPanel.Controls.Add(xButton);
            xButton.BringToFront();

            xButton.Click += Close_Object;



            // btnAddNew
            xButton = new Button();
            xButton.BackgroundImage = Properties.Resources.AssignRight;
            xButton.BackgroundImageLayout = ImageLayout.Zoom;
            xButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            xButton.Location = new Point(297, 156);
            xButton.Name = "btnAddNew";
            xButton.Size = new Size(36, 29);
            xButton.TabIndex = 11;
            xButton.UseVisualStyleBackColor = true;


            xPanel.Controls.Add(xButton);

            xButton.Click += btnAddNewCategoryValue_Click;


            // btnUpdate
            xButton = new Button();
            xButton.Location = new Point(339, 382);
            xButton.Name = "btnUpdate";
            xButton.Size = new Size(252, 33);
            xButton.TabIndex = 6;
            xButton.Text = "Update";
            xButton.UseVisualStyleBackColor = true;

            xPanel.Controls.Add(xButton);

            xButton.Click += btnUpdate_Click;

            // btnNewGroup
            xButton = new Button();
            xButton.Location = new Point(420, 90);
            xButton.Name = "btnAddNewGroup";
            xButton.Size = new Size(30, 30);
            xButton.BackgroundImage = Properties.Resources.Add2;
            xButton.BackgroundImageLayout = ImageLayout.Zoom;
            xButton.BringToFront();

            xPanel.Controls.Add(xButton);

            xButton.Click += btnAddNewCategory_Click;



            AssignControls(xPanel);

            return xPanel;
        }


        private void btnAddNewCategoryValue_Click(object? sender, EventArgs e)
        {
            ComboBox cmb = xComboBoxes.Find(x => x.Name == "cmbGroups");
            TextBox xValue = xTextBoxs.Find(x => x.Name == "txtAddNewItem");

            if (cmb == null)
            {
                errorProvider.SetError(cmb, "Missing Value");
            }
            else if (xValue == null)
            {
                errorProvider.SetError(xValue, "Missing Value");
            }
            else
            {
                db.ExecuteCommand(db.sqlCommands("Budget_4", Value1: cmb.Text, Value2: xValue.Text));
            }


        }

        private void btnAddNewCategory_Click(object? sender, EventArgs e)
        {

            ComboBox cmb = xComboBoxes.Find(x => x.Name == "cmbGroups");

            string test = cmb.Text;

            InputBox("What is the 1st value of this new category?", (xValue) =>
            {
                // Now you can use xValue here
                db.ExecuteCommand(db.sqlCommands("Budget_4", Value1: cmb.Text, Value2: xValue));
            });


            TreeView tv = xTreeViews.Find(x => x.Name == "treeView_BudgetData");
            tv.Nodes.Clear();
            PopulateBudgetTree(ref tv, cmb.Text);


        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private void XCombobox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            try
            {
                ComboBox cb = xComboBoxes.Find(x => x.Name == "cmbGroups");
                TreeView tv = xTreeViews.Find(x => x.Name == "treeView_BudgetData");
                PopulateBudgetTree(ref tv, cb.SelectedItem.ToString());
            }
            catch (System.Exception)
            {

            }

        }
        private void PopulateBudgetTree(ref TreeView cntrlName, string Category)
        {
            TreeView BudgetTree = xTreeViews.Find(x => x.Name == "treeView_BudgetData");
            TreeNode selectedCategory = new TreeNode(Category);//Creates Parent Node for View


            using (SQLiteDataReader reader = db.FetchData(db.sqlCommands(sqlCode: "Budget_3", Value1: Category)))
            {
                while (reader.Read())
                {
                    if (reader.GetOrdinal("SubGroup") >= 0)
                    {
                        try
                        {
                            TreeNode value = new TreeNode(reader["SubGroup"].ToString());
                            selectedCategory.Nodes.Add(value);
                        }
                        catch (System.Exception)
                        {

                        }
                    }


                }
            }

            BudgetTree.Nodes.Add(selectedCategory);
            BudgetTree.ExpandAll();





        }




        #endregion

        private void PnlBottom_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #region "Main Menu"
        private void mnuEditBudgetCategories_Click(object sender, EventArgs e)
        {
            Center_Object(Create_BudgetEditorPanel(), EventArgs.Empty, 0, -100);

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuNewPayee_Click(object sender, EventArgs e)
        {
            pnlBottom.Height = 1;
            pnlNewPayee.Visible = true;
            pnlImageSelector.Location = new Point(181, 234);
            pnlImageSelector.Visible = false;
            Center_Object(pnlNewPayee, EventArgs.Empty, 0, 0);
        }
        private void mnuViewChart_Click(object sender, EventArgs e)
        {
            // CreateChartPanel();
        }

        private void mnuNewAccount_Click(object sender, EventArgs e)
        {
            pnlNewAccountSetup.Size = new Size(716, 413);
            Center_Object(pnlNewAccountSetup, EventArgs.Empty, 0, -250);
            pnlMainMenu.Visible = false;
            pnlNewAccountSetup.Visible = true;
            picPnlNewAccountSetup_Logo.AllowDrop = true;
        }



        #endregion

        #region "Chart Panel"

        /*  private void CreateChartPanel()
          {


              pnlBottom.Controls.Clear();//Remove any Controls currently in panel


              //frmMain xForm = new frmMain();
              Panel xPanel = new Panel();// Main Panel to contain other controls            
              Label xLabel = new Label(); //Generic Lable place holder for various labels            
              Button xButton = new Button();
              bool flag = false;




              #region "Hidden Code"

              //Create ToolTip for these controls
              System.Windows.Forms.ToolTip info = new System.Windows.Forms.ToolTip();
              info.AutomaticDelay = 5000;
              info.InitialDelay = 1000;
              info.ReshowDelay = 500;
              info.ShowAlways = false;


              //Create Panels
              //Base            
              xPanel.Dock = DockStyle.Fill;
              xPanel.Name = "Base";
              xPanel.Visible = true;
              xPanel.BackColor = Color.DarkGray;
              xPanel.BorderStyle = BorderStyle.FixedSingle;

              //Generate Events for Base Panel
              xPanel.Resize += xPanel_Resize;
              xPanel.Click += xPanel_Click;

             // pnlBottom.Controls.Add(xPanel);//Add Base Panelk to Bottom Panel


              #endregion

              //Add Top Lable to Panel
              xLabel = new Label();
              xLabel.BackColor = Color.Tan;
              xLabel.Dock = DockStyle.Top;
              xLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
              xLabel.ForeColor = Color.White;
              xLabel.Location = new Point(0, 0);
              xLabel.Name = "lblChartPanelHeader";
              xLabel.Size = new Size(1235, 43);
              xLabel.TabIndex = 1;
              xLabel.Text = "Chart Data";
              xLabel.TextAlign = ContentAlignment.MiddleCenter;

              xPanel.Controls.Add(xLabel);

              //Add Key Panel
              Panel iPanel = new Panel();
              iPanel.Name = "pnlKey";
              iPanel.Size = new Size(180, 384);
              iPanel.BorderStyle = BorderStyle.FixedSingle;
              iPanel.Location = new Point(pnlBottom.Width - 175 - 180,xLabel.Height + 20) ;

              xPanel.Controls.Add(iPanel);

               //Add Label to Key Panel
              xLabel = new Label();
              xLabel.BackColor = Color.Black;
              xLabel.Dock = DockStyle.Top;
              xLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
              xLabel.ForeColor = Color.White;
              xLabel.Location = new Point(0, 0);
              xLabel.Name = "lblChartKeyPanelHeader";
              xLabel.Text = "Key";
              xLabel.TextAlign = ContentAlignment.MiddleCenter;

              iPanel.Controls.Add(xLabel);

              //Add Chart Panel
              Panel ChartPanel = new Panel();
              ChartPanel.Name = "pnlChart";
              ChartPanel.Size = new Size(iPanel.Left-87, pnlBottom.Height- 103);
              ChartPanel.Location = new Point(80,iPanel.Top);
              ChartPanel.BorderStyle = BorderStyle.FixedSingle;
              ChartPanel.BackColor = Color.Gray;
              ChartPanel.Visible = true;

              xPanel.Controls.Add(ChartPanel);

              // Add Di




              pnlBottom.Controls.Add(xPanel);//Add Base Panelk to Bottom Panel
          }




  */

        #endregion

        #region "pnlImageSelector"

        private void ImageSelectorControls_Click(object sender, EventArgs e)
        {
            int displayNumber = 0;
            Button xButton = new Button();

            xButton = sender as Button;

            if (xButton.Name == "btnImageSelectorScrollLeft")
            {
                int.TryParse(btnUseSelectedImage.Tag.ToString(), out displayNumber);
                displayNumber--;
                if (displayNumber == -1)
                {
                    picImageSelectorSelectedImage.Image = Properties.Resources.CreditCardLogos;
                }
                else if (displayNumber < -1)
                {
                    displayNumber = 51;
                    CreditCardImageSelection(displayNumber);
                }
                else
                {
                    CreditCardImageSelection(displayNumber);
                }
            }
            else if (xButton.Name == "btnImageSelectorScrollRight")
            {
                int.TryParse(btnUseSelectedImage.Tag.ToString(), out displayNumber);
                displayNumber++;
                if (displayNumber > 51)
                {
                    displayNumber = -1;
                    picImageSelectorSelectedImage.Image = Properties.Resources.CreditCardLogos;
                }
                else
                {
                    CreditCardImageSelection(displayNumber);
                }

            }
            else
            {
                picNewPayeeCardSelectedImage.Image = picImageSelectorSelectedImage.Image;
                //"btnUseSelectedImage"
                //ToDo Send value to Database create Utility Table or Settings

                pnlImageSelector.Visible = false;
            }

            btnUseSelectedImage.Tag = displayNumber;


        }

        private void picNewPayeeCardSelectedImage_Click(object sender, EventArgs e)
        {
            pnlImageSelector.Visible = true;
            lblImageSelectorHeader.Text = "Select Credit Card Image";
            picImageSelectorSelectedImage.Image = Properties.Resources.CreditCardLogos;
            pnlImageSelector.BringToFront();
            if (btnUseSelectedImage.Tag.ToString() != "-1")
            {
                int.TryParse(btnUseSelectedImage.Tag.ToString(), out int displayNumber);
                CreditCardImageSelection(displayNumber);

            }
        }

        private void CreditCardImageSelection(int displayNumber)
        {

            // Define the row and column values for each logo Grid = 4rows & 13Col
            int Row = displayNumber / 13;
            int Col = displayNumber % 13;



            Size sectionSize = new Size(501, 348); //Size of each logo on Vector Image
            Image image = Properties.Resources.CreditCardLogos;//Logos Purchased from Vector Stock
            const int RowSpacing = 484;//Spacing Between Images 136 plus Image Height 348
            const int ColSpacing = 718;//Spacing Between Images 217 plus Width of Image 501

            Point sectionStartPoint = new Point(0, 0);

            sectionStartPoint = new Point(ColSpacing * Col, RowSpacing * Row); // Replace with the actual values

            Bitmap section = new Bitmap(sectionSize.Width, sectionSize.Height);//Creates a place holder with correct size for image

            using (Graphics g = Graphics.FromImage(section))
            {
                g.DrawImage(image, new Rectangle(Point.Empty, sectionSize), new Rectangle(sectionStartPoint, sectionSize), GraphicsUnit.Pixel);

            }

            if (Row == 4) { picImageSelectorSelectedImage.Image = Properties.Resources.CreditCardLogos; btnUseSelectedImage.Tag = "-1"; }//Reset Control
            else { picImageSelectorSelectedImage.Image = section; }

        }

        #endregion

        #region "pnlMainMenu"


        private void MainMenuButtons_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            pnlMainMenu.Visible = false;
            pnlBottom.Visible = false;

            switch (btn.Name)
            {
                case "btnMainMenuPanel_RecordIncome":
                    CustomExceptionHandler();
                    //throw new NotImplementedException();
                    break;
                case "btnMainMenuPanel_PayBills":
                    CustomExceptionHandler();

                    break;
                case "btnMainMenuPanel_NewTransaction":
                    CustomExceptionHandler();

                    break;
                case "btnMainMenuPanel_DisPlayCalendar":
                    CustomExceptionHandler();

                    break;
                case "btnMainMenuPanel_DisplayCharts":
                    CustomExceptionHandler();

                    break;
                case "btnMainMenuPanel_MoveToSavings":
                    CustomExceptionHandler();

                    break;
                case "btnMainMenuPanel_NewBill":
                    pnlNewPayee.Size = new Size(695, 886);
                    Center_Object(pnlNewPayee, EventArgs.Empty, 0, -50);
                    pnlNewPayee.Visible = true;
                    break;
                case "btnMainMenuPanel_OpenBudget":
                    CustomExceptionHandler();

                    break;
                case "btnMainMenuPanel_AdjustBalances":
                    CustomExceptionHandler();

                    break;
                case "btnMainMenuPanel_PayOffPlanner":
                    CustomExceptionHandler();

                    break;
            }



        }

        private void pnlMainMenu_Resize(object sender, EventArgs e)
        {
            //ToDo: Resize all controls using a loop and mathamatical operations to get size of each control
        }

        private void pnlMainMenu_Click(object sender, EventArgs e)
        {

            if (pnlMainMenu.Height >= 475)//Instant Display
            {
                pnlMainMenu.Height = 35;
            }
            else
            {
                pnlMainMenu.Height = 475;
            }
        }

        private void pnlMainMenu_MouseEnter(object sender, EventArgs e)
        {
            //Assign Paremeters to be used in Generic Timer control for Animation
            dictVariables["intEndSize"] = "475";
            dictVariables["intSizeMode"] = "1";
            dictVariables["intStepSize"] = "30";
            dictVariables["boolHorizontalDirection"] = "false";
            dictVariables["myControl"] = "pnlMainMenu";

            tmrMainForm.Interval = 25;
            tmrMainForm.Enabled = true;
        }



        private void pnlMainMenu_MouseLeave(object sender, EventArgs e)
        {
            if (!pnlMainMenu.ClientRectangle.Contains(pnlMainMenu.PointToClient(Control.MousePosition)))
            {
                //Assign Paremeters to be used in Generic Timer control for Animation
                dictVariables["intEndSize"] = "35";
                dictVariables["intSizeMode"] = "2";
                dictVariables["intStepSize"] = "30";
                dictVariables["boolHorizontalDirection"] = "false";
                dictVariables["myControl"] = "pnlMainMenu";
                tmrMainForm.Enabled = true;
            }



        }

        private void pnlNewPayee_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlNewPayee.Visible == false) { pnlMainMenu.Visible = true; }
        }
        #endregion


        #region "New Bill / Payee Panel"
        private void AccountTypeDecisionLables_Click(object sender, EventArgs e)
        {
            if (!(sender is Label)) { return; }

            Label selection = (Label)sender;




            if (selection.Name == "lblpnlNewPayeeHouseHoldAccount" || selection.Name == "lblpnlNewPayeeLoanAccount" || selection.Name == "lblpnlNewPayeeCrditCardAccount")
            {
                lblpnlNewPayeeHouseHoldAccount.BackColor = Color.FromKnownColor(KnownColor.Control);
                lblpnlNewPayeeHouseHoldAccount.ForeColor = Color.Black;
                lblpnlNewPayeeLoanAccount.BackColor = Color.FromKnownColor(KnownColor.Control);
                lblpnlNewPayeeLoanAccount.ForeColor = Color.Black;
                lblpnlNewPayeeCrditCardAccount.BackColor = Color.FromKnownColor(KnownColor.Control);
                lblpnlNewPayeeCrditCardAccount.ForeColor = Color.Black;




                selection.BackColor = Color.RoyalBlue;
                selection.ForeColor = Color.White;

            }
            pnlNewLiabilityHouseHold.Visible = false;
            pnlNewLiabilityLoan.Visible = false;
            pnlNewLiabilityCreditCard.Visible = false;
            pnlNewLiabilityAccountInformation.Visible = true;
            pnlNewLiabilityAccountInformation.Size = new Size(0, 25);
            pnlNewLiabilityAccountInformation.Location = new Point(0, 753);



            if (selection.Name == "lblpnlNewPayeeHouseHoldAccount")
            {
                pnlNewLiabilityHouseHold.Visible = true;
                pnlNewLiabilityHouseHold.Location = new Point(0, 360);
                pnlNewLiabilityHouseHold.Height = 400;
                pnlNewLiabilityHouseHold.BringToFront();
            }
            else if (selection.Name == "lblpnlNewPayeeLoanAccount")
            {
                pnlNewLiabilityLoan.Visible = true;
                pnlNewLiabilityLoan.Location = new Point(0, 360);
                pnlNewLiabilityLoan.Height = 400;
                pnlNewLiabilityLoan.BringToFront();
            }
            else if (selection.Name == "lblpnlNewPayeeCrditCardAccount")
            {
                pnlNewLiabilityCreditCard.Visible = true;
                pnlNewLiabilityCreditCard.Location = new Point(0, 360);
                pnlNewLiabilityCreditCard.Height = 400;
                pnlNewLiabilityCreditCard.BringToFront();
            }
            else if (selection.Name == "lblpnlNewPayeeAccountInformation")
            {
                pnlNewLiabilityAccountInformation.Visible = true;
                pnlNewLiabilityAccountInformation.Location = new Point(0, 360);
                pnlNewLiabilityAccountInformation.Height = 425;
                pnlNewLiabilityAccountInformation.BringToFront();
            }


        }
        private void monthCalendarPnlNewPayee_DateSelected(object sender, DateRangeEventArgs e)
        {
            btnPnlNewPayeeSetDate.Text = monthCalendarPnlNewPayee.SelectionRange.Start.Day.ToString();
            btnPnlNewPayeeSetDate.Visible = true;
            btnPnlNewPayeeSetDate.BringToFront();
            monthCalendarPnlNewPayee.Visible = false;
            lblPnlNewPayee_SelectedDay.Text = "Selected Due Day";
        }

        private void btnPnlNewPayeeSetDate_Click(object sender, EventArgs e)
        {
            btnPnlNewPayeeSetDate.Visible = false;
            btnPnlNewPayeeSetDate.SendToBack();
            monthCalendarPnlNewPayee.Visible = true;
            monthCalendarPnlNewPayee.BringToFront();
            lblPnlNewPayee_SelectedDay.Text = "Select Due By Date";
        }

        private void PreferedPaymentMethod_MouseEnter(object sender, EventArgs e)//Moves the TextHiglight Box to current control
        {

            PictureBox pic = new PictureBox();
            string xTag = string.Empty;
            pic = sender as PictureBox;

            Point xControl = pic.Location;

            xTag = pic.Tag.ToString();

            lblPaymentMethodHighligter.Visible = false;
            lblPaymentMethodHighligter2.Visible = false;
            lblPaymentMethodHighligter3.Visible = false;

            switch (xTag)
            {
                case "House Hold":
                    lblPaymentMethodHighligter.Location = new Point(xControl.X - 5, xControl.Y - 5);
                    lblPaymentMethodHighligter.Visible = true;
                    break;
                case "Credit Card":
                    lblPaymentMethodHighligter2.Location = new Point(xControl.X - 5, xControl.Y - 5);
                    lblPaymentMethodHighligter2.Visible = true;

                    break;
                case "Loan":
                    lblPaymentMethodHighligter3.Location = new Point(xControl.X - 5, xControl.Y - 5);
                    lblPaymentMethodHighligter3.Visible = true;
                    break;
            }






        }
        #endregion

        #region "New Account"

        private void btnPnlNewAccountSetup_Save_Click(object sender, EventArgs e)
        {

        }



        private void picPnlNewAccountSetup_AccountType_Selection_Click(object sender, EventArgs e)
        {
            PictureBox pic = new PictureBox();

            pic = sender as PictureBox;

            Point xControl = pic.Location;

            lblPnlNewAccountSetup_AccountTypeHilighter.Location = new Point(pic.Location.X - 5, pic.Location.Y - 5);
            lblPnlNewAccountSetup_AccountTypeHilighter.Visible = true;

        }

        private void picPnlNewAccountSetup_Logo_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void picPnlNewAccountSetup_Logo_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files != null && files.Any())
                {
                    picPnlNewAccountSetup_Logo.Image = Image.FromFile(files[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry Someting went wrong while trying to capture the image" + ex.Message);
            }
        }


        private void trackBarPnlNewAccountSetup_Scroll(object sender, EventArgs e)
        {
            if (trackBarPnlNewAccountSetup.Value > 0) { picPnlNewAccountSetup_Logo.SizeMode = PictureBoxSizeMode.StretchImage; }
            else { picPnlNewAccountSetup_Logo.SizeMode = PictureBoxSizeMode.Zoom; }
        }


        private void pnlNewAccountSetup_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlNewAccountSetup.Visible == true)
            {
                pnlMainMenu.Visible = false;
            }
            else
            {
                pnlMainMenu.Visible = true;
            }
        }


        #endregion














    }//end class
}//end NameSpace
