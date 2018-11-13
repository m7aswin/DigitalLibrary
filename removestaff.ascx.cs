using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class removeteacher : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dbconnection db = new dbconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select teacher_id from tb_teacher where status='suspend' or status='ok'";
            SqlDataReader dr = db.executeread(cmd);
            DropDownList1.Items.Add("--Select--");
            while (dr.Read())
            {
                String x = dr[0].ToString();
                DropDownList1.Items.Add(x);

            }
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        String x = DropDownList1.SelectedItem.Text;
        dbconnection db1 = new dbconnection();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select name,dept,status from tb_teacher where teacher_id=@d";
        cmd.Parameters.AddWithValue("@d", x);
        SqlDataReader dr = db1.executeread(cmd);
        dr.Read();
        String n = dr.GetString(0);
        String dt = dr.GetString(1);
        String sts = dr.GetString(2);
        if (sts.Equals("suspend"))
        {
            Button3.Visible = true;
            Button1.Visible = false;
        }
        else
        {
            Button3.Visible = false;
            Button1.Visible = true;
        }
        TextBox1.Text = n;
        TextBox2.Text = dt;
        TextBox3.Text = sts;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        dbconnection db = new dbconnection();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "update tb_teacher set status='ok' where teacher_id=@d";
        cmd.Parameters.AddWithValue("@d", DropDownList1.SelectedItem.Text);
        db.execute(cmd);
        dbconnection db1 = new dbconnection();
        cmd.CommandText = "select status from tb_teacher where teacher_id=@j";
        cmd.Parameters.AddWithValue("@j", DropDownList1.SelectedItem.Text);
        SqlDataReader dr = db1.executeread(cmd);
        dr.Read();
        String n = dr.GetString(0);
        TextBox3.Text = n;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbconnection db = new dbconnection();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "update tb_teacher set status='suspend' where teacher_id=@d";
        cmd.Parameters.AddWithValue("@d", DropDownList1.SelectedItem.Text);
        db.execute(cmd);
        dbconnection db1 = new dbconnection();
        cmd.CommandText = "select status from tb_teacher where teacher_id=@j";
        cmd.Parameters.AddWithValue("@j", DropDownList1.SelectedItem.Text);
        SqlDataReader dr = db1.executeread(cmd);
        dr.Read();
        String n = dr.GetString(0);
        TextBox3.Text = n;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        dbconnection db = new dbconnection();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "delete from tb_teacher where teacher_id=@d";
        cmd.Parameters.AddWithValue("@d", DropDownList1.SelectedItem.Text);
        db.execute(cmd);
        TextBox3.Text = "Removed!!";
    }
}