<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="SportsStore.Pages.Admin.Products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ListView runat="server" ItemType="SportsStore.Models.Product" 
        SelectMethod="GetProducts" DataKeyNames="ProductID" UpdateMethod="UpdateProduct" 
        DeleteMethod="DeleteProduct" InsertMethod="InsertProduct" 
        InsertItemPosition="LastItem" EnableViewState="false">
        <LayoutTemplate>
            <div class="outerContainer">
                <table id="productsTable">
                    <tr>
                        <th>Name</th>
                        <th>Description</th>
                        <th>Category</th>
                        <th>Price</th>
                    </tr>
                    <tr runat="server" id="itemPlaceholder"></tr>
                </table>
            </div>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%# Item.Name %></td>
                <td class="description"><span><%# Item.Description %></span></td>
                <td><%# Item.Category %></td>
                <td><%# Item.Price.ToString("c") %></td>
                <td>

                </td>
            </tr>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
