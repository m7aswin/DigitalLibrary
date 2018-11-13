using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class addqp : System.Web.UI.UserControl
{
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {
        dbconnection db = new dbconnection();
        cmd.CommandText = "select qp_id from tb_id";
        SqlDataReader dr = db.executeread(cmd);
        dr.Read();
        int x = dr.GetInt32(0);
        x++;
        String s = "QPJHQ" + x.ToString();
        TextBox1.Text = s;
        if (!IsPostBack)
        {
            DropDownList1.Items.Add("--Select--");
            dbconnection db1 = new dbconnection();
            cmd.CommandText = "select stream from tb_course";
            SqlDataReader dr1 = db1.executeread(cmd);
            while (dr.Read())
            {
                String st = dr1[0].ToString();
                DropDownList1.Items.Add(st);
            }
        }            

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList2.Items.Clear();
        DropDownList2.Items.Add("--Select--");
        dbconnection db = new dbconnection();
        cmd.CommandText = "select no_sem from tb_course where stream=@d";
        cmd.Parameters.AddWithValue("@d", DropDownList1.SelectedItem.Text);
        SqlDataReader dr = db.executeread(cmd);
        while (dr.Read())
        {
            String s = dr[0].ToString();
            DropDownList2.Items.Add(s);
        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList3.Items.Clear();
        DropDownList3.Items.Add("--Select--");
        dbconnection db1 = new dbconnection();
        cmd.CommandText = "select crs_id from tb_course where stream=@f and no_sem=@g";
        cmd.Parameters.AddWithValue("@f", DropDownList1.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@g", DropDownList2.SelectedItem.Text);
        SqlDataReader dr1 = db1.executeread(cmd);
        dr1.Read();
        String id = dr1.GetString(0);
        dbconnection db = new dbconnection();
        cmd.CommandText = "select  subject from tb_subject where crs_id=@d";
        cmd.Parameters.AddWithValue("@d",id);
        SqlDataReader dr = db.executeread(cmd);
        while (dr.Read())
        {
            String s = dr[0].ToString();
            DropDownList2.Items.Add(s);
        }
    }
}