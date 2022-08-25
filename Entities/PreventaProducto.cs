using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiTienda.Entities
{
    public class PreventaProducto
    {
        [Key]
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int PreventaId { get; set; }
        public Producto Producto { get; set; }
        public Preventa Preventa { get; set; }
    }
}