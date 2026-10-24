using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DaoProvincia
    {
        AccesoDatos ds = new AccesoDatos();

        public DataTable getTablaProvincias()
        {
            String consulta = "SELECT Id_Provincia, DescripcionProvincia FROM Provincia";

            DataTable tabla = ds.ObtenerTabla("Provincia", consulta);

            return tabla;
        }
    }
}
