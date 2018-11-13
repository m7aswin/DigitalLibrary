<%@ Page Title="" Language="C#" MasterPageFile="~/Student_Master.master" AutoEventWireup="true" CodeFile="viewebooks.aspx.cs" Inherits="viewebooks" %>

<%@ Register src="viewebooks.ascx" tagname="viewebooks" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:viewebooks ID="viewebooks1" runat="server" />
</asp:Content>

