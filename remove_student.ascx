<%@ Control Language="C#" AutoEventWireup="true" CodeFile="remove_student.ascx.cs" Inherits="remove_student" %>
<div><h3>Remove Student</h3></div>
<div>
    <asp:DropDownList ID="DropDownList1" runat="server" placeholder="Student Id" 
        AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList> </div>
    <div>
        <asp:TextBox ID="TextBox1" runat="server" placeholder="Name" ReadOnly="True"></asp:TextBox>
    </div>
    <div>
    <asp:TextBox ID="TextBox2" runat="server" placeholder="Course" ReadOnly="True"></asp:TextBox>
    </div>
    <div>
    <asp:TextBox ID="TextBox3" runat="server" placeholder="Department" ReadOnly="True"></asp:TextBox>
    </div>
   
    <div>
     <asp:TextBox ID="TextBox4" runat="server" placeholder="Sem" ReadOnly="True"></asp:TextBox>
    </div>
    
    <div>
    <asp:Button ID="Button1" runat="server" Text="Remove" onclick="Button1_Click" />       
    </div>
