using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA;
using System.Data;
using System.Data.SqlClient;
using BI;

namespace BI
{
    public class users:PersonProcessor
    {
        public static bool up1 = false;
        public static bool up2 = false;
        public static bool up3 = false;
        public static bool up4 = false;

        public int id;
        public string username;
        public string pas;
        public bool p1;
        public bool p2;
        public bool p3;
        public bool p4;

        public void insert()
        {
            base.connect();

            string query = "insert into users_tbl (id,username,password,up1,up2,up3,up4)";
            query += "values({0},'{1}','{2}','{3}','{4}','{5}','{6}')";
            query = String.Format(query, id, username, pas, this.p1, this.p2, this.p3, this.p4);
            base.docommand(query);

            base.Disconnect();
        }
        public DataTable Select()
        {
            base.connect();
            DataTable dt = base.select("select * from users_tbl");
            base.Disconnect();
            return dt;
        }

        public void permission(string username)
        {
            base.connect();

            string query = "select * from users_tbl where username='{0}'";
            query = string.Format(query, username);
            DataTable dt = base.select(query);
            up1 = Convert.ToBoolean(dt.Rows[0]["up1"].ToString());
            up2 = Convert.ToBoolean(dt.Rows[0]["up2"].ToString());
            up3 = Convert.ToBoolean(dt.Rows[0]["up3"].ToString());
            up4= Convert.ToBoolean(dt.Rows[0]["up4"].ToString());

            base.Disconnect();


        }
        public bool login(string username,string password)
        {
            base.connect();
            string query = "select count(*) from users_tbl where username='{0}' AND password='{1}'";
            query = string.Format(query,username,password);
            DataTable dt = base.select(query);
            base.Disconnect();

            bool enter = false;
            if (dt.Rows[0][0].ToString() == "1")
                enter = true;
            return enter;

        }
    }
}
