<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Master.master" AutoEventWireup="true" CodeFile="add_student.aspx.cs" Inherits="add_student" %>

<%@ Register src="add_student.ascx" tagname="add_student" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:add_student ID="add_student1" runat="server" />
</asp:Content>

