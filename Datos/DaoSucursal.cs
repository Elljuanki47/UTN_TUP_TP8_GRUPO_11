using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    internal class DaoSucursal
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaSucursales()
        {
            String consulta = "SELECT S.Id_Sucursal, S.NombreSucursal, S.DescripcionSucursal, P.DescripcionProvincia, S.DireccionSucursal FROM Sucursal S INNER JOIN Provincia P ON S.Id_ProvinciaSucursal = P.Id_Provincia";

            DataTable tabla = ds.ObtenerTabla("Sucursal", consulta);

            return tabla;
        }
    }
}
