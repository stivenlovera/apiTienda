using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiTienda.Dto.Tienda;
using apiTienda.Entities;

namespace apiTienda.Dto.Producto
{
    public class ProductoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public TiendaDto Productos { get; set; }
        public Categoria Categoria { get; set; }
        public Caracteristica Caracteristica { get; set; }
    }
}