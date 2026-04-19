using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
			List<Articulo> lista = new List<Articulo>();

			AccesoDatos Datos = new AccesoDatos();

			try
            { 
				Datos.setearConsulta(
					"SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, M.Descripcion as Marca, C.Descripcion as Categoria " +
					"from ARTICULOS A " + 
					"INNER JOIN MARCAS M ON M.Id = A.IdMarca " + 
					"INNER JOIN CATEGORIAS C ON C.Id = A.IdCategoria"
					);
				Datos.ejecutarLectura();

				while(Datos.Lector.Read())
				{
					Articulo aux = new Articulo();
					aux.Id = Datos.Lector.GetInt32(0);
					aux.Nombre = (String)Datos.Lector["Nombre"];
					aux.Codigo = (String)Datos.Lector["Codigo"];
					aux.Descripcion = (String)Datos.Lector["Descripcion"];
					aux.Precio = (Decimal)Datos.Lector["Precio"];
					aux.Marca = new Marca();
					aux.Marca.Descripcion = (string)Datos.Lector["Marca"];
					aux.Categoria = new Categoria();
					aux.Categoria.Descripcion = (string)Datos.Lector["Categoria"];

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
