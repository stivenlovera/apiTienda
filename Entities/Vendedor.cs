using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiTienda.Entities
{
    public class Vendedor
    {
        [Key]
        public int Id { get; set; }
        public string Ci { get; set; }
        public string Dirrecion { get; set; }
        public string Observaciones { get; set; }
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
        public VendedorArchivo Archivo { get; set; }
    }
}