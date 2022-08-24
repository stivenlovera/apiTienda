using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiTienda.Entities
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string User { get; set; }
        public string Contraseña { get; set; }
        [Column("PersonaId")]
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
        public List<Tienda> Tienda { get; set; }
        [Column("UsuarioId")]
        public List<Preventa> Preventa { get; set; }
    }
}