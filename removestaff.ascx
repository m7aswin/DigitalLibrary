<%@ Control Language="C#" AutoEventWireup="true" CodeFile="removestaff.ascx.cs" Inherits="removeteacher" %>
<style type="text/css">
    .style1
    {
        width: 51%;
        height: 356px;
    }
    .style2
    {
        width: 732px;
    }
    .style3
    {
        width: 731px;
    }
</style>
<div align="center">
<h1>Teacher Management</h1><br />
    <table class="style1">
        <tr>
            <td class="style3">
                <asp:Label ID="Label1" runat="server" Text="Teacher Id"></asp:Label>
            </td>
            <td class="style2">
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="TextBox1" runat="server" Height="28px" Width="257px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Label ID="Label3" runat="server" Text="Department"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="TextBox2" runat="server" Height="28px" Width="257px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Label ID="Label4" runat="server" Text="Status"></asp:Label>
            </td>
            <td class="style2">
                <asp:TextBox ID="TextBox3" runat="server" Height="28px" Width="257px" 
                    ForeColor="Red"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <th class="style3" colspan=2>
                <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Sustain" 
                    Visible="False" />
                <asp:Button ID="Button1" runat="server" Text="Suspend" 
                    onclick="Button1_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" Text="Remove" onclick="Button2_Click" />
            </th>
            
        </tr>
    </table>
</div>