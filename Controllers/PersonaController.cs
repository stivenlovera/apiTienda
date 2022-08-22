using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiTienda.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiTienda.Servicios;

namespace apiTienda.Controllers
{
    [ApiController]
    [Route("api/persona")]
    public class PersonaController : ControllerBase
    {
        private PersonaService _PersonaService;
        public PersonaController(PersonaService PersonaService)
        {
            this._PersonaService=PersonaService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Persona>>> MostrarTodo(){
            var personas=await _PersonaService.MostrasTodo();
            return personas;
        }
    }
}