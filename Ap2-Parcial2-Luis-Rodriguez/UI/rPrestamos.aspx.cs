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
    public partial class rPrestamos : System.Web.UI.Page
    {
        public static Prestamos prestamos = null;
        public static List<Prestamos> Lista { get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            prestamos = null;

            if (!Page.IsPostBack)
            {
                Lista = PrestamosBLL.GetListAll();

                CargarLista();
            }
          
        }

        private void CargarLista()
        {
            //CuentaConsultaGridView.DataSource = Lista;
            //CuentaConsultaGridView.DataBind();
            CalcularDatos();
        }
        private void CalcularDatos()
        {
            double capital = Convert.ToDouble(prestamos.Monto);
            double Interes = Convert.ToDouble(prestamos.IntereSAnual) /1200;
            double Plazo = Convert.ToDouble(prestamos.NoCuotas);
            
            //Formula para generar Desglose de couta
            

            double InteresMensual = 0;
            double Amortizacion = 0;
            double Amortizacion_Total = 0;

            for(int i=1; i <=Plazo; i++)
            {
                InteresMensual = Math.Round((Interes * capital), 2);
                capital = Math.Round(capital - Convert.ToDouble( prestamos.Coutas) + InteresMensual, 2);

                Amortizacion_Total += Math.Round(capital - InteresMensual, 2);
                Amortizacion = Convert.ToDouble (prestamos.Coutas) - InteresMensual;
            }
 
        }
    }
}