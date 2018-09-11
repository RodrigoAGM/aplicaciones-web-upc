using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio_;

namespace CapaPresentacion
{
    public partial class RegSolucion : Form
    {
        private Problema ObjProb;
        private SolucionNE solucionNE;
        private ProblemaNE problemaNE;
        public RegSolucion()
        {
            InitializeComponent();
            ObjProb = new Problema();
            solucionNE = new SolucionNE();
            problemaNE = new ProblemaNE();
            ObjProb.IdProblema = -1;
        }

        void LlenarProblemas()
        {
            dgProblemas.DataSource = problemaNE.ListarProblemas();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(ObjProb.IdProblema != -1)
            {
                try
                {
                    Solucion Obj = new Solucion();
                    Obj.Descripcion = txtDescripcion.Text;
                    Obj.ObjProblema = ObjProb;

                    int i = solucionNE.CrearSolucion(Obj);
                    MessageBox.Show("Registro OK");
                    this.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ocurrio un error " + exception.Message);
                }
            }
        }

        private void RegSolucion_Load(object sender, EventArgs e)
        {
            LlenarProblemas();
        }


        private void dgProblemas_MouseClick(object sender, MouseEventArgs e)
        {
            ObjProb.IdProblema = int.Parse(dgProblemas.CurrentRow.Cells[0].Value.ToString());
            ObjProb.Descripcion = dgProblemas.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
