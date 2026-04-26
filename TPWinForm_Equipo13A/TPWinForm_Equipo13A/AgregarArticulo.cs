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
        private Articulo articulo = null;

        public AgregarArticulo()
        {
            InitializeComponent();
            btnAdministrarImg.Hide();
        }

        public AgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
            txtbAgregarURL.Hide();

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
                if(articulo == null)
                {
                    articulo = new Articulo();
                }
                articulo.Codigo = txtAgregarCodigo.Text;
                articulo.Nombre = txtAgregarNombre.Text;
                articulo.Descripcion = txtbAgregarDescripcion.Text;
                articulo.Precio = decimal.Parse(txtbAgregarPrecio.Text);
                articulo.Marca = (Marca)cmbAgregarMarca.SelectedItem;
                articulo.Categoria = (Categoria)cmbAgregarCategoria.SelectedItem;

                ArticuloNegocio negocio = new ArticuloNegocio();


                if (articulo.Id !=0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado agregado correctamente", "Yupiii", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    articulo.Id = negocio.agregar(articulo);
                    Imagen nuevaImagen = new Imagen();

                    string AgregarURL = txtbAgregarURL.Text;

                    nuevaImagen.URL = AgregarURL;
                    nuevaImagen.IdArticulo = articulo.Id;
                    nuevaImagen.Id = negocio.agregarImagen(nuevaImagen);
                    articulo.Imagenes.Add(nuevaImagen);

                    MessageBox.Show("Articulo agregado correctamente", "Yupiii", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

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

            if(articulo != null)
            {
                txtAgregarCodigo.Text = articulo.Codigo;
                txtAgregarNombre.Text = articulo.Nombre;
                txtbAgregarDescripcion.Text = articulo.Descripcion;
                cmbAgregarCategoria.SelectedValue = articulo.Categoria.Id;
                cmbAgregarMarca.SelectedValue = articulo.Marca.Id;
                txtbAgregarPrecio.Text = articulo.Precio.ToString();

            }
        }
        private void btnAgregarCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdministrarImg_Click(object sender, EventArgs e)
        {
            Imagenes formImagenes = new Imagenes(articulo);
            formImagenes.ShowDialog();

        }

    }
    }
