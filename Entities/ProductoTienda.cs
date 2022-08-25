using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiTienda.Entities
{
    public class ProductoTienda
    {
        [Key]
        public int Id { get; set; }
        public int TiendaId { get; set; }
        public int ProductoId { get; set; }
        public Tienda Tienda { get; set; }
        public Producto Producto { get; set; }
        public List<Caracteristica> Caracteristica { get; set; }
    }
}