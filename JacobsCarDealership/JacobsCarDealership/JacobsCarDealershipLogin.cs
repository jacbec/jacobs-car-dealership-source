using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace JacobsCarDealership
{
    public partial class JacobsCarDealershipLogin : Form
    {
        #region Set variables
        private DB db = new DB();
        private DataTable result;

        private string staff = "staff";

        private string[] fields;
        private string[] where;
        private string[] parameters;
        private string[] values;
        private string value;

        private string salt = null;
        private string password = null;
        #endregion

        public JacobsCarDealershipLogin()
        {
            InitializeComponent();
            CenterToScreen();
        }
        
        private void JacobsCarDealershipLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Make sure the username and password fields are not null or empty
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                #region Log Staff in
                //Set the command text to query DB with
                result = db.select(staff, where = new string[3] { "username", "=", "@username" }, value = txtUsername.Text);

                //If there are any rows in result get the salt and create the hash password
                if (result.Rows.Count == 1)
                {
                    foreach (DataRow row in result.Rows)
                    {
                        salt = (string)row["salt"];
                        password = Encrypt.generateSHA256Hash(txtPassword.Text, salt);
                    }

                    //Set the command text to query DB with
                    result = db.query(staff, "SELECT * FROM [staff] WHERE [username] = @1 AND [password] = @2", values = new string[2] { txtUsername.Text, password });

                    //If there are any rows in result set the user info and load JacobsCarDealership
                    if (result.Rows.Count == 1)
                    {
                        foreach (DataRow row in result.Rows)
                        {
                            User.ID = (int)row["id"];
                            User.FirstName = (string)row["firstName"];
                            User.LastName = (string)row["lastName"];
                            User.Username = (string)row["username"];
                            User.Position = (string)row["position"];
                        }

                        txtUsername.Text = "";
                        txtPassword.Text = "";

                        //Make new form
                        JacobsCarDealership jacobsCarDealership = new JacobsCarDealership();

                        //Set parent form's visible to false
                        this.Visible = false;

                        //Open new dialog
                        jacobsCarDealership.ShowDialog();

                        //Set parent form's visible to true
                        this.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Username or password is incorrect!", "Error: Incorrect Information");
                    }
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect!", "Error: Incorrect Information");
                }
                #endregion
            }
            else
            {
                MessageBox.Show("The username and password fields are required!", "Error: Empty Fields");
            }
        }
    }
}
