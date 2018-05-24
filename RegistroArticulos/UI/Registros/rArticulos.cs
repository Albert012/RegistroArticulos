using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegistroArticulos.Entidades;

namespace RegistroArticulos.UI.Registros
{
    public partial class rArticulos : Form
    {
        public rArticulos()
        {
            InitializeComponent();
        }

        private void rArticulos_Load(object sender, EventArgs e)
        {

        }

        private void Guardar_button_Click(object sender, EventArgs e)
        {
            Articulos articulo = LlenaClase();
            bool paso = false;

            //Verificar si es a guardar o modificar un articulo
            if (ArticuloId_numericUpDown.Value == 0)
            {
                paso = BLL.ArticulosBLL.Guardar(articulo);
            }
               
            else
            {
                paso = BLL.ArticulosBLL.Modificar(articulo);
            }
                
            
            //Notifica Si ocurrio o no
            if (paso)
                MessageBox.Show("Se Ha Guardado!!", "Congradulation!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Imposible Guardar??", "Oops!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private static void Validar()
        {

        }

        private Articulos LlenaClase()
        {
            Articulos articulo = new Articulos();

            articulo.ArticuloId = Convert.ToInt32(ArticuloId_numericUpDown.Value);
            articulo.FechaVencimiento = FechaVenc_dateTimePicker.Value;
            articulo.Descripcion = Descripcion_textBox.Text;
            articulo.Precio = Convert.ToInt32(Precio_numericUpDown.Value);
            articulo.Existencia = Convert.ToInt32(Existencia_numericUpDown.Value);            
            articulo.CantCotizada = Convert.ToInt32(CantCotizada_numericUpDown.Value);

            return articulo;
        }

        private void Nuevo_button_Click(object sender, EventArgs e)
        {
            ArticuloId_numericUpDown.Value = 0;
            FechaVenc_dateTimePicker.ResetText();
            Descripcion_textBox.Clear();
            Precio_numericUpDown.Value = 0;
            Existencia_numericUpDown.Value = 0;
            CantCotizada_numericUpDown.Value = 0;

        }

        private void Buscar_button_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ArticuloId_numericUpDown.Value);
            Articulos articulos = BLL.ArticulosBLL.Buscar(id);

            if(articulos != null)
            {
                FechaVenc_dateTimePicker.Value = Convert.ToDateTime(articulos.FechaVencimiento);
                Descripcion_textBox.Text = articulos.Descripcion;
                Precio_numericUpDown.Value = articulos.Precio;
                Existencia_numericUpDown.Value = articulos.Existencia;
                CantCotizada_numericUpDown.Value = articulos.CantCotizada;
            }
            else
            {
                MessageBox.Show("No Hay Resultado Para Esta Busqueda!!", "No Found!!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ArticuloId_numericUpDown.Value);

            if(BLL.ArticulosBLL.Eliminar(id))
            {
                MessageBox.Show("Se Ha Eliminado Satisfactoriamente!!", "Congradulation!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nuevo_button.PerformClick();
            }
                
             else
                MessageBox.Show("No Se Pudo Eliminar!!", "Algo Salio Mal!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
    }
}
