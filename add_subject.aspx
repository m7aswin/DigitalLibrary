<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Master.master" AutoEventWireup="true" CodeFile="add_subject.aspx.cs" Inherits="add_subject" %>

<%@ Register src="add_subject.ascx" tagname="add_subject" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:add_subject ID="add_subject1" runat="server" />
</asp:Content>

