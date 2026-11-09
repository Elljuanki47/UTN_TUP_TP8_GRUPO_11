using System;
using Datos;
using Entidades;

namespace Negocio
{
    public class NegocioSucursal
    {
        public int eliminarSucursal(int id)
        {
            Sucursal suc = new Sucursal();
            suc.setIdSucursal(id);

            DaoSucursal dao = new DaoSucursal();

            return dao.eliminarSucursal(suc);
        }
    }
}