<%@ Control Language="C#" AutoEventWireup="true" CodeFile="login.ascx.cs" Inherits="login" %>
<style type="text/css">
    .style1
    {
        width: 41%;
        height: 188px;
    }
    .style6
    {
        height: 70px;
        width: 155px;
    }
    .style7
    {
        height: 70px;
        width: 905px;
    }
    </style>
<div align=center>
    <p style="font-weight: bold; font-family: 'Goudy Old Style'; font-size: xx-large">User Login</p><br />
    <table class="style1" bgcolor="#FFCCCC">
        <tr>
            <th class="style6">
                <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            </th>
            <th class="style7">
                <asp:TextBox ID="TextBox1" runat="server" Width="265px" Height="30px"></asp:TextBox>
            </th>
        </tr>
        <tr>
            <th class="style6">
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            </th>
            <th class="style7">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="265px" 
                    Height="30px"></asp:TextBox>
            </th>
        </tr>
        <tr>
            <th colspan=2>
                &nbsp;</td>
            
                <asp:Button ID="Button1" runat="server" Text="Login" onclick="Button1_Click" 
                    style="height: 29px" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <asp:Label ID="Label3" runat="server" ForeColor="#FF0066" 
                    Text="*Invalid username or password" Visible="False"></asp:Label>
            
        </tr>
    </table><br />
</div>