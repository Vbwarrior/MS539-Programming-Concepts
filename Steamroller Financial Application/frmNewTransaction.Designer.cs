namespace Steamroller_Financial_Application
{
    partial class frmNewTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewTransaction));
            txtAmount = new TextBox();
            toolTip1 = new ToolTip(components);
            btnAccept = new Button();
            btnHousing = new Button();
            btnTransportation = new Button();
            btnTravel = new Button();
            btnEntertainment = new Button();
            btnPersonalCare = new Button();
            btnSavings = new Button();
            btnEducation = new Button();
            btnInsurance = new Button();
            btnHealthCare = new Button();
            btnUtilities = new Button();
            btnClothing = new Button();
            btnGroceries = new Button();
            btnPets = new Button();
            btnGifts = new Button();
            btnCash = new Button();
            btnPayBills = new Button();
            btnOnlineBanking = new Button();
            btnCheck = new Button();
            btnCreditCard = new Button();
            btnDebitCard = new Button();
            label1 = new Label();
            btnReturn = new Button();
            pnlHeader = new Panel();
            label2 = new Label();
            btnTaxes = new Button();
            lblPaymentMethodHalo = new Label();
            txtPayTo = new TextBox();
            label4 = new Label();
            lblCategoryHalo = new Label();
            button22 = new Button();
            label3 = new Label();
            label5 = new Label();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // txtAmount
            // 
            txtAmount.BorderStyle = BorderStyle.None;
            txtAmount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new Point(341, 345);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(154, 32);
            txtAmount.TabIndex = 41;
            txtAmount.Text = "0.00";
            txtAmount.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.Transparent;
            btnAccept.BackgroundImage = Properties.Resources.Thumbs_Up_Left;
            btnAccept.BackgroundImageLayout = ImageLayout.Stretch;
            btnAccept.FlatAppearance.BorderSize = 0;
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.Location = new Point(566, 392);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(46, 46);
            btnAccept.TabIndex = 43;
            toolTip1.SetToolTip(btnAccept, "Accept");
            btnAccept.UseVisualStyleBackColor = false;
            // 
            // btnHousing
            // 
            btnHousing.BackgroundImage = Properties.Resources.House;
            btnHousing.BackgroundImageLayout = ImageLayout.Zoom;
            btnHousing.FlatAppearance.BorderSize = 0;
            btnHousing.Location = new Point(88, 75);
            btnHousing.Name = "btnHousing";
            btnHousing.Size = new Size(75, 75);
            btnHousing.TabIndex = 26;
            btnHousing.Tag = "Housing";
            toolTip1.SetToolTip(btnHousing, "Housing &  Maintenance");
            btnHousing.UseVisualStyleBackColor = true;
            // 
            // btnTransportation
            // 
            btnTransportation.BackgroundImage = Properties.Resources.Vehicle;
            btnTransportation.BackgroundImageLayout = ImageLayout.Zoom;
            btnTransportation.FlatAppearance.BorderSize = 0;
            btnTransportation.Location = new Point(169, 75);
            btnTransportation.Name = "btnTransportation";
            btnTransportation.Size = new Size(75, 75);
            btnTransportation.TabIndex = 24;
            btnTransportation.Tag = "Transportation";
            toolTip1.SetToolTip(btnTransportation, "Transportation &  Maintenance");
            btnTransportation.UseVisualStyleBackColor = true;
            // 
            // btnTravel
            // 
            btnTravel.BackgroundImage = Properties.Resources.Travel;
            btnTravel.BackgroundImageLayout = ImageLayout.Zoom;
            btnTravel.FlatAppearance.BorderSize = 0;
            btnTravel.Location = new Point(412, 156);
            btnTravel.Name = "btnTravel";
            btnTravel.Size = new Size(75, 75);
            btnTravel.TabIndex = 27;
            btnTravel.Tag = "Travel";
            toolTip1.SetToolTip(btnTravel, "Travel & Leisure");
            btnTravel.UseVisualStyleBackColor = true;
            // 
            // btnEntertainment
            // 
            btnEntertainment.BackgroundImage = Properties.Resources.Entertainment;
            btnEntertainment.BackgroundImageLayout = ImageLayout.Zoom;
            btnEntertainment.FlatAppearance.BorderSize = 0;
            btnEntertainment.Location = new Point(331, 156);
            btnEntertainment.Name = "btnEntertainment";
            btnEntertainment.Size = new Size(75, 75);
            btnEntertainment.TabIndex = 28;
            btnEntertainment.Tag = "Entertainment";
            toolTip1.SetToolTip(btnEntertainment, "Entertainment");
            btnEntertainment.UseVisualStyleBackColor = true;
            // 
            // btnPersonalCare
            // 
            btnPersonalCare.BackgroundImage = Properties.Resources.Personal_Care;
            btnPersonalCare.BackgroundImageLayout = ImageLayout.Zoom;
            btnPersonalCare.FlatAppearance.BorderSize = 0;
            btnPersonalCare.Location = new Point(250, 156);
            btnPersonalCare.Name = "btnPersonalCare";
            btnPersonalCare.Size = new Size(75, 75);
            btnPersonalCare.TabIndex = 29;
            btnPersonalCare.Tag = "Personal Care";
            toolTip1.SetToolTip(btnPersonalCare, "Personal Care & Grooming");
            btnPersonalCare.UseVisualStyleBackColor = true;
            // 
            // btnSavings
            // 
            btnSavings.BackgroundImage = Properties.Resources.PiggyBank;
            btnSavings.BackgroundImageLayout = ImageLayout.Stretch;
            btnSavings.FlatAppearance.BorderSize = 0;
            btnSavings.Location = new Point(169, 156);
            btnSavings.Name = "btnSavings";
            btnSavings.Size = new Size(75, 75);
            btnSavings.TabIndex = 30;
            btnSavings.Tag = "Savings";
            toolTip1.SetToolTip(btnSavings, "Savings & Investments");
            btnSavings.UseVisualStyleBackColor = true;
            // 
            // btnEducation
            // 
            btnEducation.BackgroundImage = Properties.Resources.Education;
            btnEducation.BackgroundImageLayout = ImageLayout.Zoom;
            btnEducation.FlatAppearance.BorderSize = 0;
            btnEducation.Location = new Point(88, 156);
            btnEducation.Name = "btnEducation";
            btnEducation.Size = new Size(75, 75);
            btnEducation.TabIndex = 31;
            btnEducation.Tag = "Education";
            toolTip1.SetToolTip(btnEducation, "Education & After School Care");
            btnEducation.UseVisualStyleBackColor = true;
            // 
            // btnInsurance
            // 
            btnInsurance.BackgroundImage = Properties.Resources.Insurance;
            btnInsurance.BackgroundImageLayout = ImageLayout.Zoom;
            btnInsurance.FlatAppearance.BorderSize = 0;
            btnInsurance.Location = new Point(574, 75);
            btnInsurance.Name = "btnInsurance";
            btnInsurance.Size = new Size(75, 75);
            btnInsurance.TabIndex = 33;
            btnInsurance.Tag = "Insurance";
            toolTip1.SetToolTip(btnInsurance, "Insurance");
            btnInsurance.UseVisualStyleBackColor = true;
            // 
            // btnHealthCare
            // 
            btnHealthCare.BackgroundImage = Properties.Resources.HealthCare;
            btnHealthCare.BackgroundImageLayout = ImageLayout.Zoom;
            btnHealthCare.FlatAppearance.BorderSize = 0;
            btnHealthCare.Location = new Point(493, 75);
            btnHealthCare.Name = "btnHealthCare";
            btnHealthCare.Size = new Size(75, 75);
            btnHealthCare.TabIndex = 34;
            btnHealthCare.Tag = "Medical ";
            toolTip1.SetToolTip(btnHealthCare, "Health Care");
            btnHealthCare.UseVisualStyleBackColor = true;
            // 
            // btnUtilities
            // 
            btnUtilities.BackgroundImage = Properties.Resources.Utilites;
            btnUtilities.BackgroundImageLayout = ImageLayout.Zoom;
            btnUtilities.Location = new Point(412, 75);
            btnUtilities.Name = "btnUtilities";
            btnUtilities.Size = new Size(75, 75);
            btnUtilities.TabIndex = 35;
            btnUtilities.Tag = "Utilities";
            toolTip1.SetToolTip(btnUtilities, "Houehold Utilities");
            btnUtilities.UseVisualStyleBackColor = true;
            // 
            // btnClothing
            // 
            btnClothing.BackgroundImage = Properties.Resources.Clothes;
            btnClothing.BackgroundImageLayout = ImageLayout.Zoom;
            btnClothing.FlatAppearance.BorderSize = 0;
            btnClothing.Location = new Point(331, 75);
            btnClothing.Name = "btnClothing";
            btnClothing.Size = new Size(75, 75);
            btnClothing.TabIndex = 36;
            btnClothing.Tag = "Clothing";
            toolTip1.SetToolTip(btnClothing, "Clothing & Accessories");
            btnClothing.UseVisualStyleBackColor = true;
            // 
            // btnGroceries
            // 
            btnGroceries.BackgroundImage = Properties.Resources.Food;
            btnGroceries.BackgroundImageLayout = ImageLayout.Zoom;
            btnGroceries.FlatAppearance.BorderSize = 0;
            btnGroceries.Location = new Point(250, 75);
            btnGroceries.Name = "btnGroceries";
            btnGroceries.Size = new Size(75, 75);
            btnGroceries.TabIndex = 37;
            btnGroceries.Tag = "Groceries";
            toolTip1.SetToolTip(btnGroceries, "Groceries & Household Supplies");
            btnGroceries.UseVisualStyleBackColor = true;
            // 
            // btnPets
            // 
            btnPets.BackgroundImage = Properties.Resources.Pets;
            btnPets.BackgroundImageLayout = ImageLayout.Zoom;
            btnPets.FlatAppearance.BorderSize = 0;
            btnPets.Location = new Point(493, 156);
            btnPets.Name = "btnPets";
            btnPets.Size = new Size(75, 75);
            btnPets.TabIndex = 38;
            btnPets.Tag = "Pets";
            toolTip1.SetToolTip(btnPets, "Pet Care & Accessories");
            btnPets.UseVisualStyleBackColor = true;
            // 
            // btnGifts
            // 
            btnGifts.BackgroundImage = Properties.Resources.Gifts;
            btnGifts.BackgroundImageLayout = ImageLayout.Zoom;
            btnGifts.FlatAppearance.BorderSize = 0;
            btnGifts.Location = new Point(574, 156);
            btnGifts.Name = "btnGifts";
            btnGifts.Size = new Size(75, 75);
            btnGifts.TabIndex = 39;
            btnGifts.Tag = "Gifts";
            toolTip1.SetToolTip(btnGifts, "Gifts & Contributions");
            btnGifts.UseVisualStyleBackColor = true;
            // 
            // btnCash
            // 
            btnCash.BackgroundImage = Properties.Resources.vectorstock_51448106;
            btnCash.BackgroundImageLayout = ImageLayout.Zoom;
            btnCash.Location = new Point(212, 457);
            btnCash.Name = "btnCash";
            btnCash.Size = new Size(76, 51);
            btnCash.TabIndex = 48;
            toolTip1.SetToolTip(btnCash, "Cash");
            btnCash.UseVisualStyleBackColor = true;
            // 
            // btnPayBills
            // 
            btnPayBills.BackgroundImage = (Image)resources.GetObject("btnPayBills.BackgroundImage");
            btnPayBills.BackgroundImageLayout = ImageLayout.Stretch;
            btnPayBills.FlatAppearance.BorderSize = 0;
            btnPayBills.Location = new Point(655, 156);
            btnPayBills.Margin = new Padding(1);
            btnPayBills.Name = "btnPayBills";
            btnPayBills.Size = new Size(75, 75);
            btnPayBills.TabIndex = 52;
            btnPayBills.Tag = "Education";
            toolTip1.SetToolTip(btnPayBills, "Pay Bills");
            btnPayBills.UseVisualStyleBackColor = true;
            // 
            // btnOnlineBanking
            // 
            btnOnlineBanking.BackgroundImage = Properties.Resources.vectorstock_1143062_transparent;
            btnOnlineBanking.BackgroundImageLayout = ImageLayout.Zoom;
            btnOnlineBanking.Location = new Point(548, 457);
            btnOnlineBanking.Name = "btnOnlineBanking";
            btnOnlineBanking.Size = new Size(76, 51);
            btnOnlineBanking.TabIndex = 56;
            toolTip1.SetToolTip(btnOnlineBanking, "Online Banking");
            btnOnlineBanking.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            btnCheck.BackgroundImage = Properties.Resources.BlankCheckGreen;
            btnCheck.BackgroundImageLayout = ImageLayout.Zoom;
            btnCheck.Location = new Point(296, 457);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(76, 51);
            btnCheck.TabIndex = 61;
            toolTip1.SetToolTip(btnCheck, "Cash");
            btnCheck.UseVisualStyleBackColor = true;
            // 
            // btnCreditCard
            // 
            btnCreditCard.BackgroundImage = Properties.Resources.CreditCard;
            btnCreditCard.BackgroundImageLayout = ImageLayout.Zoom;
            btnCreditCard.Location = new Point(380, 457);
            btnCreditCard.Name = "btnCreditCard";
            btnCreditCard.Size = new Size(76, 51);
            btnCreditCard.TabIndex = 62;
            toolTip1.SetToolTip(btnCreditCard, "Cash");
            btnCreditCard.UseVisualStyleBackColor = true;
            // 
            // btnDebitCard
            // 
            btnDebitCard.BackgroundImage = Properties.Resources.Debit_Card;
            btnDebitCard.BackgroundImageLayout = ImageLayout.Zoom;
            btnDebitCard.Location = new Point(464, 457);
            btnDebitCard.Name = "btnDebitCard";
            btnDebitCard.Size = new Size(76, 51);
            btnDebitCard.TabIndex = 63;
            toolTip1.SetToolTip(btnDebitCard, "Cash");
            btnDebitCard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(244, 237, 204);
            label1.Location = new Point(377, 319);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 42;
            label1.Text = "Amount";
            // 
            // btnReturn
            // 
            btnReturn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReturn.BackColor = Color.Transparent;
            btnReturn.BackgroundImage = Properties.Resources.Cancel1;
            btnReturn.BackgroundImageLayout = ImageLayout.Zoom;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Location = new Point(784, 3);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(25, 25);
            btnReturn.TabIndex = 44;
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            pnlHeader.BackgroundImage = Properties.Resources.Grid1;
            pnlHeader.BackgroundImageLayout = ImageLayout.Stretch;
            pnlHeader.Controls.Add(btnReturn);
            pnlHeader.Controls.Add(label2);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(812, 55);
            pnlHeader.TabIndex = 47;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Ink Free", 26.2499962F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(812, 55);
            label2.TabIndex = 45;
            label2.Text = "New Transaction";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTaxes
            // 
            btnTaxes.BackgroundImage = Properties.Resources.Taxes1;
            btnTaxes.BackgroundImageLayout = ImageLayout.Zoom;
            btnTaxes.FlatAppearance.BorderSize = 0;
            btnTaxes.Location = new Point(655, 75);
            btnTaxes.Name = "btnTaxes";
            btnTaxes.Size = new Size(75, 75);
            btnTaxes.TabIndex = 32;
            btnTaxes.Tag = "Taxes";
            toolTip1.SetToolTip(btnTaxes, "Taxes & Fees");
            btnTaxes.UseVisualStyleBackColor = true;
            // 
            // lblPaymentMethodHalo
            // 
            lblPaymentMethodHalo.BackColor = SystemColors.Highlight;
            lblPaymentMethodHalo.Location = new Point(207, 452);
            lblPaymentMethodHalo.Name = "lblPaymentMethodHalo";
            lblPaymentMethodHalo.Size = new Size(86, 61);
            lblPaymentMethodHalo.TabIndex = 57;
            // 
            // txtPayTo
            // 
            txtPayTo.BorderStyle = BorderStyle.None;
            txtPayTo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPayTo.Location = new Point(276, 396);
            txtPayTo.Name = "txtPayTo";
            txtPayTo.Size = new Size(284, 32);
            txtPayTo.TabIndex = 58;
            txtPayTo.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(244, 237, 204);
            label4.Location = new Point(188, 402);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 59;
            label4.Text = "Paid To:";
            // 
            // lblCategoryHalo
            // 
            lblCategoryHalo.BackColor = Color.Magenta;
            lblCategoryHalo.Location = new Point(83, 70);
            lblCategoryHalo.Name = "lblCategoryHalo";
            lblCategoryHalo.Size = new Size(85, 85);
            lblCategoryHalo.TabIndex = 60;
            // 
            // button22
            // 
            button22.AutoSize = true;
            button22.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button22.BackColor = Color.Transparent;
            button22.BackgroundImage = Properties.Resources.Black_Metal;
            button22.BackgroundImageLayout = ImageLayout.Stretch;
            button22.FlatAppearance.BorderSize = 0;
            button22.FlatStyle = FlatStyle.Flat;
            button22.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button22.ForeColor = Color.Magenta;
            button22.Location = new Point(356, 256);
            button22.Name = "button22";
            button22.Size = new Size(100, 32);
            button22.TabIndex = 64;
            button22.Text = "Button22";
            button22.TextImageRelation = TextImageRelation.TextBeforeImage;
            button22.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.BackColor = Color.SlateGray;
            label3.Location = new Point(96, 245);
            label3.Name = "label3";
            label3.Size = new Size(621, 2);
            label3.TabIndex = 65;
            // 
            // label5
            // 
            label5.BackColor = Color.SlateGray;
            label5.Location = new Point(96, 307);
            label5.Name = "label5";
            label5.Size = new Size(621, 2);
            label5.TabIndex = 66;
            // 
            // frmNewTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.Black_Metal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(812, 526);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(button22);
            Controls.Add(btnDebitCard);
            Controls.Add(btnCreditCard);
            Controls.Add(btnCheck);
            Controls.Add(label4);
            Controls.Add(txtPayTo);
            Controls.Add(btnOnlineBanking);
            Controls.Add(btnHousing);
            Controls.Add(btnTransportation);
            Controls.Add(btnPayBills);
            Controls.Add(btnTravel);
            Controls.Add(btnCash);
            Controls.Add(btnEntertainment);
            Controls.Add(pnlHeader);
            Controls.Add(btnPersonalCare);
            Controls.Add(btnAccept);
            Controls.Add(btnEducation);
            Controls.Add(btnSavings);
            Controls.Add(btnTaxes);
            Controls.Add(label1);
            Controls.Add(btnInsurance);
            Controls.Add(txtAmount);
            Controls.Add(btnHealthCare);
            Controls.Add(btnUtilities);
            Controls.Add(btnGifts);
            Controls.Add(btnClothing);
            Controls.Add(btnPets);
            Controls.Add(btnGroceries);
            Controls.Add(lblPaymentMethodHalo);
            Controls.Add(lblCategoryHalo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmNewTransaction";
            Text = "NewTransaction";
            Load += NewTransaction_Load;
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtAmount;
        private ToolTip toolTip1;
        private Label label1;
        private Button btnAccept;
        private Button btnReturn;
        private Panel pnlHeader;
        private Label label2;
        private Button btnHousing;
        private Button btnTransportation;
        private Button btnTravel;
        private Button btnEntertainment;
        private Button btnPersonalCare;
        private Button btnSavings;
        private Button btnEducation;
        private Button btnTaxes;
        private Button btnInsurance;
        private Button btnHealthCare;
        private Button btnUtilities;
        private Button btnClothing;
        private Button btnGroceries;
        private Button btnPets;
        private Button btnGifts;
        private Button btnCash;
        private Button btnPayBills;
        private Button btnOnlineBanking;
        private Button btnDebitCard;
        private Button btnCreditCard;
        private Button btnCheck;
        private Label lblPaymentMethodHalo;
        private TextBox txtPayTo;
        private Label label4;
        private Label lblCategoryHalo;
        private Button button22;
        private Label label3;
        private Label label5;
    }
}