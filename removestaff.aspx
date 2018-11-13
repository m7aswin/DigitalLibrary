<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Master.master" AutoEventWireup="true" CodeFile="removestaff.aspx.cs" Inherits="removeteacher" %>

<%@ Register src="removestaff.ascx" tagname="removeteacher" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:removeteacher ID="removeteacher1" runat="server" />
</asp:Content>

