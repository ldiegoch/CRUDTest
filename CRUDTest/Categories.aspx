<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Categories.aspx.cs" Inherits="CRUDTest.Categories" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <div class="table-header">
            <h1>Categories</h1>
            <asp:LinkButton runat="server" PostBackUrl="~/New.aspx" CssClass="btn btn-sm btn-warning filter">Create</asp:LinkButton>
        </div>
        <asp:GridView ID="CategoriesGrid" runat="server" CssClass="table table-bordered" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" HeaderStyle-Width="40px" ReadOnly="true" />
                <asp:BoundField DataField="Name" HeaderText="Nombre" />
                <asp:CheckBoxField DataField="IsActive" HeaderText="Activa" HeaderStyle-Width="50px" ItemStyle-CssClass="content-center" />
                <asp:TemplateField HeaderText="Acciones" ItemStyle-CssClass="content-center" HeaderStyle-Width="150px">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" CommandArgument='<%# Eval("Id") %>'
                            OnClick="Editar_Click" CssClass="btn btn-sm btn-primary"> Editar</asp:LinkButton>
                        <asp:LinkButton runat="server" CommandArgument='<%# Eval("Id") %>'
                            OnClick="Eliminar_Click" CssClass="btn btn-sm btn-danger" OnClientClick="return confirm('Desea eliminar?')"> Eliminar</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </main>
</asp:Content>
