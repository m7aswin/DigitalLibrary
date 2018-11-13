<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher_Master.master" AutoEventWireup="true" CodeFile="teacher_addnote.aspx.cs" Inherits="teacher_addnote" %>

<%@ Register src="teacher_addnote.ascx" tagname="teacher_addnote" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:teacher_addnote ID="teacher_addnote1" runat="server" />
</asp:Content>

