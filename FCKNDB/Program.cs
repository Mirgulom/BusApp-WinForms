using System.Data;
using System.Drawing.Text;
using Microsoft.Data.Sqlite;

namespace FCKNDB
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
    public static class Connection
    {
        public static SqliteConnection Connect()
        {
            SqliteConnection connection = new SqliteConnection("Data Source=test.db"); //Singleton
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
    }
}