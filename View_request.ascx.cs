using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class View_request : System.Web.UI.UserControl
{
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        dbconnection db = new dbconnection();
        cmd.CommandText = "select req_id,tb_request.std_id,tb_request.ebk_id,tb_ebook.bkname,author,category,tb_student.name,course,semester from tblRequest,tblBook,tblStudent where tblRequest.BookID=tblBook.BookID and tblRequest.StudentID=tblStudent.StudentID and tblRequest.Status=@state";
    }
}