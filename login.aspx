<%@ Page Title="" Language="C#" MasterPageFile="~/Home_Master.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<%@ Register src="login.ascx" tagname="login" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:login ID="login1" runat="server" />
</asp:Content>

