<%@ Page Title="" Language="C#" MasterPageFile="~/Librarian_Master.master" AutoEventWireup="true" CodeFile="add_ebooks.aspx.cs" Inherits="add_ebooks" %>

<%@ Register src="add_ebooks.ascx" tagname="add_ebooks" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:add_ebooks ID="add_ebooks1" runat="server" />
</asp:Content>

