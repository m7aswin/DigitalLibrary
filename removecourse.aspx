<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Master.master" AutoEventWireup="true" CodeFile="removecourse.aspx.cs" Inherits="removecourse" %>

<%@ Register src="removecourse.ascx" tagname="removecourse" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:removecourse ID="removecourse1" runat="server" />
</asp:Content>

