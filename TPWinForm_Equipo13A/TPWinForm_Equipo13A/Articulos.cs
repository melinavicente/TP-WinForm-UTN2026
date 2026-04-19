using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using Negocio;

namespace TPWinForm_Equipo13A
{
    public partial class Articulos : Form
    {
        private List<Articulo> listaArticulos;
        public Articulos()
        {
            InitializeComponent();
        }

         private void Articulos_Load(object sender, EventArgs e) 
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();

                lsbListadoArticulos.DataSource = listaArticulos;
                lsbListadoArticulos.DisplayMember = "Nombre";
                lsbListadoArticulos.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar artículos: " + ex.Message);
            }

        }
        private void lsbListadoArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {

            Articulo ArticuloSeleccionado = listaArticulos[lsbListadoArticulos.SelectedIndex];

            lblItemId.Text = ArticuloSeleccionado.Codigo;
            lblItemNombre.Text = ArticuloSeleccionado.Nombre;
            lblItemDescripcion.Text = ArticuloSeleccionado.Descripcion;
            lblItemPrecio.Text = ArticuloSeleccionado.Precio.ToString();
            lblItemMarca.Text = ArticuloSeleccionado.Marca.Descripcion;
            lblItemCategoria.Text = ArticuloSeleccionado.Categoria.Descripcion;


        }

        //PORQUE NO SE ENVIAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (lsbListadoArticulos.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un artículo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("Estas por eliminar un articulo", "Confirmar eliminación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                lsbListadoArticulos.Items.RemoveAt(lsbListadoArticulos.SelectedIndex);

                lblItemId.Text = "";
                lblItemNombre.Text = "";
                lblItemDescripcion.Text = "";
                lblItemPrecio.Text = "";
                lblItemMarca.Text = "";
                lblItemCategoria.Text = "";
            }
        }
        private void grpbDetalleProducto_Enter(object sender, EventArgs e) { }
        private void picProducto_Click(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btn_modificar_Click(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

      

    }
}
