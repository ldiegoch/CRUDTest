<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Categories.aspx.cs" Inherits="CRUDTest.Categories" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <div class="row">
            <div>
                <h1>Categories</h1>
               
            </div>
            <asp:Label ID="lblTitulo" runat="server" CssClass="fs-4 fw-bold"></asp:Label>

    <div class="mb-3">
        <label class="form-label">Nombre</label>
        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
    </div>
      <div class="mb-3">
        <label class="form-label">Activa</label>
          <asp:CheckBox ID="ckActiva" runat="server" CssClass="form-control"></asp:CheckBox>
    </div>

    <asp:Button ID="btnSubmit" runat="server" Text="Enviar" CssClass="btn btn-sm btn-primary" OnClick="btnSubmit_Click" />
    <asp:LinkButton runat="server" PostBackUrl="~/Default.aspx"  CssClass="btn btn-sm btn-warning">Volver</asp:LinkButton>
            
        </div>
    </main>

</asp:Content>
