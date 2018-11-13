using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class add_student : System.Web.UI.UserControl
{
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dbconnection db = new dbconnection();
            cmd.CommandText = "select course_id from tb_course";
            SqlDataReader dr = db.executeread(cmd);
            DropDownList1.Items.Add("--Select--");
            while (dr.Read())
            {
                DropDownList1.Items.Add(dr[0].ToString());
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        dbconnection db = new dbconnection();
        cmd.CommandText = "insert into tb_student values(@a,@b,@c,@d,@e,@f,@g,@h)";
        cmd.Parameters.AddWithValue("@a", TextBox1.Text);
        cmd.Parameters.AddWithValue("@b", TextBox2.Text);
        cmd.Parameters.AddWithValue("@c", DropDownList1.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@d", Convert.ToInt32(DropDownList2.SelectedItem.Text));
        cmd.Parameters.AddWithValue("@e", TextBox3.Text);
        cmd.Parameters.AddWithValue("@f", TextBox4.Text);
        cmd.Parameters.AddWithValue("@g", TextBox5.Text);
        cmd.Parameters.AddWithValue("@h", TextBox8.Text);
        db.execute(cmd);
        dbconnection db1 = new dbconnection();
        cmd.CommandText = "insert into login values(@x,@y,@z)";
        cmd.Parameters.AddWithValue("@x", TextBox5.Text);
        cmd.Parameters.AddWithValue("@y", TextBox4.Text);
        cmd.Parameters.AddWithValue("@z","Student");
        db1.execute(cmd);
        Response.Redirect("add_student.aspx");
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnection db = new dbconnection();
        cmd.CommandText = "select stream,course,no_sem from tb_course where course_id=@d";
        cmd.Parameters.AddWithValue("@d", DropDownList1.SelectedItem.Text);
        SqlDataReader dr = db.executeread(cmd);
        dr.Read();
        TextBox6.Text = dr.GetString(0);
        TextBox7.Text = dr.GetString(1);
        int n = dr.GetInt32(2);
        DropDownList2.Items.Clear();
        DropDownList2.Items.Add("--Select--");
        for (int i = 1; i <= n; i++)
        {
            DropDownList2.Items.Add(i.ToString());
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("add_student.aspx");
    }
}