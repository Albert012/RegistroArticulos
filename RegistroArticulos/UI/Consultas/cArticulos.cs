using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegistroArticulos.Entidades;
using System.Linq.Expressions;

namespace RegistroArticulos.UI.Consultas
{
    public partial class cArticulos : Form
    {
        public cArticulos()
        {
            InitializeComponent();
        }

        private void Consultar_button_Click(object sender, EventArgs e)
        {
            //inicializar filtro en True
            Expression<Func<Articulos, bool>> filtro = a => true;
            int id;

            switch(Filtro_comboBox.SelectedIndex)
            {
                case 0://Todos
                    break;
                case 1://ArticuloId
                    id = Convert.ToInt32(Criterio_textBox.Text);
                    filtro = a => a.ArticuloId == id;
                    break;
                case 2://Descripcion
                    filtro = a => a.Descripcion.Contains(Criterio_textBox.Text);
                    break;                
            }
            Consulta_dataGridView.DataSource = BLL.ArticulosBLL.GetList(filtro);
        }

        private void Filtro_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Filtro_comboBox.SelectedIndex == 0)
            {
                Criterio_textBox.Clear();
                Consultar_button.PerformClick();
            }
        }

        private void Criterio_textBox_TextChanged(object sender, EventArgs e)
        {
            /*if(Filtro_comboBox.SelectedIndex == 0)
            {
                Criterio_textBox.Clear();
            }*/
        }
    }
}
