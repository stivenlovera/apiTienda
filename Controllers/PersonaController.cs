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

namespace apiTienda.Controllers
{
    [ApiController]
    [Route("api/persona")]
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
        [HttpPost("store")]
        public async Task<ActionResult<string>> store(PersonaCreateDto personaCreateDto)
        {
            var persona = _mapper.Map<Persona>(personaCreateDto);
            this._DbContext.Add(persona);
            await this._DbContext.SaveChangesAsync();
            return "";
        }
    }
}