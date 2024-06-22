

namespace Steamroller_Financial_Application
{
    partial class frmBudget
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlHeader = new Panel();
            btnCloseAlocatorPanel = new Button();
            lblAllocatedAmount = new Label();
            lblAssignedAmount = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            pnlBudgetCategory_Alocator = new Panel();
            btnAccept = new Button();
            btnReturn = new Button();
            btnAddItemsToCategory = new Button();
            label12 = new Label();
            lblCategoryName = new Label();
            label4 = new Label();
            picControlKnob = new PictureBox();
            button3 = new Button();
            txtAmount = new TextBox();
            button2 = new Button();
            lblGreenBar = new Label();
            button1 = new Button();
            lblRedBar = new Label();
            lblOrangeBar = new Label();
            ttBudget = new ToolTip(components);
            btnTaxes = new Button();
            btnHousing = new Button();
            btnTravel = new Button();
            btnEntertainment = new Button();
            btnPersonalCare = new Button();
            btnsavings = new Button();
            btnEducation = new Button();
            btnInsurance = new Button();
            btnMedicalAndHealthCare = new Button();
            btnUtilities = new Button();
            btnClothing = new Button();
            btnGroceries = new Button();
            btnTransportion = new Button();
            btnPets = new Button();
            btnGifts = new Button();
            pnlHeader.SuspendLayout();
            pnlBudgetCategory_Alocator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picControlKnob).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackgroundImage = Properties.Resources.Grid;
            pnlHeader.BackgroundImageLayout = ImageLayout.Stretch;
            pnlHeader.Controls.Add(btnCloseAlocatorPanel);
            pnlHeader.Controls.Add(lblAllocatedAmount);
            pnlHeader.Controls.Add(lblAssignedAmount);
            pnlHeader.Controls.Add(label7);
            pnlHeader.Controls.Add(label6);
            pnlHeader.Controls.Add(label3);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(811, 55);
            pnlHeader.TabIndex = 0;
            // 
            // btnCloseAlocatorPanel
            // 
            btnCloseAlocatorPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseAlocatorPanel.BackColor = Color.Transparent;
            btnCloseAlocatorPanel.BackgroundImage = Properties.Resources.Cancel1;
            btnCloseAlocatorPanel.BackgroundImageLayout = ImageLayout.Zoom;
            btnCloseAlocatorPanel.FlatAppearance.BorderSize = 0;
            btnCloseAlocatorPanel.FlatStyle = FlatStyle.Flat;
            btnCloseAlocatorPanel.Location = new Point(783, 3);
            btnCloseAlocatorPanel.Name = "btnCloseAlocatorPanel";
            btnCloseAlocatorPanel.Size = new Size(25, 25);
            btnCloseAlocatorPanel.TabIndex = 14;
            ttBudget.SetToolTip(btnCloseAlocatorPanel, "Close Budget");
            btnCloseAlocatorPanel.UseVisualStyleBackColor = false;
            btnCloseAlocatorPanel.Click += btnCloseAlocatorPanel_Click;
            // 
            // lblAllocatedAmount
            // 
            lblAllocatedAmount.BackColor = Color.Transparent;
            lblAllocatedAmount.FlatStyle = FlatStyle.Flat;
            lblAllocatedAmount.Font = new Font("Segoe UI", 8.25F);
            lblAllocatedAmount.ForeColor = Color.FromArgb(244, 237, 204);
            lblAllocatedAmount.Location = new Point(58, 0);
            lblAllocatedAmount.Name = "lblAllocatedAmount";
            lblAllocatedAmount.Size = new Size(37, 23);
            lblAllocatedAmount.TabIndex = 6;
            lblAllocatedAmount.Text = "3000";
            lblAllocatedAmount.TextAlign = ContentAlignment.MiddleCenter;
            ttBudget.SetToolTip(lblAllocatedAmount, "Total available funds for budget.");
            // 
            // lblAssignedAmount
            // 
            lblAssignedAmount.BackColor = Color.Transparent;
            lblAssignedAmount.FlatStyle = FlatStyle.Flat;
            lblAssignedAmount.Font = new Font("Segoe UI", 8.25F);
            lblAssignedAmount.ForeColor = Color.FromArgb(244, 237, 204);
            lblAssignedAmount.Location = new Point(58, 23);
            lblAssignedAmount.Name = "lblAssignedAmount";
            lblAssignedAmount.Size = new Size(37, 23);
            lblAssignedAmount.TabIndex = 5;
            lblAssignedAmount.Text = "1500";
            lblAssignedAmount.TextAlign = ContentAlignment.MiddleCenter;
            ttBudget.SetToolTip(lblAssignedAmount, "Amount of funds already used in budget.");
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 8.25F);
            label7.ForeColor = Color.FromArgb(97, 150, 166);
            label7.Location = new Point(0, 23);
            label7.Name = "label7";
            label7.Size = new Size(58, 23);
            label7.TabIndex = 2;
            label7.Text = "Assigned";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 8.25F);
            label6.ForeColor = Color.FromArgb(97, 150, 166);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 23);
            label6.TabIndex = 1;
            label6.Text = "Allocated";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Ink Free", 26.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(811, 55);
            label3.TabIndex = 0;
            label3.Text = "Budget";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBudgetCategory_Alocator
            // 
            pnlBudgetCategory_Alocator.BackColor = Color.Transparent;
            pnlBudgetCategory_Alocator.Controls.Add(btnAccept);
            pnlBudgetCategory_Alocator.Controls.Add(btnReturn);
            pnlBudgetCategory_Alocator.Controls.Add(btnAddItemsToCategory);
            pnlBudgetCategory_Alocator.Controls.Add(label12);
            pnlBudgetCategory_Alocator.Controls.Add(lblCategoryName);
            pnlBudgetCategory_Alocator.Controls.Add(label4);
            pnlBudgetCategory_Alocator.Controls.Add(picControlKnob);
            pnlBudgetCategory_Alocator.Controls.Add(button3);
            pnlBudgetCategory_Alocator.Controls.Add(txtAmount);
            pnlBudgetCategory_Alocator.Controls.Add(button2);
            pnlBudgetCategory_Alocator.Controls.Add(lblGreenBar);
            pnlBudgetCategory_Alocator.Controls.Add(button1);
            pnlBudgetCategory_Alocator.Controls.Add(lblRedBar);
            pnlBudgetCategory_Alocator.Controls.Add(lblOrangeBar);
            pnlBudgetCategory_Alocator.Location = new Point(12, 61);
            pnlBudgetCategory_Alocator.MinimumSize = new Size(783, 368);
            pnlBudgetCategory_Alocator.Name = "pnlBudgetCategory_Alocator";
            pnlBudgetCategory_Alocator.Size = new Size(783, 368);
            pnlBudgetCategory_Alocator.TabIndex = 10;
            pnlBudgetCategory_Alocator.Visible = false;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.Transparent;
            btnAccept.BackgroundImage = Properties.Resources.Thumbs_Up_Left;
            btnAccept.BackgroundImageLayout = ImageLayout.Zoom;
            btnAccept.FlatAppearance.BorderSize = 0;
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.Location = new Point(480, 75);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(32, 35);
            btnAccept.TabIndex = 15;
            ttBudget.SetToolTip(btnAccept, "Accept Amount");
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackgroundImage = Properties.Resources.Return_Logo1;
            btnReturn.BackgroundImageLayout = ImageLayout.Zoom;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Location = new Point(3, 20);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(67, 23);
            btnReturn.TabIndex = 14;
            ttBudget.SetToolTip(btnReturn, "Return to category selection");
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnAddItemsToCategory
            // 
            btnAddItemsToCategory.BackgroundImage = Properties.Resources.Add2;
            btnAddItemsToCategory.BackgroundImageLayout = ImageLayout.Zoom;
            btnAddItemsToCategory.FlatAppearance.BorderSize = 0;
            btnAddItemsToCategory.FlatStyle = FlatStyle.Flat;
            btnAddItemsToCategory.Location = new Point(755, 234);
            btnAddItemsToCategory.Name = "btnAddItemsToCategory";
            btnAddItemsToCategory.Size = new Size(25, 25);
            btnAddItemsToCategory.TabIndex = 13;
            ttBudget.SetToolTip(btnAddItemsToCategory, "Add new item to selected category.");
            btnAddItemsToCategory.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(95, 93, 156);
            label12.Location = new Point(0, 206);
            label12.Name = "label12";
            label12.Size = new Size(783, 22);
            label12.TabIndex = 12;
            label12.Text = "Items in Category";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCategoryName
            // 
            lblCategoryName.Dock = DockStyle.Top;
            lblCategoryName.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoryName.ForeColor = Color.FromArgb(244, 237, 204);
            lblCategoryName.Location = new Point(0, 0);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(783, 43);
            lblCategoryName.TabIndex = 11;
            lblCategoryName.Text = "Category Name";
            lblCategoryName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Gray;
            label4.Location = new Point(3, 230);
            label4.Name = "label4";
            label4.Size = new Size(777, 1);
            label4.TabIndex = 10;
            // 
            // picControlKnob
            // 
            picControlKnob.BackColor = Color.Transparent;
            picControlKnob.Image = Properties.Resources.SliderControlKnob;
            picControlKnob.Location = new Point(91, 123);
            picControlKnob.Name = "picControlKnob";
            picControlKnob.Size = new Size(30, 30);
            picControlKnob.SizeMode = PictureBoxSizeMode.Zoom;
            picControlKnob.TabIndex = 4;
            picControlKnob.TabStop = false;
            picControlKnob.MouseDown += picControlKnob_MouseDown;
            picControlKnob.MouseMove += picControlKnob_MouseMove;
            picControlKnob.MouseUp += picControlKnob_MouseUp;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.Black_Metal;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(255, 192, 128);
            button3.Location = new Point(467, 247);
            button3.Name = "button3";
            button3.Size = new Size(62, 26);
            button3.TabIndex = 9;
            button3.Text = "Name";
            button3.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            txtAmount.BackColor = Color.FromArgb(64, 64, 64);
            txtAmount.BorderStyle = BorderStyle.None;
            txtAmount.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAmount.ForeColor = Color.Yellow;
            txtAmount.Location = new Point(309, 67);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(165, 43);
            txtAmount.TabIndex = 5;
            txtAmount.Text = "0";
            txtAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.Black_Metal;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.Orchid;
            button2.Location = new Point(360, 247);
            button2.Name = "button2";
            button2.Size = new Size(62, 26);
            button2.TabIndex = 8;
            button2.Text = "Name";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblGreenBar
            // 
            lblGreenBar.BackColor = Color.FromArgb(128, 255, 0);
            lblGreenBar.Location = new Point(91, 133);
            lblGreenBar.Name = "lblGreenBar";
            lblGreenBar.Size = new Size(15, 10);
            lblGreenBar.TabIndex = 2;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackgroundImage = Properties.Resources.Black_Metal;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.Aquamarine;
            button1.Location = new Point(253, 247);
            button1.Name = "button1";
            button1.Size = new Size(50, 25);
            button1.TabIndex = 7;
            button1.Text = "Name";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblRedBar
            // 
            lblRedBar.BackColor = Color.Maroon;
            lblRedBar.Location = new Point(631, 133);
            lblRedBar.Name = "lblRedBar";
            lblRedBar.Size = new Size(60, 10);
            lblRedBar.TabIndex = 3;
            // 
            // lblOrangeBar
            // 
            lblOrangeBar.BackColor = Color.FromArgb(255, 128, 0);
            lblOrangeBar.Location = new Point(91, 133);
            lblOrangeBar.Name = "lblOrangeBar";
            lblOrangeBar.Size = new Size(600, 10);
            lblOrangeBar.TabIndex = 1;
            // 
            // btnTaxes
            // 
            btnTaxes.BackgroundImage = Properties.Resources.Taxes1;
            btnTaxes.BackgroundImageLayout = ImageLayout.Zoom;
            btnTaxes.FlatAppearance.BorderSize = 0;
            btnTaxes.Location = new Point(341, 190);
            btnTaxes.Name = "btnTaxes";
            btnTaxes.Size = new Size(100, 100);
            btnTaxes.TabIndex = 17;
            btnTaxes.Tag = "Taxes";
            ttBudget.SetToolTip(btnTaxes, "Taxes & Fees");
            btnTaxes.UseVisualStyleBackColor = true;
            btnTaxes.Click += Category_Click;
            // 
            // btnHousing
            // 
            btnHousing.BackgroundImage = Properties.Resources.House;
            btnHousing.BackgroundImageLayout = ImageLayout.Zoom;
            btnHousing.FlatAppearance.BorderSize = 0;
            btnHousing.Location = new Point(53, 72);
            btnHousing.Name = "btnHousing";
            btnHousing.Size = new Size(100, 100);
            btnHousing.TabIndex = 11;
            btnHousing.Tag = "Housing";
            ttBudget.SetToolTip(btnHousing, "Housing &  Maintenance");
            btnHousing.UseVisualStyleBackColor = true;
            btnHousing.Click += Category_Click;
            // 
            // btnTravel
            // 
            btnTravel.BackgroundImage = Properties.Resources.Travel;
            btnTravel.BackgroundImageLayout = ImageLayout.Zoom;
            btnTravel.FlatAppearance.BorderSize = 0;
            btnTravel.Location = new Point(341, 308);
            btnTravel.Name = "btnTravel";
            btnTravel.Size = new Size(100, 100);
            btnTravel.TabIndex = 12;
            btnTravel.Tag = "Travel";
            ttBudget.SetToolTip(btnTravel, "Travel & Leisure");
            btnTravel.UseVisualStyleBackColor = true;
            btnTravel.Click += Category_Click;
            // 
            // btnEntertainment
            // 
            btnEntertainment.BackgroundImage = Properties.Resources.Entertainment;
            btnEntertainment.BackgroundImageLayout = ImageLayout.Zoom;
            btnEntertainment.FlatAppearance.BorderSize = 0;
            btnEntertainment.Location = new Point(197, 308);
            btnEntertainment.Name = "btnEntertainment";
            btnEntertainment.Size = new Size(100, 100);
            btnEntertainment.TabIndex = 13;
            btnEntertainment.Tag = "Entertainment";
            ttBudget.SetToolTip(btnEntertainment, "Entertainment");
            btnEntertainment.UseVisualStyleBackColor = true;
            btnEntertainment.Click += Category_Click;
            // 
            // btnPersonalCare
            // 
            btnPersonalCare.BackgroundImage = Properties.Resources.Personal_Care;
            btnPersonalCare.BackgroundImageLayout = ImageLayout.Zoom;
            btnPersonalCare.FlatAppearance.BorderSize = 0;
            btnPersonalCare.Location = new Point(53, 308);
            btnPersonalCare.Name = "btnPersonalCare";
            btnPersonalCare.Size = new Size(100, 100);
            btnPersonalCare.TabIndex = 14;
            btnPersonalCare.Tag = "Personal Care";
            ttBudget.SetToolTip(btnPersonalCare, "Personal Care & Grooming");
            btnPersonalCare.UseVisualStyleBackColor = true;
            btnPersonalCare.Click += Category_Click;
            // 
            // btnsavings
            // 
            btnsavings.BackgroundImage = Properties.Resources.PiggyBank;
            btnsavings.BackgroundImageLayout = ImageLayout.Zoom;
            btnsavings.FlatAppearance.BorderSize = 0;
            btnsavings.Location = new Point(629, 190);
            btnsavings.Name = "btnsavings";
            btnsavings.Size = new Size(100, 100);
            btnsavings.TabIndex = 15;
            btnsavings.Tag = "Savings";
            ttBudget.SetToolTip(btnsavings, "Savings & Investments");
            btnsavings.UseVisualStyleBackColor = true;
            btnsavings.Click += Category_Click;
            // 
            // btnEducation
            // 
            btnEducation.BackgroundImage = Properties.Resources.Education;
            btnEducation.BackgroundImageLayout = ImageLayout.Zoom;
            btnEducation.FlatAppearance.BorderSize = 0;
            btnEducation.Location = new Point(485, 190);
            btnEducation.Name = "btnEducation";
            btnEducation.Size = new Size(100, 100);
            btnEducation.TabIndex = 16;
            btnEducation.Tag = "Education";
            ttBudget.SetToolTip(btnEducation, "Education & After School Care");
            btnEducation.UseVisualStyleBackColor = true;
            btnEducation.Click += Category_Click;
            // 
            // btnInsurance
            // 
            btnInsurance.BackgroundImage = Properties.Resources.Insurance;
            btnInsurance.BackgroundImageLayout = ImageLayout.Zoom;
            btnInsurance.FlatAppearance.BorderSize = 0;
            btnInsurance.Location = new Point(197, 190);
            btnInsurance.Name = "btnInsurance";
            btnInsurance.Size = new Size(100, 100);
            btnInsurance.TabIndex = 18;
            btnInsurance.Tag = "Insurance";
            ttBudget.SetToolTip(btnInsurance, "Insurance");
            btnInsurance.UseVisualStyleBackColor = true;
            btnInsurance.Click += Category_Click;
            // 
            // btnMedicalAndHealthCare
            // 
            btnMedicalAndHealthCare.BackgroundImage = Properties.Resources.HealthCare;
            btnMedicalAndHealthCare.BackgroundImageLayout = ImageLayout.Zoom;
            btnMedicalAndHealthCare.FlatAppearance.BorderSize = 0;
            btnMedicalAndHealthCare.Location = new Point(53, 190);
            btnMedicalAndHealthCare.Name = "btnMedicalAndHealthCare";
            btnMedicalAndHealthCare.Size = new Size(100, 100);
            btnMedicalAndHealthCare.TabIndex = 19;
            btnMedicalAndHealthCare.Tag = "Medical ";
            ttBudget.SetToolTip(btnMedicalAndHealthCare, "Health Care");
            btnMedicalAndHealthCare.UseVisualStyleBackColor = true;
            btnMedicalAndHealthCare.Click += Category_Click;
            // 
            // btnUtilities
            // 
            btnUtilities.BackgroundImage = Properties.Resources.Utilites;
            btnUtilities.BackgroundImageLayout = ImageLayout.Zoom;
            btnUtilities.Location = new Point(629, 72);
            btnUtilities.Name = "btnUtilities";
            btnUtilities.Size = new Size(100, 100);
            btnUtilities.TabIndex = 20;
            btnUtilities.Tag = "Utilities";
            ttBudget.SetToolTip(btnUtilities, "Houehold Utilities");
            btnUtilities.UseVisualStyleBackColor = true;
            btnUtilities.Click += Category_Click;
            // 
            // btnClothing
            // 
            btnClothing.BackgroundImage = Properties.Resources.Clothes;
            btnClothing.BackgroundImageLayout = ImageLayout.Zoom;
            btnClothing.FlatAppearance.BorderSize = 0;
            btnClothing.Location = new Point(485, 72);
            btnClothing.Name = "btnClothing";
            btnClothing.Size = new Size(100, 100);
            btnClothing.TabIndex = 21;
            btnClothing.Tag = "Clothing";
            ttBudget.SetToolTip(btnClothing, "Clothing & Accessories");
            btnClothing.UseVisualStyleBackColor = true;
            btnClothing.Click += Category_Click;
            // 
            // btnGroceries
            // 
            btnGroceries.BackgroundImage = Properties.Resources.Food;
            btnGroceries.BackgroundImageLayout = ImageLayout.Zoom;
            btnGroceries.FlatAppearance.BorderSize = 0;
            btnGroceries.Location = new Point(341, 72);
            btnGroceries.Name = "btnGroceries";
            btnGroceries.Size = new Size(100, 100);
            btnGroceries.TabIndex = 22;
            btnGroceries.Tag = "Groceries";
            ttBudget.SetToolTip(btnGroceries, "Groceries & Household Supplies");
            btnGroceries.UseVisualStyleBackColor = true;
            btnGroceries.Click += Category_Click;
            // 
            // btnTransportion
            // 
            btnTransportion.BackgroundImage = Properties.Resources.Vehicle;
            btnTransportion.BackgroundImageLayout = ImageLayout.Zoom;
            btnTransportion.FlatAppearance.BorderSize = 0;
            btnTransportion.Location = new Point(197, 72);
            btnTransportion.Name = "btnTransportion";
            btnTransportion.Size = new Size(100, 100);
            btnTransportion.TabIndex = 23;
            btnTransportion.Tag = "Transportation";
            ttBudget.SetToolTip(btnTransportion, "Transportation &  Maintenance");
            btnTransportion.UseVisualStyleBackColor = true;
            btnTransportion.Click += Category_Click;
            // 
            // btnPets
            // 
            btnPets.BackgroundImage = Properties.Resources.Pets;
            btnPets.BackgroundImageLayout = ImageLayout.Zoom;
            btnPets.FlatAppearance.BorderSize = 0;
            btnPets.Location = new Point(485, 308);
            btnPets.Name = "btnPets";
            btnPets.Size = new Size(100, 100);
            btnPets.TabIndex = 24;
            btnPets.Tag = "Pets";
            ttBudget.SetToolTip(btnPets, "Pet Care & Accessories");
            btnPets.UseVisualStyleBackColor = true;
            btnPets.Click += Category_Click;
            // 
            // btnGifts
            // 
            btnGifts.BackgroundImage = Properties.Resources.Gifts;
            btnGifts.BackgroundImageLayout = ImageLayout.Zoom;
            btnGifts.FlatAppearance.BorderSize = 0;
            btnGifts.Location = new Point(629, 308);
            btnGifts.Name = "btnGifts";
            btnGifts.Size = new Size(100, 100);
            btnGifts.TabIndex = 25;
            btnGifts.Tag = "Gifts";
            ttBudget.SetToolTip(btnGifts, "Gifts & Contributions");
            btnGifts.UseVisualStyleBackColor = true;
            btnGifts.Click += Category_Click;
            // 
            // frmBudget
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.Black_Metal;
            ClientSize = new Size(811, 460);
            Controls.Add(pnlBudgetCategory_Alocator);
            Controls.Add(btnGifts);
            Controls.Add(btnPets);
            Controls.Add(btnTransportion);
            Controls.Add(btnGroceries);
            Controls.Add(btnClothing);
            Controls.Add(btnUtilities);
            Controls.Add(btnMedicalAndHealthCare);
            Controls.Add(btnInsurance);
            Controls.Add(btnTaxes);
            Controls.Add(btnEducation);
            Controls.Add(btnsavings);
            Controls.Add(btnPersonalCare);
            Controls.Add(btnEntertainment);
            Controls.Add(btnTravel);
            Controls.Add(btnHousing);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "frmBudget";
            StartPosition = FormStartPosition.CenterParent;
            Tag = "Housing";
            Text = "frmTransactionsAndBudget";
            Load += frmBudget_Load;
            pnlHeader.ResumeLayout(false);
            pnlBudgetCategory_Alocator.ResumeLayout(false);
            pnlBudgetCategory_Alocator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picControlKnob).EndInit();
            ResumeLayout(false);
        }





        #endregion

        private Panel pnlHeader;
        private Label lblOrangeBar;
        private Label lblGreenBar;
        private Label lblRedBar;
        private PictureBox picControlKnob;
        private TextBox txtAmount;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
        private Panel pnlBudgetCategory_Alocator;
        private Label lblAssignedAmount;
        private Label label7;
        private Label label6;
        private Label lblCategoryName;
        private Label label4;
        private Label lblAllocatedAmount;
        private Label label12;
        private Button btnCloseAlocatorPanel;
        private Button btnAddItemsToCategory;
        private ToolTip ttBudget;
        private Button btnReturn;
        private Button btnAccept;
        private Button btnHousing;
        private Button btnTravel;
        private Button btnEntertainment;
        private Button btnPersonalCare;
        private Button btnsavings;
        private Button btnEducation;
        private Button btnTaxes;
        private Button btnInsurance;
        private Button btnMedicalAndHealthCare;
        private Button btnUtilities;
        private Button btnClothing;
        private Button btnGroceries;
        private Button btnTransportion;
        private Button btnPets;
        private Button btnGifts;
    }
}