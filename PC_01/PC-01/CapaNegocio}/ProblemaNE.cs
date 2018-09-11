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
    public class ProblemaNE
    {
        private ProblemaDAO problemaDAO;

        public ProblemaNE()
        {
            problemaDAO = new ProblemaDAO();
        }

        public DataTable ListarProblemas()
        {
            return problemaDAO.ListarProblemas();
        }

        public int CrearProblema(Problema problema)
        {
            return problemaDAO.NuevoProblema(problema);
        }

            
    }
}
