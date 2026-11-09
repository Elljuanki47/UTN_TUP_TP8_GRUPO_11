using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        public int Id_Sucursal { get; set; }
        public string NombreSucursal { get; set; }
        public string DescripcionSucursal { get; set; }
        public int Id_ProvinciaSucursal { get; set; }
        public string DireccionSucursal { get; set; }
        public int getIdSucursal()
        {
            return Id_Sucursal;
        }

        public void setIdSucursal(int idSucursal)
        {
            Id_Sucursal = idSucursal;
        }
    }
}
