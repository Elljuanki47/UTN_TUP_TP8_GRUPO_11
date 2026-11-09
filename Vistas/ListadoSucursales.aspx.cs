using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
namespace Vistas
{
    public partial class ListadoSucursales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrilla();
            }
        }

        private void CargarGrilla()
        {
            NegocioSucursal negocio = new NegocioSucursal();

            gvSucursales.DataSource = negocio.getTabla();
            gvSucursales.DataBind();
        }

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            txtFiltrar.Text = "";
            CargarGrilla();
        }

        protected void btnFiltrar_Click (object sender, EventArgs e)
        {
            int idSucursal;

            if (!Page.IsValid)
            {
                return;
            }

            if (!int.TryParse(txtFiltrar.Text, out idSucursal))
            {
                return;
            }

            NegocioSucursal negocio = new NegocioSucursal();

            gvSucursales.DataSource = negocio.FiltrarSucursal(idSucursal);

            gvSucursales.DataBind();

            txtFiltrar.Text = "";
        }

    }
}