
using System;
using System.Data;
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
                return 0;

            return dao.AgregarSucursal(nombre.Trim(), descripcion.Trim(), provincia, direccion.Trim());
        }

        public DataTable getTabla()
        {
            DaoSucursal dao = new DaoSucursal();

            return dao.getTablaSucursales();
        }

        public DataTable FiltrarSucursal(int idSucursal)
        {
            DaoSucursal dao = new DaoSucursal();

            return dao.FiltrarSucursal(idSucursal);
        }
    }
}
