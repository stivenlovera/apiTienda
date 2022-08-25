using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using apiTienda.Dto.Persona;
using apiTienda.Dto.Usuario;
using apiTienda.Dto.VendedorDocumento;

namespace apiTienda.Dto.Vendedor
{
    public class VendedorCreateDto
    {
        [Required(ErrorMessage = "El campo CI es Requerido")]
        [StringLength(20, MinimumLength = 7, ErrorMessage = "Maximo de 20 caracteres y un minimo de 7")]
        public string Ci { get; set; }
        [Required(ErrorMessage = "El campo Dirrecion es Requerido")]
        [StringLength(256, MinimumLength = 7, ErrorMessage = "Describa su dirrecion mas de 7 caracteres")]
        public string Dirrecion { get; set; }
        [Required]
        public PersonaCreateDto Persona { get; set; }
    }
}