using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace JacobsCarDealership
{
    public partial class JacobsCarDealership : Form
    {
        #region Set variables
        private DB db = new DB();
        private DataTable result;

        private string cars = "cars";
        private string sold = "sold";
        private string staff = "staff";

        private string[] fields;
        private string[] where;
        private string[] parameters;
        private string[] values;
        private string value;

        private string username = null;
        private string salt = null;
        private string password = null;
        #endregion

        public JacobsCarDealership()
        {
            InitializeComponent();
            CenterToScreen();
        }

        //Method to check if any field is empty
        private bool emptyFields(GroupBox box)
        {
            bool emptyFields = true;
            int numberEmptyFields = 0;

            //Loop through the controls in the given group box
            foreach (Control control in box.Controls)
            {
                //Check if it is a text box
                if(control is TextBox)
                {
                    TextBox textBox = control as TextBox;
                    //If the text box is empty or null add to number of empty fields
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        if (textBox.Name == txtAddBedLength.Name)
                        {
                            continue;
                        }
                        else
                        {
                            numberEmptyFields += 1;
                        }
                    }
                }

                //Check if it is a combo box
                if (control is ComboBox)
                {
                    ComboBox comboBox = control as ComboBox;
                    //If the combo box is empty or null add to number of empty fields
                    if (string.IsNullOrEmpty(comboBox.Text))
                    {
                        numberEmptyFields += 1;
                    }
                }
            }

            //Check if umber of empty fields is greater than 0
            //If so set empty fields to true and return it
            if (numberEmptyFields > 0)
            {
                emptyFields = true;
            }
            else
            {
                emptyFields = false;
            }

            return emptyFields;
        }

        //Method to set all fields to empty
        private void resetFields(GroupBox box)
        {
            //Loop through the controls in the given group box
            foreach (Control control in box.Controls)
            {
                //Check if it is a text box
                if (control is TextBox)
                {
                    TextBox textBox = control as TextBox;
                    textBox.Text = string.Empty;
                    
                }

                //Check if it is a combo box
                if (control is ComboBox)
                {
                    ComboBox comboBox = control as ComboBox;
                    comboBox.Text = string.Empty;
                }
            }
        }

        //Method to get all cars on the lot
        //Can add a parameter
        private string getCars(string add = null)
        {
            //Set query string
            string query = "SELECT * FROM [cars] WHERE [sold] = false";
            //If add not null
            if (add != null)
            {
                query += String.Format(" {0}", add);
            }
            return query;
        }

        //Method to load the cars in the data grid view
        private void loadCars(DataTable table)
        {
            dgvCarsList.DataSource = table;
            dgvCarsList.Columns["sold"].Visible = false;
        }

        //Method to load cars in the staff sold cars data grid view
        private void loadStaffSoldCars()
        {
            #region Load All Cars Sold for Owner
            //Set the command text to query DB with
            using (result = db.query(sold, "SELECT * FROM [sold]"))
            {
                if (result.Rows.Count >= 1)
                {
                    boxStaffSoldCars.Text = "Staff Sold Cars";

                    dgvStaffSoldCars.DataSource = result;
                    
                }
                else
                {
                    boxStaffSoldCars.Text = "Nobody is Selling Cars!";
                }
            }
            #endregion
        }

        //Method to load cars in the user sold cars data grid view
        //Hiding non important fields
        private void loadUserSoldCars()
        {
            #region Load All Cars Sold by User
            //Set the command text to query DB with
            using (result = db.query(sold, "SELECT * FROM [sold] WHERE [soldBy] = @1", values = new string[1] { User.ID.ToString() }))
            {
                if (result.Rows.Count >= 1)
                {
                    boxUserSoldCars.Text = String.Format("{0} {1} Sold Cars", User.FirstName, User.LastName);

                    dgvUserSoldCars.DataSource = result;
                    dgvUserSoldCars.Columns["id"].Visible = false;
                    dgvUserSoldCars.Columns["soldToFirstName"].Visible = false;
                    dgvUserSoldCars.Columns["soldToLastName"].Visible = false;
                    dgvUserSoldCars.Columns["soldToCity"].Visible = false;
                    dgvUserSoldCars.Columns["soldToStreet"].Visible = false;
                    dgvUserSoldCars.Columns["soldToZip"].Visible = false;
                    dgvUserSoldCars.Columns["soldToState"].Visible = false;
                    dgvUserSoldCars.Columns["soldToDriverLicense"].Visible = false;
                    dgvUserSoldCars.Columns["soldBy"].Visible = false;
                }
                else
                {
                    boxUserSoldCars.Text = "You have not sold any cars!";
                }
            }
            #endregion
        }

        //Method to load cars in on lot longest data grid view
        //Hiding non important fields
        private void loadOnLotLongestCars()
        {
            #region Load Cars on Lot Longest
            //Set the command text to query DB with
            using (result = db.query(cars, "SELECT TOP 10 * FROM [cars] WHERE [sold] = false AND [added] <= @1 ORDER BY [added] DESC", values = new string[1] { String.Format("{0}", DateTime.Today.ToString()) }))
            {
                if (result.Rows.Count >= 1)
                {
                    dgvOnLotLongest.DataSource = result;
                    dgvOnLotLongest.Columns["type"].Visible = false;
                    dgvOnLotLongest.Columns["condition"].Visible = false;
                    dgvOnLotLongest.Columns["mileage"].Visible = false;
                    dgvOnLotLongest.Columns["year"].Visible = false;
                    dgvOnLotLongest.Columns["color"].Visible = false;
                    dgvOnLotLongest.Columns["doors"].Visible = false;
                    dgvOnLotLongest.Columns["roofType"].Visible = false;
                    dgvOnLotLongest.Columns["bedLength"].Visible = false;
                    dgvOnLotLongest.Columns["sold"].Visible = false;
                }
            }
            #endregion
        }

        //Method to load the bi-weekly text with the bi-weekly sum
        private void loadBiWeekly()
        {
            using(result = db.query(sold, "SELECT [soldPrice] FROM [sold] WHERE [soldDate] <= @1 AND [soldDate] >= @2", values = new string[2] { DateTime.Today.ToString(), DateTime.Today.AddDays(-7).ToString()}))
            {
                decimal value = default(decimal);
                if(result.Rows.Count >= 1)
                {
                    foreach(DataRow row in result.Rows)
                    {
                        value += (decimal)row["soldPrice"];
                    }

                    lblBiWeeklyValue.Text = value.ToString("c");
                }
            }
        }

        //Method to load the monthly text with the monthly sum
        private void loadMonthly()
        {
            using (result = db.query(sold, "SELECT [soldPrice] FROM [sold] WHERE [soldDate] <= @1 AND [soldDate] >= @2", values = new string[2] { DateTime.Today.ToString(), DateTime.Today.AddMonths(-1).ToString() }))
            {
                decimal value = default(decimal);
                if (result.Rows.Count >= 1)
                {
                    foreach (DataRow row in result.Rows)
                    {
                        value += (decimal)row["soldPrice"];
                    }

                   lblMonthlyValue.Text = value.ToString("c");
                }
            }
        }

        //Method to load the semi-annual text with the semi-annual sum
        private void loadSemiAnnual()
        {
            using (result = db.query(sold, "SELECT [soldPrice] FROM [sold] WHERE [soldDate] <= @1 AND [soldDate] >= @2", values = new string[2] { DateTime.Today.ToString(), DateTime.Today.AddMonths(-6).ToString() }))
            {
                decimal value = default(decimal);
                if (result.Rows.Count >= 1)
                {
                    foreach (DataRow row in result.Rows)
                    {
                        value += (decimal)row["soldPrice"];
                    }

                    lblSemiAnnualValue.Text = value.ToString("c");
                }
            }
        }

        //Method to load the annual text with the annual sum
        private void loadAnnual()
        {
            using (result = db.query(sold, "SELECT [soldPrice] FROM [sold] WHERE [soldDate] <= @1 AND [soldDate] >= @2", values = new string[2] { DateTime.Today.ToString(), DateTime.Today.AddYears(-1).ToString() }))
            {
                decimal value = default(decimal);
                if (result.Rows.Count >= 1)
                {
                    foreach (DataRow row in result.Rows)
                    {
                        value += (decimal)row["soldPrice"];
                    }

                    lblAnnualValue.Text = value.ToString("c");
                }
            }
        }

        //Method to load the projected total text with the projected total sum
        private void loadProjectedTotal()
        {
            using (result = db.query(cars, "SELECT [cost] FROM [cars] WHERE [sold] = false"))
            {
                decimal value = default(decimal);
                if (result.Rows.Count >= 1)
                {
                    foreach (DataRow row in result.Rows)
                    {
                        value += (decimal)row["cost"];
                    }

                    lblProjectedTotalValue.Text = value.ToString("c");
                }
            }
        }

        //Method to load everything so we do not have to keep write all that code
        private void loadAll()
        {
            if (User.Position == "Owner")
            {
                loadStaffSoldCars();

                loadBiWeekly();
                loadMonthly();
                loadSemiAnnual();
                loadAnnual();
                loadProjectedTotal();
            }

            loadUserSoldCars();

            loadOnLotLongestCars();

            using (result = db.query(cars, getCars()))
            {
                loadCars(result);
            }
        }

        //Method to reset user first name and last name on edit info
        private void reSetUserInfo()
        {
            using(result = db.select(staff, where = new string[3] { "id", "=", "@id" }, value = User.ID.ToString()))
            {
                if(result.Rows.Count == 1)
                {
                    foreach (DataRow row in result.Rows)
                    {
                        User.FirstName = (string)row["firstName"];
                        User.LastName = (string)row["lastName"];
                    }

                    tpCompany.Text = String.Format("{0} {1}", User.FirstName, User.LastName);
                }
            }
        }

        //Method to edit all non empty fields in edit info
        private void editFields(GroupBox box, string table)
        {
            //Loop through the controls in the given group box 
            //Counting all non empty fields
            int number = 0;
            foreach (Control control in box.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = control as TextBox;
                    if (!string.IsNullOrEmpty(textBox.Text))
                    {
                        //Adding an extra if it is password (will add salt)
                        if (textBox.Name == txtEditPassword.Name)
                        {
                            number++;
                        }
                        number++;
                    }
                }
            }

            number++;

            //Set the arrays for the update method
            fields = new string[number];
            parameters = new string[number];
            values = new string[number];

            //Loop through the controls in the given group box 
            //Setting fields, parameters, and values based on the name
            int i = 0;
            foreach (Control control in box.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = control as TextBox;
                    if (!string.IsNullOrEmpty(textBox.Text))
                    {
                        if (textBox.Name == txtEditFirstName.Name)
                        {
                            fields[i] = "firstName";

                            parameters[i] = String.Format("@{0}", i);

                            values[i] = txtEditFirstName.Text;

                            i++;
                        }
                        else if (textBox.Name == txtEditLastName.Name)
                        {
                            fields[i] = "lastName";

                            parameters[i] = String.Format("@{0}", i);

                            values[i] = txtEditLastName.Text;

                            i++;
                        }
                        else if (textBox.Name == txtEditPassword.Name)
                        {
                            salt = Encrypt.createSalt();
                            password = Encrypt.generateSHA256Hash(txtEditPassword.Text, salt);

                            fields[i] = "salt";
                            fields[i + 1] = "password";

                            parameters[i] = String.Format("@{0}", i);
                            parameters[i + 1] = String.Format("@{0}", i + 1);

                            values[i] = salt;
                            values[i + 1] = password;

                            i++;
                        }
                    }
                }
            }

            //Setting the final fields, parameters, and values
            fields[i] = "id";

            parameters[i] = String.Format("@{0}", i);

            values[i] = User.ID.ToString();

            //Updating the info
            db.update(table, fields, parameters, values);

            //Reset the info
            reSetUserInfo();
        }

        private void JacobsCarDealership_Load(object sender, EventArgs e)
        {
            //Setting the default values of the form
            tpCompany.Text = String.Format("{0} {1}", User.FirstName, User.LastName);
            tcCompany.TabPages.Remove(tpOwner);
            //If user is the owner setting his tab
            if (User.Position == "Owner")
            {
                tcCompany.TabPages.Add(tpOwner);
            }

            loadAll();
        }

        private void btnSellCar_Click(object sender, EventArgs e)
        {
            //If no empty fields in sell car
            if (emptyFields(boxSellCar) == false)
            {
                //Set the query
                using (result = db.query(cars, "SELECT * FROM [cars] WHERE [id] = @1", values = new string[1] { txtCarID.Text }))
                {
                    //Find the cost of the car
                    string cost = "";
                    foreach (DataRow row in result.Rows)
                    {
                        cost = row["cost"].ToString();
                    }

                    //Insert the data into the sold db
                    db.insert(sold,
                    fields = new string[12] { "carID", "carPrice", "soldPrice", "soldToFirstName", "soldToLastName", "soldToCity", "soldToStreet", "soldToZip", "soldToState", "soldToDriverLicense", "soldBy", "soldDate" },
                    parameters = new string[12] { "@1", "@2", "@3", "@4", "@5", "@6", "@7", "@8", "@9", "@10", "@11", "@12" },
                    values = new string[12] { txtCarID.Text, cost, txtSoldPrice.Text, txtSoldToFirstName.Text, txtSoldToLastName.Text, txtSoldToCity.Text, txtSoldToStreet.Text, txtSoldToZip.Text, txtSoldToState.Text, txtSoldToDriverLicense.Text, User.ID.ToString(), DateTime.Today.ToString("MM/dd/yyyy") });

                    //Update the car in cars db to sold
                    db.update(cars, fields = new string[2] { "sold", "id" }, parameters = new string[2] { "@1", "@2" }, values = new string[2] { true.ToString(), txtCarID.Text });

                    //Reload the form
                    loadAll();
                }

                //Set all fields to empty
                resetFields(boxSellCar);
            }
            else
            {
                MessageBox.Show("All fields are required to sell a car!", "Error: Empty Fields");
            }
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            //Check to make sure at least one field is not empty
            if (!string.IsNullOrEmpty(txtEditFirstName.Text) || !string.IsNullOrEmpty(txtEditLastName.Text) || !string.IsNullOrEmpty(txtEditPassword.Text))
            {
                editFields(boxEditInfo, staff);

                //Set all fields to empty
                resetFields(boxEditInfo);
            }
            else
            {
                MessageBox.Show("At least one field is required to edit your info!", "Error: Empty Fields");
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //Set objects to null
            User.ID = default(Int32);
            User.FirstName = null;
            User.LastName = null;
            User.Username = null;
            User.Position = null;
            
            //Set parent form's visible to true
            this.Visible = false;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            //Make sure the user is Owner
            if (User.Position == "Owner")
            {
                //If no empty fields in add car
                if (emptyFields(boxAddCar) == false)
                {
                    //Set the car objects
                    Car car = new Car(cboAddType.Text);
                    car.Condition = cboAddCondition.Text;
                    car.Make = txtAddMake.Text;
                    car.Model = txtAddModel.Text;
                    car.Year = txtAddYear.Text;
                    car.Mileage = Convert.ToInt32(txtAddMileage.Text);
                    car.Color = txtAddColor.Text;
                    car.Doors = Convert.ToInt32(cboAddDoors.Text);
                    car.RoofType = cboAddRoofType.Text;
                    car.BedLength = string.IsNullOrEmpty(txtAddBedLength.Text) ? (double?)null : Convert.ToDouble(txtAddBedLength.Text);
                    car.Cost = Convert.ToDecimal(txtAddCost.Text);

                    //Insert the car
                    db.insert(cars,
                    fields = new string[12] { "type", "condition", "make", "model", "mileage", "year", "color", "doors", "roofType", "bedLength", "cost", "added" },
                    parameters = new string[12] { "@1", "@2", "@3", "@4", "@5", "@6", "@7", "@8", "@9", "@10", "@11", "@12" },
                    values = new string[12] { car.Type, car.Condition, car.Make, car.Model, car.Mileage.ToString(), car.Year, car.Color, car.Doors.ToString(), car.RoofType, car.BedLength.ToString(), car.Cost.ToString(), DateTime.Today.ToString("MM/dd/yyyy") });

                    //Reload the form
                    loadAll();

                    //Set all fields to empty
                    resetFields(boxAddCar);
                }
                else
                {
                    MessageBox.Show("All fields are required to add a car!", "Error: Empty Fields");
                }
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            //Make sure the user is Owner
            if (User.Position == "Owner")
            {
                //If no empty fields in add staff
                if (emptyFields(boxAddStaff) == false)
                {
                    using (result = db.query(staff, "SELECT * FROM [staff]"))
                    {
                        bool end = false;
                        int i = 1;
                        //Find a username
                        //Loop until we get end = true
                        while (end == false)
                        {
                            DataTable check;
                            //Set the username
                            username = txtAddFirstName.Text.Substring(0, 3) + txtAddLastName.Text.Substring(0, 3) + i;

                            //Check if the username already exists
                            using (check = db.select(staff, where = new string[3] { "username", "=", "@username" }, value = username))
                            {
                                if (check.Rows.Count >= 1)
                                {
                                    end = false;
                                    i++;
                                }
                                else
                                {
                                    end = true;
                                }
                            }
                        }
                    }

                    //Set the salt and password
                    salt = Encrypt.createSalt();
                    password = Encrypt.generateSHA256Hash(txtAddPassword.Text, salt);

                    //Insert the staff
                    db.insert(staff,
                    fields = new string[7] { "firstName", "lastName", "username", "position", "salt", "password", "hired" },
                    parameters = new string[7] { "@1", "@2", "@3", "@4", "@5", "@6", "@7" },
                    values = new string[7] { txtAddFirstName.Text, txtAddLastName.Text, username, txtAddPosition.Text, salt, password, DateTime.Today.ToString("MM/dd/yyyy") });

                    //Reload the form
                    loadAll();

                    //Set all fields to empty
                    resetFields(boxAddStaff);
                }
                else
                {
                    MessageBox.Show("All fields are required to add staff!", "Error: Empty Fields");
                }
            }
        }

        private void btnRemoveStaff_Click(object sender, EventArgs e)
        {
            //Make sure the user is Owner
            if (User.Position == "Owner")
            {
                //If no empty fields in remove staff
                if (emptyFields(boxRemoveStaff) == false)
                {
                    //Remove the staff
                    db.query(staff, "DELETE from [staff] WHERE [id] = @1 AND [username] = @2", values = new string[2] { txtRemoveID.Text, txtRemoveUsername.Text });

                    //Reload the form
                    loadAll();

                    //Set all fields to empty
                    resetFields(boxRemoveStaff);
                }
                else
                {
                    MessageBox.Show("All fields are required to remove staff!", "Error: Empty Fields");
                }
            }
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex == -1)
            {
            }
            else if (cboType.Text == "All" || cboType.Text == "all")
            {
                using (result = db.query(cars, getCars()))
                {
                    loadCars(result);
                }
            }
            else
            {
                using (result = db.query(cars, getCars(" AND [Type] = @1"), values = new string[1] { cboType.Text }))
                {
                    loadCars(result);
                }
            }
        }

        private void cboCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCondition.SelectedIndex == -1)
            {
            }
            else if (cboCondition.Text == "All" || cboCondition.Text == "all")
            {
                using (result = db.query(cars, getCars()))
                {
                    loadCars(result);
                }
            }
            else
            {
                using (result = db.query(cars, getCars(" AND [Condition] = @1"), values = new string[1] { cboCondition.Text }))
                {
                    loadCars(result);
                }
            }
        }

        private void cboMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reload the cars data grid view based on the selected item
            if (cboMake.SelectedIndex == -1)
            {
            }
            else if (cboMake.Text == "All" || cboMake.Text == "all")
            {
                using (result = db.query(cars, getCars()))
                {
                    loadCars(result);
                }
            }
            else
            {
                using (result = db.query(cars, getCars(" AND [Make] = @1"), values = new string[1] { cboMake.Text }))
                {
                    loadCars(result);
                }
            }
        }

        private void cboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reload the cars data grid view based on the selected item
            if (cboModel.SelectedIndex == -1)
            {
            }
            else if (cboModel.Text == "All" || cboModel.Text == "all")
            {
                using (result = db.query(cars, getCars()))
                {
                    loadCars(result);
                }
            }
            else
            {
                using (result = db.query(cars, getCars(" AND [Model] = @1"), values = new string[1] { cboModel.Text }))
                {
                    loadCars(result);
                }
            }
        }

        private void cboMileage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reload the cars data grid view based on the selected item
            if (cboMileage.SelectedIndex == -1)
            {
            }
            else if (cboMileage.Text == "All" || cboMileage.Text == "all")
            {
                using (result = db.query(cars, getCars()))
                {
                    loadCars(result);
                }
            }
            else
            {
                using (result = db.query(cars, getCars(String.Format(" AND [Mileage] {0}", cboMileage.Text))))
                {
                    loadCars(result);
                }
            }
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reload the cars data grid view based on the selected item
            if (cboYear.SelectedIndex == -1)
            {
            }
            else if (cboYear.Text == "All" || cboYear.Text == "all")
            {
                using (result = db.query(cars, getCars()))
                {
                    loadCars(result);
                }
            }
            else
            {
                using (result = db.query(cars, getCars(String.Format(" AND [Year] {0}", cboYear.Text))))
                {
                    loadCars(result);
                }
            }
        }

        private void cboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reload the cars data grid view based on the selected item
            if (cboColor.SelectedIndex == -1)
            {
            }
            else if (cboColor.Text == "All" || cboColor.Text == "all")
            {
                using (result = db.query(cars, getCars()))
                {
                    loadCars(result);
                }
            }
            else
            {
                using (result = db.query(cars, getCars(" AND [Color] = @1"), values = new string[1] { cboColor.Text }))
                {
                    loadCars(result);
                }
            }
        }

        private void cboDoors_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reload the cars data grid view based on the selected item
            if (cboDoors.SelectedIndex == -1)
            {
            }
            else if (cboDoors.Text == "All" || cboDoors.Text == "all")
            {
                using (result = db.query(cars, getCars()))
                {
                    loadCars(result);
                }
            }
            else
            {
                using (result = db.query(cars, getCars(" AND [Doors] = @1"), values = new string[1] { cboDoors.Text }))
                {
                    loadCars(result);
                }
            }
        }

        private void cboRoofType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reload the cars data grid view based on the selected item
            if (cboRoofType.SelectedIndex == -1)
            {
            }
            else if (cboRoofType.Text == "All" || cboRoofType.Text == "all")
            {
                using (result = db.query(cars, getCars()))
                {
                    loadCars(result);
                }
            }
            else
            {
                using (result = db.query(cars, getCars(" AND [RoofType] = @1"), values = new string[1] { cboRoofType.Text }))
                {
                    loadCars(result);
                }
            }
        }

        private void cboBedLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reload the cars data grid view based on the selected item
            if (cboBedLength.SelectedIndex == -1)
            {
            }
            else if (cboBedLength.Text == "All" || cboBedLength.Text == "all")
            {
                using (result = db.query(cars, getCars()))
                {
                    loadCars(result);
                }
            }
            else
            {
                using (result = db.query(cars, getCars(" AND [BedLength] = @1"), values = new string[1] { cboBedLength.Text }))
                {
                    loadCars(result);
                }
            }
        }

        private void cboCost_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Reload the cars data grid view based on the selected item
            if (cboCost.SelectedIndex == -1)
            {
            }
            else if(cboCost.Text == "All" || cboCost.Text == "all")
            {
                using (result = db.query(cars, getCars()))
                {
                    loadCars(result);
                }
            }
            else
            {
                using (result = db.query(cars, getCars(String.Format(" AND [Cost] {0}", cboCost.Text))))
                {
                    loadCars(result);
                }
            }
        }
    }
}
