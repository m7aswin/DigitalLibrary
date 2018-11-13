using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class teacher_semanounce : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String uid = Session["tid"].ToString();
        dbconnection db = new dbconnection();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select sem_topic_id from tb_id";
        SqlDataReader dr = db.executeread(cmd);
        dr.Read();
        int y = dr.GetInt32(0);
        y++;
        String cid = "SEMTOPIC" + y.ToString();
        TextBox1.Text = cid;

        dbconnection db5 = new dbconnection();
        cmd.CommandText = "select name from tb_teacher where tchr_id=@q";
        cmd.Parameters.AddWithValue("@q", uid);
        SqlDataReader dr1 = db5.executeread(cmd);
        dr1.Read();
        String name = dr1.GetString(0);
        TextBox2.Text = uid;
        TextBox3.Text = name;
        if (!IsPostBack)
        {
            dbconnection db6 = new dbconnection();
            cmd.CommandText = "select distinct course from tb_course";
            SqlDataReader dr2 = db6.executeread(cmd);
            DropDownList1.Items.Add("--Select Course--");
            DropDownList2.Items.Add("--Select Department--");
            DropDownList3.Items.Add("--Select Semester--");
            DropDownList4.Items.Add("--Select Subject--");
            while (dr2.Read())
            {
                String x = dr2[0].ToString();
                DropDownList1.Items.Add(x);
            }
        }
        TextBox7.Text = DateTime.Now.ToShortDateString();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        String cr = DropDownList1.SelectedItem.Text;
        DropDownList2.Items.Clear();
        dbconnection dbc = new dbconnection();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select distinct stream from tb_course where course=@d";
        cmd.Parameters.AddWithValue("@d", cr);
        SqlDataReader dr = dbc.executeread(cmd);
        DropDownList2.Items.Add("--Select Department--");
        while (dr.Read())
        {
            String x = dr[0].ToString();
            DropDownList2.Items.Add(x);
        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList3.Items.Clear();
        DropDownList3.Items.Add("--Select Semester--");
        dbconnection db = new dbconnection();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select course_id,no_sem from tb_course where course=@d and stream=@f";
        cmd.Parameters.AddWithValue("@d", DropDownList1.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@f", DropDownList2.SelectedItem.Text);
        SqlDataReader dr = db.executeread(cmd);
        dr.Read();
        int n = dr.GetInt32(1);
        for (int i = 1; i <= n; i++)
        {
            DropDownList3.Items.Add(i.ToString());
        }
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        String s = DropDownList1.SelectedItem.Text;
        String c = DropDownList2.SelectedItem.Text;
        String n = DropDownList3.SelectedItem.Text;
        DropDownList4.Items.Clear();
        dbconnection db2 = new dbconnection();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select course_id from tb_course where course=@d and stream=@f";
        cmd.Parameters.AddWithValue("@d", DropDownList1.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@f", DropDownList2.SelectedItem.Text);
        SqlDataReader drr = db2.executeread(cmd);
        drr.Read();
        String id = drr.GetString(0);
        dbconnection dbc = new dbconnection();
        cmd.CommandText = "select subject from tb_subject where crs_id=@id and sem=@g";
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@g", n);
        SqlDataReader dr = dbc.executeread(cmd);
        DropDownList4.Items.Add("--Select Subject--");
        while (dr.Read())
        {
            String x = dr[0].ToString();
            DropDownList4.Items.Add(x);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        dbconnection db2 = new dbconnection();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select course_id from tb_course where course=@cr and stream=@st";
        cmd.Parameters.AddWithValue("@cr", DropDownList1.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@st", DropDownList2.SelectedItem.Text);
        SqlDataReader drr = db2.executeread(cmd);
        drr.Read();
        String id = drr.GetString(0);
        dbconnection db1 = new dbconnection();
        cmd.CommandText = "select sub_id from tb_subject where crs_id=@crs and sem=@sem and subject=@sub";
        cmd.Parameters.AddWithValue("@crs", id);
        cmd.Parameters.AddWithValue("@sem", DropDownList3.SelectedItem.Text);
        cmd.Parameters.AddWithValue("@sub", DropDownList4.SelectedItem.Text);
        SqlDataReader drs = db1.executeread(cmd);
        drs.Read();
        String subid = drs.GetString(0);
        
        dbconnection db7 = new dbconnection();

        cmd.CommandText = "insert into tb_semtopic values(@a,@b,@c,@d,@e,@f,@h)";
        cmd.Parameters.AddWithValue("@a", TextBox1.Text);
        cmd.Parameters.AddWithValue("@b", TextBox2.Text);
        cmd.Parameters.AddWithValue("@c", subid);
        cmd.Parameters.AddWithValue("@d", TextBox7.Text);
        cmd.Parameters.AddWithValue("@e", TextBox4.Text);
        cmd.Parameters.AddWithValue("@f", TextBox8.Text);
        cmd.Parameters.AddWithValue("@h", TextBox5.Text);
        db7.execute(cmd);
        dbconnection db = new dbconnection();
        cmd.CommandText = "select sem_topic_id from tb_id";
        SqlDataReader dr = db.executeread(cmd);
        dr.Read();
        int y = dr.GetInt32(0);
        y++;
        dbconnection db4 = new dbconnection();
        cmd.CommandText = "update tb_id set sem_topic_id=@idd";
        cmd.Parameters.AddWithValue("@idd", y);
        db4.execute(cmd);
        Response.Redirect("teacher_semanounce.aspx");
    }
}