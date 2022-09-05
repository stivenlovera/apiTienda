using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiTienda.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiTienda.Servicios;
using apiTienda.IServicios;
using Microsoft.AspNetCore.Authorization;
using apiTienda.Filtros;
using apiTienda.Dto.Persona;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace apiTienda.Controllers
{
    [ApiController]
    [Route("api/persona")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PersonaController : ControllerBase
    {
        private AplicationDbContext _DbContext;
        private readonly IMapper _mapper;
        private readonly IServicio _servicio;
        /*private PersonaService _PersonaService;*/
        private readonly ServicioTransit _servicioTransit;
        private readonly ServicioScope _servicioScope;
        private readonly ServicioSingelton _servicioSingelton;
        private readonly ILogger<PersonaController> _ILogger;

        public PersonaController(
            IServicio servicio,
            /* PersonaService PersonaService*/
            ServicioTransit servicioTransit,
            ServicioScope servicioScope,
            ServicioSingelton servicioSingelton,
            ILogger<PersonaController> Ilogger,
            AplicationDbContext DbContext,
            IMapper mapper
            )
        {
            /*this._PersonaService = PersonaService;*/
            this._servicioScope = servicioScope;
            this._servicioSingelton = servicioSingelton;
            this._servicioTransit = servicioTransit;
            this._ILogger = Ilogger;
            this._DbContext = DbContext;
            this._mapper = mapper;
            this._servicio = servicio;
        }
        /* [HttpGet]
        public async Task<ActionResult<List<Persona>>> MostrarTodo()
        {
            var personas = await _PersonaService.MostrasTodo();
            return personas;
        } */
        [HttpGet("guid")]
        //[ResponseCache(Duration = 5)]
        [ServiceFilter(typeof(MiFilterAction))]
        public ActionResult ObtenerGuid()
        {
            _ILogger.LogInformation("este el log de guid");
            _ILogger.LogWarning("este el log de advertencia guid");
            return Ok(new
            {
                servicioTransit = _servicioTransit.Guid,
                ServicioA_transit = _servicio.ObtenerTransit(),

                servicioScope = _servicioScope.Guid,
                ServicioA_scopet = _servicio.ObtenerScope(),

                ServicioSingelton = _servicioSingelton.Guid,
                ServicioA_singelton = _servicio.ObtenerSingelton()
            });
        }
        [HttpGet("test")]
        //[ResponseCache(Duration = 5)]
        //[Authorize]
        [ServiceFilter(typeof(MiFilterAction))]
        public ActionResult Test()
        {

            return Ok(
                new
                {
                    test = "protejido"
                }
            );
        }
        [HttpPost]
        public async Task<ActionResult> store(PersonaCreateDto personaCreateDto)
        {
            var persona = _mapper.Map<Persona>(personaCreateDto);
            this._DbContext.Add(persona);
            await this._DbContext.SaveChangesAsync();

            return Ok(new
            {
                message = "registrado correctamente"
            });
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<List<PersonaDto>>> ObtenerTodo()
        {
            var personas = await _DbContext.Persona.Include(personas => personas.Usuario).ToListAsync();
            return _mapper.Map<List<PersonaDto>>(personas);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<PersonaDto>> ObtenerUno(int id)
        {
            var persona = await _DbContext.Persona.FirstOrDefaultAsync(persona => persona.Id == id);
            if (persona == null)
            {
                return NotFound();
            }
            return _mapper.Map<PersonaDto>(persona);
        }
        [HttpGet("{nombre}")]
        public async Task<ActionResult<List<PersonaDto>>> ObtenerUnoNombre(string nombre)
        {
            System.Console.WriteLine("aki");
            var personas = await _DbContext.Persona.Where(persona => persona.Nombre.Contains(nombre)).ToListAsync();
            return _mapper.Map<List<PersonaDto>>(personas);
        }
    }
}