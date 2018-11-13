using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class viewebooks : System.Web.UI.UserControl
{
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownList1.Items.Add("--Select--");
            DropDownList2.Items.Add("--Select--");
            dbconnection db = new dbconnection();
            cmd.CommandText = "select distinct category from tb_ebook";
            SqlDataReader dr = db.executeread(cmd);
            while (dr.Read())
            {
                String s = dr[0].ToString();
                DropDownList1.Items.Add(s);
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Enabled = false;
        Panel1.Visible = true;
    }
   
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if(e.CommandName=="Request")
        {
            String ebkid = e.CommandArgument.ToString();
            dbconnection db = new dbconnection();
            cmd.CommandText = "select status from tb_ebook where ebk_id=@d";
            cmd.Parameters.AddWithValue("@d", ebkid);
            SqlDataReader dr = db.executeread(cmd);
            dr.Read();
            string status = dr.GetString(0);
            dbconnection db1 = new dbconnection();
            cmd.CommandText = "select req_id from tb_id";
            SqlDataReader dr1 = db1.executeread(cmd);
            dr1.Read();
            int id = dr1.GetInt32(0);
            id++;
            String reqid = "REQID" + id.ToString();
            String sid = Session["uid"].ToString();
            DateTime date = DateTime.Today;

            dbconnection db7 = new dbconnection();
            SqlCommand cmd7 = new SqlCommand();
            cmd7.CommandText = "insert into tblRequest values(@rno,@sid,@bid,@date,@status)";
            cmd7.Parameters.AddWithValue("@rno", reqid);
            cmd7.Parameters.AddWithValue("@sid", sid);
            cmd7.Parameters.AddWithValue("@bid", ebkid);
            cmd7.Parameters.AddWithValue("@date", date);
            cmd7.Parameters.AddWithValue("@status", status);
            db7.execute(cmd7);
            dbconnection db8 = new dbconnection();
            SqlCommand cmd8 = new SqlCommand();
            cmd8.CommandText = "update tb_id set req_id=@idd";
            cmd8.Parameters.AddWithValue("@idd", id);
            db8.execute(cmd8); 
        }
    }
  
    protected void Button1_Click(object sender, EventArgs e)
    {
        String str = TextBox1.Text;
        dbconnection db = new dbconnection();
        cmd.CommandText = "select * from tb_ebook where bkname=@n";
        cmd.Parameters.AddWithValue("@n", str);
        DataList1.DataSource = db.executeread(cmd);
        DataList1.DataBind();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        dbconnection db = new dbconnection();
        cmd.CommandText = "select * from tb_ebook where category=@a and subject=@b";
        cmd.Parameters.AddWithValue("@a", DropDownList1.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@b", DropDownList2.SelectedItem.Text);
        DataList1.DataSource = db.executeread(cmd);
        DataList1.DataBind();
    }
    protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        DropDownList2.Items.Clear();
        String s = DropDownList1.SelectedItem.Text;
        DropDownList2.Items.Add("--Select--");
        dbconnection db1 = new dbconnection();
        cmd.CommandText = "select subject from tb_ebook where category=@d";
        cmd.Parameters.AddWithValue("@d", s);
        SqlDataReader dr = db1.executeread(cmd);
        while (dr.Read())
        {
            String st = dr[0].ToString();
            DropDownList2.Items.Add(st);
        }
    }
}