using BLL;
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
            AlertGuardar.Visible = false;

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
            cuentas = new Cuentas(id, NombreTextBox.Text, Utilidades.TODECIMAL(MontoTextBox.Text), Convert.ToDateTime(FechaTextBox.Text));
        }

        private bool Validar()
        {
            bool interutor = true;
            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                interutor = false;
            }

            if (string.IsNullOrWhiteSpace(MontoTextBox.Text))
            {
                interutor = false;
            }

            return interutor;
        }

        private void DatosCuenta()
        {
            Id.Text = cuentas.CuentaId.ToString();
            NombreTextBox.Text = cuentas.Nombre;
            MontoTextBox.Text = cuentas.Balance.ToString();
            FechaTextBox.Text = cuentas.Fecha.ToString("yyyy-MM-dd");

        }


        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                LlenarCamposInstancia();
                if (CuentasBLL.Guardar(cuentas))
                {
                    Id.Text = cuentas.CuentaId.ToString();
                    AlertGuardar.Visible = true;
                }
            }
        }

        protected void BtnNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}