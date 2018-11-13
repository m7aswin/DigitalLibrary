using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class login : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbconnection db = new dbconnection();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "select * from login where username=@ur and password=@p ";
        cmd.Parameters.AddWithValue("@ur", TextBox1.Text);
        cmd.Parameters.AddWithValue("@p", TextBox2.Text);
        SqlDataReader dr = db.executeread(cmd);
        if (dr.Read())
        {
            Session["u"] = TextBox1.Text;
            Session["p"] = TextBox2.Text;
            String type = dr.GetString(2);
            if (type == "Admin")
            {
                Response.Redirect("AdminHome.aspx");
            }
            else if (type == "Teacher")
            {
                dbconnection db2 = new dbconnection();
                cmd.CommandText = "select tchr_id from tb_teacher where email=@e and phone=@f";
                cmd.Parameters.AddWithValue("@e", TextBox1.Text);
                cmd.Parameters.AddWithValue("@f", TextBox2.Text);
                SqlDataReader dr2 = db2.executeread(cmd);
                dr2.Read();
                String tid = dr2.GetString(0);
                Session["tid"] = tid;
                Response.Redirect("TeacherHome.aspx");
            }
            else if (type == "Student")
            {
                dbconnection db3 = new dbconnection();
                cmd.CommandText = "select std_id from tb_student where email=@e and phone=@f";
                cmd.Parameters.AddWithValue("@e", TextBox1.Text);
                cmd.Parameters.AddWithValue("@f", TextBox2.Text);
                SqlDataReader dr3 = db3.executeread(cmd);
                dr.Read();
                Session["std_id"] = dr3.GetString(0);
                Response.Redirect("student_home.aspx");

            }
            else if (type == "Librarian")
            {

                Response.Redirect("librarianhome.aspx");

            }
            else
            {
                Label3.Visible = true;
            }
        }
    }
}