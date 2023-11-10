<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="New.aspx.cs" Inherits="CRUDTest.New" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>

        <div>
            <asp:Label ID="lblTitulo" runat="server" CssClass="fs-4 fw-bold"></asp:Label>
            <asp:HiddenField ID="categoryIdHidden" runat="server" />
            <div class="form-fields">
                <div class="mb-3">
                    <label class="form-label">Nombre</label>
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="ckActiva" class="form-label">Activa</label>
                    <asp:CheckBox ID="ckActiva" runat="server" CssClass="form-control no-border"></asp:CheckBox>
                </div>
            </div>

            <asp:Button ID="btnSubmit" runat="server" Text="Enviar" CssClass="btn btn-sm btn-primary" OnClick="btnSubmit_Click" />
            <asp:LinkButton runat="server" PostBackUrl="~/Categories.aspx" CssClass="btn btn-sm btn-warning">Volver</asp:LinkButton>
        </div>

    </main>

</asp:Content>
