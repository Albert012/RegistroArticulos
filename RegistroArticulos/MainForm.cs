using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegistroArticulos.UI.Registros;
using RegistroArticulos.UI.Consultas;

namespace RegistroArticulos
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta Luego, Esperamos Verlo Pronto Por Aqui!!", "Despedida!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rArticulos articulo = new rArticulos();
            articulo.MdiParent = this.MdiParent;
            articulo.Show();
        }

        private void articulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cArticulos articulo = new cArticulos();
            articulo.MdiParent = this.MdiParent;
            articulo.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.MdiParent = this.MdiParent;
            about.Show();
        }
    }
}