using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace apiTienda.Entities
{
    public class Preventa
    {
        [Key]
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public double PrecioTotal { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public List<PreventaProducto> PreventaProducto { get; set; }
    }
}