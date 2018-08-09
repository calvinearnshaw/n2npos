using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace N2NPOS
{
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
    }
}
