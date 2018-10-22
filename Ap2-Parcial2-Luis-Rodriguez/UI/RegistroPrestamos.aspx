<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="RegistroPrestamos.aspx.cs" Inherits="Ap2_Parcial2_Luis_Rodriguez.UI.RegistroPrestamos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="container mt-5 pt-5">
        <div class="row">
            <div class="col-10">
                <div class="form-row">

                    <div class="form-group col-md-3 ">
                        <label for="PrestamoId" class="col-form-label">Id:</label>
                        <asp:TextBox ID="Id" runat="server" Class="form-control"></asp:TextBox>


                    </div>
                    <div class="form-group col-md-3 ">
                        <label for="PrestamoId" class="col-form-label">Id:</label>
                      


                    </div>

                    <div class="form-group col-md-6 ">
                        <br />
                        <asp:Label ID="CuentaLabel" runat="server" Text="Cuenta:"></asp:Label>
                        <asp:DropDownList CssClass="form-control" ID="CuentaDropDownList" runat="server"></asp:DropDownList>

                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="Nombre">Nombre:</label>
                        <asp:TextBox ID="NombreTextBox" runat="server" Class="form-control "></asp:TextBox>
                    </div>

                    <div class="form-group col-md-6 ">
                        <label for="Direccion">Direccion:</label>
                        <asp:TextBox ID="DireccionTextBox" runat="server" Class="form-control"></asp:TextBox>
                    </div>
                </div>

                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="Interes">Interes Anual:</label>
                        <asp:TextBox ID="InteresTextBox" runat="server" Class="form-control "></asp:TextBox>
                    </div>

                    <div class="form-group col-md-6 ">
                        <label for="Fecha">Fecha:</label>
                        <asp:TextBox type="date" CssClass="form-control" ID="FechaTextBox" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="Monto">Monto:</label>
                        <asp:TextBox ID="MontoTextBox" runat="server" Class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="Cuota">No.Couta:</label>
                        <asp:TextBox ID="CuotaTextBox" runat="server" Class="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-7 ml-md-auto">
                        <asp:Panel ID="AlertGuardar" Class="form-control alert-success text-center" runat="server" role="alert">
                            <asp:Label ID="MensajeGuardado" runat="server">!Se Guardo Con Exito! </asp:Label>
                        </asp:Panel>
                    </div>
                </div>
                <div class="form-group row">
                    <div class="col-lg-12">
                        <div class="col-10 ml-md-auto">
                            <asp:Button ID="BtnNuevo" runat="server" class="btn btn-primary" Text="Nuevo" OnClick="BtnNuevo_Click" />
                            <asp:Button ID="BtnGuardar" runat="server" class="btn btn-primary" Text="Guardar" OnClick="BtnGuardar_Click" />

                            <asp:Button ID="Button2" runat="server" class="btn btn-primary" Text="Eliminar" OnClick="Button2_Click" />

                        </div>
                    </div>

                </div>

            </div>
        </div>
    </section>
</asp:Content>
