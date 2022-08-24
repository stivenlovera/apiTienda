using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiTienda.Dto.Usuario
{
    public class UsuarioCreateDto
    {
        [Required]
        public string User { get; set; }
        public string Contraseña { get; set; }
    }
}