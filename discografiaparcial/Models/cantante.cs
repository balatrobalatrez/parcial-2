using System;
using System.Collections.Generic;
using System.Text;

namespace discografiaparcial.Models
{
    public class cantante   

    {
        public int Id { get; set; } 
        public string Nombre { get; set; }

        public List <cancion> Canciones { get; set; } = new List<cancion>();

    }
}
