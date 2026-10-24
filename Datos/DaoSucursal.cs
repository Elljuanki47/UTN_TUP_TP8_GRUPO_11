using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DaoSucursal
    {
        AccesoDatos ds = new AccesoDatos();

        public int eliminarSucursal(Sucursal suc)
        {
            String consulta = "DELETE FROM Sucursal WHERE Id_Sucursal = " + suc.getIdSucursal();

            return ds.EjecutarConsulta(consulta);
        }
    }
}
