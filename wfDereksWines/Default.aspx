<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="wfDereksWines._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Derek's Wines 2018</h1>
        <p><a href="#" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>
    <section>
        <asp:ListView ID="WinesListView" 
            ItemType="wfDereksWines.Models.Wine" 
            SelectMethod="GetAllWines"
            GroupItemCount ="3"
            runat="server">
            <ItemTemplate>
                <section class="col-lg card">
                    <article class="card-body">
                        <img src="/Images/<%#Item.ImagePath %>" style="width:100px" />
                        <h3 class="card-title">
                            <a href="WineDetails.aspx?WineID=<%#:Item.WineID %>">
                                <%# Item.Producer %>
                                <%# Item.Name %>
                            </a>
                        </h3>
                        <p class="card-text">
                            <%# Item.Description %>
                        </p>
                        <a href="/WineDetails.aspx?WineID=<%#:Item.WineID %>" class="btn btn-primary">View Details</a>
                        <br />
                        <br />
                    </article>
                </section>
            </ItemTemplate>
            <LayoutTemplate>
                  <div>
                      <asp:PlaceHolder ID="groupPlaceholder" runat="server"></asp:PlaceHolder>
                  </div>
                </div>
            </LayoutTemplate>
            <GroupTemplate>
                <section class="row">
                    <asp:PlaceHolder id="itemPlaceholder" runat="server"></asp:PlaceHolder>
                </section>
            </GroupTemplate>
        </asp:ListView>
    </section>

 <%--   <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>--%>

</asp:Content>
