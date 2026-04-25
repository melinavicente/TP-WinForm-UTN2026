using dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_Equipo13A
{
    public partial class Categorias : Form
    {

            private CategoriaNegocio negocio = new CategoriaNegocio();
            private List<Categoria> listaCategoria;
            public Categorias()
            {
                InitializeComponent();
            }

            private void actualizarListado(CategoriaNegocio categoriaNegocio)
            {
                listaCategoria = categoriaNegocio.listar();
                lsbCategorias.DataSource = listaCategoria;
                lsbCategorias.DisplayMember = "Descripcion";
                lsbCategorias.ValueMember = "Id";
            }

            private void Categorias_Load(object sender, EventArgs e)
            {

                try
                {
                    actualizarListado(negocio);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar categorias: " + ex.Message);
                }

            }

            private void lsbCategorias_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (lsbCategorias.SelectedItem == null) return;
                Categoria categoriaSeleccionado = listaCategoria[lsbCategorias.SelectedIndex];
                txtDescripcion.Text = categoriaSeleccionado.Descripcion;

            }



        private void lblArticulos_Click(object sender, EventArgs e) { }

            private void btnModificar_Click(object sender, EventArgs e)
            {
                if (lsbCategorias.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una categoria.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Ingrese una descripción.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    Categoria seleccionado = (Categoria)lsbCategorias.SelectedItem;
                    seleccionado.Descripcion = txtDescripcion.Text;
                    negocio.modificar(seleccionado); 

                    actualizarListado(negocio);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar: " + ex.Message);
                }
            }

            private void btnAgregar_Click(object sender, EventArgs e)
            {
                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("Ingrese una descripción.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    Categoria nueva = new Categoria();
                    nueva.Descripcion = txtDescripcion.Text;
                    negocio.agregar(nueva);
                    MessageBox.Show("Categoria agregada correctamente.");
                    txtDescripcion.Text = "";
                    actualizarListado(negocio);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar: " + ex.Message);
                }
            }

            private void btnEliminar_Click(object sender, EventArgs e)
            {
                if (lsbCategorias.SelectedItems == null)
                {
                    MessageBox.Show("Seleccione una categoria.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult confirmacion = MessageBox.Show("Estas por eliminar una categoria", "Confirmar eliminación",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        Categoria seleccionada = (Categoria)lsbCategorias.SelectedItem;
                        negocio.eliminar(seleccionada.Id);
                        txtDescripcion.Text = "";
                        actualizarListado(negocio);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }
                }
            }

            private void Categorias_FormClosed_1(object sender, FormClosedEventArgs e)
            {
                MainMenu mn = new MainMenu();
                mn.Show();

            }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
