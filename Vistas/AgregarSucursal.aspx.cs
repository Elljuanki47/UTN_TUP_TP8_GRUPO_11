using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Vistas
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NegocioProvincia negocio = new NegocioProvincia();

                ddlProvincia.DataSource = negocio.getTabla();
                ddlProvincia.DataTextField = "DescripcionProvincia";
                ddlProvincia.DataValueField = "Id_Provincia";
                ddlProvincia.DataBind();

                ddlProvincia.Items.Insert(0, new ListItem("--Seleccione--", "0"));
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;

            try
            {
                NegocioSucursal negocio = new NegocioSucursal();

                int filas = negocio.AgregarSucursal(
                    txtNombre.Text,
                    txtDescripcion.Text,
                    int.Parse(ddlProvincia.SelectedValue),
                    txtDireccion.Text);

                if (filas > 0)
                {
                    lblMensaje.Text = "La sucursal se ha agregado con éxito";
                    lblMensaje.ForeColor = System.Drawing.Color.Green; 

                    txtNombre.Text = "";
                    txtDescripcion.Text = "";
                    txtDireccion.Text = "";
                    ddlProvincia.SelectedIndex = 0;

                    txtNombre.Focus();
                }
                else
                {
                    lblMensaje.Text = "No se pudo agregar la sucursal";
                    lblMensaje.ForeColor = System.Drawing.Color.Red; 
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error al intentar guardar: " + ex.Message;
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }
    }

    }

