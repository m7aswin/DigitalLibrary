using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class removesubject : System.Web.UI.UserControl
{
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dbconnection db = new dbconnection();
            
            cmd.CommandText = "select sub_id from tb_subject";
            SqlDataReader dr = db.executeread(cmd);
            DropDownList1.Items.Add("--Select--");
            while (dr.Read())
            {
                String s = dr[0].ToString();
                DropDownList1.Items.Add(s);
            }
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnection db = new dbconnection();
        cmd.CommandText = "select crs_id,subject,sem from tb_subject where sub_id=@d";
        cmd.Parameters.AddWithValue("@d", DropDownList1.SelectedItem.Text);
        SqlDataReader dr = db.executeread(cmd);
        dr.Read();
        String cid = dr.GetString(0);
        dbconnection db1 = new dbconnection();
        cmd.CommandText = "select course,dept from tb_course where course_id=@f";
        cmd.Parameters.AddWithValue("@f", cid);
        SqlDataReader dr1 = db1.executeread(cmd);
        dr1.Read();
        TextBox2.Text = dr1.GetString(0);
        TextBox3.Text = dr1.GetString(1);
        TextBox5.Text = dr.GetString(1);
        TextBox4.Text=dr.GetInt32(2).ToString();
        Response.Redirect("removesubject.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbconnection db = new dbconnection();
        cmd.CommandText = "delete from tb_subject where sub_id=@d";
        cmd.Parameters.AddWithValue("@d", DropDownList1.SelectedItem.Text);
        db.execute(cmd);
    }
}