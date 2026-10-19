using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Sucursal
    {
        private int IdSucursal;
        private String NombreSucursal;
        private String DescripcionSucursal;
        private int IdProvinciaSucursal;
        private String DireccionSucursal;

        public Sucursal()
        { }

        public int getIdSucursal()
        {
            return IdSucursal;
        }

        public void setIdSucursal(int idSucursal)
        {
            IdSucursal = idSucursal;
        }

        public String getNombreSucursal()
        {
            return NombreSucursal;
        }

        public void setNombreSucursal(String nombreSucursal)
        {
            NombreSucursal = nombreSucursal;
        }

        public String getDescripcionSucursal()
        {
            return DescripcionSucursal;
        }

        public void setDescripcionSucursal(String descripcionSucursal)
        {
            DescripcionSucursal = descripcionSucursal;
        }

        public int getIdProvinciaSucursal()
        {
            return IdProvinciaSucursal;
        }

        public void setIdProvinciaSucursal(int idProvinciaSucursal)
        {
            IdProvinciaSucursal = idProvinciaSucursal;
        }

        public String getDireccionSucursal()
        {
            return DireccionSucursal;
        }

        public void setDireccionSucursal(String direccionSucursal)
        {
            DireccionSucursal = direccionSucursal;
        }
    }
}
