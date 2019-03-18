<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Store.Master" 
    AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" 
    Inherits="SportsStore.Pages.Checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContent" runat="server">
    <div id="content">
        <div id="checkoutForm" runat="server" class="checkout">
            <h2>Checkout now</h2>
            Please enter your details, and we'll ship your goods right away!

            <div id="errors">
                <asp:validationsummary runat="server" />
            </div>

            <h3>Ship to</h3>
            <div>
                <label for="name">Name:</label>
                <input id="name" name="name" />
            </div>

            <h3>Address</h3>
            <div><label for="line1">Line 1:</label><input id="line1" name="line1" /></div>
            <div><label for="line2">Line 2:</label><input id="line2" name="line2" /></div>
            <div><label for="line3">Line 3:</label><input id="line3" name="line3" /></div>
            <div><label for="city">City:</label><input id="city" name="city" /></div>
            <div><label for="state">State:</label><input id="state" name="state" /></div>
        </div>
    </div>
</asp:Content>
