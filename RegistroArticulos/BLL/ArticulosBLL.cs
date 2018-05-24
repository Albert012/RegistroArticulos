using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RegistroArticulos.DAL;
using RegistroArticulos.Entidades;
using System.Data.Entity;
using System.Linq.Expressions;

namespace RegistroArticulos.BLL
{
    /// <summary>
    /// Aqui van todas las operaciones a realizar
    /// </summary>
    public class ArticulosBLL
    {
        /// <summary>
        /// A que podremos guardar en la entidad de la base de datos
        /// </summary>
        /// <param name="articulo"></param>
        /// <returns></returns>
        public static bool Guardar(Articulos articulo)
        {
            bool paso = false;
            //nuestra variable que nos dara acceso a la base de datos
            Contexto contexto = new Contexto();
            try
            {
                if(contexto.articulos.Add(articulo)!=null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();                
            }
            catch(Exception)
            {
                throw;
            }
            return paso;

        }

        /// <summary>
        /// En esta parte podemos modificar el articulo ya creado
        /// </summary>
        /// <param name="articulo"></param>
        /// <returns></returns>
        public static bool Modificar(Articulos articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(articulo).State = EntityState.Modified;
                if(contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch(Exception)
            {
                throw;
            }
            return paso;
        }

        /// <summary>
        /// Se puede eliminar un articulo mediante la busqueda de su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Articulos articulo = contexto.articulos.Find(id);
                contexto.articulos.Remove(articulo);

                if(contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        /// <summary>
        /// En esta parte podemos buscar un articulo mediante su id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Articulos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Articulos articulo = new Articulos();

            try
            {
                articulo = contexto.articulos.Find(id);
                contexto.Dispose();
            }
            catch(Exception)
            {
                throw;
            }
            return articulo;

        }

        /// <summary>
        /// permite extraer una lista de articulos
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public static List<Articulos> GetList(Expression<Func<Articulos,bool>> expression)
        {
            List<Articulos> articulos = new List<Articulos>();
            Contexto contexto = new Contexto();

            try
            {
                articulos = contexto.articulos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch(Exception)
            {
                throw;
            }
            return articulos;
        }

    }
}
