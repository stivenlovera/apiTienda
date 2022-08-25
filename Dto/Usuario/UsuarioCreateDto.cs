using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiTienda.Dto.Usuario
{
    public class UsuarioCreateDto
    {
        [Required(ErrorMessage = "El campo Usuario es Requerido")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Maximo de 20 caracteres y un minimo de 8")]
        public string User { get; set; }
        [Required(ErrorMessage = "El campo Contraseña es Requerido")]
        [StringLength(20, MinimumLength = 7, ErrorMessage = "Maximo de 20 caracteres y un minimo de 7")]
        public string Contraseña { get; set; }
    }
}