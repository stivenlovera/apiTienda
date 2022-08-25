using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiTienda.Dto.Vendedor;
using apiTienda.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace apiTienda.Controllers
{
    [ApiController]
    [Route("api/vendedor")]
    public class VendedorController : ControllerBase
    {
        public AplicationDbContext _aplicationDbContext { get; }
        public IMapper _mapper { get; }

        public VendedorController(AplicationDbContext aplicationDbContext, IMapper mapper)
        {
            _aplicationDbContext = aplicationDbContext;
            _mapper = mapper;
        }

        [HttpPost()]
        public async Task<ActionResult> store(VendedorCreateDto vendedorCreateDto)
        {
            var vendedor = _mapper.Map<Vendedor>(vendedorCreateDto);
            this._aplicationDbContext.Add(vendedor);
            await this._aplicationDbContext.SaveChangesAsync();

            return Ok(new
            {
                message = "registrado correctamente"
            });
        }
        [HttpGet]
        public async Task<ActionResult<List<VendedorDto>>> ObtenerTodo()
        {
            var vendedores = await this._aplicationDbContext.Vendedor.Include(vendedor=>vendedor.Persona).ToListAsync();
            return _mapper.Map<List<VendedorDto>>(vendedores);
        }
    }
}