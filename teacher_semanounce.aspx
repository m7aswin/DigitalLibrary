<%@ Page Title="" Language="C#" MasterPageFile="~/Teacher_Master.master" AutoEventWireup="true" CodeFile="teacher_semanounce.aspx.cs" Inherits="teacher_semanounce" %>

<%@ Register src="teacher_semanounce.ascx" tagname="teacher_semanounce" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:teacher_semanounce ID="teacher_semanounce1" runat="server" />
</asp:Content>

