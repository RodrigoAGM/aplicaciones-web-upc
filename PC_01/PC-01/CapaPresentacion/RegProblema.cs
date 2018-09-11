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
    public partial class RegProblema : Form
    {

        private ProblemaNE problemaNE;
        public RegProblema()
        {
            InitializeComponent();
            problemaNE = new ProblemaNE();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Problema Obj = new Problema();
                Obj.Tipo = cbTipo.SelectedText;
                Obj.Descripcion = txtDescripcion.Text;

                int i = problemaNE.CrearProblema(Obj);
                MessageBox.Show("Registro OK");
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ocurrio un error " + exception.Message);
            }
        }
    }
}
