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
    public partial class ConsultaCuentas : System.Web.UI.Page
    {
        public static List<Cuentas> Lista { get; set; }
        public static Cuentas cuenta = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            cuenta = null;

            if (!Page.IsPostBack)
            {
                Lista = CuentasBLL.GetListAll();
                
            }
            BotonImprimirVisibleSiHayListas();
            VisibleInvisibleFechas();
        }

        private void VisibleInvisibleFechas()
        {
            if (FiltrarFechaCheckBox.Checked == true)
            {
                FechaDesdeTextBox.Visible = true;
                FechaHastaTextBox.Visible = true;
                DesdeLabel.Visible = true;
                HastaLabel.Visible = true;
            }
            else
            {
                FechaDesdeTextBox.Visible = false;
                FechaHastaTextBox.Visible = false;
                DesdeLabel.Visible = false;
                HastaLabel.Visible = false;
                FechaDesdeTextBox.Text = "";
                FechaHastaTextBox.Text = "";

            }
        }

        private void Limpiar()
        {
            FiltrarDropDownList.SelectedIndex = 0;
            FiltroTextBox.Text = "";
            FechaDesdeTextBox.Text = "";
            FechaHastaTextBox.Text = "";
        }

        private void CargarListaCuenta()
        {
            CuentaConsultaGridView.DataSource = Lista;
            CuentaConsultaGridView.DataBind();
        }

        private void BotonImprimirVisibleSiHayListas()
        {
            if (Lista == null || Lista.Count() == 0)
            {
                ImprimirButton.Visible = false;
            }
            else
            {
                ImprimirButton.Visible = true;
            }
        }

        private void Filtrar()
        {
            DateTime FechaDesde = new DateTime();
            DateTime FechaHasta = new DateTime();

            if (FiltrarFechaCheckBox.Checked)
            {
                FechaDesde = Convert.ToDateTime(FechaDesdeTextBox.Text);
                FechaHasta = Convert.ToDateTime(FechaHastaTextBox.Text);
            }

            if (FiltrarDropDownList.SelectedIndex == 0)
            {
                if (FiltrarFechaCheckBox.Checked)
                {
                    Lista = CuentasBLL.GetList(p => p.Fecha >= FechaDesde.Date && p.Fecha <= FechaHasta.Date);
                }
                else
                {
                    Lista = CuentasBLL.GetListAll();
                }
            }
            else if (FiltrarDropDownList.SelectedIndex != 0)
            {
                if (FiltrarDropDownList.SelectedIndex == 2)
                {
                    if (FiltrarFechaCheckBox.Checked)
                    {
                        Lista = CuentasBLL.GetList(p => p.Nombre == FiltroTextBox.Text && p.Fecha >= FechaDesde.Date && p.Fecha <= FechaHasta.Date);
                    }
                    else
                    {
                        Lista = CuentasBLL.GetList(p => p.Nombre == FiltroTextBox.Text);
                    }
                }


                if (FiltrarDropDownList.SelectedIndex == 1)
                {
                    int id = Utilidades.TOINT(FiltroTextBox.Text);
                    if (FiltrarFechaCheckBox.Checked)
                    {
                        Lista = CuentasBLL.GetList(p => p.CuentaId == id && p.Fecha >= FechaDesde.Date && p.Fecha <= FechaHasta.Date);
                    }
                    else
                    {
                        Lista = CuentasBLL.GetList(p => p.CuentaId == id);
                    }
                }
            }
            CargarListaCuenta();
            if (Lista.Count() == 0)
            {
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('No existe usuario');", addScriptTags: true);
                ImprimirButton.Visible = false;
            }

        }

        protected void FiltroButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FiltroTextBox.Text) && FiltrarDropDownList.SelectedIndex != 0)
            {
               CuentaConsultaGridView.DataBind();
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Por favor digite el dato del filtro');", addScriptTags: true);
                ImprimirButton.Visible = false;
            }
            else if (FiltrarFechaCheckBox.Checked)
            {
                if (string.IsNullOrEmpty(FechaDesdeTextBox.Text) || string.IsNullOrEmpty(FechaHastaTextBox.Text))
                {
                    CuentaConsultaGridView.DataBind();
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['info']('Por favor elige el rango de la fecha');", addScriptTags: true);
                    ImprimirButton.Visible = false;
                }
                else
                {
                    Filtrar();
                    BotonImprimirVisibleSiHayListas();
                }
            }
            else
            {
                ImprimirButton.Visible = false;
                Filtrar();
                BotonImprimirVisibleSiHayListas();
            }

        }

        protected void CuentaConsultaGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}