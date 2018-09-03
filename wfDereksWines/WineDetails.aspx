<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WineDetails.aspx.cs" Inherits="wfDereksWines.WineDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section>
        <asp:FormView ID="WineFormView" runat="server" 
            ItemType="wfDereksWines.Models.Wine" 
            SelectMethod="GetWine">
            <ItemTemplate>
                <section class="jumbotron">
                    <h1><%#:Item.Producer %> <%#:Item.Name %></h1>
                </section>
                <section>
                    <img src="/Images/<%#Item.ImagePath %>" style="width:100px" />
                        <p class="card-text">
                            <%# Item.Description %>
                        </p>
                        <a href="/AddToCart.aspx?WineID=<%#:Item.WineID %>" class="btn btn-primary">Add to Cart</a>
                </section>
            </ItemTemplate>
        </asp:FormView>
    </section>
</asp:Content>
