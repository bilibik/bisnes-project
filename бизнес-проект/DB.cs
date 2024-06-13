using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace бизнес_проект
{
    class DB
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-O8J7TB9;Initial Catalog=master;Integrated Security=True");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}