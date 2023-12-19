using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Context : DbContext
    {
        public Context() : base("Asp_Net_MVC_CS")
        {
            Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());
        }
        public DbSet<AreaConhecimento> AreaConhecimento { get; set; }
        public DbSet<Curso> Cursos { get; set; }
    }
}