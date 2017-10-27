using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruvaTour.Services
{
    public class ConnectDB
    {
        SqlConnection con;

        public ConnectDB(string connString)
        {
            connString = ConfigurationManager.ConnectionStrings[connString].ConnectionString;
            con = new SqlConnection(connString);
            con.Open();
        }

        public SqlCommand createSpCommand()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            return cmd;
        }

        public SqlCommand createQuerryCommand()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            return cmd;
        }
    }
}
