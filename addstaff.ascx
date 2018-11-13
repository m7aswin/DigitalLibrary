<%@ Control Language="C#" AutoEventWireup="true" CodeFile="addstaff.ascx.cs" Inherits="addteacher" %>
<style type="text/css">
    .style1
    {
        width: 52%;
        height: 451px;
    }
    .style2
    {
        width: 253px;
    }
    .style3
    {
        width: 253px;
        height: 50px;
    }
    .style4
    {
        height: 50px;
    }
</style>
<div ><h1>Staff Management</h1><br/>
    <table class="style1" >
        <tr>
            <td class="style2">
                <asp:Label ID="Label1" runat="server" Text="Satff Id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Height="28px" 
                    style="margin-left: 0px" Width="280px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Height="28px" 
                    style="margin-left: 0px" Width="280px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label3" runat="server" Text="Stream"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label9" runat="server" Text="Qualification"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server" Height="28px" 
                    style="margin-left: 0px" Width="280px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label8" runat="server" Text="Other Qualifiation"></asp:Label>
            </td>
            <td>
                <asp:CheckBox ID="CheckBox1" runat="server" Text="PHD" />
                <br />
                <asp:CheckBox ID="CheckBox2" runat="server" Text="MPHIL" />
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" Height="28px" 
                    style="margin-left: 0px" TextMode="MultiLine" Width="280px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Label ID="Label6" runat="server" Text="Email"></asp:Label>
            </td>
            <td class="style4">
                <asp:TextBox ID="TextBox6" runat="server" Height="28px" 
                    style="margin-left: 0px" Width="280px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label5" runat="server" Text="Phone"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server" Height="28px" 
                    style="margin-left: 0px" Width="280px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label7" runat="server" Text="Status"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox8" runat="server" Height="28px" 
                    style="margin-left: 0px" Width="280px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <th colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" /></th>
        </tr>
    </table>
    <br />
</div>

