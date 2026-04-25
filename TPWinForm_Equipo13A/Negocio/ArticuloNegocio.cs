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
                    "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, M.Descripcion as Marca, C.Descripcion as Categoria, I.Id as IdImagen, I.IdArticulo, I.ImagenUrl as Imagen, I.Id as IdImagen, A.IdMarca, A.IdCategoria " +
					"from ARTICULOS A " +
					"INNER JOIN MARCAS M ON M.Id = A.IdMarca " +
					"INNER JOIN CATEGORIAS C ON C.Id = A.IdCategoria " +
					"LEFT JOIN IMAGENES I ON I.IdArticulo = A.Id " +
					"ORDER BY A.Id"
					);
				Datos.ejecutarLectura();

				Articulo aux = null;
				int ultimoId = -1;

                while(Datos.Lector.Read())
                {
                    int Id = (int)Datos.Lector["Id"];

                    if(Id!=ultimoId)
                    {
                        aux = new Articulo();
						aux.Id = Datos.Lector.GetInt32(0);
						aux.Nombre = (String)Datos.Lector["Nombre"];
						aux.Codigo = (String)Datos.Lector["Codigo"];
						aux.Descripcion = (String)Datos.Lector["Descripcion"];
						aux.Precio = (Decimal)Datos.Lector["Precio"];

						aux.Marca = new Marca();
						aux.Marca.Descripcion = (string)Datos.Lector["Marca"];
                        aux.Marca.Id = (int)Datos.Lector["IdMarca"];

						aux.Categoria = new Categoria();
						aux.Categoria.Descripcion = (string)Datos.Lector["Categoria"];
                        aux.Categoria.Id = (int)Datos.Lector["IdCategoria"];

                        aux.Imagenes = new List<Imagen>();

						ultimoId = Id;
						lista.Add(aux);

					}

					if (!(Datos.Lector["Imagen"] is DBNull))
					{
						Imagen img = new Imagen();
						img.URL = (string)Datos.Lector["Imagen"];
                        img.Id = (int)Datos.Lector["IdImagen"];
                        img.IdArticulo = (int)Datos.Lector["IdArticulo"];
						aux.Imagenes.Add(img);
					}
				}

				return lista;
			}
			catch (Exception ex)
			{
				throw ex;

            }
            finally
            {
                Datos.CerrarConexion();
            }

        }

            public void eliminar(int id)
            {
                AccesoDatos datos = new AccesoDatos();
                try
                {
                    datos.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @id");
                    datos.setearParametro("@id", id);
                    datos.ejecutarAccion();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void agregar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(
                    "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                    "VALUES (@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @precio)"
                );
                datos.setearParametro("@codigo", articulo.Codigo);
                datos.setearParametro("@nombre", articulo.Nombre);
                datos.setearParametro("@descripcion", articulo.Descripcion);
                datos.setearParametro("@idMarca", articulo.Marca.Id);
                datos.setearParametro("@idCategoria", articulo.Categoria.Id);
                datos.setearParametro("@precio", articulo.Precio);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void modificar(Articulo art)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("UPDATE ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdCategoria = @idcategoria, IdMarca = @idmarca Where Id =@id");
                datos.setearParametro("@codigo", art.Codigo);
                datos.setearParametro("@nombre", art.Nombre);
                datos.setearParametro("@descripcion", art.Descripcion);
                datos.setearParametro("@idcategoria", art.Categoria.Id);
                datos.setearParametro("@idmarca", art.Marca.Id);
                datos.setearParametro("@id", art.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void eliminarImagen(Imagen img)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM IMAGENES WHERE Id = @id");
                datos.setearParametro("@id", img.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public int agregarImagen(Imagen img)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO IMAGENES(IdArticulo, ImagenUrl) OUTPUT INSERTED.Id VALUES(@IdArticulo, @ImagenUrl)");
                datos.setearParametro("@IdArticulo", img.IdArticulo);
                datos.setearParametro("@ImagenUrl", img.URL);

                int idGenerado = (int)datos.ejecutarScalar();

                return idGenerado;
                                                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

    }
}