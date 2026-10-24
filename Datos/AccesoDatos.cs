using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    internal class AccesoDatos
    {
        String rutaBDSucursales = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BDSucursales;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        private SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(rutaBDSucursales);

            try
            {
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private SqlDataAdapter ObtenerAdaptador(String consultaSql, SqlConnection cn)
        {
            SqlDataAdapter adaptador;

            try
            {
                adaptador = new SqlDataAdapter(consultaSql, cn);
                return adaptador;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DataTable ObtenerTabla(String nombreTabla, String consulta)
        {
            DataSet ds = new DataSet();
            SqlConnection conexion = ObtenerConexion();
            SqlDataAdapter adaptador = ObtenerAdaptador(consulta, conexion);

            adaptador.Fill(ds, nombreTabla);
            conexion.Close();

            return ds.Tables[nombreTabla];
        }
    }
}
