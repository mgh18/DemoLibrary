using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using System.Data;
using System.Data.SqlClient;


namespace DA
{
    public class PersonProcessor
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
    
        public PersonProcessor()
        {
            con = new SqlConnection();
            cmd = new SqlCommand();
            da = new SqlDataAdapter();
            cmd.Connection = con;
            da.SelectCommand = cmd;

         }
        public void connect()
        {
            con.ConnectionString = "Data Source=DESKTOP-PPIILUB;Initial Catalog=permission;Integrated Security=True";
            con.Open();

        }
        public void Disconnect()
        {
            con.Close();

        }
        public void docommand(string query)
        {
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }
        public DataTable select(string query)
        {
            cmd.CommandText = query;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}