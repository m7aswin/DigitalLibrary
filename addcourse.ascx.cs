using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class addcourse : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        dbconnection db = new dbconnection();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select course_id from tb_id";
        SqlDataReader dr = db.executeread(cmd);
        dr.Read();
        int x = dr.GetInt32(0);
        x++;
        String cid = "CAWHCRS" + x.ToString();
        TextBox1.Text = cid;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbconnection db1 = new dbconnection();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText="insert into tb_course values(@a,@b,@c,@d)";
        cmd.Parameters.AddWithValue("@a", TextBox1.Text);
        cmd.Parameters.AddWithValue("@b", TextBox2.Text);
        cmd.Parameters.AddWithValue("@c", TextBox3.Text);
        cmd.Parameters.AddWithValue("@d", TextBox4.Text);
        db1.execute(cmd);
        dbconnection db2 = new dbconnection();
        cmd.CommandText = "select course_id from tb_id";
        SqlDataReader dr = db2.executeread(cmd);
        dr.Read();
        int x = dr.GetInt32(0);
        x++;
        cmd.CommandText = "update tb_id set course_id=@v";
        cmd.Parameters.AddWithValue("@v", x);
        db2.execute(cmd);
        Response.Write("<script>alert('Data inserted successfully')</script>");
        Response.Redirect("addcourse.aspx");
    }
}