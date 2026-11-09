using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
namespace Vistas
{
    public partial class EliminarSucursales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarSucursal();
        }

        public void EliminarSucursal()
        {
            lblMensaje.Text = "";

            int idSucursal;

            if (string.IsNullOrWhiteSpace(txtIdSucursal.Text))
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "El campo ID de sucursal no puede estar vacio.";

                return;
            }

            if (!int.TryParse(txtIdSucursal.Text.Trim(), out idSucursal))
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "Ingrese un ID de Sucursal numérico válido.";
                txtIdSucursal.Text = "";
                return;
            }

            if (idSucursal <= 0)
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "El ID de sucursal debe ser mayor a cero.";
                txtIdSucursal.Text = "";
                return;
            }
            NegocioSucursal negocio = new NegocioSucursal();

            int filasAfectadas = negocio.eliminarSucursal(idSucursal);

            if (filasAfectadas > 0)
            {
                lblMensaje.ForeColor = System.Drawing.Color.Green;
                lblMensaje.Text =
                    "La sucursal con ID " + idSucursal +
                    " se ha eliminado con éxito.";
            }
            else
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text =
                    "No existe una sucursal con el ID " + idSucursal + ".";
            }
            txtIdSucursal.Text = "";
        }
    }
}