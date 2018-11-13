using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class add_qp : System.Web.UI.UserControl
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
        String id= "QPEXM" + x.ToString();
        TextBox1.Text = id;
        if(!IsPostBack)
        {
        dbconnection db1 = new dbconnection();
        cmd.CommandText = "select crs_id from  tb_subject";
        SqlDataReader dr1 = db1.executeread(cmd);
        DropDownList1.Items.Add("--Select Course Id--");
        DropDownList2.Items.Add("--Select Semester--");
        DropDownList3.Items.Add("--Select Subject--");
        while (dr1.Read())
        {
            DropDownList1.Items.Add(dr1[0].ToString());
        }
        }
        TextBox7.Text = DateTime.Now.ToShortDateString();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        FileUpload1.SaveAs(Server.MapPath(@"~\qp\" + FileUpload1.FileName.ToString()));
        String str = FileUpload1.FileName.ToString();
        dbconnection db = new dbconnection();
        cmd.CommandText = "insert into tb_qp values(@a,@b,@c,@d,@e,@f)";
        cmd.Parameters.AddWithValue("@a",TextBox1.Text);
        cmd.Parameters.AddWithValue("@b",DropDownList1.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@c",DropDownList3.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@d",TextBox7.Text);
        cmd.Parameters.AddWithValue("@e",str);
        cmd.Parameters.AddWithValue("@f",TextBox8.Text);
        db.execute(cmd);
        dbconnection db1 = new dbconnection();
        cmd.CommandText = "select qp_id from tb_id";
        SqlDataReader dr = db1.executeread(cmd);
        dr.Read();
        int x = dr.GetInt32(0);
        dbconnection db2 = new dbconnection();
        cmd.CommandText = "update tb_id set qp_id=@x";
        cmd.Parameters.AddWithValue("@x", x++);
        db2.execute(cmd);
        Response.Redirect("add_qp.aspx");
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnection db = new dbconnection();
        cmd.CommandText = "select course,stream,no_sem from tb_course where course_id=@d";
        cmd.Parameters.AddWithValue("@d", DropDownList1.SelectedItem.Text);
        SqlDataReader dr = db.executeread(cmd);
        dr.Read();
        TextBox3.Text = dr.GetString(0);
        TextBox4.Text = dr.GetString(1);
        DropDownList2.Items.Clear();
        DropDownList2.Items.Add("--Select Semester--");
        int n = dr.GetInt32(2);
        for (int i = 1; i <= n; i++)
        {
            DropDownList2.Items.Add(i.ToString());
        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        dbconnection db = new dbconnection();
        cmd.CommandText = "select subject from tb_subject where crs_id=@a and sem=@b";
        cmd.Parameters.AddWithValue("@a", DropDownList1.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@b",Convert.ToInt32(DropDownList2.SelectedItem.Text));
        SqlDataReader dr = db.executeread(cmd);
        DropDownList3.Items.Clear();
        DropDownList3.Items.Add("--Select Subject--");
        while (dr.Read())
        {
            DropDownList3.Items.Add(dr[0].ToString());
        }
    }
    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {

    }
}