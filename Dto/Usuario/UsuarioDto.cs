using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTienda.Dto.Usuario
{
    public class UsuarioDto
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Contraseña { get; set; }
    }
}