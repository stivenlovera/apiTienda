using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiTienda.Dto.SubCategoria;

namespace apiTienda.Dto
{
    public class CategoriaCreateDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<SubCategoriaCreacion> SubCategoria { get; set; }
    }
}