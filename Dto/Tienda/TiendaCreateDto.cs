using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTienda.Dto.Tienda
{
    public class TiendaCreateDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Nit { get; set; }
        public string Dirrecion { get; set; }
        public int DepartamentoId { get; set; }
        public int UsuarioId { get; set; }
    }
}