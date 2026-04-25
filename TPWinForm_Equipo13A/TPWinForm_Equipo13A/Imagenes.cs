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

        public Imagenes()
        {
            InitializeComponent();
        }

        public Imagenes(Articulo art)
        {
            InitializeComponent();
            listaImagenes = art.Imagenes;
        }

        private void Imagenes_Load(object sender, EventArgs e)
        {
            dgvImagenes.DataSource = listaImagenes;
        }
    }
}
