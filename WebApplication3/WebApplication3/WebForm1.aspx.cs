using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication3

{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AS5TFTR\\SQLEXPRESS;Initial Catalog=Emp;Integrated Security=True");
            {
                string eid = TextBox1.Text;
                string ename = TextBox2.Text;
                string salary = TextBox3.Text;
                string did = TextBox4.Text;
                string mid = TextBox5.Text;
                 string query = "insert into Employee values(@eid,@ename,@salary,@did,@mid)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@eid", eid);
                cmd.Parameters.AddWithValue("@ename", ename);
                cmd.Parameters.AddWithValue("@salary", salary);
                cmd.Parameters.AddWithValue("@did", did);
                cmd.Parameters.AddWithValue("@mid",mid);

                conn.Open();

                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    Console.WriteLine(a + " Value is inserted");
                }
                else
                {
                    Console.WriteLine(a + " not inserted");
                }

                conn.Close();
            }

        }

    }
}