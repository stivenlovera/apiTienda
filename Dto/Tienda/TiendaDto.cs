using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiTienda.Dto.Usuario;

namespace apiTienda.Dto.Tienda
{
    public class TiendaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Nit { get; set; }
        public string Dirrecion { get; set; }
        public string Departamento { get; set; }
        public int UsuarioId { get; set; }
        public UsuarioDto Usuario { get; set; }
    }
}