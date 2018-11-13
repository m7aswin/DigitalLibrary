<%@ Control Language="C#" AutoEventWireup="true" CodeFile="removecourse.ascx.cs" Inherits="removecourse" %>
<style type="text/css">
    .style1
    {
        width: 51%;
    }
</style>
<div align=center>
<h1>Removing Course</h1><br />
    <table class="style1" bgcolor="#CCFFCC">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Course Id"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Department"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Width="201px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Course"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Width="201px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <th colspan=2>
                <asp:Button ID="Button1" runat="server" Text="Remove" onclick="Button1_Click" /></th>
        </tr>
    </table>
    <br />
</div>