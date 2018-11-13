<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Master.master" AutoEventWireup="true" CodeFile="removesubject.aspx.cs" Inherits="removesubject" %>

<%@ Register src="removesubject.ascx" tagname="removesubject" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:removesubject ID="removesubject1" runat="server" />
</asp:Content>

