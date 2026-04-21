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
    public partial class AgregarArticulo : Form
    {
        public AgregarArticulo()
        {
            InitializeComponent();
        }

        private void btnAgregarAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAgregarCodigo.Text) ||
            string.IsNullOrWhiteSpace(txtAgregarNombre.Text) ||
            string.IsNullOrWhiteSpace(txtbAgregarDescripcion.Text) ||
            string.IsNullOrWhiteSpace(txtbAgregarPrecio.Text))
            {
                MessageBox.Show("Complete todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Articulo nuevo = new Articulo();
                nuevo.Codigo = txtAgregarCodigo.Text;
                nuevo.Nombre = txtAgregarNombre.Text;
                nuevo.Descripcion = txtbAgregarDescripcion.Text;
                nuevo.Precio = decimal.Parse(txtbAgregarPrecio.Text);
                nuevo.Marca = (Marca)cmbAgregarMarca.SelectedItem;
                nuevo.Categoria = (Categoria)cmbAgregarCategoria.SelectedItem;

                ArticuloNegocio negocio = new ArticuloNegocio();
                negocio.agregar(nuevo);

                MessageBox.Show("Articulo agregado correctamente", "Yupiii", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAgregarPrecio_Click(object sender, EventArgs e)
        {

        }

        private void AgregarArticulo_Load_1(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            cmbAgregarMarca.DataSource = marcaNegocio.listar();
            cmbAgregarMarca.DisplayMember = "Descripcion";
            cmbAgregarMarca.ValueMember = "Id";

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cmbAgregarCategoria.DataSource = categoriaNegocio.listar();
            cmbAgregarCategoria.DisplayMember = "Descripcion";
            cmbAgregarCategoria.ValueMember = "Id";
        }
    }
    }
