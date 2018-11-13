<%@ Control Language="C#" AutoEventWireup="true" CodeFile="removesubject.ascx.cs" Inherits="removesubject" %>
<asp:Label ID="Label1" runat="server" Text="Subject_Id"></asp:Label>
<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
</asp:DropDownList>
<br />
<br />
<asp:Label ID="Label2" runat="server" Text="Course"></asp:Label>
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<br />
<br />
<asp:Label ID="Label3" runat="server" Text="Department"></asp:Label>
<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
<br />
<br />
<asp:Label ID="Label4" runat="server" Text="Semester"></asp:Label>
<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
<br />
<br />
<asp:Label ID="Label5" runat="server" Text="Subject"></asp:Label>
<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
<br />
<br />
<p>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Remove" />
</p>

