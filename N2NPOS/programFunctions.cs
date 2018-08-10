using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace N2NPOS
{
    // This class contains functions required across the system.
    // This means code does not have to be written out twice, three times, etc.

    class programFunctions
    {
    
        public static void refreshUidBox(System.Windows.Forms.ComboBox cb, string connString)
        {
            // To refresh the Username UID box.

            // If there is existent items inside the username combobox...
            if (cb.Items.Count > 0)
            {
                // ...then remove them
                cb.Items.Clear();
            }

            // Setup the SQL connection and open it
            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = connString;
            myConn.Open();

            // Setup the SQL command, then execute a data reader
            SqlCommand cmd = new SqlCommand("SELECT * from [staff]", myConn);
            SqlDataReader dr = cmd.ExecuteReader();

            // If the datareader finds anything...
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    // ...then add said items to the username combobox...
                    cb.Items.Add(dr.GetString(0));
                }
            }
            else
            {
                // ...otherwise, display a message saying no accounts were found.
                // Nobody should receive this error at any given point in the final release.
                MessageBox.Show("No accounts found!", "N2NPOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // As all processes are complete at this point, stop the connection to the database,
            // and clear the SQL command.
            myConn.Close();
            cmd.Dispose();
        }

        public static void startDevMode(string connString, IWin32Window win)
        {
            // This sets up an account for an example (developer) POS user.
            // Then, it creates 20 stock items, of different prices and descriptions.
            // This will not be included in the final release. Remove before final commit to github.

            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = connString;
            myConn.Open();

            // Setup the SQL command, then execute the query
            SqlCommand cmd = new SqlCommand("INSERT into [staff] ([staffUid], [password], [forename], [surname], [dob]) VALUES ('calvinearnshaw', 'dev', 'Calvin', 'Earnshaw', '01/01/2001')", myConn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            // Now ask for stock creation...
            DialogResult msg;
            msg = MessageBox.Show("Do you wish to create sample stock?", "N2NPOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If stock creation will commence...
            if (msg == DialogResult.Yes)
            {
                // ...then create the sample stock...
                int stockCount = 0;

                while (stockCount < 20)
                {
                    // ... and repeat this process 20 times...
                    SqlCommand stkCmd = new SqlCommand("INSERT into [stock] ([ItemID], [ItemName], [ItemGroup], [ItemPrice]) VALUES ('" + stockCount.ToString() + "', 'Sample Item " + stockCount.ToString() + "', 'Group " + stockCount.ToString() + "', '" + stockCount.ToString("0.00") + "')", myConn);
                    stkCmd.ExecuteNonQuery();
                    stockCount = stockCount + 1;
                }
            } else
            {
                // ...otherwise, don't create the sample stock
            }

            // Dev mode initialisation complete!
            // Provide confirmation to user.

            MessageBox.Show("Sign in with the following details:" + Environment.NewLine + Environment.NewLine +
                "Username: calvinearnshaw" + Environment.NewLine + "Password: dev", "N2NPOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool verifyUserDetails(string username, string password, string connString)
        {
            // This verifies a user's details based on the information given.
            // The details are checked against the posData database.
            // This function will return either true or false, based on what
            // the outcome of the verification process is.

            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = connString;
            myConn.Open();

            // Setup the SQL command, then execute a data reader
            SqlCommand cmd = new SqlCommand("SELECT * from [staff] WHERE [staffUid]='" + username + "' AND [password] ='" + password + "'", myConn);
            SqlDataReader dr = cmd.ExecuteReader();

            // Check for rows based on the query above
            // If the data reader finds a matching record...
            if (dr.HasRows)
            {
                // ...then return true...
                return true;
            } else
            {
                // ...otherwise, return false.
                return false;
            }
        }

        public static string returnUserDetails(string info, string username, string password, string connString)
        {
            // This provides details about a selected user based on the
            // information given programmatically.
            // Program must provide username/password to the account in order to
            // access its information.
            // This allows for security and compliance with the GDPR in terms of
            // security.
            // This function will return a string of the information required
            // by the program.

            SqlConnection myConn = new SqlConnection();
            myConn.ConnectionString = connString;
            myConn.Open();

            // Setup the SQL command, then execute a data reader
            SqlCommand cmd = new SqlCommand("SELECT * from [staff] WHERE [staffUid]='" + username + "' AND [password] ='" + password + "'", myConn);
            SqlDataReader dr = cmd.ExecuteReader();

            // Check for rows based on the query above
            // If the data reader finds a matching record...
            if (dr.HasRows)
            {
                // ...then get its information
                while (dr.Read())
                {
                    if (info == "staffUid")
                    {
                        return dr.GetString(0);
                    }
                    else if (info == "password")
                    {
                        return dr.GetString(1);
                    }
                    else if (info == "forename")
                    {
                        return dr.GetString(2);
                    }
                    else if (info == "surname")
                    {
                        return dr.GetString(3);
                    }
                    else if (info == "dob")
                    {
                        return dr.GetString(4);
                    }
                    else
                    {
                        // Function should never reach this point as this function is invoked
                        // programmatically.
                        return "";
                    }
                }
            }
            // Function should never reach this point as this function is invoked
            // programmatically.
            return "";
        }
    }
}
