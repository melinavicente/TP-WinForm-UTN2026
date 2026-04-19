using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    internal class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();

            AccesoDatos Datos = new AccesoDatos();

            try
            {
                Datos.setearConsulta("Select Id, Descripcion from CATEGORIAS");
                Datos.ejecutarLectura();

                while (Datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = Datos.Lector.GetInt32(0);
                    aux.Descripcion = (String)Datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                Datos.CerrarConexion();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}
