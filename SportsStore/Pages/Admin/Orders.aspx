﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="SportsStore.Pages.Admin.Orders" EnableViewState="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="outerContainer">
        <table>
            <tr>
                <th>Name</th><th>City</th><th>Items</th><th>Total</th><th></th>
                <asp:Repeater runat="server" SelectMethod="GetOrders" 
                    ItemType="SportsStore.Models.Order">
                    <ItemTemplate>
                        <tr>
                            <td><%: Item.Name %></td>
                            <td><%: Item.City %></td>
                            <td><%: Item.OrderLines.Sum(ol => ol.Quantity) %></td>
                            <td><%: Total(Item.OrderLines).ToStrin("C") %></td>
                            <td>
                                <asp:PlaceHolder Visible="<%# !Item.Dispatched %>" 
                                    runat="server">
                                    <button type="submit" name="dispatch" 
                                        value="<%# Item.OrderId %>">Dispatch</button>
                                </asp:PlaceHolder>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tr>
        </table>
    </div>
</asp:Content>
