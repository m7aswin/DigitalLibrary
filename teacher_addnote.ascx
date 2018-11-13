<%@ Control Language="C#" AutoEventWireup="true" CodeFile="teacher_addnote.ascx.cs" Inherits="t_note_add" %>


<div align="center">
         <div>
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Note Id"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="TextBox2" runat="server" placeholder="Teacher Id"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="TextBox3" runat="server" placeholder="Name"></asp:TextBox>
        </div>
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
                AutoPostBack="True" placeholder="Course">
            </asp:DropDownList>
        </div>
        <div>
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList2_SelectedIndexChanged" placeholder="Department">
            </asp:DropDownList>
       </div>
       <div>
            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" 
                onselectedindexchanged="DropDownList3_SelectedIndexChanged" placeholder="Semester">
            </asp:DropDownList>
       </div>
       <div>
            <asp:DropDownList ID="DropDownList4" runat="server">
            </asp:DropDownList>
       </div>
       <div>
            <asp:TextBox ID="TextBox7" runat="server" placeholder="Date"></asp:TextBox>
        </div>
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
        </div>
        <div>
            <asp:TextBox ID="TextBox8" runat="server" placeholder="Remark"></asp:TextBox>
       </div>
       <div>
           
            <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
        </div>
        </div>

