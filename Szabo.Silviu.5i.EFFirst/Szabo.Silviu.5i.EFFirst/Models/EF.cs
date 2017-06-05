using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Szabo.Silviu._5i.EFFirst.Models
{
    public class EF:DbContext
    {
        public DbSet<Studente> Studenti { get; set; }
        public DbSet<Classe> Classi { get; set; }
    }
}