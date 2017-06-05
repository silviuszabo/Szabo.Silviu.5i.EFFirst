using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Szabo.Silviu._5i.EFFirst.Models
{
    public class Studente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public Classe Classe { get; set; }
    }
}