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
    public partial class RegistroPrestamos : System.Web.UI.Page
    {
        private Prestamos prestamos = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            AlertGuardar.Visible = false;

        }

        private void Limpiar()
        {
            prestamos = null;
            Id.Text = "";
            NombreTextBox.Text = "";
            MontoTextBox.Text = "";
            //CategoriaTextBox.Text = "";
            DireccionTextBox.Text = "";

        }

        private void DatosPrestamo()
        {
            Id.Text = prestamos.PrestamoId.ToString();
            DireccionTextBox.Text = prestamos.Direccion;
            MontoTextBox.Text = prestamos.Monto.ToString();
            NombreTextBox.Text = prestamos.Nombre;
            CuotaTextBox.Text = prestamos.NoCuotas.ToString();
           
        }
        private void BuscarPrestamo()
        {


            int id = Utilidades.TOINT(Id.Text);

            prestamos = PrestamosBLL.Buscar(p => p.PrestamoId == id);

            if (prestamos != null)
            {

                DatosPrestamo();
            }

        }


        private void LlenarCamposInstancia()
        {
            int id = 0;
            if (Id.Text != "")
            {
                id = Utilidades.TOINT(Id.Text);
            }
            prestamos = new Prestamos(id, NombreTextBox.Text, DireccionTextBox.Text, Utilidades.TODECIMAL(MontoTextBox.Text),Utilidades.TOINT(CuotaTextBox.Text));
        }


        private bool Validar()
        {
            bool interutor = true;
            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                interutor = false;
            }
            if (string.IsNullOrWhiteSpace(DireccionTextBox.Text))
            {
                interutor = false;
            }

            if (string.IsNullOrWhiteSpace(MontoTextBox.Text))
            {
                interutor = false;
            }

            return interutor;
        }

        protected void BtnNuevo_Click(object sender, EventArgs e)
        {
            BuscarPrestamo();
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            LlenarCamposInstancia();

            PrestamosBLL.Guardar(prestamos);

            Id.Text = prestamos.PrestamoId.ToString();
            //MensajeGuardado.Text = "Gardo";
            AlertGuardar.Visible = true;
            //ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Usuario guardado con exito');", addScriptTags: true);
            //UtilidadesWeb.MostrarToastr(this, "Guardado", "Usuario", "info");
            Limpiar();





        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int id = Utilidades.TOINT(Id.Text);

            
            
                if (PrestamosBLL.Eliminar(PrestamosBLL.Buscar(p => p.PrestamoId == id)))
                {
                    Limpiar();

                }
            
        }
    }
}