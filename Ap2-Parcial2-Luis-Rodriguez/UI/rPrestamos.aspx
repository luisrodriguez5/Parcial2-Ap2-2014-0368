<%@ Page Title="" Language="C#" MasterPageFile="~/Base.Master" AutoEventWireup="true" CodeBehind="rPrestamos.aspx.cs" Inherits="Ap2_Parcial2_Luis_Rodriguez.UI.rPrestamos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="container mt-5 pt-5">
        <div class="row">
            <div class="col-6">
               <h1>Tabla de amortizacion</h1>
                <table class="table-bordered">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Couta</th>
                            <th>Interes Mensual</th>
                            <th>Amortizacion Principal</th>
                            <th>Amortizacion Total</th>
                            <th>Capital Pediente</th>
                        </tr>
                    </thead>
                    
                </table>
            </div>
        </div>
    </section>

</asp:Content>
