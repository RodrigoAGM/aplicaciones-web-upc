using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnProblema_Click(object sender, EventArgs e)
        {
            RegProblema form = new RegProblema();
            form.Show();
        }

        private void btnSolucion_Click(object sender, EventArgs e)
        {
            RegSolucion form = new RegSolucion();
            form.Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listado form = new Listado();
            form.Show();
        }
    }
}
