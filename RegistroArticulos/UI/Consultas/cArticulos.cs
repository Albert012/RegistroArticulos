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
                case 3://Fecha Vencimiento
                    filtro = a => a.FechaVencimiento.Equals(Fecha_dateTimePicker.Value.Date);
                    break;
                   
            }
            Consulta_dataGridView.DataSource = BLL.ArticulosBLL.GetList(filtro);
        }

        private void Filtro_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            /*Si seleccionamos el indice 0 se limpiar una busqueda anterior y deshabilita la busqueda
             * por criterio, ademas buscamos automaticamente
             */
            if (Filtro_comboBox.SelectedIndex == 0)
            {
                Criterio_textBox.Clear();
                Criterio_textBox.Enabled = false;
                Fecha_dateTimePicker.Visible = false;
                Consultar_button.PerformClick();
            }
            else
                Criterio_textBox.Enabled = true;
            //el indice 3 no visualiza el text de criterio sino que visualiza un calendario para 
            //elegir una fecha exacta
            if(Filtro_comboBox.SelectedIndex == 3)
            {
                Criterio_textBox.Visible = false;
                Fecha_dateTimePicker.Visible = true;
            }
            else
            {
                Fecha_dateTimePicker.Visible = false;
                Criterio_textBox.Visible = true;
            }

            
        }


        private void Criterio_textBox_TextChanged(object sender, EventArgs e)
        {
            //buscamos automaticamente mientras vamos digitando
            if(Criterio_textBox.Text != string.Empty)
            {
                Consultar_button.PerformClick();
                    
            }
        }
    }
}
