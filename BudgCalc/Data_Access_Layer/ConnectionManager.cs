using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Data.SqlClient;


namespace BudgCalc.Data_Access_Layer
{
    class ConnectionManager
    {

        public static SqlConnection DatabaseConnection()
        {
            // Make a connection to the specific database.
            string connection = "Data Source=JOCELYN\\SQLEXPRESS;Initial Catalog=BudgetCalculator;User ID=sa;Password=sqlexpress";
            SqlConnection conn = new SqlConnection(connection);
            return conn;
        }
    }
}
