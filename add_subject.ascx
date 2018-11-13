<%@ Control Language="C#" AutoEventWireup="true" CodeFile="add_subject.ascx.cs" Inherits="add_subject" %>
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
<div ><h1>Subject Management</h1><br />
    <table class="style1" >
        <tr>
            <td class="style2">
                <asp:Label ID="Label1" runat="server" Text="Subject Id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" Height="28px" 
                    style="margin-left: 0px" Width="280px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label2" runat="server" Text="Subject "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" Height="28px" 
                    style="margin-left: 0px" Width="280px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label3" runat="server" Text="Coure Id"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                    Height="27px" onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
                    Width="156px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label4" runat="server" Text="Course"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox10" runat="server" Height="28px" 
                    style="margin-left: 0px" Width="280px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <asp:Label ID="Label8" runat="server" Text="Department"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox11" runat="server" Height="28px" 
                    style="margin-left: 0px" Width="280px" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Label ID="Label6" runat="server" Text="Semester"></asp:Label>
            </td>
            <td class="style4">
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                    Height="27px" Width="156px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Label ID="Label9" runat="server" Text="Teacher Id"></asp:Label>
            </td>
            <td class="style4">
                <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" 
                    Height="27px" Width="156px" 
                    onselectedindexchanged="DropDownList3_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style3">
                <asp:Label ID="Label10" runat="server" Text="Teacher Name"></asp:Label>
            </td>
            <td class="style4">
                <asp:TextBox ID="TextBox9" runat="server" Height="28px" 
                    style="margin-left: 0px" Width="280px" ReadOnly="True" 
                    ></asp:TextBox>
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
                <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" 
                    style="height: 29px" /></th>
        </tr>
    </table>
    <br />
</div>