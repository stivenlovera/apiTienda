using apiTienda.Dto.Caracteristica;
using apiTienda.Dto.Categoria;
using apiTienda.Dto.Tienda;

namespace apiTienda.Dto.Producto
{
    public class ProductoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public TiendaDto Tienda { get; set; }
        public CategoriaDto Categoria { get; set; }
        public CaracteristicaDto Caracteristica { get; set; }
    }
}