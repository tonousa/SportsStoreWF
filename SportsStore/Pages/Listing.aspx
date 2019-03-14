﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="/Pages/Store.Master" CodeBehind="Listing.aspx.cs" Inherits="SportsStore.Pages.Listing" %>
<%@ Import Namespace="System.Web.Routing" %>

    <asp:Content ContentPlaceHolderID="bodyContent" runat="server" >
    <div id="content">
        <%--<%foreach (SportsStore.Models.Product prod in GetProducts())
          {--%>
        <asp:Repeater ItemType="SportsStore.Models.Product" SelectMethod="GetProducts" 
            runat="server">
            <ItemTemplate>
              <div class='item'>
                <h3><%# Item.Name %></h3>
                <%# Item.Description %>
                <h4><%# Item.Price.ToString("c") %></h4>
                <button name='add' type='submit'"
                    value='<%# Item.ProductID %>'>Add to Cart</button>
              </div>    
            </ItemTemplate>
        </asp:Repeater>
        <%--  } %>--%>
    </div>
    

    <div class="pager">
        <% for (int i = 1; i <= MaxPage; i++)
           {
               string path = RouteTable.Routes.GetVirtualPath(null, null,
                   new RouteValueDictionary() { { "page", i } }).VirtualPath;
               Response.Write(
                   string.Format("<a href='/pages/Listing.aspx?page={0}' {1}>{2}</a>"
                   , i, i == CurrentPage ? "class='selected'" : "", i));
           }
            
             %>
    </div>
    </asp:Content>
