using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TimeTrack
{
    class Database
    {
        public static bool SQLConnected = false;
        public static bool databaseConnected = false;

        public static void ConnectToSQL(string databaseServer, string databaseName, string databaseConnectionAuthentication, string databaseSQLUsername, string databaseSQLPassword)
        {
            if (SQLConnected)
            {
                SQLConnected = false;
                return;
            }

            try
            {
                // Build connection string
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = databaseServer;
                //if (databaseConnectionAuthentication == "Windows")
                //    builder.Authentication = SqlAuthenticationMethod.ActiveDirectoryIntegrated;
                //if (databaseConnectionAuthentication == "SQL")
                //    builder.Authentication = SqlAuthenticationMethod.;
                builder.UserID = databaseSQLUsername;
                builder.Password = databaseSQLPassword;
                builder.InitialCatalog = "master";

                // Connect to SQL

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    if (!SQLConnected)
                    {
                        connection.Open();
                        DialogResult dialogResult = MessageBox.Show("Successfully connected to SQL", "Connection status", MessageBoxButtons.OK);
                        SQLConnected = true;
                    }
                    else
                    {
                        connection.Close();
                        DialogResult dialogResult = MessageBox.Show("Disconnected from SQL", "Connection status", MessageBoxButtons.OK);
                        SQLConnected = false;
                    }
                }
            }
            catch (SqlException e)
            {
                DialogResult dialogResult = MessageBox.Show("Failed to connect to SQL", "Connection status", MessageBoxButtons.OK);
            }
        }

        public static void BuildDatabase()
        {
            if (!SQLConnected)
            {
                DialogResult dialogResult = MessageBox.Show("Not connected to SQL, please reconnect", "Connection status", MessageBoxButtons.OK);
                return;
            }

        }
    }
}
