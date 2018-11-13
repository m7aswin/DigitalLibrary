using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class addteacher : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        dbconnection db = new dbconnection();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select tchr_id from tb_id";
        SqlDataReader dr = db.executeread(cmd);
        dr.Read();
        int x = dr.GetInt32(0);
        x++;
        String d = "AWHTCH" + x.ToString();
        TextBox1.Text = d;
        if (!IsPostBack)
        {
            dbconnection db1 = new dbconnection();
            cmd.CommandText = "select distinct stream from tb_course";
            SqlDataReader dr1 = db1.executeread(cmd);
            DropDownList1.Items.Add("--Select--");
            while (dr1.Read())
            {
                String s = dr1[0].ToString();
                DropDownList1.Items.Add(s);
            }
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String s = "";
        if (CheckBox1.Checked)
            s += CheckBox1.Text+", ";
        if (CheckBox2.Checked)
            s += CheckBox2.Text;
        dbconnection db1 = new dbconnection();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText="insert into tb_teacher values(@a,@b,@c,@d,@e,@f,@g,@h,@i)";
        cmd.Parameters.AddWithValue("@a", TextBox1.Text);
        cmd.Parameters.AddWithValue("@b", TextBox2.Text);
        cmd.Parameters.AddWithValue("@c", DropDownList1.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@d", TextBox5.Text);
        cmd.Parameters.AddWithValue("@e", s);
        cmd.Parameters.AddWithValue("@f", TextBox4.Text);
        cmd.Parameters.AddWithValue("@g", TextBox6.Text);
        cmd.Parameters.AddWithValue("@h", TextBox7.Text);
        cmd.Parameters.AddWithValue("@i", TextBox8.Text);
        db1.execute(cmd);
        dbconnection db2 = new dbconnection();
        cmd.CommandText = "insert into login values(@u,@p,@t)";
        cmd.Parameters.AddWithValue("@u", TextBox6.Text);
        cmd.Parameters.AddWithValue("@p", TextBox7.Text);
        cmd.Parameters.AddWithValue("@t","Teacher");
        db2.execute(cmd);
        dbconnection db3 = new dbconnection();
        cmd.CommandText = "select tchr_id from tb_id";
        SqlDataReader dr = db1.executeread(cmd);
        dr.Read();
        int x = dr.GetInt32(0);
        x++;
        cmd.CommandText = "update tb_id set tchr_id=@y";
        cmd.Parameters.AddWithValue("@y", x);
        db3.execute(cmd);
        Response.Redirect("addteacher.aspx");
       
    }
    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
       
    }
}