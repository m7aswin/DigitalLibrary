<%@ Control Language="C#" AutoEventWireup="true" CodeFile="View_request.ascx.cs" Inherits="View_request" %>
<h2>View Request</h2>
<asp:DataList ID="DataList1" runat="server" 
    onitemcommand="DataList1_ItemCommand">
<AlternatingItemStyle BackColor="White" />
                                                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                        <HeaderTemplate>
                                                            <table class="style1">
                                                                <tr>
                                                                    <td>
                                                                        <asp:Label ID="Label3" runat="server" Text="Req No"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="Label5" runat="server" Text="Book ID"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="Label2" runat="server" Text="Book Name"></asp:Label>
                                                                    </td>
                                                                     
                                                       
                                                                    <td>
                                                                        <asp:Label ID="Label4" runat="server" Text="Author"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="Label7" runat="server" Text="Category"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="Label8" runat="server" Text="Student ID"></asp:Label>
                                                                    </td>
                                                                    <td>
                                                                        <asp:Label ID="Label9" runat="server" Text="Student Name"></asp:Label>
                                                                    </td>
                                                                     <td>
                                                                        <asp:Label ID="Label10" runat="server" Text="Course"></asp:Label>
                                                                    </td>
                                                       
                                                                    <td>
                                                                        <asp:Label ID="Label11" runat="server" Text="Semester"></asp:Label>
                                                                    </td>
                                                                     <td>
                                                                        <asp:Label ID="Label12" runat="server" Text="Issue"></asp:Label>
                                                                    </td>
                                                                   
                                                                </tr>
                                                            </table>
                                                        </HeaderTemplate>
                                                        <ItemStyle BackColor="#EFF3FB" />
                                                        <ItemTemplate>
                                                            <table class="style1">
                                                                <tr>
                                                                    <td>
                                                                        <%# Eval("RequestNo")%></td>
                                                                    <td>
                                                                        <%# Eval("BookID") %></td>
                                                                     <td>
                                                                        <%# Eval("Name") %></td>
                                                                        
                                                                    <td>
                                                                        <%# Eval("Author") %></td>
                                                                     <td>
                                                                        <%# Eval("Category") %></td>
                                                                         <td>
                                                                        <%# Eval("StudentID") %></td>
                                                                    <td>
                                                                        <%# Eval("Name") %></td>
                                                                     <td>
                                                                        <%# Eval("Course") %></td>
                                                                    <td>
                                                                        <%# Eval("Semester") %></td>
                                                                    <td>
                                                                        <a href="Librarian_ViewRequest.aspx?rno=<%# Eval("RequestNo")%> &sid=<%# Eval("StudentID")%> &bid=<%# Eval("BookID") %> &name=<%# Eval("Name") %> &book=<%# Eval("Book") %> ">Issue</a>
                                                                         </td>
                                                                </tr>
                                                            </table>
                                                        </ItemTemplate>
                                                        <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
</asp:DataList>