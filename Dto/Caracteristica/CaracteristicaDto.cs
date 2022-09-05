using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTienda.Dto.Caracteristica
{
    public class CaracteristicaDto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Otros { get; set; }
        public int ProductoTiendaId { get; set; }
    }
}