<%@ Control Language="C#" AutoEventWireup="true" CodeFile="addqp.ascx.cs" Inherits="addqp" %>
<asp:Label ID="Label1" runat="server" Text="QP ID"></asp:Label>
&nbsp;
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<br />
<asp:Label ID="Label2" runat="server" Text="Stream"></asp:Label>
&nbsp;
<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
</asp:DropDownList>
<br />
<asp:Label ID="Label3" runat="server" Text="Semester"></asp:Label>
&nbsp;
<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
    onselectedindexchanged="DropDownList2_SelectedIndexChanged">
</asp:DropDownList>
<br />
<asp:Label ID="Label4" runat="server" Text="Subject"></asp:Label>
&nbsp;
<asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True">
</asp:DropDownList>
<br />
<asp:Label ID="Label5" runat="server" Text="QP"></asp:Label>
&nbsp;
<asp:FileUpload ID="FileUpload1" runat="server" />
<br />
<asp:Label ID="Label6" runat="server" Text="Year"></asp:Label>
<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
<br />
<p>
    <asp:Button ID="Button1" runat="server" Text="Button" />
</p>
<p>
    &nbsp;</p>

