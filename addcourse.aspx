﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin_Master.master" AutoEventWireup="true" CodeFile="addcourse.aspx.cs" Inherits="addcourse" %>

<%@ Register src="addcourse.ascx" tagname="addcourse" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <uc1:addcourse ID="addcourse1" runat="server" />
</asp:Content>

