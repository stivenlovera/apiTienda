using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiTienda.Dto.Usuario;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace apiTienda.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private AplicationDbContext _DbContext;
        private readonly IMapper _mapper;

        public AplicationDbContext DbContext { get; }

        public UsuarioController(IMapper mapper, AplicationDbContext DbContext)
        {
            this._mapper = mapper;
            this._DbContext = DbContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<UsuarioDto>>> ObtenerTodo()
        {
            var usuarios = await _DbContext.Usuario.ToListAsync();
            return _mapper.Map<List<UsuarioDto>>(usuarios);
        }
        [HttpPost]
        public async Task<ActionResult> store(UsuarioCreateDto usuarioCreateDto)
        {
            var usuario = _mapper.Map<UsuarioDto>(usuarioCreateDto);
            this._DbContext.Add(usuario);
            await this._DbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<UsuarioDto>> ObtenerUno(int id)
        {
            var usuario = await _DbContext.Usuario.FirstOrDefaultAsync(usuario => usuario.Id == id);
            if (usuario == null)
            {
                return NotFound();
            }
            return _mapper.Map<UsuarioDto>(usuario);
        }

    }
}