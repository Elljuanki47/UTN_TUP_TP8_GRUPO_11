using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
namespace Negocio
{
    public class NegocioSucursal
    {
        public int AgregarSucursal(string nombre, string descripcion, int provincia, string direccion)
        {
            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(descripcion) ||
                string.IsNullOrWhiteSpace(direccion) ||
                provincia <= 0)
            {
                return 0;
            }

            DaoSucursal dao = new DaoSucursal();

            if (dao.ExisteSucursal(nombre.Trim()))
            {
                return 0;
            }

            return dao.AgregarSucursal(nombre.Trim(), descripcion.Trim(), provincia, direccion.Trim());
        }
    }
    
}
