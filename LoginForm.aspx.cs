using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EncryptPassword
{
    public partial class LoginForm : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=occweb05;Initial Catalog=EmployeeDB;user id=sa;password=odpserver550810998@;");  
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string enpass = encrypt(TextBox2.Text);
            SqlCommand cmd = new SqlCommand("select * from [User] where LoginName=@LoginName and PasswordHash=@PasswordHash", con);
            cmd.Parameters.AddWithValue("@LoginName", TextBox1.Text);
            cmd.Parameters.AddWithValue("@PasswordHash", enpass);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable st = new DataTable();
            da.Fill(st);
            if (st!=null && st.Rows.Count> 0)
            {
                msg.Text = "Login SuccessFully.";
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