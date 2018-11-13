<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Master.master" AutoEventWireup="true" CodeFile="add_qp.aspx.cs" Inherits="add_qp" %>

<%@ Register src="add_qp.ascx" tagname="add_qp" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:add_qp ID="add_qp1" runat="server" />
</asp:Content>

