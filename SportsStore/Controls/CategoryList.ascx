<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CategoryList.ascx.cs" 
    Inherits="SportsStore.Controls.CategoryList" %>

<%=CreateHomeLinkHtml() %>

<% foreach (string cate in GetCategories())
   {
       Response.Write(CreateLinkHtml(cate));
   }
     %>