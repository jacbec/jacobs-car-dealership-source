using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace JacobsCarDealership
{
    class DB
    {
        #region Set variables
        private OleDbConnection connection;
        private OleDbCommand command;
        private OleDbDataReader reader;
        private DataTable results;
        #endregion

        //Private method to get the connection
        private OleDbConnection getConnection()
        {
            try
            {
                connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\CarDealer.accdb; Persist Security Info = False;");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: Database Connection Failed");
            }

            return connection;
        }

        //Private method to set then get the command
        private OleDbCommand getCommand(string query)
        {
            command = new OleDbCommand(query, connection);
            return command;
        }

        //Private method for select and delete
        private string action(string action, string table, string[] where)
        {
            //Start query string
            string query = "";

            //Check that where has 3 items
            if (where.Length == 3)
            {
                //List the possible operators
                string[] operators = new string[5] { "=", ">", "<", ">=", "<=" };

                //Set variables for query string
                string field = where[0];
                string _operator = where[1];
                string parameter = where[2];

                //If the operator is in the list set the query string
                if (operators.Any(_operator.Contains))
                {
                    query = String.Format("{0} [{1}] WHERE [{2}] {3} {4}", action, table, field, _operator, parameter);
                }
            }

            return query;
        }

        //Method to query the db with no or more than 1 parameter
        public DataTable query(string table, string query, string[] values = null)
        {
            #region Query the DB
            try
            {
                results = new DataTable(table);

                //Set the connection
                using (getConnection())
                {
                    //Set the command text
                    using (getCommand(query))
                    {
                        //Check if there are parameters
                        if (values != null)
                        {
                            //Loop through the parameters array binding the parameters to query string
                            int i = 1;
                            foreach (string value in values)
                            {
                                object dbValue = DBNull.Value;
                                int intValue;
                                double doubleValue;
                                bool boolValue;
                                decimal decimalValue;
                                DateTime dateValue;

                                if (string.IsNullOrEmpty(value))
                                {
                                    command.Parameters.AddWithValue("@" + i, dbValue);
                                    i++;
                                }
                                else if (int.TryParse(value, out intValue))
                                {
                                    command.Parameters.AddWithValue("@" + i, intValue);
                                    i++;
                                }
                                else if(double.TryParse(value, out doubleValue))
                                {
                                    command.Parameters.AddWithValue("@" + i, doubleValue);
                                    i++;
                                }
                                else if (bool.TryParse(value, out boolValue))
                                {
                                    command.Parameters.AddWithValue("@" + i, boolValue);
                                    i++;
                                }
                                else if (decimal.TryParse(value, out decimalValue))
                                {
                                    command.Parameters.AddWithValue("@" + i, decimalValue);
                                    i++;
                                }
                                else if(DateTime.TryParse(value, out dateValue))
                                {
                                    command.Parameters.AddWithValue("@" + i, dateValue.ToString("MM/dd/yyyy"));
                                    i++;
                                }
                                else
                                {
                                    command.Parameters.AddWithValue("@" + i, value);
                                    i++;
                                }
                            }
                        }

                        //Open connection and execute the query
                        command.Connection.Open();
                        command.ExecuteNonQuery();

                        using (reader = command.ExecuteReader())
                        {
                            results.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: Query Failed");
            }
            finally
            {
                if (connection != null) connection.Close();
            }
            #endregion
            
            return results;
        }

        //Method to get a SELECT query dataSet 
        public DataTable select(string table, string[] where, string value)
        {
            //Set the query string
            string query = action("SELECT * FROM", table, where);

            #region Query the DB
            try
            {
                results = new DataTable(table);

                //Set the connection
                using (getConnection())
                {
                    //Set the command text
                    using (getCommand(query))
                    {
                        command.Connection.Open();

                        //Bind the parameter to query string
                        object dbValue = DBNull.Value;
                        int intValue;
                        double doubleValue;
                        bool boolValue;
                        decimal decimalValue;
                        DateTime dateValue;

                        if (string.IsNullOrEmpty(value))
                        {
                            command.Parameters.AddWithValue(where[2], dbValue);
                        }
                        else if (int.TryParse(value, out intValue))
                        {
                            command.Parameters.AddWithValue(where[2], intValue);
                        }
                        else if (double.TryParse(value, out doubleValue))
                        {
                            command.Parameters.AddWithValue(where[2], doubleValue);
                        }
                        else if (bool.TryParse(value, out boolValue))
                        {
                            command.Parameters.AddWithValue(where[2], boolValue);
                        }
                        else if (decimal.TryParse(value, out decimalValue))
                        {
                            command.Parameters.AddWithValue(where[2], decimalValue);
                        }
                        else if (DateTime.TryParse(value, out dateValue))
                        {
                            command.Parameters.AddWithValue(where[2], dateValue.ToString("MM/dd/yyyy"));
                        }
                        else
                        {
                            command.Parameters.AddWithValue(where[2], value);
                        }

                        //Open connection and execute the query
                        command.ExecuteNonQuery();

                        using (reader = command.ExecuteReader())
                        {
                            results.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: Select Query Failed");
            }
            finally
            {
                if (connection != null) connection.Close();
            }
            #endregion
            
            return results;
        }

        //Method to Inset data into the db returning a MessageBox
        public DialogResult insert(string table, string[] fields, string[] parameters, string[] values)
        {
            //Set the DialogResult for MessageBox
            DialogResult messageBox;

            #region Set the query string
            //Start Insert query string
            string query = String.Format("INSERT INTO [{0}] (", table);

            //Loop through fields array setting the data to query string
            int i = 1;
            foreach (string field in fields)
            {
                if (i == fields.Length)
                {
                    query += String.Format("[{0}])", field);
                }
                else
                {
                    query += String.Format("[{0}], ", field);
                }
                i++;
            }

            query += " VALUES (";

            //Loop through parameters array setting the data to query string
            int x = 1;
            foreach (string param in parameters)
            {
                if (x == parameters.Length)
                {
                    query += String.Format("{0})", param);
                }
                else
                {
                    query += String.Format("{0}, ", param);
                }
                x++;
            }
            #endregion

            #region Query the DB
            try
            {
                //Set the connection
                using (getConnection())
                {
                    //Set the command text
                    using (getCommand(query))
                    {
                        //Loop through values array binding the parameters to query string
                        int j = 1;
                        foreach (string value in values)
                        {
                            object dbValue = DBNull.Value;
                            int intValue;
                            double doubleValue;
                            bool boolValue;
                            decimal decimalValue;
                            DateTime dateValue;

                            if (string.IsNullOrEmpty(value))
                            {
                                command.Parameters.AddWithValue(String.Format("@{0}", j), dbValue);
                                j++;
                            }
                            else if(int.TryParse(value, out intValue))
                            {
                                command.Parameters.AddWithValue(String.Format("@{0}", j), intValue);
                                j++;
                            }
                            else if (double.TryParse(value, out doubleValue))
                            {
                                command.Parameters.AddWithValue(String.Format("@{0}", j), doubleValue);
                                j++;
                            }
                            else if (bool.TryParse(value, out boolValue))
                            {
                                command.Parameters.AddWithValue(String.Format("@{0}", j), boolValue);
                                j++;
                            }
                            else if (decimal.TryParse(value, out decimalValue))
                            {
                                command.Parameters.AddWithValue(String.Format("@{0}", j), decimalValue);
                                j++;
                            }
                            else if (DateTime.TryParse(value, out dateValue))
                            {
                                command.Parameters.AddWithValue(String.Format("@{0}", j), dateValue.ToString("MM/dd/yyyy"));
                                j++;
                            }
                            else
                            {
                                command.Parameters.AddWithValue(String.Format("@{0}", j), value);
                                j++;
                            }
                        }

                        //Open connection and execute the query
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                //Set MessageBox
                messageBox = MessageBox.Show("Selected contents have been inserted into the database", "Success: Data Inserted");
            }
            catch (Exception ex)
            {
                messageBox = MessageBox.Show(ex.ToString(), "Error: Insert Query Failed");
            }
            finally
            {
                if (connection != null) connection.Close();
            }
            #endregion

            //Return the message
            return messageBox;
        }

        //Method to Update data in the db returning a MessageBox
        public DialogResult update(string table, string[] fields, string[] parameters, string[] values)
        {
            //Set the DialogResult for MessageBox
            DialogResult messageBox;

            #region Set the query string
            //Start Update query string
            string query = String.Format("UPDATE [{0}] SET", table);

            //Loop through the fields and parameters array setting them to the query string
            bool end = false;
            int i = 1;
            while (end == false)
            {
                if (i == fields.Length)
                {
                    query += String.Format(" WHERE [{0}] = {1}", fields[i - 1], parameters[i - 1]);
                    end = true;
                }
                else if (i == fields.Length - 1)
                {
                    query += String.Format(" [{0}] = {1}", fields[i - 1], parameters[i - 1]);
                }
                else
                {
                    query += String.Format(" [{0}] = {1},", fields[i - 1], parameters[i - 1]);
                }

                i++;
            }
            #endregion

            #region Query the DB
            try
            {
                using (getConnection())
                {
                    using (getCommand(query))
                    {

                        //Loop through values array binding the parameters to query string
                        int x = 1;
                        foreach (string value in values)
                        {
                            object dbValue = DBNull.Value;
                            int intValue;
                            double doubleValue;
                            bool boolValue;
                            decimal decimalValue;
                            DateTime dateValue;

                            if (string.IsNullOrEmpty(value))
                            {
                                command.Parameters.AddWithValue(String.Format("@{0}", x), dbValue);
                                x++;
                            }
                            else if (int.TryParse(value, out intValue))
                            {
                                command.Parameters.AddWithValue(String.Format("@{0}", x), intValue);
                                x++;
                            }
                            else if (double.TryParse(value, out doubleValue))
                            {
                                command.Parameters.AddWithValue(String.Format("@{0}", x), doubleValue);
                                x++;
                            }
                            else if (bool.TryParse(value, out boolValue))
                            {
                                command.Parameters.AddWithValue(String.Format("@{0}", x), boolValue);
                                x++;
                            }
                            else if (decimal.TryParse(value, out decimalValue))
                            {
                                command.Parameters.AddWithValue(String.Format("@{0}", x), decimalValue);
                                x++;
                            }
                            else if (DateTime.TryParse(value, out dateValue))
                            {
                                command.Parameters.AddWithValue(String.Format("@{0}", x), dateValue.ToString("MM/dd/yyyy"));
                                x++;
                            }
                            else
                            {
                                command.Parameters.AddWithValue(String.Format("@{0}", x), value);
                                x++;
                            }
                        }

                        //Open connection and execute the query
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

                //Set MessageBox
                messageBox = MessageBox.Show("Selected contents in the database have been updated", "Success: Data Updated");
            }
            catch (Exception ex)
            {
                messageBox = MessageBox.Show(ex.Message, "Error: Update Query Failed");
            }
            finally
            {
                if (connection != null) connection.Close();
            }
            #endregion

            //Return the MessageBox
            return messageBox;
        }

        //Method to Delete data from the db returning a MessageBox
        public DialogResult delete(string table, string[] where, string value)
        {
            //Set the DialogResult for MessageBox
            DialogResult messageBox;
            string query = action("DELETE FROM ", table, where);

            #region Query the DB
            try
            {
                //Set the connection
                using (getConnection())
                {
                    //Set the command text
                    using (getCommand(query))
                    {
                        //Bind the parameters to the query string
                        object dbValue = DBNull.Value;
                        int intValue;
                        double doubleValue;
                        bool boolValue;
                        decimal decimalValue;
                        DateTime dateValue;

                        if (string.IsNullOrEmpty(value))
                        {
                            command.Parameters.AddWithValue(where[2], dbValue);
                        }
                        else if (int.TryParse(value, out intValue))
                        {
                            command.Parameters.AddWithValue(where[2], intValue);
                        }
                        else if (double.TryParse(value, out doubleValue))
                        {
                            command.Parameters.AddWithValue(where[2], doubleValue);
                        }
                        else if (bool.TryParse(value, out boolValue))
                        {
                            command.Parameters.AddWithValue(where[2], boolValue);
                        }
                        else if (decimal.TryParse(value, out decimalValue))
                        {
                            command.Parameters.AddWithValue(where[2], decimalValue);
                        }
                        else if (DateTime.TryParse(value, out dateValue))
                        {
                            command.Parameters.AddWithValue(where[2], dateValue.ToString("MM/dd/yyyy"));
                        }
                        else
                        {
                            command.Parameters.AddWithValue(where[2], value);
                        }
                        
                        //Open connection and execute the query
                        command.ExecuteNonQuery();
                    }
                }

                //Set MessageBox
                messageBox = MessageBox.Show("Selected contents in the database have been deleted", "Success: Data Deleted");
            }
            catch (Exception ex)
            {
                messageBox = MessageBox.Show(ex.Message, "Error: Delete Query Failed");
            }
            finally
            {
                if (connection != null) connection.Close();
            }
            #endregion

            //Return the MessageBox
            return messageBox;
        }
    }
}
