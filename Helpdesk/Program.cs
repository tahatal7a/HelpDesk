using System.Data.SqlClient;

namespace Helpdesk
{
    internal static class Program
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
            Application.Run(new Form1());
            

        }
        public static SqlConnection GetConnection()
        {    
            string strCnx = @"server=.\SQLEXPRESS;database=helpdesk_db;Integrated Security=true";
            SqlConnection cnx = new SqlConnection(strCnx);
            return cnx;
        }
    }
}