using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class removecourse : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        dbconnection db = new dbconnection();
        if (!IsPostBack)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select course_id from tb_course";
            DropDownList1.Items.Add("--Select--");
            SqlDataReader dr = db.executeread(cmd);
            while (dr.Read())
            {
                String x = dr[0].ToString();
                DropDownList1.Items.Add(x);
            }
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnection db1 = new dbconnection();
        String d = DropDownList1.SelectedItem.Text;
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select dept,course from tb_course where course_id=@d";
        cmd.Parameters.AddWithValue("@d", d);
        SqlDataReader dr = db1.executeread(cmd);
        dr.Read();
        TextBox1.Text = dr.GetString(0);
        TextBox2.Text = dr.GetString(1);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbconnection db2 = new dbconnection();
        String b = DropDownList1.SelectedItem.Text;
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "delete from tb_course where course_id=@b";
        cmd.Parameters.AddWithValue("@b", b);
        db2.execute(cmd);
        Response.Redirect("removecourse.aspx");
    }
}