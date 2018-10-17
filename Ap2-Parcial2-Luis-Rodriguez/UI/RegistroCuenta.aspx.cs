using Entidades;
using SistemaTech;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ap2_Parcial2_Luis_Rodriguez.UI
{
    public partial class RegistroCuenta : System.Web.UI.Page
    {
        private Cuentas cuentas = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            cuentas = null;
            Id.Text = "";
            NombreTextBox.Text = "";
            MontoTextBox.Text = "";

        }
        private void LlenarCamposInstancia()
        {
            int id = 0;
            if (Id.Text != "")
            {
                id = Utilidades.TOINT(Id.Text);
            }
            cuentas = new Cuentas(id, NombreTextBox.Text, Utilidades.TODECIMAL(MontoTextBox.Text));
        }

        private void DatosCuenta()
        {
            Id.Text = cuentas.CuentaId.ToString();
            NombreTextBox.Text = cuentas.Nombre;
            MontoTextBox.Text = cuentas.Balance.ToString();

        }


        protected void BtnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}