using System;
using System.Collections.Generic;
using System.Text;

namespace discografiaparcial.Models
{
    public class cancion
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Duracion { get; set; }
        public int CantanteId { get; set; }
        public cantante Cantante { get; set; }
    }
}
