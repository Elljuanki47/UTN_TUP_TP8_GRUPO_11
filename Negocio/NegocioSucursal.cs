using Entidades;
using Datos;
using Entidades;
using System;
using System.Data;

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
        public int eliminarSucursal(int id)
        {
            Sucursal suc = new Sucursal();
            suc.setIdSucursal(id);

            DaoSucursal dao = new DaoSucursal();

            return dao.eliminarSucursal(suc);
        }
    }
}
