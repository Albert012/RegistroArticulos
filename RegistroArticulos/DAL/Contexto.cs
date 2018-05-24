using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using RegistroArticulos.Entidades;

namespace RegistroArticulos.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Articulos> articulos { get; set; }

        public Contexto() : base("ConStr")
        {

        }

    }
}
