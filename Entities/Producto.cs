using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace apiTienda.Entities
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        [Column("TiendaId")]
        public Tienda Productos { get; set; }
        [Column("CategoriaId")]
        public Categoria Categoria { get; set; }
        [Column("CaracteristicaId")]
        public Caracteristica Caracteristica { get; set; }
        [Column("ProductoId")]
        public List<Preventa> Preventa { get; set; }
    }
}