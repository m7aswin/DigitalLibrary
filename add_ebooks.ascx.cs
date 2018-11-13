using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class add_ebooks : System.Web.UI.UserControl
{
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {
        dbconnection db = new dbconnection();
        cmd.CommandText = "select ebk_id from tb_id ";
        SqlDataReader dr = db.executeread(cmd);
        dr.Read();
        int id = dr.GetInt32(0);
        id++;
        String eid = "EBKID" + id.ToString();
        TextBox1.Text = eid;
        if (!IsPostBack)
        {
            dbconnection db1 = new dbconnection();
            cmd.CommandText = "select distinct stream from tb_course";
            SqlDataReader dr1 = db1.executeread(cmd);
            DropDownList1.Items.Add("--Select--");
            while (dr1.Read())
            {
                String s = dr1.GetString(0);
                DropDownList1.Items.Add(s);
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbconnection db = new dbconnection();
        cmd.CommandText = "select ebk_id from tb_id";
        SqlDataReader dr = db.executeread(cmd);
        dr.Read();
        int id = dr.GetInt32(0);
        id++;
        dbconnection db1 = new dbconnection();
        cmd.CommandText = "update tb_id set ebk_id=@d";
        cmd.Parameters.AddWithValue("@d", id);
        db1.execute(cmd);
        FileUpload1.SaveAs(Server.MapPath(@"~\ebooks\" + FileUpload1.FileName.ToString()));
        string a = FileUpload1.FileName.ToString();
        dbconnection db7 = new dbconnection();
        
       
        cmd.CommandText = "insert into tb_ebook values(@a,@b,@v,@c,@f,@g,@h,@i,@j)";
        cmd.Parameters.AddWithValue("@a",TextBox1.Text);
        cmd.Parameters.AddWithValue("@b",DropDownList1.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@v", TextBox8.Text);
        cmd.Parameters.AddWithValue("@c",TextBox3.Text);
        cmd.Parameters.AddWithValue("@f",TextBox4.Text);
        cmd.Parameters.AddWithValue("@g",Convert.ToInt32(TextBox5.Text));
        cmd.Parameters.AddWithValue("@h",Convert.ToInt32(TextBox6.Text));
        cmd.Parameters.AddWithValue("@i",a);
        cmd.Parameters.AddWithValue("@j",TextBox7.Text);
        db7.execute(cmd);
        Response.Redirect("add_ebooks.aspx");
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}