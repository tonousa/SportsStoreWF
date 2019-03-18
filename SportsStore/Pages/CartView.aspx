﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CartView.aspx.cs" Inherits="SportsStore.Pages.CartView" MasterPageFile="~/Pages/Store.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContent" runat="server">
    <div id="content">
        <table id="cartTable">
            <thead>
                <tr>
                    <th>Quantity</th>
                    <th>Item</th>
                    <th>Price</th>
                    <th>SubTotal</th>
                </tr>
            </thead>
            <tbody>
            <asp:Repeater ItemType="SportsStore.Models.CartLine" 
                SelectMethod="GetCartLines" runat="server" EnableViewState="false">
                <ItemTemplate>
                    <tr>
                        <td><%# Item.Quantity%></td>
                        <td><%# Item.Product.Name%></td>
                        <td><%# Item.Product.Price.ToString("c")%></td>
                        <td><%# (Item.Quantity * 
                                    Item.Product.Price).ToString("c")%></td>
                        <td><button type="submit" name="remove" class="actionButtons"
                            value="<%# Item.Product.ProductID %>">Remove</button></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            </tbody>
            <tfoot>
                <tr>
                    <td colspan="3">Total:</td>
                    <td><%= CartTotal.ToString("c") %></td>
                </tr>
            </tfoot>
        </table>
        <p class="actionButtons">
            <a href="<%= ReturnUrl %>">Continue Shopping</a>
            <a href="<%= CheckoutUrl %>">Checkout</a>
        </p>
    </div>
</asp:Content>