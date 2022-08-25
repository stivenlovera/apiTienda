using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiTienda.Entities
{
    public class Caracteristica
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
         [Column(TypeName = "text")]
        public string Otros { get; set; }
        public int ProductoTiendaId { get; set; }
        public ProductoTienda ProductoTienda { get; set; }
    }
}