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
        public int SubCategoriaId { get; set; }
        public SubCategoria SubCategoria { get; set; }
        public List<ProductoTienda> ProductosTienda { get; set; }
        public List<PreventaProducto> PreventaProducto { get; set; }
    }
}