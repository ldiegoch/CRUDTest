<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CRUDTest._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="row">
            <div>
                <h1>Productos</h1>
                <asp:DropDownList runat="server" ID="DropDownCategories" Height="30px" Width="250px" OnSelectedIndexChanged="DropDownCategories_SelectedIndexChanged" AutoPostBack="true">
                </asp:DropDownList>
            </div>

            <asp:GridView ID="Products" runat="server" CssClass="table table-bordered" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Nombre" />
                    <asp:BoundField DataField="Price" HeaderText="Precio" DataFormatString="{0:C}" />
                    <asp:BoundField DataField="CategoryName" HeaderText="CategoryName" />
                </Columns>

            </asp:GridView>
        </div>
    </main>

</asp:Content>
