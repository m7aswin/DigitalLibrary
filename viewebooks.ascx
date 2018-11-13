<%@ Control Language="C#" AutoEventWireup="true" CodeFile="viewebooks.ascx.cs" Inherits="viewebooks" %>
<asp:Label ID="Label1" runat="server" Text="BOOK NAME"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button1" runat="server" Text="Search" onclick="Button1_Click" />
&nbsp;&nbsp;
<asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
    Text="Advance Search" />
<br />


<asp:Panel ID="Panel1" runat="server" Height="282px" Visible="False" 
    Width="445px">
&nbsp;<br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="Category"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged1" 
        >
    </asp:DropDownList>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label3" runat="server" Text="Subject"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="DropDownList2" runat="server" 
         
        AutoPostBack="True">
    </asp:DropDownList>
    <br />
    &nbsp;&nbsp;&nbsp;
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" Text="Search" onclick="Button3_Click" />
</asp:Panel>



 <asp:DataList ID="DataList1" runat="server" CellPadding="4" 
                onitemcommand="DataList1_ItemCommand" Height="299px" Width="652px" 
                ForeColor="#333333"  
                >
                <AlternatingItemStyle BackColor="White" />
                <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderTemplate>
                    <table class="style4">
                        <tr>
                            <td>
                                <asp:Label ID="Label5" runat="server" Text="EBookID"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label7" runat="server" Text="Book"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="Author"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label6" runat="server" Text="Publisher"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label8" runat="server" Text="Version"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label9" runat="server" Text="Request"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </HeaderTemplate>
                <ItemStyle BackColor="#E3EAEB" />
                <ItemTemplate>
                <table class="style4">
                        <tr>
                            <td>
                                <%# Eval("ebk_id") %>
                            </td>
                            <td>
                                <%# Eval("bkname") %>
                            </td>
                            <td>
                                <%# Eval("author") %>
                            </td>
                            <td>
                                <%# Eval("publisher") %>
                            </td>
                            <td>
                                <%# Eval("version") %>
                            </td>
                            <td>
                                <asp:Button ID="Button1" runat="server" Text="Request" commandargument='<%# Eval("ebk_id") %>' CommandName="Request" />
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
                <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            </asp:DataList>




