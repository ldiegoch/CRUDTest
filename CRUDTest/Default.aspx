<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CRUDTest._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="row">
            <div class="table-header">
                <h1>Productos</h1>
                <label class="filter" for="DropDownCategories">
                    Categoria: 
                 <asp:DropDownList runat="server" ID="DropDownCategories" Height="30px" Width="250px" OnSelectedIndexChanged="DropDownCategories_SelectedIndexChanged" AutoPostBack="true">
                 </asp:DropDownList>
                </label>
            </div>

            <asp:GridView ID="Products" runat="server" CssClass="table table-bordered" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" HeaderStyle-Width="40px" />
                    <asp:BoundField DataField="Name" HeaderText="Nombre" />
                    <asp:BoundField DataField="Price" HeaderText="Precio" DataFormatString="{0:n2}" HeaderStyle-Width="15%" ItemStyle-CssClass="price" />
                    <asp:BoundField DataField="CategoryName" HeaderText="CategoryName" HeaderStyle-Width="30%" />
                </Columns>
                <EmptyDataTemplate>No encontramos productos asociados</EmptyDataTemplate>
            </asp:GridView>
        </div>
    </main>

</asp:Content>
