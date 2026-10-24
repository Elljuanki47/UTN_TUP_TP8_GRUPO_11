using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    internal class AccesoDatos
    {
        String rutaBDScuursales = @"Data Source=localhost\sqlexpress;Initial Catalog=BDSucursales;Integrated Security=True";

        private SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(rutaBDScuursales);
            cn.Open();
            return cn;
        }

        public DataTable ObtenerTabla(String nombreTabla, String consulta)
        {
            DataSet ds = new DataSet();
            SqlConnection conexion = ObtenerConexion();

            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            adaptador.Fill(ds, nombreTabla);

            conexion.Close();

            return ds.Tables[nombreTabla];
        }
    }
}
