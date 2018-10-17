<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="rPrestamos.aspx.cs" Inherits="Ap2_Parcial2_Luis_Rodriguez.UI.rPrestamos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="container mt-5 pt-5">
        <div class="row">
            <div class="col-6">
                <div class="form-group row">
                    <label for="Id" class="col-2 col-form-label">Id:</label>
                    <asp:TextBox ID="Id" runat="server" Class="form-control col-2"></asp:TextBox>

                </div>
                <div class="form-group row">
                    <label for="Nombre" class="col-2">Nombre:</label>
                    <asp:TextBox ID="NombreTextBox" runat="server" Class="form-control col-6"></asp:TextBox>
                </div>


                <div class="form-group row">
                    <label for="Balance" class="col-2">Monto:</label>
                    <asp:TextBox ID="MontoTextBox" runat="server" Class="form-control col-6"></asp:TextBox>
                </div>

                <div class="form-group row">
                    <div class="col-lg-12">
                        <div class="col-10 ml-md-auto">
                            <asp:Button ID="BtnNuevo" runat="server" class="btn btn-primary" Text="Nuevo" />
                            <asp:Button ID="BtnGuardar" runat="server" class="btn btn-primary" Text="Guardar" />
                            <asp:Button ID="Button2" runat="server" class="btn btn-primary" Text="Eliminar" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

</asp:Content>
