using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiTienda.Dto.Usuario;

namespace apiTienda.Dto.Persona
{
    public class PersonaDto
    {
        public int Id { get; set; }
        public string Ci { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNac { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Dirrecion { get; set; }
        public string Observaciones { get; set; }
        public string ImageDocumento { get; set; }
        public string Estado { get; set; }
        public UsuarioDto Usuario { get; set; }
    }
}