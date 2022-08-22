using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiTienda.Entities;
using Microsoft.EntityFrameworkCore;

namespace apiTienda.Servicios
{
    public class PersonaService
    {
        private AplicationDbContext _DbContext;
        public PersonaService(AplicationDbContext DbContext)
        {
            this._DbContext = DbContext;
        }
        public async Task<List<Persona>> MostrasTodo()
        {
            var personas = await this._DbContext.Persona.ToListAsync();
            return personas;
        }
    }
}