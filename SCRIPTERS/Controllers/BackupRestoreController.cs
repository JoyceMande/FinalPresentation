using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SCRIPTERS.Controllers
{
    public class BackupRestoreController : Controller
    {
       
        
        public List<dynamic> Recovery()
        {

            DateTime nm = DateTime.Now;
            string date = nm.ToString("yyyymmddMMss");
            SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=ScriptersDb_New;Integrated Security=True");
            connection.Open();
            var Query = "RESTORE DATABASE ScriptersDb_New FROM DISK = 'C:\back.bak' ";
            var Query1 = "USE master";
            var Query2 = "ALTER DATABASE ScriptersDb_New SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
            var Query3 = "DROP DATABASE UTRANSPORTDATABASE";
            SqlCommand cmd = new SqlCommand(Query, connection);
            SqlCommand cmd1 = new SqlCommand(Query1, connection);
            SqlCommand cmd2 = new SqlCommand(Query2, connection);
            SqlCommand cmd3 = new SqlCommand(Query3, connection);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            connection.Close();
            return null;
        }
    }
}