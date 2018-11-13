<%@ Control Language="C#" AutoEventWireup="true" CodeFile="add_qp.ascx.cs" Inherits="add_qp" %>

<div align="center">
       <div>
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Question Id"></asp:TextBox>
       </div>
       <div>
            <asp:DropDownList ID="DropDownList1" runat="server" 
               
                AutoPostBack="True" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
       </div>
       <div>
            <asp:TextBox ID="TextBox3" runat="server" placeholder="Department"></asp:TextBox>
       </div>
       <div>
            <asp:TextBox ID="TextBox4" runat="server" placeholder="Course"></asp:TextBox>
        </div>
        <div>
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList2_SelectedIndexChanged">
            </asp:DropDownList>
       </div>
       <div>
           <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True">
           </asp:DropDownList>
       </div>
       <div>
            <asp:TextBox ID="TextBox7" runat="server" placeholder="Date" 
                ontextchanged="TextBox7_TextChanged"></asp:TextBox>
        </div>
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" placeholder="Question Paper"/>
       </div>
       <div>
            <asp:TextBox ID="TextBox8" runat="server" placeholder="Year"></asp:TextBox>
       </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
        </div>
    
    </div>