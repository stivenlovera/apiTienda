using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiTienda.Dto.Persona;

namespace apiTienda.Dto.Vendedor
{
    public class VendedorDto
    {
        public string Ci { get; set; }
        public string Dirrecion { get; set; }
        public PersonaDto Persona { get; set; }
    }
}