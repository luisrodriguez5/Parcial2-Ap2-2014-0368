<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="ConsultaCuentas.aspx.cs" Inherits="Ap2_Parcial2_Luis_Rodriguez.UI.ConsultaCuentas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="page-header text-center">
            <h1>Consulta de Cuentas</h1>
            <br />
        </div>

        <div class="container">
            <!--DropDowmList y TextBox-->
            <div class="row">
                <div class="col-12 col-sm-5">
                    <asp:DropDownList ID="FiltrarDropDownList" runat="server" CssClass="form-control ">
                        <asp:ListItem>Todo</asp:ListItem>
                        <asp:ListItem>ID</asp:ListItem>
                        <asp:ListItem>Nombres</asp:ListItem>

                    </asp:DropDownList>
                </div>
                <div class="col-12 col-sm-7">
                    <asp:TextBox ID="FiltroTextBox" runat="server" CssClass="form-control" autoComplete="off"></asp:TextBox>
                </div>
            </div>
            <br />
            <asp:CheckBox ID="FiltrarFechaCheckBox" runat="server" Text="Filtrar por fecha" AutoPostBack="true" />

            <!--TextBox Fecha-->
            <div class="row">
                <div class="form-group col-12 col-sm-6">
                    <asp:Label ID="DesdeLabel" runat="server" Text="Desde:"></asp:Label>
                    <asp:TextBox type="date" CssClass="form-control" ID="FechaDesdeTextBox" runat="server"></asp:TextBox>
                </div>
                <div class="form-group col-12 col-sm-6">
                    <asp:Label ID="HastaLabel" runat="server" Text="Hasta:"></asp:Label>
                    <asp:TextBox type="date" CssClass="form-control" ID="FechaHastaTextBox" runat="server"></asp:TextBox>
                </div>
            </div>
        </div>
        <!--Container-->
        <!--GridView-->
        <div class="container">
            <div class="auto-style1">
                <div class="float-right">
                    <asp:Button ID="FiltroButton" runat="server" CssClass="btn btn-secondary" Text="Filtrar" OnClick="FiltroButton_Click" />
                </div>
                <asp:GridView CssClass="table table-responsive table-hover" ID="CuentaConsultaGridView" runat="server"
                    AutoGenerateColumns="False" GridLines="None" DataKeyNames="CuentaId,Nombre" ShowFooter="True" CellPadding="4" ForeColor="#333333">
                    <HeaderStyle CssClass="bg-secondary text-white" BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="" HeaderText="Id" />
                        <asp:BoundField DataField="Nombre" HeaderText="Nombres" />
                        <asp:BoundField DataField="Balance" HeaderText="Monto" />
                        <asp:BoundField DataField="Fecha" DataFormatString="{0:d}" HeaderText="Fecha" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="EnviarAlModalEliminarButton" CommandName="Select" CssClass="btn btn-secondary" runat="server"
                                    Text="Eliminar" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="EnviarAlModalModificarButton" CommandName="Select" CssClass="btn btn-primary" runat="server"
                                    Text="Modificar" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
        
                 
                </asp:GridView>
                <div class="float-left">
                    <asp:Button ID="ImprimirButton" runat="server" CommandName="Select" CssClass="btn btn-primary" Text="Imprimir" />
                </div>
            </div>
        </div>
        <!--Div grid view-->

        <!--Modal de confirmacion de eliminar-->
        <!-- Button trigger modal -->


        <!-- Modal -->
        <div class="modal fade" id="ModalEliminar" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalLabel">Modal title</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        ...
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                        <button type="button" class="btn btn-primary">Save changes</button>
                    </div>
                </div>
            </div>
        </div>
        <!--Modal de confirmacion de modificar-->
        <div class="modal" id="ModalModificar">
            <div class="modal-dialog" role="document">
                <div class="modal-content ">
                    <div class="modal-header bg-primary">
                        <h5 class="modal-title">¡Atencion!</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <p>Esta seguro de modificar este usuario?</p>
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="ModificarButton" runat="server" CssClass="btn btn-primary" Text="Si" />
                        <asp:Button ID="CancelarModificacionButton" runat="server" CssClass="btn btn-secondary" Text="No" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
