using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio_;
using CapaEntidad;

namespace CapaPresentacion
{

    public partial class Listado : Form
    {
        private SolucionNE solucionNE;
        private ProblemaNE problemaNE;
        private int idProblema;

        public Listado()
        {
            InitializeComponent();
            problemaNE = new ProblemaNE();
            solucionNE = new SolucionNE();
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            LlenarProblemas();
        }

        void LlenarProblemas()
        {
            dgProblemas.DataSource = problemaNE.ListarProblemas();
        }

        void LlenarSoluciones(int id)
        {
            dgSoluciones.DataSource = solucionNE.ListarSolucion(id);
        }

        private void dgProblemas_MouseClick(object sender, MouseEventArgs e)
        {
            idProblema = int.Parse(dgProblemas.CurrentRow.Cells[0].Value.ToString());
            LlenarSoluciones(idProblema);
        }
    }
}
