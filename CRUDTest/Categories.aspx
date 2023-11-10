<%@ Page Title="Categorías" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Categories.aspx.cs" Inherits="CRUDTest.Categories" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <div class="table-header">
            <h1>Categorías</h1>
            <asp:LinkButton ID="BtnCreate" runat="server" OnClick="BtnCreate_Click" CssClass="btn btn-sm btn-warning filter">Nueva Categoría</asp:LinkButton>
        </div>
        <asp:Panel ID="FormPanel" runat="server" Visible="false">
            <asp:Label ID="lblTitulo" runat="server" CssClass="fs-4 fw-bold"></asp:Label>
            <asp:HiddenField ID="categoryIdHidden" runat="server" />
            <div class="form-fields">
                <label class="form-label">Nombre</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                <label for="ckActiva" class="form-label">Activa</label>
                <asp:CheckBox ID="ckActiva" runat="server" CssClass="form-control no-border"></asp:CheckBox>
                <asp:Button ID="btnSubmit" runat="server" Text="Guardar" CssClass="btn btn-sm btn-primary" OnClick="btnSubmit_Click" />
                <asp:LinkButton runat="server" PostBackUrl="~/Categories.aspx" CssClass="btn btn-sm btn-warning">Cancelar</asp:LinkButton>
            </div>
        </asp:Panel>
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
                            OnClick="Eliminar_Click" CssClass="btn btn-sm btn-danger" OnClientClick="return confirm('Esta seguro que desea eliminar la categoría?')"> Eliminar</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </main>
</asp:Content>
