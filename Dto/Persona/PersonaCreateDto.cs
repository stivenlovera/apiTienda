using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using apiTienda.Dto.Usuario;

namespace apiTienda.Dto.Persona
{
    public class PersonaCreateDto
    {
        [Required(ErrorMessage = "El campo nombre es Requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo apellido es Requerido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El campo de nacimiento es Requerido")]
        public DateTime FechaNac { get; set; }
        [Required(ErrorMessage = "El campo de email es Requerido")]
        public string Email { get; set; }
        public string Celular { get; set; } = "";
        public string Estado { get; set; } = "activo";
        public UsuarioCreateDto Usuario { get; set; }
    }
}