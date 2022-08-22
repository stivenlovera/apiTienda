using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace apiTienda.Entities
{
    public class Tienda
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Nit { get; set; }
        public string Dirrecion { get; set; }
        public string Departamento { get; set; }
        [Column("UsuarioId")]
        public Usuario Usuario { get; set; }
        [ForeignKey("TiendaId")]
        public List<Producto> Productos { get; set; }
    }
}