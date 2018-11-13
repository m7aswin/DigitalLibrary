<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Master.master" AutoEventWireup="true" CodeFile="addstaff.aspx.cs" Inherits="addteacher" %>

<%@ Register src="addstaff.ascx" tagname="addteacher" tagprefix="uc1" %>

<%@ Register src="addstaff.ascx" tagname="addstaff" tagprefix="uc2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc2:addstaff ID="addstaff1" runat="server" />
</asp:Content>

