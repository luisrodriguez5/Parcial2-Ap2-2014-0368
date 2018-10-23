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
        double Couta;
        protected void Page_Load(object sender, EventArgs e)
        {
            prestamos = new Prestamos();

            if (!Page.IsPostBack)
            {
                LlenarCuentas();
            }


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
        private void Calcular()
        {
            int plazo = Convert.ToInt32(CuotaTextBox.Text);
            double capital = Convert.ToDouble(MontoTextBox.Text);
            double Interes = Convert.ToDouble(InteresTextBox.Text) / 1200;

           Couta = capital * (Interes / (double)(1 - Math.Pow(1 + (double)Interes, -plazo)));
           
        }

        private void DatosPrestamo()
        {
            Id.Text = prestamos.PrestamoId.ToString();
            DireccionTextBox.Text = prestamos.Direccion;
            MontoTextBox.Text = prestamos.Monto.ToString();
            NombreTextBox.Text = prestamos.Nombre;
            CuotaTextBox.Text = prestamos.NoCuotas.ToString();
            FechaTextBox.Text = prestamos.FechaInicio.ToString("yyyy-MM-dd");
            CuentaDropDownList.Text = prestamos.CuentaId.ToString();
            InteresTextBox.Text = prestamos.IntereSAnual.ToString();

         
        }

        private Prestamos LlenarInstanciaPrestamos()
        {
            

            //producto.ProductoId = Utilidades.TOINT(ProductoIdTextBox.Text);
            prestamos.Direccion = DireccionTextBox.Text;
            prestamos.Nombre = NombreTextBox.Text;
            prestamos.Monto = Utilidades.TOINT(MontoTextBox.Text);
            prestamos.NoCuotas = Utilidades.TOINT( CuotaTextBox.Text);
            prestamos.FechaInicio = Convert.ToDateTime(FechaTextBox.Text);
            prestamos.CuentaId = Utilidades.TOINT(CuentaDropDownList.SelectedValue);
            prestamos.Coutas = Convert.ToDecimal (Couta);
            return prestamos;
        }


        private void LlenarCuentas()
        {
            List<Cuentas> Lista = CuentasBLL.GetListAll();

            CuentaDropDownList.DataSource = Lista;
            CuentaDropDownList.DataValueField = "CuentaId";
            CuentaDropDownList.DataTextField = "Nombre";
            CuentaDropDownList.DataBind();

        }
        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(DireccionTextBox.Text))
            {
                interruptor = false;
            }
            if (string.IsNullOrEmpty(NombreTextBox.Text))
            {
                interruptor = false;
            }
            if (string.IsNullOrEmpty(MontoTextBox.Text))
            {
                interruptor = false;
            }
            if (string.IsNullOrEmpty(CuotaTextBox.Text))
            {
                interruptor = false;
            }
            if (string.IsNullOrEmpty(FechaTextBox.Text))
            {
                interruptor = false;
            }

            return interruptor;
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

        private bool VerificarExistenciaPrestamos()
        {
            if (string.IsNullOrEmpty(Id.Text))
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Digite el id del Prestamo');", addScriptTags: true);
            }
            else
            {
                int id = Utilidades.TOINT(Id.Text);

                prestamos = PrestamosBLL.Buscar(p => p.PrestamoId == id);

                if (prestamos != null)
                {

                    return true;
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('No existe Prestamos con ese id');", addScriptTags: true);
                }
            }

            return false;
        }




        protected void BtnNuevo_Click(object sender, EventArgs e)
        {
            BuscarPrestamo();
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {


            if (Validar())
            {
                prestamos.PrestamoId = Utilidades.TOINT(Id.Text);
      

                
                
                    if (PrestamosBLL.Guardar(LlenarInstanciaPrestamos()))
                    {
                        Id.Text = Convert.ToString(prestamos.PrestamoId);
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['success']('Producto guardado con exito');", addScriptTags: true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('No se pudo guardar el producto');", addScriptTags: true);
                    }
                
              
            }


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