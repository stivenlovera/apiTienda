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
        public string Otros { get; set; }
        [ForeignKey("CaracteristicaId")]
        public List<Producto> Producto { get; set; }
    }
}