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

namespace TPWinForm_Equipo13A
{
    public partial class Articulos : Form
    {
        public Articulos()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Articulos_Load(object sender, EventArgs e)
        {

        }

        private void lsbListadoArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {

            Articulo SelectedArticulo = new Articulo();

            if (lsbListadoArticulos.SelectedIndex == 0)
            {
            //Le asigno valores para testear si funciona rapido, lo pueden borrar si quieren
            //Se que se puede optimizar, pero tengo sueño y queria testearlo nomas :p
            SelectedArticulo.Id = 1;
            SelectedArticulo.Nombre = "Basura";
            SelectedArticulo.Codigo = "100";
            SelectedArticulo.Descripcion = "Sirve para nada";
            SelectedArticulo.Precio = 1000;
            //SelectedArticulo.Marca = "Pepito";
            //SelectedArticulo.Categoria = "Basura";

            lblItemId.Text = SelectedArticulo.Codigo.ToString();
            lblItemNombre.Text = SelectedArticulo.Nombre.ToString();
            lblItemDescripcion.Text = SelectedArticulo.Descripcion.ToString();
            lblItemPrecio.Text = SelectedArticulo.Precio.ToString();
            //lblItemMarca.Text = SelectedArticulo.Marca.ToString();
            //lblItemCategoria.Text = SelectedArticulo.Categoria.ToString();
            }
            else if (lsbListadoArticulos.SelectedIndex == 1)
            {
                SelectedArticulo.Id = 2;
                SelectedArticulo.Nombre = "Compu";
                SelectedArticulo.Codigo = "200";
                SelectedArticulo.Descripcion = "Dispositivo";
                SelectedArticulo.Precio = 150000;
                //SelectedArticulo.Marca = "Pepito";
                //SelectedArticulo.Categoria = "Basura";

                lblItemId.Text = SelectedArticulo.Codigo.ToString();
                lblItemNombre.Text = SelectedArticulo.Nombre.ToString();
                lblItemDescripcion.Text = SelectedArticulo.Descripcion.ToString();
                lblItemPrecio.Text = SelectedArticulo.Precio.ToString();
                //lblItemMarca.Text = SelectedArticulo.Marca.ToString();
                //lblItemCategoria.Text = SelectedArticulo.Categoria.ToString();
            }


        }

        private void grpbDetalleProducto_Enter(object sender, EventArgs e)
        {

        }

        private void picProducto_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

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

    }
}
