using Entidades;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DaoSucursal
    {
        AccesoDatos ds = new AccesoDatos();

        public int AgregarSucursal(string nombre, string descripcion, int provincia, string direccion)
        {
            string consulta = "INSERT INTO Sucursal " +
                "(NombreSucursal, DescripcionSucursal, Id_ProvinciaSucursal, DireccionSucursal) " +
                "VALUES (@Nombre, @Descripcion, @Provincia, @Direccion)";

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

        public DataTable getTablaSucursales()
        {
            string consulta = "SELECT S.Id_Sucursal, S.NombreSucursal, S.DescripcionSucursal, " +
                "P.DescripcionProvincia, S.DireccionSucursal " +
                "FROM Sucursal S INNER JOIN Provincia P " +
                "ON S.Id_ProvinciaSucursal = P.Id_Provincia";

            return ds.ObtenerTabla("Sucursal", consulta);
        }

        public DataTable FiltrarSucursal(int idSucursal)
        {
            string consulta = "SELECT S.Id_Sucursal, S.NombreSucursal, S.DescripcionSucursal, " +
                "P.DescripcionProvincia, S.DireccionSucursal " +
                "FROM Sucursal S INNER JOIN Provincia P " +
                "ON S.Id_ProvinciaSucursal = P.Id_Provincia " +
                "WHERE S.Id_Sucursal = " + idSucursal;

            return ds.ObtenerTabla("Sucursal", consulta);
        }
        public int eliminarSucursal(Sucursal suc)
        {
            String consulta = "DELETE FROM Sucursal WHERE Id_Sucursal = " + suc.getIdSucursal();

            return ds.EjecutarConsulta(consulta);
        }
    }
}
