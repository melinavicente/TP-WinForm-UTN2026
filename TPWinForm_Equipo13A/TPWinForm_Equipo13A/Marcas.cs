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
    public partial class Marcas : Form
    {
        private MarcaNegocio negocio = new MarcaNegocio();
        private List<Marca> listaMarcas; 
        public Marcas()
        {
            InitializeComponent();
        }

        private void actualizarListado(MarcaNegocio marcaNegocio)
        {
            listaMarcas = marcaNegocio.listar();
            lsbMarcas.DataSource = listaMarcas;
            lsbMarcas.DisplayMember = "Descripcion";
            lsbMarcas.ValueMember = "Id";
        }

        private void Marcas_Load(object sender, EventArgs e)
        {

            try
            {
                actualizarListado(negocio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar marcas: " + ex.Message);
            }

        }

        private void lsbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbMarcas.SelectedItem == null) return;
            Marca marcaSeleccionado = listaMarcas[lsbMarcas.SelectedIndex];
            txtDescripcion.Text = marcaSeleccionado.Descripcion; 

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lsbMarcas.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una marca.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Ingrese una descripción.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Marca seleccionado = (Marca)lsbMarcas.SelectedItem;
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
                Marca nueva = new Marca();
                nueva.Descripcion = txtDescripcion.Text;
                negocio.agregar(nueva);
                MessageBox.Show("Marca agregada correctamente.");
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
            if (lsbMarcas.SelectedItems == null)
            {
                MessageBox.Show("Seleccione una marca.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult confirmacion = MessageBox.Show("Estas por eliminar un articulo", "Confirmar eliminación",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    Marca seleccionada = (Marca)lsbMarcas.SelectedItem;
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

        private void Marcas_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            MainMenu mn = new MainMenu();
            mn.Show(); 

        }
    }
}
