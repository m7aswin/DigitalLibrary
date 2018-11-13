<%@ Control Language="C#" AutoEventWireup="true" CodeFile="add_ebooks.ascx.cs" Inherits="add_ebooks" %>
&nbsp;<asp:Label ID="Label1" runat="server" Text="Book Id"></asp:Label>
&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<p>
    &nbsp;</p>
&nbsp;&nbsp;
<asp:Label ID="Label8" runat="server" Text="Category"></asp:Label>
&nbsp;&nbsp;
<asp:DropDownList ID="DropDownList1" runat="server" 
    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
</asp:DropDownList>
<br />
<br />
<br />
<asp:Label ID="Label10" runat="server" Text="Subject"></asp:Label>
<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
<br />
<br />
<br />
<asp:Label ID="Label3" runat="server" Text="Author"></asp:Label>
&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
<p>
    &nbsp;</p>
<asp:Label ID="Label4" runat="server" Text="Publisher"></asp:Label>
&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
<p>
    &nbsp;</p>
&nbsp;<asp:Label ID="Label5" runat="server" Text="Version No"></asp:Label>
&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
<p>
    &nbsp;</p>
<asp:Label ID="Label6" runat="server" Text="Year"></asp:Label>
&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
<p>
    &nbsp;</p>
<asp:Label ID="Label7" runat="server" Text="Book"></asp:Label>
&nbsp;&nbsp;&nbsp;
<asp:FileUpload ID="FileUpload1" runat="server" />
<br />
<p>
    <asp:Label ID="Label9" runat="server" Text="Status"></asp:Label>
    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
</p>
<asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />

