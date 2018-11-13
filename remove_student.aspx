<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Master.master" AutoEventWireup="true" CodeFile="remove_student.aspx.cs" Inherits="remove_student" %>

<%@ Register src="remove_student.ascx" tagname="remove_student" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:remove_student ID="remove_student1" runat="server" />
</asp:Content>

