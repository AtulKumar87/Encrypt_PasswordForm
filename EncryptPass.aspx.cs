using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlClient;
using System.Data; 

namespace EncryptPassword
{
    public partial class EncryptPass : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=occweb05;Initial Catalog=EmployeeDB;user id=sa;password=odpserver550810998@;");  
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string enpass = encrypt(TextBox2.Text);
            SqlCommand cmd = new SqlCommand("insert into [User] values(@LoginName,@PasswordHash,@Name)", con);
            cmd.Parameters.AddWithValue("@LoginName",TextBox1.Text);
            cmd.Parameters.AddWithValue("@PasswordHash",enpass);
            cmd.Parameters.AddWithValue("@Name",TextBox3.Text);
            if (con.State == ConnectionState.Closed)
                con.Open();
            int n = cmd.ExecuteNonQuery();
            con.Close();
            if(n>0)
            {
                msg.Text = "Record save";
            }
            else
            {
                msg.Text = "sorry";
            }
        }
        public string encrypt(string pass)
        {
            string msg = "";
            byte[] encode = new byte[pass.Length];
            encode = Encoding.UTF8.GetBytes(pass);
            msg = Convert.ToBase64String(encode);
            return msg;
        }
    }
}