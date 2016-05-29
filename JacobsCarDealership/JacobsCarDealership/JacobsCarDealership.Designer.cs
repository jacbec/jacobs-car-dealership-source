using System;
using System.Windows.Forms;

namespace JacobsCarDealership
{
    partial class JacobsCarDealership
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
            this.boxAddCar = new System.Windows.Forms.GroupBox();
            this.cboAddRoofType = new System.Windows.Forms.ComboBox();
            this.cboAddDoors = new System.Windows.Forms.ComboBox();
            this.cboAddCondition = new System.Windows.Forms.ComboBox();
            this.cboAddType = new System.Windows.Forms.ComboBox();
            this.txtAddMileage = new System.Windows.Forms.TextBox();
            this.lblAddMileage = new System.Windows.Forms.Label();
            this.txtAddCost = new System.Windows.Forms.TextBox();
            this.lblAddCost = new System.Windows.Forms.Label();
            this.txtAddBedLength = new System.Windows.Forms.TextBox();
            this.lblAddBedLength = new System.Windows.Forms.Label();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.lblAddRoofType = new System.Windows.Forms.Label();
            this.lblAddDoors = new System.Windows.Forms.Label();
            this.txtAddColor = new System.Windows.Forms.TextBox();
            this.txtAddYear = new System.Windows.Forms.TextBox();
            this.txtAddModel = new System.Windows.Forms.TextBox();
            this.txtAddMake = new System.Windows.Forms.TextBox();
            this.lblAddColor = new System.Windows.Forms.Label();
            this.lblAddYear = new System.Windows.Forms.Label();
            this.lblAddModel = new System.Windows.Forms.Label();
            this.lblAddMake = new System.Windows.Forms.Label();
            this.lblAddCondition = new System.Windows.Forms.Label();
            this.lblAddType = new System.Windows.Forms.Label();
            this.boxAddStaff = new System.Windows.Forms.GroupBox();
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.txtAddPosition = new System.Windows.Forms.TextBox();
            this.txtAddFirstName = new System.Windows.Forms.TextBox();
            this.lblAddPassword = new System.Windows.Forms.Label();
            this.lblAddPosition = new System.Windows.Forms.Label();
            this.lblAddLastName = new System.Windows.Forms.Label();
            this.lblAddFirstName = new System.Windows.Forms.Label();
            this.boxRemoveStaff = new System.Windows.Forms.GroupBox();
            this.txtRemoveUsername = new System.Windows.Forms.TextBox();
            this.btnRemoveStaff = new System.Windows.Forms.Button();
            this.txtRemoveID = new System.Windows.Forms.TextBox();
            this.lblRemoveUsername = new System.Windows.Forms.Label();
            this.lblRemoveID = new System.Windows.Forms.Label();
            this.boxProfit = new System.Windows.Forms.GroupBox();
            this.lblProjectedTotalValue = new System.Windows.Forms.Label();
            this.lblAnnualValue = new System.Windows.Forms.Label();
            this.lblSemiAnnualValue = new System.Windows.Forms.Label();
            this.lblMonthlyValue = new System.Windows.Forms.Label();
            this.lblBiWeeklyValue = new System.Windows.Forms.Label();
            this.lblProjectedTotal = new System.Windows.Forms.Label();
            this.lblAnnual = new System.Windows.Forms.Label();
            this.lblSemiAnnual = new System.Windows.Forms.Label();
            this.lblMonthly = new System.Windows.Forms.Label();
            this.lblBiWeekly = new System.Windows.Forms.Label();
            this.boxStaffSoldCars = new System.Windows.Forms.GroupBox();
            this.dgvStaffSoldCars = new System.Windows.Forms.DataGridView();
            this.boxCarList = new System.Windows.Forms.GroupBox();
            this.dgvCarsList = new System.Windows.Forms.DataGridView();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.cboCost = new System.Windows.Forms.ComboBox();
            this.cboBedLength = new System.Windows.Forms.ComboBox();
            this.cboRoofType = new System.Windows.Forms.ComboBox();
            this.cboDoors = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboMileage = new System.Windows.Forms.ComboBox();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.cboMake = new System.Windows.Forms.ComboBox();
            this.cboCondition = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.tcCompany = new System.Windows.Forms.TabControl();
            this.tpCompany = new System.Windows.Forms.TabPage();
            this.boxOnLotLongest = new System.Windows.Forms.GroupBox();
            this.dgvOnLotLongest = new System.Windows.Forms.DataGridView();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.boxEditInfo = new System.Windows.Forms.GroupBox();
            this.txtEditFirstName = new System.Windows.Forms.TextBox();
            this.lblEditFirstName = new System.Windows.Forms.Label();
            this.btnEditInfo = new System.Windows.Forms.Button();
            this.txtEditPassword = new System.Windows.Forms.TextBox();
            this.txtEditLastName = new System.Windows.Forms.TextBox();
            this.lblEditPassword = new System.Windows.Forms.Label();
            this.lblEditLastName = new System.Windows.Forms.Label();
            this.boxSellCar = new System.Windows.Forms.GroupBox();
            this.txtSoldToDriverLicense = new System.Windows.Forms.TextBox();
            this.txtSoldToState = new System.Windows.Forms.TextBox();
            this.lblSoldToDriverLicense = new System.Windows.Forms.Label();
            this.lblSoldToState = new System.Windows.Forms.Label();
            this.txtSoldToZip = new System.Windows.Forms.TextBox();
            this.lblSoldToZip = new System.Windows.Forms.Label();
            this.txtSoldToStreet = new System.Windows.Forms.TextBox();
            this.lblSoldToStreet = new System.Windows.Forms.Label();
            this.txtSoldToCity = new System.Windows.Forms.TextBox();
            this.lblSoldToCity = new System.Windows.Forms.Label();
            this.txtSoldToLastName = new System.Windows.Forms.TextBox();
            this.lblSoldToLastName = new System.Windows.Forms.Label();
            this.txtSoldToFirstName = new System.Windows.Forms.TextBox();
            this.lblSoldToFirstName = new System.Windows.Forms.Label();
            this.btnSellCar = new System.Windows.Forms.Button();
            this.txtSoldPrice = new System.Windows.Forms.TextBox();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.lblSoldPrice = new System.Windows.Forms.Label();
            this.lblCarID = new System.Windows.Forms.Label();
            this.boxUserSoldCars = new System.Windows.Forms.GroupBox();
            this.dgvUserSoldCars = new System.Windows.Forms.DataGridView();
            this.tpOwner = new System.Windows.Forms.TabPage();
            this.boxAddCar.SuspendLayout();
            this.boxAddStaff.SuspendLayout();
            this.boxRemoveStaff.SuspendLayout();
            this.boxProfit.SuspendLayout();
            this.boxStaffSoldCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffSoldCars)).BeginInit();
            this.boxCarList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarsList)).BeginInit();
            this.tcCompany.SuspendLayout();
            this.tpCompany.SuspendLayout();
            this.boxOnLotLongest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnLotLongest)).BeginInit();
            this.boxEditInfo.SuspendLayout();
            this.boxSellCar.SuspendLayout();
            this.boxUserSoldCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserSoldCars)).BeginInit();
            this.tpOwner.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxAddCar
            // 
            this.boxAddCar.Controls.Add(this.cboAddRoofType);
            this.boxAddCar.Controls.Add(this.cboAddDoors);
            this.boxAddCar.Controls.Add(this.cboAddCondition);
            this.boxAddCar.Controls.Add(this.cboAddType);
            this.boxAddCar.Controls.Add(this.txtAddMileage);
            this.boxAddCar.Controls.Add(this.lblAddMileage);
            this.boxAddCar.Controls.Add(this.txtAddCost);
            this.boxAddCar.Controls.Add(this.lblAddCost);
            this.boxAddCar.Controls.Add(this.txtAddBedLength);
            this.boxAddCar.Controls.Add(this.lblAddBedLength);
            this.boxAddCar.Controls.Add(this.btnAddCar);
            this.boxAddCar.Controls.Add(this.lblAddRoofType);
            this.boxAddCar.Controls.Add(this.lblAddDoors);
            this.boxAddCar.Controls.Add(this.txtAddColor);
            this.boxAddCar.Controls.Add(this.txtAddYear);
            this.boxAddCar.Controls.Add(this.txtAddModel);
            this.boxAddCar.Controls.Add(this.txtAddMake);
            this.boxAddCar.Controls.Add(this.lblAddColor);
            this.boxAddCar.Controls.Add(this.lblAddYear);
            this.boxAddCar.Controls.Add(this.lblAddModel);
            this.boxAddCar.Controls.Add(this.lblAddMake);
            this.boxAddCar.Controls.Add(this.lblAddCondition);
            this.boxAddCar.Controls.Add(this.lblAddType);
            this.boxAddCar.Location = new System.Drawing.Point(6, 6);
            this.boxAddCar.Name = "boxAddCar";
            this.boxAddCar.Size = new System.Drawing.Size(294, 334);
            this.boxAddCar.TabIndex = 0;
            this.boxAddCar.TabStop = false;
            this.boxAddCar.Text = "Add Car";
            // 
            // cboAddRoofType
            // 
            this.cboAddRoofType.FormattingEnabled = true;
            this.cboAddRoofType.Items.AddRange(new object[] {
            "Hard",
            "Contractible",
            "Removable"});
            this.cboAddRoofType.Location = new System.Drawing.Point(103, 219);
            this.cboAddRoofType.Name = "cboAddRoofType";
            this.cboAddRoofType.Size = new System.Drawing.Size(185, 21);
            this.cboAddRoofType.TabIndex = 26;
            // 
            // cboAddDoors
            // 
            this.cboAddDoors.FormattingEnabled = true;
            this.cboAddDoors.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboAddDoors.Location = new System.Drawing.Point(103, 194);
            this.cboAddDoors.Name = "cboAddDoors";
            this.cboAddDoors.Size = new System.Drawing.Size(185, 21);
            this.cboAddDoors.TabIndex = 25;
            // 
            // cboAddCondition
            // 
            this.cboAddCondition.FormattingEnabled = true;
            this.cboAddCondition.Items.AddRange(new object[] {
            "New",
            "Used"});
            this.cboAddCondition.Location = new System.Drawing.Point(103, 41);
            this.cboAddCondition.Name = "cboAddCondition";
            this.cboAddCondition.Size = new System.Drawing.Size(185, 21);
            this.cboAddCondition.TabIndex = 24;
            // 
            // cboAddType
            // 
            this.cboAddType.FormattingEnabled = true;
            this.cboAddType.Items.AddRange(new object[] {
            "Coupe",
            "Sedan",
            "Van",
            "Convertible",
            "Truck"});
            this.cboAddType.Location = new System.Drawing.Point(103, 16);
            this.cboAddType.Name = "cboAddType";
            this.cboAddType.Size = new System.Drawing.Size(185, 21);
            this.cboAddType.TabIndex = 23;
            // 
            // txtAddMileage
            // 
            this.txtAddMileage.Location = new System.Drawing.Point(103, 117);
            this.txtAddMileage.Name = "txtAddMileage";
            this.txtAddMileage.Size = new System.Drawing.Size(185, 20);
            this.txtAddMileage.TabIndex = 22;
            // 
            // lblAddMileage
            // 
            this.lblAddMileage.AutoSize = true;
            this.lblAddMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMileage.Location = new System.Drawing.Point(6, 117);
            this.lblAddMileage.Name = "lblAddMileage";
            this.lblAddMileage.Size = new System.Drawing.Size(68, 20);
            this.lblAddMileage.TabIndex = 21;
            this.lblAddMileage.Text = "Mileage:";
            // 
            // txtAddCost
            // 
            this.txtAddCost.Location = new System.Drawing.Point(103, 271);
            this.txtAddCost.Name = "txtAddCost";
            this.txtAddCost.Size = new System.Drawing.Size(185, 20);
            this.txtAddCost.TabIndex = 20;
            // 
            // lblAddCost
            // 
            this.lblAddCost.AutoSize = true;
            this.lblAddCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCost.Location = new System.Drawing.Point(6, 271);
            this.lblAddCost.Name = "lblAddCost";
            this.lblAddCost.Size = new System.Drawing.Size(46, 20);
            this.lblAddCost.TabIndex = 19;
            this.lblAddCost.Text = "Cost:";
            // 
            // txtAddBedLength
            // 
            this.txtAddBedLength.Location = new System.Drawing.Point(103, 245);
            this.txtAddBedLength.Name = "txtAddBedLength";
            this.txtAddBedLength.Size = new System.Drawing.Size(185, 20);
            this.txtAddBedLength.TabIndex = 18;
            // 
            // lblAddBedLength
            // 
            this.lblAddBedLength.AutoSize = true;
            this.lblAddBedLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBedLength.Location = new System.Drawing.Point(6, 245);
            this.lblAddBedLength.Name = "lblAddBedLength";
            this.lblAddBedLength.Size = new System.Drawing.Size(96, 20);
            this.lblAddBedLength.TabIndex = 17;
            this.lblAddBedLength.Text = "Bed Length:";
            // 
            // btnAddCar
            // 
            this.btnAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Location = new System.Drawing.Point(211, 297);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(77, 29);
            this.btnAddCar.TabIndex = 12;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // lblAddRoofType
            // 
            this.lblAddRoofType.AutoSize = true;
            this.lblAddRoofType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRoofType.Location = new System.Drawing.Point(6, 219);
            this.lblAddRoofType.Name = "lblAddRoofType";
            this.lblAddRoofType.Size = new System.Drawing.Size(86, 20);
            this.lblAddRoofType.TabIndex = 15;
            this.lblAddRoofType.Text = "Roof Type:";
            // 
            // lblAddDoors
            // 
            this.lblAddDoors.AutoSize = true;
            this.lblAddDoors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDoors.Location = new System.Drawing.Point(6, 193);
            this.lblAddDoors.Name = "lblAddDoors";
            this.lblAddDoors.Size = new System.Drawing.Size(56, 20);
            this.lblAddDoors.TabIndex = 13;
            this.lblAddDoors.Text = "Doors:";
            // 
            // txtAddColor
            // 
            this.txtAddColor.Location = new System.Drawing.Point(103, 168);
            this.txtAddColor.Name = "txtAddColor";
            this.txtAddColor.Size = new System.Drawing.Size(185, 20);
            this.txtAddColor.TabIndex = 11;
            // 
            // txtAddYear
            // 
            this.txtAddYear.Location = new System.Drawing.Point(103, 143);
            this.txtAddYear.Name = "txtAddYear";
            this.txtAddYear.Size = new System.Drawing.Size(185, 20);
            this.txtAddYear.TabIndex = 10;
            // 
            // txtAddModel
            // 
            this.txtAddModel.Location = new System.Drawing.Point(103, 91);
            this.txtAddModel.Name = "txtAddModel";
            this.txtAddModel.Size = new System.Drawing.Size(185, 20);
            this.txtAddModel.TabIndex = 9;
            // 
            // txtAddMake
            // 
            this.txtAddMake.Location = new System.Drawing.Point(103, 66);
            this.txtAddMake.Name = "txtAddMake";
            this.txtAddMake.Size = new System.Drawing.Size(185, 20);
            this.txtAddMake.TabIndex = 8;
            // 
            // lblAddColor
            // 
            this.lblAddColor.AutoSize = true;
            this.lblAddColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddColor.Location = new System.Drawing.Point(6, 168);
            this.lblAddColor.Name = "lblAddColor";
            this.lblAddColor.Size = new System.Drawing.Size(50, 20);
            this.lblAddColor.TabIndex = 5;
            this.lblAddColor.Text = "Color:";
            // 
            // lblAddYear
            // 
            this.lblAddYear.AutoSize = true;
            this.lblAddYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddYear.Location = new System.Drawing.Point(6, 143);
            this.lblAddYear.Name = "lblAddYear";
            this.lblAddYear.Size = new System.Drawing.Size(47, 20);
            this.lblAddYear.TabIndex = 4;
            this.lblAddYear.Text = "Year:";
            // 
            // lblAddModel
            // 
            this.lblAddModel.AutoSize = true;
            this.lblAddModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddModel.Location = new System.Drawing.Point(6, 91);
            this.lblAddModel.Name = "lblAddModel";
            this.lblAddModel.Size = new System.Drawing.Size(56, 20);
            this.lblAddModel.TabIndex = 3;
            this.lblAddModel.Text = "Model:";
            // 
            // lblAddMake
            // 
            this.lblAddMake.AutoSize = true;
            this.lblAddMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMake.Location = new System.Drawing.Point(6, 66);
            this.lblAddMake.Name = "lblAddMake";
            this.lblAddMake.Size = new System.Drawing.Size(52, 20);
            this.lblAddMake.TabIndex = 2;
            this.lblAddMake.Text = "Make:";
            // 
            // lblAddCondition
            // 
            this.lblAddCondition.AutoSize = true;
            this.lblAddCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCondition.Location = new System.Drawing.Point(6, 41);
            this.lblAddCondition.Name = "lblAddCondition";
            this.lblAddCondition.Size = new System.Drawing.Size(80, 20);
            this.lblAddCondition.TabIndex = 1;
            this.lblAddCondition.Text = "Condition:";
            // 
            // lblAddType
            // 
            this.lblAddType.AutoSize = true;
            this.lblAddType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddType.Location = new System.Drawing.Point(6, 16);
            this.lblAddType.Name = "lblAddType";
            this.lblAddType.Size = new System.Drawing.Size(47, 20);
            this.lblAddType.TabIndex = 0;
            this.lblAddType.Text = "Type:";
            // 
            // boxAddStaff
            // 
            this.boxAddStaff.Controls.Add(this.txtAddLastName);
            this.boxAddStaff.Controls.Add(this.btnAddStaff);
            this.boxAddStaff.Controls.Add(this.txtAddPassword);
            this.boxAddStaff.Controls.Add(this.txtAddPosition);
            this.boxAddStaff.Controls.Add(this.txtAddFirstName);
            this.boxAddStaff.Controls.Add(this.lblAddPassword);
            this.boxAddStaff.Controls.Add(this.lblAddPosition);
            this.boxAddStaff.Controls.Add(this.lblAddLastName);
            this.boxAddStaff.Controls.Add(this.lblAddFirstName);
            this.boxAddStaff.Location = new System.Drawing.Point(306, 173);
            this.boxAddStaff.Name = "boxAddStaff";
            this.boxAddStaff.Size = new System.Drawing.Size(296, 165);
            this.boxAddStaff.TabIndex = 1;
            this.boxAddStaff.TabStop = false;
            this.boxAddStaff.Text = "Add Staff";
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.Location = new System.Drawing.Point(102, 41);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(186, 20);
            this.txtAddLastName.TabIndex = 19;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.Location = new System.Drawing.Point(204, 130);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(86, 29);
            this.btnAddStaff.TabIndex = 18;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.Location = new System.Drawing.Point(103, 91);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.PasswordChar = '*';
            this.txtAddPassword.Size = new System.Drawing.Size(186, 20);
            this.txtAddPassword.TabIndex = 17;
            // 
            // txtAddPosition
            // 
            this.txtAddPosition.Location = new System.Drawing.Point(103, 66);
            this.txtAddPosition.Name = "txtAddPosition";
            this.txtAddPosition.Size = new System.Drawing.Size(186, 20);
            this.txtAddPosition.TabIndex = 16;
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.Location = new System.Drawing.Point(103, 15);
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.Size = new System.Drawing.Size(185, 20);
            this.txtAddFirstName.TabIndex = 14;
            // 
            // lblAddPassword
            // 
            this.lblAddPassword.AutoSize = true;
            this.lblAddPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPassword.Location = new System.Drawing.Point(6, 91);
            this.lblAddPassword.Name = "lblAddPassword";
            this.lblAddPassword.Size = new System.Drawing.Size(82, 20);
            this.lblAddPassword.TabIndex = 13;
            this.lblAddPassword.Text = "Password:";
            // 
            // lblAddPosition
            // 
            this.lblAddPosition.AutoSize = true;
            this.lblAddPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPosition.Location = new System.Drawing.Point(6, 66);
            this.lblAddPosition.Name = "lblAddPosition";
            this.lblAddPosition.Size = new System.Drawing.Size(69, 20);
            this.lblAddPosition.TabIndex = 12;
            this.lblAddPosition.Text = "Position:";
            // 
            // lblAddLastName
            // 
            this.lblAddLastName.AutoSize = true;
            this.lblAddLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddLastName.Location = new System.Drawing.Point(6, 41);
            this.lblAddLastName.Name = "lblAddLastName";
            this.lblAddLastName.Size = new System.Drawing.Size(90, 20);
            this.lblAddLastName.TabIndex = 11;
            this.lblAddLastName.Text = "Last Name:";
            // 
            // lblAddFirstName
            // 
            this.lblAddFirstName.AutoSize = true;
            this.lblAddFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddFirstName.Location = new System.Drawing.Point(6, 16);
            this.lblAddFirstName.Name = "lblAddFirstName";
            this.lblAddFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblAddFirstName.TabIndex = 10;
            this.lblAddFirstName.Text = "First Name:";
            // 
            // boxRemoveStaff
            // 
            this.boxRemoveStaff.Controls.Add(this.txtRemoveUsername);
            this.boxRemoveStaff.Controls.Add(this.btnRemoveStaff);
            this.boxRemoveStaff.Controls.Add(this.txtRemoveID);
            this.boxRemoveStaff.Controls.Add(this.lblRemoveUsername);
            this.boxRemoveStaff.Controls.Add(this.lblRemoveID);
            this.boxRemoveStaff.Location = new System.Drawing.Point(608, 174);
            this.boxRemoveStaff.Name = "boxRemoveStaff";
            this.boxRemoveStaff.Size = new System.Drawing.Size(293, 165);
            this.boxRemoveStaff.TabIndex = 33;
            this.boxRemoveStaff.TabStop = false;
            this.boxRemoveStaff.Text = "Remove Staff";
            // 
            // txtRemoveUsername
            // 
            this.txtRemoveUsername.Location = new System.Drawing.Point(102, 41);
            this.txtRemoveUsername.Name = "txtRemoveUsername";
            this.txtRemoveUsername.Size = new System.Drawing.Size(185, 20);
            this.txtRemoveUsername.TabIndex = 19;
            // 
            // btnRemoveStaff
            // 
            this.btnRemoveStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStaff.Location = new System.Drawing.Point(171, 129);
            this.btnRemoveStaff.Name = "btnRemoveStaff";
            this.btnRemoveStaff.Size = new System.Drawing.Size(116, 29);
            this.btnRemoveStaff.TabIndex = 18;
            this.btnRemoveStaff.Text = "Remove Staff";
            this.btnRemoveStaff.UseVisualStyleBackColor = true;
            this.btnRemoveStaff.Click += new System.EventHandler(this.btnRemoveStaff_Click);
            // 
            // txtRemoveID
            // 
            this.txtRemoveID.Location = new System.Drawing.Point(103, 15);
            this.txtRemoveID.Name = "txtRemoveID";
            this.txtRemoveID.Size = new System.Drawing.Size(185, 20);
            this.txtRemoveID.TabIndex = 14;
            // 
            // lblRemoveUsername
            // 
            this.lblRemoveUsername.AutoSize = true;
            this.lblRemoveUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveUsername.Location = new System.Drawing.Point(6, 41);
            this.lblRemoveUsername.Name = "lblRemoveUsername";
            this.lblRemoveUsername.Size = new System.Drawing.Size(90, 20);
            this.lblRemoveUsername.TabIndex = 11;
            this.lblRemoveUsername.Text = "First Name:";
            // 
            // lblRemoveID
            // 
            this.lblRemoveID.AutoSize = true;
            this.lblRemoveID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoveID.Location = new System.Drawing.Point(6, 16);
            this.lblRemoveID.Name = "lblRemoveID";
            this.lblRemoveID.Size = new System.Drawing.Size(30, 20);
            this.lblRemoveID.TabIndex = 10;
            this.lblRemoveID.Text = "ID:";
            // 
            // boxProfit
            // 
            this.boxProfit.Controls.Add(this.lblProjectedTotalValue);
            this.boxProfit.Controls.Add(this.lblAnnualValue);
            this.boxProfit.Controls.Add(this.lblSemiAnnualValue);
            this.boxProfit.Controls.Add(this.lblMonthlyValue);
            this.boxProfit.Controls.Add(this.lblBiWeeklyValue);
            this.boxProfit.Controls.Add(this.lblProjectedTotal);
            this.boxProfit.Controls.Add(this.lblAnnual);
            this.boxProfit.Controls.Add(this.lblSemiAnnual);
            this.boxProfit.Controls.Add(this.lblMonthly);
            this.boxProfit.Controls.Add(this.lblBiWeekly);
            this.boxProfit.Location = new System.Drawing.Point(907, 174);
            this.boxProfit.Name = "boxProfit";
            this.boxProfit.Size = new System.Drawing.Size(377, 166);
            this.boxProfit.TabIndex = 35;
            this.boxProfit.TabStop = false;
            this.boxProfit.Text = "Profit";
            // 
            // lblProjectedTotalValue
            // 
            this.lblProjectedTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectedTotalValue.Location = new System.Drawing.Point(135, 124);
            this.lblProjectedTotalValue.Name = "lblProjectedTotalValue";
            this.lblProjectedTotalValue.Size = new System.Drawing.Size(236, 23);
            this.lblProjectedTotalValue.TabIndex = 29;
            // 
            // lblAnnualValue
            // 
            this.lblAnnualValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnualValue.Location = new System.Drawing.Point(135, 87);
            this.lblAnnualValue.Name = "lblAnnualValue";
            this.lblAnnualValue.Size = new System.Drawing.Size(236, 23);
            this.lblAnnualValue.TabIndex = 28;
            // 
            // lblSemiAnnualValue
            // 
            this.lblSemiAnnualValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemiAnnualValue.Location = new System.Drawing.Point(135, 65);
            this.lblSemiAnnualValue.Name = "lblSemiAnnualValue";
            this.lblSemiAnnualValue.Size = new System.Drawing.Size(236, 23);
            this.lblSemiAnnualValue.TabIndex = 27;
            // 
            // lblMonthlyValue
            // 
            this.lblMonthlyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyValue.Location = new System.Drawing.Point(135, 37);
            this.lblMonthlyValue.Name = "lblMonthlyValue";
            this.lblMonthlyValue.Size = new System.Drawing.Size(236, 23);
            this.lblMonthlyValue.TabIndex = 26;
            // 
            // lblBiWeeklyValue
            // 
            this.lblBiWeeklyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiWeeklyValue.Location = new System.Drawing.Point(135, 11);
            this.lblBiWeeklyValue.Name = "lblBiWeeklyValue";
            this.lblBiWeeklyValue.Size = new System.Drawing.Size(236, 23);
            this.lblBiWeeklyValue.TabIndex = 25;
            // 
            // lblProjectedTotal
            // 
            this.lblProjectedTotal.AutoSize = true;
            this.lblProjectedTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectedTotal.Location = new System.Drawing.Point(6, 128);
            this.lblProjectedTotal.Name = "lblProjectedTotal";
            this.lblProjectedTotal.Size = new System.Drawing.Size(119, 20);
            this.lblProjectedTotal.TabIndex = 24;
            this.lblProjectedTotal.Text = "Projected Total:";
            // 
            // lblAnnual
            // 
            this.lblAnnual.AutoSize = true;
            this.lblAnnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnual.Location = new System.Drawing.Point(6, 91);
            this.lblAnnual.Name = "lblAnnual";
            this.lblAnnual.Size = new System.Drawing.Size(63, 20);
            this.lblAnnual.TabIndex = 23;
            this.lblAnnual.Text = "Annual:";
            // 
            // lblSemiAnnual
            // 
            this.lblSemiAnnual.AutoSize = true;
            this.lblSemiAnnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemiAnnual.Location = new System.Drawing.Point(6, 66);
            this.lblSemiAnnual.Name = "lblSemiAnnual";
            this.lblSemiAnnual.Size = new System.Drawing.Size(104, 20);
            this.lblSemiAnnual.TabIndex = 22;
            this.lblSemiAnnual.Text = "Semi-Annual:";
            // 
            // lblMonthly
            // 
            this.lblMonthly.AutoSize = true;
            this.lblMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthly.Location = new System.Drawing.Point(6, 41);
            this.lblMonthly.Name = "lblMonthly";
            this.lblMonthly.Size = new System.Drawing.Size(68, 20);
            this.lblMonthly.TabIndex = 21;
            this.lblMonthly.Text = "Monthly:";
            // 
            // lblBiWeekly
            // 
            this.lblBiWeekly.AutoSize = true;
            this.lblBiWeekly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBiWeekly.Location = new System.Drawing.Point(6, 16);
            this.lblBiWeekly.Name = "lblBiWeekly";
            this.lblBiWeekly.Size = new System.Drawing.Size(83, 20);
            this.lblBiWeekly.TabIndex = 20;
            this.lblBiWeekly.Text = "Bi-Weekly:";
            // 
            // boxStaffSoldCars
            // 
            this.boxStaffSoldCars.Controls.Add(this.dgvStaffSoldCars);
            this.boxStaffSoldCars.Location = new System.Drawing.Point(306, 6);
            this.boxStaffSoldCars.Name = "boxStaffSoldCars";
            this.boxStaffSoldCars.Size = new System.Drawing.Size(978, 165);
            this.boxStaffSoldCars.TabIndex = 34;
            this.boxStaffSoldCars.TabStop = false;
            // 
            // dgvStaffSoldCars
            // 
            this.dgvStaffSoldCars.AllowUserToAddRows = false;
            this.dgvStaffSoldCars.AllowUserToDeleteRows = false;
            this.dgvStaffSoldCars.AllowUserToResizeColumns = false;
            this.dgvStaffSoldCars.AllowUserToResizeRows = false;
            this.dgvStaffSoldCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaffSoldCars.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStaffSoldCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffSoldCars.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStaffSoldCars.Location = new System.Drawing.Point(6, 16);
            this.dgvStaffSoldCars.Name = "dgvStaffSoldCars";
            this.dgvStaffSoldCars.Size = new System.Drawing.Size(966, 140);
            this.dgvStaffSoldCars.TabIndex = 0;
            // 
            // boxCarList
            // 
            this.boxCarList.Controls.Add(this.dgvCarsList);
            this.boxCarList.Controls.Add(this.cboColor);
            this.boxCarList.Controls.Add(this.cboCost);
            this.boxCarList.Controls.Add(this.cboBedLength);
            this.boxCarList.Controls.Add(this.cboRoofType);
            this.boxCarList.Controls.Add(this.cboDoors);
            this.boxCarList.Controls.Add(this.cboYear);
            this.boxCarList.Controls.Add(this.cboMileage);
            this.boxCarList.Controls.Add(this.cboModel);
            this.boxCarList.Controls.Add(this.cboMake);
            this.boxCarList.Controls.Add(this.cboCondition);
            this.boxCarList.Controls.Add(this.cboType);
            this.boxCarList.Location = new System.Drawing.Point(12, 388);
            this.boxCarList.Name = "boxCarList";
            this.boxCarList.Size = new System.Drawing.Size(1300, 256);
            this.boxCarList.TabIndex = 36;
            this.boxCarList.TabStop = false;
            this.boxCarList.Text = "Cars on Lot";
            // 
            // dgvCarsList
            // 
            this.dgvCarsList.AllowUserToAddRows = false;
            this.dgvCarsList.AllowUserToDeleteRows = false;
            this.dgvCarsList.AllowUserToResizeColumns = false;
            this.dgvCarsList.AllowUserToResizeRows = false;
            this.dgvCarsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCarsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarsList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCarsList.Location = new System.Drawing.Point(6, 46);
            this.dgvCarsList.Name = "dgvCarsList";
            this.dgvCarsList.Size = new System.Drawing.Size(1288, 204);
            this.dgvCarsList.TabIndex = 11;
            // 
            // cboColor
            // 
            this.cboColor.FormattingEnabled = true;
            this.cboColor.IntegralHeight = false;
            this.cboColor.Items.AddRange(new object[] {
            "All"});
            this.cboColor.Location = new System.Drawing.Point(710, 19);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(110, 21);
            this.cboColor.TabIndex = 6;
            this.cboColor.Text = "Color";
            this.cboColor.SelectedIndexChanged += new System.EventHandler(this.cboColor_SelectedIndexChanged);
            // 
            // cboCost
            // 
            this.cboCost.FormattingEnabled = true;
            this.cboCost.Items.AddRange(new object[] {
            "All",
            ">= 25000",
            "<= 25000",
            "<= 20000",
            "<= 15000",
            "<= 10000",
            "<= 5000"});
            this.cboCost.Location = new System.Drawing.Point(1174, 19);
            this.cboCost.Name = "cboCost";
            this.cboCost.Size = new System.Drawing.Size(110, 21);
            this.cboCost.TabIndex = 10;
            this.cboCost.Text = "Cost";
            this.cboCost.SelectedIndexChanged += new System.EventHandler(this.cboCost_SelectedIndexChanged);
            // 
            // cboBedLength
            // 
            this.cboBedLength.FormattingEnabled = true;
            this.cboBedLength.IntegralHeight = false;
            this.cboBedLength.Items.AddRange(new object[] {
            "All"});
            this.cboBedLength.Location = new System.Drawing.Point(1058, 19);
            this.cboBedLength.Name = "cboBedLength";
            this.cboBedLength.Size = new System.Drawing.Size(110, 21);
            this.cboBedLength.TabIndex = 9;
            this.cboBedLength.Text = "Bed Length";
            this.cboBedLength.SelectedIndexChanged += new System.EventHandler(this.cboBedLength_SelectedIndexChanged);
            // 
            // cboRoofType
            // 
            this.cboRoofType.FormattingEnabled = true;
            this.cboRoofType.Items.AddRange(new object[] {
            "All",
            "Hard",
            "Contractible",
            "Removable"});
            this.cboRoofType.Location = new System.Drawing.Point(942, 19);
            this.cboRoofType.Name = "cboRoofType";
            this.cboRoofType.Size = new System.Drawing.Size(110, 21);
            this.cboRoofType.TabIndex = 8;
            this.cboRoofType.Text = "Roof Type";
            this.cboRoofType.SelectedIndexChanged += new System.EventHandler(this.cboRoofType_SelectedIndexChanged);
            // 
            // cboDoors
            // 
            this.cboDoors.FormattingEnabled = true;
            this.cboDoors.Items.AddRange(new object[] {
            "All",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboDoors.Location = new System.Drawing.Point(826, 19);
            this.cboDoors.Name = "cboDoors";
            this.cboDoors.Size = new System.Drawing.Size(110, 21);
            this.cboDoors.TabIndex = 7;
            this.cboDoors.Text = "Doors";
            this.cboDoors.SelectedIndexChanged += new System.EventHandler(this.cboDoors_SelectedIndexChanged);
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "All",
            ">= 2010",
            "<= 2010",
            "<= 2000",
            "<= 1990",
            "<= 1980"});
            this.cboYear.Location = new System.Drawing.Point(594, 19);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(110, 21);
            this.cboYear.TabIndex = 5;
            this.cboYear.Text = "Year";
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // cboMileage
            // 
            this.cboMileage.FormattingEnabled = true;
            this.cboMileage.Items.AddRange(new object[] {
            "All",
            ">= 250000",
            "<= 250000",
            "<= 200000",
            "<= 150000",
            "<= 100000"});
            this.cboMileage.Location = new System.Drawing.Point(478, 19);
            this.cboMileage.Name = "cboMileage";
            this.cboMileage.Size = new System.Drawing.Size(110, 21);
            this.cboMileage.TabIndex = 4;
            this.cboMileage.Text = "Mileage";
            this.cboMileage.SelectedIndexChanged += new System.EventHandler(this.cboMileage_SelectedIndexChanged);
            // 
            // cboModel
            // 
            this.cboModel.FormattingEnabled = true;
            this.cboModel.IntegralHeight = false;
            this.cboModel.Items.AddRange(new object[] {
            "All"});
            this.cboModel.Location = new System.Drawing.Point(362, 19);
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size(110, 21);
            this.cboModel.TabIndex = 3;
            this.cboModel.Text = "Model";
            this.cboModel.SelectedIndexChanged += new System.EventHandler(this.cboModel_SelectedIndexChanged);
            // 
            // cboMake
            // 
            this.cboMake.FormattingEnabled = true;
            this.cboMake.IntegralHeight = false;
            this.cboMake.Items.AddRange(new object[] {
            "All"});
            this.cboMake.Location = new System.Drawing.Point(246, 19);
            this.cboMake.Name = "cboMake";
            this.cboMake.Size = new System.Drawing.Size(110, 21);
            this.cboMake.TabIndex = 2;
            this.cboMake.Text = "Make";
            this.cboMake.SelectedIndexChanged += new System.EventHandler(this.cboMake_SelectedIndexChanged);
            // 
            // cboCondition
            // 
            this.cboCondition.FormattingEnabled = true;
            this.cboCondition.IntegralHeight = false;
            this.cboCondition.Items.AddRange(new object[] {
            "All",
            "New",
            "Used"});
            this.cboCondition.Location = new System.Drawing.Point(130, 19);
            this.cboCondition.Name = "cboCondition";
            this.cboCondition.Size = new System.Drawing.Size(110, 21);
            this.cboCondition.TabIndex = 1;
            this.cboCondition.Text = "Condition";
            this.cboCondition.SelectedIndexChanged += new System.EventHandler(this.cboCondition_SelectedIndexChanged);
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "All",
            "Coupe",
            "Sedan",
            "Van",
            "Convertible",
            "Truck"});
            this.cboType.Location = new System.Drawing.Point(14, 19);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(110, 21);
            this.cboType.TabIndex = 0;
            this.cboType.Text = "Type";
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // tcCompany
            // 
            this.tcCompany.Controls.Add(this.tpCompany);
            this.tcCompany.Controls.Add(this.tpOwner);
            this.tcCompany.Location = new System.Drawing.Point(12, 12);
            this.tcCompany.Name = "tcCompany";
            this.tcCompany.SelectedIndex = 0;
            this.tcCompany.Size = new System.Drawing.Size(1300, 370);
            this.tcCompany.TabIndex = 37;
            // 
            // tpCompany
            // 
            this.tpCompany.Controls.Add(this.boxOnLotLongest);
            this.tpCompany.Controls.Add(this.btnLogOut);
            this.tpCompany.Controls.Add(this.boxEditInfo);
            this.tpCompany.Controls.Add(this.boxSellCar);
            this.tpCompany.Controls.Add(this.boxUserSoldCars);
            this.tpCompany.Location = new System.Drawing.Point(4, 22);
            this.tpCompany.Name = "tpCompany";
            this.tpCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tpCompany.Size = new System.Drawing.Size(1292, 344);
            this.tpCompany.TabIndex = 0;
            this.tpCompany.UseVisualStyleBackColor = true;
            // 
            // boxOnLotLongest
            // 
            this.boxOnLotLongest.Controls.Add(this.dgvOnLotLongest);
            this.boxOnLotLongest.Location = new System.Drawing.Point(599, 157);
            this.boxOnLotLongest.Name = "boxOnLotLongest";
            this.boxOnLotLongest.Size = new System.Drawing.Size(687, 145);
            this.boxOnLotLongest.TabIndex = 43;
            this.boxOnLotLongest.TabStop = false;
            this.boxOnLotLongest.Text = "On Lot Longest";
            // 
            // dgvOnLotLongest
            // 
            this.dgvOnLotLongest.AllowUserToAddRows = false;
            this.dgvOnLotLongest.AllowUserToDeleteRows = false;
            this.dgvOnLotLongest.AllowUserToResizeColumns = false;
            this.dgvOnLotLongest.AllowUserToResizeRows = false;
            this.dgvOnLotLongest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOnLotLongest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOnLotLongest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOnLotLongest.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOnLotLongest.Location = new System.Drawing.Point(6, 19);
            this.dgvOnLotLongest.Name = "dgvOnLotLongest";
            this.dgvOnLotLongest.Size = new System.Drawing.Size(675, 120);
            this.dgvOnLotLongest.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(6, 308);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(1280, 30);
            this.btnLogOut.TabIndex = 44;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // boxEditInfo
            // 
            this.boxEditInfo.Controls.Add(this.txtEditFirstName);
            this.boxEditInfo.Controls.Add(this.lblEditFirstName);
            this.boxEditInfo.Controls.Add(this.btnEditInfo);
            this.boxEditInfo.Controls.Add(this.txtEditPassword);
            this.boxEditInfo.Controls.Add(this.txtEditLastName);
            this.boxEditInfo.Controls.Add(this.lblEditPassword);
            this.boxEditInfo.Controls.Add(this.lblEditLastName);
            this.boxEditInfo.Location = new System.Drawing.Point(327, 6);
            this.boxEditInfo.Name = "boxEditInfo";
            this.boxEditInfo.Size = new System.Drawing.Size(266, 145);
            this.boxEditInfo.TabIndex = 39;
            this.boxEditInfo.TabStop = false;
            this.boxEditInfo.Text = "Edit Info";
            // 
            // txtEditFirstName
            // 
            this.txtEditFirstName.Location = new System.Drawing.Point(103, 15);
            this.txtEditFirstName.Name = "txtEditFirstName";
            this.txtEditFirstName.Size = new System.Drawing.Size(157, 20);
            this.txtEditFirstName.TabIndex = 14;
            // 
            // lblEditFirstName
            // 
            this.lblEditFirstName.AutoSize = true;
            this.lblEditFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditFirstName.Location = new System.Drawing.Point(6, 16);
            this.lblEditFirstName.Name = "lblEditFirstName";
            this.lblEditFirstName.Size = new System.Drawing.Size(86, 20);
            this.lblEditFirstName.TabIndex = 13;
            this.lblEditFirstName.Text = "First Name";
            // 
            // btnEditInfo
            // 
            this.btnEditInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditInfo.Location = new System.Drawing.Point(183, 108);
            this.btnEditInfo.Name = "btnEditInfo";
            this.btnEditInfo.Size = new System.Drawing.Size(77, 29);
            this.btnEditInfo.TabIndex = 12;
            this.btnEditInfo.Text = "Edit Info";
            this.btnEditInfo.UseVisualStyleBackColor = true;
            this.btnEditInfo.Click += new System.EventHandler(this.btnEditInfo_Click);
            // 
            // txtEditPassword
            // 
            this.txtEditPassword.Location = new System.Drawing.Point(103, 65);
            this.txtEditPassword.Name = "txtEditPassword";
            this.txtEditPassword.PasswordChar = '*';
            this.txtEditPassword.Size = new System.Drawing.Size(157, 20);
            this.txtEditPassword.TabIndex = 7;
            // 
            // txtEditLastName
            // 
            this.txtEditLastName.Location = new System.Drawing.Point(103, 40);
            this.txtEditLastName.Name = "txtEditLastName";
            this.txtEditLastName.Size = new System.Drawing.Size(157, 20);
            this.txtEditLastName.TabIndex = 6;
            // 
            // lblEditPassword
            // 
            this.lblEditPassword.AutoSize = true;
            this.lblEditPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditPassword.Location = new System.Drawing.Point(6, 66);
            this.lblEditPassword.Name = "lblEditPassword";
            this.lblEditPassword.Size = new System.Drawing.Size(78, 20);
            this.lblEditPassword.TabIndex = 1;
            this.lblEditPassword.Text = "Password";
            // 
            // lblEditLastName
            // 
            this.lblEditLastName.AutoSize = true;
            this.lblEditLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditLastName.Location = new System.Drawing.Point(6, 41);
            this.lblEditLastName.Name = "lblEditLastName";
            this.lblEditLastName.Size = new System.Drawing.Size(86, 20);
            this.lblEditLastName.TabIndex = 0;
            this.lblEditLastName.Text = "Last Name";
            // 
            // boxSellCar
            // 
            this.boxSellCar.Controls.Add(this.txtSoldToDriverLicense);
            this.boxSellCar.Controls.Add(this.txtSoldToState);
            this.boxSellCar.Controls.Add(this.lblSoldToDriverLicense);
            this.boxSellCar.Controls.Add(this.lblSoldToState);
            this.boxSellCar.Controls.Add(this.txtSoldToZip);
            this.boxSellCar.Controls.Add(this.lblSoldToZip);
            this.boxSellCar.Controls.Add(this.txtSoldToStreet);
            this.boxSellCar.Controls.Add(this.lblSoldToStreet);
            this.boxSellCar.Controls.Add(this.txtSoldToCity);
            this.boxSellCar.Controls.Add(this.lblSoldToCity);
            this.boxSellCar.Controls.Add(this.txtSoldToLastName);
            this.boxSellCar.Controls.Add(this.lblSoldToLastName);
            this.boxSellCar.Controls.Add(this.txtSoldToFirstName);
            this.boxSellCar.Controls.Add(this.lblSoldToFirstName);
            this.boxSellCar.Controls.Add(this.btnSellCar);
            this.boxSellCar.Controls.Add(this.txtSoldPrice);
            this.boxSellCar.Controls.Add(this.txtCarID);
            this.boxSellCar.Controls.Add(this.lblSoldPrice);
            this.boxSellCar.Controls.Add(this.lblCarID);
            this.boxSellCar.Location = new System.Drawing.Point(6, 6);
            this.boxSellCar.Name = "boxSellCar";
            this.boxSellCar.Size = new System.Drawing.Size(315, 296);
            this.boxSellCar.TabIndex = 38;
            this.boxSellCar.TabStop = false;
            this.boxSellCar.Text = "Sell Car";
            // 
            // txtSoldToDriverLicense
            // 
            this.txtSoldToDriverLicense.Location = new System.Drawing.Point(120, 223);
            this.txtSoldToDriverLicense.Name = "txtSoldToDriverLicense";
            this.txtSoldToDriverLicense.Size = new System.Drawing.Size(189, 20);
            this.txtSoldToDriverLicense.TabIndex = 46;
            // 
            // txtSoldToState
            // 
            this.txtSoldToState.Location = new System.Drawing.Point(120, 197);
            this.txtSoldToState.Name = "txtSoldToState";
            this.txtSoldToState.Size = new System.Drawing.Size(189, 20);
            this.txtSoldToState.TabIndex = 24;
            // 
            // lblSoldToDriverLicense
            // 
            this.lblSoldToDriverLicense.AutoSize = true;
            this.lblSoldToDriverLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldToDriverLicense.Location = new System.Drawing.Point(6, 224);
            this.lblSoldToDriverLicense.Name = "lblSoldToDriverLicense";
            this.lblSoldToDriverLicense.Size = new System.Drawing.Size(113, 20);
            this.lblSoldToDriverLicense.TabIndex = 45;
            this.lblSoldToDriverLicense.Text = "Driver License:";
            // 
            // lblSoldToState
            // 
            this.lblSoldToState.AutoSize = true;
            this.lblSoldToState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldToState.Location = new System.Drawing.Point(6, 198);
            this.lblSoldToState.Name = "lblSoldToState";
            this.lblSoldToState.Size = new System.Drawing.Size(52, 20);
            this.lblSoldToState.TabIndex = 23;
            this.lblSoldToState.Text = "State:";
            // 
            // txtSoldToZip
            // 
            this.txtSoldToZip.Location = new System.Drawing.Point(120, 171);
            this.txtSoldToZip.Name = "txtSoldToZip";
            this.txtSoldToZip.Size = new System.Drawing.Size(189, 20);
            this.txtSoldToZip.TabIndex = 22;
            // 
            // lblSoldToZip
            // 
            this.lblSoldToZip.AutoSize = true;
            this.lblSoldToZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldToZip.Location = new System.Drawing.Point(6, 172);
            this.lblSoldToZip.Name = "lblSoldToZip";
            this.lblSoldToZip.Size = new System.Drawing.Size(77, 20);
            this.lblSoldToZip.TabIndex = 21;
            this.lblSoldToZip.Text = "Zip Code:";
            // 
            // txtSoldToStreet
            // 
            this.txtSoldToStreet.Location = new System.Drawing.Point(120, 145);
            this.txtSoldToStreet.Name = "txtSoldToStreet";
            this.txtSoldToStreet.Size = new System.Drawing.Size(189, 20);
            this.txtSoldToStreet.TabIndex = 20;
            // 
            // lblSoldToStreet
            // 
            this.lblSoldToStreet.AutoSize = true;
            this.lblSoldToStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldToStreet.Location = new System.Drawing.Point(6, 146);
            this.lblSoldToStreet.Name = "lblSoldToStreet";
            this.lblSoldToStreet.Size = new System.Drawing.Size(57, 20);
            this.lblSoldToStreet.TabIndex = 19;
            this.lblSoldToStreet.Text = "Street:";
            // 
            // txtSoldToCity
            // 
            this.txtSoldToCity.Location = new System.Drawing.Point(120, 119);
            this.txtSoldToCity.Name = "txtSoldToCity";
            this.txtSoldToCity.Size = new System.Drawing.Size(189, 20);
            this.txtSoldToCity.TabIndex = 18;
            // 
            // lblSoldToCity
            // 
            this.lblSoldToCity.AutoSize = true;
            this.lblSoldToCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldToCity.Location = new System.Drawing.Point(6, 120);
            this.lblSoldToCity.Name = "lblSoldToCity";
            this.lblSoldToCity.Size = new System.Drawing.Size(39, 20);
            this.lblSoldToCity.TabIndex = 17;
            this.lblSoldToCity.Text = "City:";
            // 
            // txtSoldToLastName
            // 
            this.txtSoldToLastName.Location = new System.Drawing.Point(120, 92);
            this.txtSoldToLastName.Name = "txtSoldToLastName";
            this.txtSoldToLastName.Size = new System.Drawing.Size(189, 20);
            this.txtSoldToLastName.TabIndex = 16;
            // 
            // lblSoldToLastName
            // 
            this.lblSoldToLastName.AutoSize = true;
            this.lblSoldToLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldToLastName.Location = new System.Drawing.Point(6, 93);
            this.lblSoldToLastName.Name = "lblSoldToLastName";
            this.lblSoldToLastName.Size = new System.Drawing.Size(90, 20);
            this.lblSoldToLastName.TabIndex = 15;
            this.lblSoldToLastName.Text = "Last Name:";
            // 
            // txtSoldToFirstName
            // 
            this.txtSoldToFirstName.Location = new System.Drawing.Point(120, 66);
            this.txtSoldToFirstName.Name = "txtSoldToFirstName";
            this.txtSoldToFirstName.Size = new System.Drawing.Size(189, 20);
            this.txtSoldToFirstName.TabIndex = 14;
            // 
            // lblSoldToFirstName
            // 
            this.lblSoldToFirstName.AutoSize = true;
            this.lblSoldToFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldToFirstName.Location = new System.Drawing.Point(6, 67);
            this.lblSoldToFirstName.Name = "lblSoldToFirstName";
            this.lblSoldToFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblSoldToFirstName.TabIndex = 13;
            this.lblSoldToFirstName.Text = "First Name:";
            // 
            // btnSellCar
            // 
            this.btnSellCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellCar.Location = new System.Drawing.Point(232, 259);
            this.btnSellCar.Name = "btnSellCar";
            this.btnSellCar.Size = new System.Drawing.Size(77, 29);
            this.btnSellCar.TabIndex = 12;
            this.btnSellCar.Text = "Sell Car";
            this.btnSellCar.UseVisualStyleBackColor = true;
            this.btnSellCar.Click += new System.EventHandler(this.btnSellCar_Click);
            // 
            // txtSoldPrice
            // 
            this.txtSoldPrice.Location = new System.Drawing.Point(120, 40);
            this.txtSoldPrice.Name = "txtSoldPrice";
            this.txtSoldPrice.Size = new System.Drawing.Size(189, 20);
            this.txtSoldPrice.TabIndex = 7;
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(120, 15);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(189, 20);
            this.txtCarID.TabIndex = 6;
            // 
            // lblSoldPrice
            // 
            this.lblSoldPrice.AutoSize = true;
            this.lblSoldPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldPrice.Location = new System.Drawing.Point(6, 41);
            this.lblSoldPrice.Name = "lblSoldPrice";
            this.lblSoldPrice.Size = new System.Drawing.Size(84, 20);
            this.lblSoldPrice.TabIndex = 1;
            this.lblSoldPrice.Text = "Sold Price:";
            // 
            // lblCarID
            // 
            this.lblCarID.AutoSize = true;
            this.lblCarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarID.Location = new System.Drawing.Point(6, 16);
            this.lblCarID.Name = "lblCarID";
            this.lblCarID.Size = new System.Drawing.Size(59, 20);
            this.lblCarID.TabIndex = 0;
            this.lblCarID.Text = "Car ID:";
            // 
            // boxUserSoldCars
            // 
            this.boxUserSoldCars.Controls.Add(this.dgvUserSoldCars);
            this.boxUserSoldCars.Location = new System.Drawing.Point(599, 6);
            this.boxUserSoldCars.Name = "boxUserSoldCars";
            this.boxUserSoldCars.Size = new System.Drawing.Size(687, 145);
            this.boxUserSoldCars.TabIndex = 42;
            this.boxUserSoldCars.TabStop = false;
            this.boxUserSoldCars.Text = "Sold Cars";
            // 
            // dgvUserSoldCars
            // 
            this.dgvUserSoldCars.AllowUserToAddRows = false;
            this.dgvUserSoldCars.AllowUserToDeleteRows = false;
            this.dgvUserSoldCars.AllowUserToResizeColumns = false;
            this.dgvUserSoldCars.AllowUserToResizeRows = false;
            this.dgvUserSoldCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserSoldCars.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUserSoldCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserSoldCars.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvUserSoldCars.Location = new System.Drawing.Point(6, 19);
            this.dgvUserSoldCars.Name = "dgvUserSoldCars";
            this.dgvUserSoldCars.Size = new System.Drawing.Size(675, 120);
            this.dgvUserSoldCars.TabIndex = 0;
            // 
            // tpOwner
            // 
            this.tpOwner.Controls.Add(this.boxProfit);
            this.tpOwner.Controls.Add(this.boxAddCar);
            this.tpOwner.Controls.Add(this.boxRemoveStaff);
            this.tpOwner.Controls.Add(this.boxStaffSoldCars);
            this.tpOwner.Controls.Add(this.boxAddStaff);
            this.tpOwner.Location = new System.Drawing.Point(4, 22);
            this.tpOwner.Name = "tpOwner";
            this.tpOwner.Padding = new System.Windows.Forms.Padding(3);
            this.tpOwner.Size = new System.Drawing.Size(1292, 344);
            this.tpOwner.TabIndex = 1;
            this.tpOwner.Text = "Owner";
            this.tpOwner.UseVisualStyleBackColor = true;
            // 
            // JacobsCarDealership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 656);
            this.Controls.Add(this.tcCompany);
            this.Controls.Add(this.boxCarList);
            this.Name = "JacobsCarDealership";
            this.Text = "Jacob\'s Car Dealership";
            this.Load += new System.EventHandler(this.JacobsCarDealership_Load);
            this.boxAddCar.ResumeLayout(false);
            this.boxAddCar.PerformLayout();
            this.boxAddStaff.ResumeLayout(false);
            this.boxAddStaff.PerformLayout();
            this.boxRemoveStaff.ResumeLayout(false);
            this.boxRemoveStaff.PerformLayout();
            this.boxProfit.ResumeLayout(false);
            this.boxProfit.PerformLayout();
            this.boxStaffSoldCars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffSoldCars)).EndInit();
            this.boxCarList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarsList)).EndInit();
            this.tcCompany.ResumeLayout(false);
            this.tpCompany.ResumeLayout(false);
            this.boxOnLotLongest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOnLotLongest)).EndInit();
            this.boxEditInfo.ResumeLayout(false);
            this.boxEditInfo.PerformLayout();
            this.boxSellCar.ResumeLayout(false);
            this.boxSellCar.PerformLayout();
            this.boxUserSoldCars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserSoldCars)).EndInit();
            this.tpOwner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox boxAddCar;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Label lblAddCondition;
        private System.Windows.Forms.Label lblAddType;
        private System.Windows.Forms.GroupBox boxAddStaff;
        private System.Windows.Forms.TextBox txtAddLastName;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.TextBox txtAddPosition;
        private System.Windows.Forms.TextBox txtAddFirstName;
        private System.Windows.Forms.Label lblAddPassword;
        private System.Windows.Forms.Label lblAddPosition;
        private System.Windows.Forms.Label lblAddLastName;
        private System.Windows.Forms.Label lblAddFirstName;
        private System.Windows.Forms.GroupBox boxRemoveStaff;
        private System.Windows.Forms.TextBox txtRemoveUsername;
        private System.Windows.Forms.Button btnRemoveStaff;
        private System.Windows.Forms.TextBox txtRemoveID;
        private System.Windows.Forms.Label lblRemoveUsername;
        private System.Windows.Forms.Label lblRemoveID;
        private System.Windows.Forms.GroupBox boxProfit;
        private System.Windows.Forms.GroupBox boxStaffSoldCars;
        private System.Windows.Forms.GroupBox boxCarList;
        private System.Windows.Forms.DataGridView dgvStaffSoldCars;
        private System.Windows.Forms.Label lblProjectedTotalValue;
        private System.Windows.Forms.Label lblAnnualValue;
        private System.Windows.Forms.Label lblSemiAnnualValue;
        private System.Windows.Forms.Label lblMonthlyValue;
        private System.Windows.Forms.Label lblBiWeeklyValue;
        private System.Windows.Forms.Label lblProjectedTotal;
        private System.Windows.Forms.Label lblAnnual;
        private System.Windows.Forms.Label lblSemiAnnual;
        private System.Windows.Forms.Label lblMonthly;
        private System.Windows.Forms.Label lblBiWeekly;
        private System.Windows.Forms.TabControl tcCompany;
        private System.Windows.Forms.TabPage tpCompany;
        private System.Windows.Forms.TabPage tpOwner;
        private System.Windows.Forms.ComboBox cboRoofType;
        private System.Windows.Forms.ComboBox cboDoors;
        private System.Windows.Forms.ComboBox cboCondition;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.ComboBox cboCost;
        private System.Windows.Forms.ComboBox cboBedLength;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.ComboBox cboMileage;
        private System.Windows.Forms.ComboBox cboModel;
        private System.Windows.Forms.ComboBox cboMake;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.DataGridView dgvCarsList;
        private System.Windows.Forms.GroupBox boxSellCar;
        private System.Windows.Forms.Button btnSellCar;
        private System.Windows.Forms.TextBox txtSoldPrice;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.Label lblSoldPrice;
        private System.Windows.Forms.Label lblCarID;
        private System.Windows.Forms.GroupBox boxUserSoldCars;
        private System.Windows.Forms.DataGridView dgvUserSoldCars;
        private System.Windows.Forms.TextBox txtAddMileage;
        private System.Windows.Forms.Label lblAddMileage;
        private System.Windows.Forms.TextBox txtAddCost;
        private System.Windows.Forms.Label lblAddCost;
        private System.Windows.Forms.TextBox txtAddBedLength;
        private System.Windows.Forms.Label lblAddBedLength;
        private System.Windows.Forms.Label lblAddRoofType;
        private System.Windows.Forms.Label lblAddDoors;
        private System.Windows.Forms.TextBox txtAddColor;
        private System.Windows.Forms.TextBox txtAddYear;
        private System.Windows.Forms.TextBox txtAddModel;
        private System.Windows.Forms.TextBox txtAddMake;
        private System.Windows.Forms.Label lblAddColor;
        private System.Windows.Forms.Label lblAddYear;
        private System.Windows.Forms.Label lblAddModel;
        private System.Windows.Forms.Label lblAddMake;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.GroupBox boxEditInfo;
        private System.Windows.Forms.Button btnEditInfo;
        private System.Windows.Forms.TextBox txtEditPassword;
        private System.Windows.Forms.TextBox txtEditLastName;
        private System.Windows.Forms.Label lblEditPassword;
        private System.Windows.Forms.Label lblEditLastName;
        private System.Windows.Forms.TextBox txtSoldToDriverLicense;
        private System.Windows.Forms.TextBox txtSoldToState;
        private System.Windows.Forms.Label lblSoldToDriverLicense;
        private System.Windows.Forms.Label lblSoldToState;
        private System.Windows.Forms.TextBox txtSoldToZip;
        private System.Windows.Forms.Label lblSoldToZip;
        private System.Windows.Forms.TextBox txtSoldToStreet;
        private System.Windows.Forms.Label lblSoldToStreet;
        private System.Windows.Forms.TextBox txtSoldToCity;
        private System.Windows.Forms.Label lblSoldToCity;
        private System.Windows.Forms.TextBox txtSoldToLastName;
        private System.Windows.Forms.Label lblSoldToLastName;
        private System.Windows.Forms.TextBox txtSoldToFirstName;
        private System.Windows.Forms.Label lblSoldToFirstName;
        private System.Windows.Forms.GroupBox boxOnLotLongest;
        private System.Windows.Forms.DataGridView dgvOnLotLongest;
        private TextBox txtEditFirstName;
        private Label lblEditFirstName;
        private ComboBox cboAddRoofType;
        private ComboBox cboAddDoors;
        private ComboBox cboAddCondition;
        private ComboBox cboAddType;
    }
}