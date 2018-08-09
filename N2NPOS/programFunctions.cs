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
                    cb.Items.Add(dr.GetString(1));
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

        public static void startDevMode(string connString)
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

            // Now ask for stock creation...
            DialogResult msg;
            msg = MessageBox.Show("Do you wish to create sample stock?", "N2NPOS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If stock creation is to be used...
            if (msg == DialogResult.Yes)
            {
                // ...then create the sample stock
                int stockCount = 0;

                while (stockCount < 20)
                {
                    // Repeat this process 20 times
                    SqlCommand stkCmd = new SqlCommand("INSERT into [stock] ([ItemID], [ItemName], [ItemGroup], [ItemPrice]) VALUES ('" + stockCount.ToString() + "', 'Sample Item " + stockCount.ToString() + "', 'Group " + stockCount.ToString() + "', '" + stockCount.ToString("0.00") + "')", myConn);
                    cmd.ExecuteNonQuery();
                    stockCount = stockCount + 1;
                }
            } else
            {
                // ...then don't create the sample stock
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
    }
}
