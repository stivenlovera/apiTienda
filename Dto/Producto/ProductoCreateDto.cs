using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiTienda.Dto.Caracteristica;
using apiTienda.Entities;

namespace apiTienda.Dto.Producto
{
    public class ProductoCreateDto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public int TiendaId { get; set; }
        public int CategoriaId { get; set; }
        public int CaracteristicaId { get; set; }
        public CaracteristicaDto Caracteristica { get; set; }
    }
}