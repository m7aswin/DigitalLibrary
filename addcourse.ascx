<%@ Control Language="C#" AutoEventWireup="true" CodeFile="addcourse.ascx.cs" Inherits="addcourse" %>

<h3>Course Details</h3>

<form method="post" action="#">
<div class="row uniform">
                
          <div class="12u$">
                <asp:TextBox ID="TextBox1" runat="server"  ReadOnly="True" placeholder="Course Id"></asp:TextBox>
           </div> 
                <!-- Break -->
            <div class="12u$">
                <asp:TextBox ID="TextBox2" runat="server"  placeholder="Course Name"></asp:TextBox>
           </div>
                
           <div class="12u$">
            <asp:TextBox ID="TextBox3" runat="server"  placeholder="No of Semester"></asp:TextBox>
           </div>
               
           
                
           <div class="12u$">
                <asp:TextBox ID="TextBox4" runat="server"  placeholder="No of Semester"></asp:TextBox>
           </div>
           <div >
                <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" />
           </div>   
</div>
</form>
