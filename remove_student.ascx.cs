using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class remove_student : System.Web.UI.UserControl
{
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {
        dbconnection db = new dbconnection();
        if (!IsPostBack)
        {
            DropDownList1.Items.Add("--Select Student Id--");
            cmd.CommandText = "select std_id from tb_student";
            SqlDataReader dr = db.executeread(cmd);
            while (dr.Read())
            {
                DropDownList1.Items.Add(dr[0].ToString());
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbconnection db = new dbconnection();
        cmd.CommandText = "delete from tb_student where std_id=@d";
        cmd.Parameters.AddWithValue("@d", DropDownList1.SelectedItem.Text);
        db.execute(cmd);
        Response.Redirect("remove_student.aspx");
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnection db = new dbconnection();
        cmd.CommandText = "select course_id,name,sem from tb_student where std_id=@a";
        cmd.Parameters.AddWithValue("@a", DropDownList1.SelectedItem.Text);
        SqlDataReader dr = db.executeread(cmd);
        dr.Read();
        dbconnection db1 = new dbconnection();
        cmd.CommandText = "select course,stream from tb_course where course_id=@d";
        cmd.Parameters.AddWithValue("@d", dr.GetString(0));
        SqlDataReader dr1 = db1.executeread(cmd);
        dr1.Read();
        TextBox1.Text = dr.GetString(1);
        TextBox2.Text = dr1.GetString(0);
        TextBox3.Text = dr1.GetString(1);
        TextBox4.Text = dr.GetInt32(2).ToString();
    }
}