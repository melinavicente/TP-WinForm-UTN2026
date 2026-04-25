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
using dominio;
using System.Data.SqlClient;

namespace TPWinForm_Equipo13A
{
    public partial class Imagenes : Form
    {
        private List<Imagen> listaImagenes;

        private Articulo articulo;

        public Imagenes()
        {
            InitializeComponent();
        }

        public Imagenes(Articulo art)
        {
            InitializeComponent();
            articulo = art;
            listaImagenes = articulo.Imagenes;
        }

        private void Imagenes_Load(object sender, EventArgs e)
        {
            dgvImagenes.DataSource = listaImagenes;
            dgvImagenes.Columns["IdArticulo"].Visible = false;
            dgvImagenes.AutoResizeColumns();
            pcbImagenes.Visible = true;
            dgvImagenes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvImagenes.MultiSelect = false;

            if (listaImagenes != null && listaImagenes.Count > 0)
            {
                pcbImagenes.LoadAsync(listaImagenes[0].URL);
            }
            else
            {
                pcbImagenes.Visible = false;
                lblnoImg.Visible = true;
            }

        }

        private void dgvImagenes_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvImagenes.CurrentRow != null)
                {
                    Imagen img = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;

                    if (img != null)
                        pcbImagenes.LoadAsync(img.URL);
                }
                else
                {
                    pcbImagenes.Visible = false;
                    lblnoImg.Visible = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            if(dgvImagenes.SelectedRows.Count == -1)
            {
                MessageBox.Show("Por favor, seleccione una imagen para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("Estas por eliminar una imagen", "Confirmar eliminación",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(confirmacion == DialogResult.Yes)
            {

                Imagen img = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;

                ArticuloNegocio negocio = new ArticuloNegocio();
                negocio.eliminarImagen(img);

                listaImagenes.Remove(img);

            }
            
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if(txtAgregarNuevaURL.Text == "")
            {
                MessageBox.Show("Ingrese una URL");
            }
            else
            {
                Imagen nuevaImagen = new Imagen();
                ArticuloNegocio negocio = new ArticuloNegocio();

                string AgregarURL = txtAgregarNuevaURL.Text;

                nuevaImagen.URL = AgregarURL;
                nuevaImagen.IdArticulo = articulo.Id;

                negocio.agregarImagen(nuevaImagen);

                listaImagenes.Add(nuevaImagen);


            }

        }

    }
}
