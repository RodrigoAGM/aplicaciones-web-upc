using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using CapaEntidad;

namespace CapaNegocio_
{
    public class SolucionNE
    {
        private SolucionDAO solucionDAO;

        public SolucionNE()
        {
            solucionDAO = new SolucionDAO();
        }

        public DataTable ListarSolucion(int id)
        {
            return solucionDAO.ListarSolucion(id);
        }

        public int CrearSolucion(Solucion solucion)
        {
            return solucionDAO.NuevaSolucion(solucion);
        }

    }
}
