using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DaoSucursal
    {
        AccesoDatos ds = new AccesoDatos();

        public int AgregarSucursal(string nombre, string descripcion, int provincia, string direccion)
        {
            string consulta =
                "INSERT INTO Sucursal " +
                "(NombreSucursal,DescripcionSucursal,Id_ProvinciaSucursal,DireccionSucursal) " +
                "VALUES (@Nombre,@Descripcion,@Provincia,@Direccion)";

            SqlCommand comando = new SqlCommand(consulta);

            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@Provincia", provincia);
            comando.Parameters.AddWithValue("@Direccion", direccion);

            return ds.EjecutarComando(comando);
        }

        public bool ExisteSucursal(string nombre)
        {
            AccesoDatos ds = new AccesoDatos();
            string consulta = "SELECT * FROM Sucursal WHERE NombreSucursal = '" + nombre + "'";
            DataTable tabla = ds.ObtenerTabla("Sucursal", consulta);
            return tabla.Rows.Count > 0;
        }
    }
}