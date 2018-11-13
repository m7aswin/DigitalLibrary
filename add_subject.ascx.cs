using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class add_subject : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlCommand cmd = new SqlCommand();
            DropDownList1.Items.Add("--Select--");
            DropDownList2.Items.Add("--Select--");
            DropDownList3.Items.Add("--Select--");
            dbconnection db1 = new dbconnection();
            cmd.CommandText = "select  course_id from tb_course ";
            SqlDataReader dr1 = db1.executeread(cmd);
            while (dr1.Read())
            {
                String s = dr1[0].ToString();
                DropDownList1.Items.Add(s);
            }
            dbconnection db2 = new dbconnection();
            cmd.CommandText = "select  teacher_id from tb_teacher ";
            SqlDataReader dr2 = db2.executeread(cmd);
            while (dr2.Read())
            {
                String s = dr2[0].ToString();
                DropDownList3.Items.Add(s);
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        dbconnection db2 = new dbconnection();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "insert into tb_subject values(@a,@b,@c,@e,@f,@g)";
        cmd.Parameters.AddWithValue("@a",TextBox1.Text);
        cmd.Parameters.AddWithValue("@b",TextBox2.Text);
        cmd.Parameters.AddWithValue("@c",DropDownList1.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@e",Convert.ToInt32(DropDownList2.SelectedItem.Text));
        cmd.Parameters.AddWithValue("@f",DropDownList3.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@g",TextBox8.Text);
        db2.execute(cmd);
        Response.Redirect("add_subject.aspx");
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList2.Items.Clear();
        DropDownList2.Items.Add("--Select--");
        dbconnection db1 = new dbconnection();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select course,dept,no_sem from tb_course where course_id=@d";
        cmd.Parameters.AddWithValue("@d", DropDownList1.SelectedItem.Text);
        SqlDataReader dr1 = db1.executeread(cmd);
        dr1.Read();
        TextBox10.Text = dr1.GetString(0);
        TextBox11.Text = dr1.GetString(1);
        int n = dr1.GetInt32(2);
        for(int i=1;i<=n;i++)
        {
            DropDownList2.Items.Add(i.ToString());
        }
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnection db = new dbconnection();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select name from tb_teacher where teacher_id=@d";
        cmd.Parameters.AddWithValue("@d", DropDownList3.SelectedItem.Text);
        SqlDataReader dr = db.executeread(cmd);
        dr.Read();
        TextBox9.Text = dr.GetString(0);
    }
}