using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiTienda.Dto.Producto;
using apiTienda.Dto.Tienda;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace apiTienda.Controllers
{
    [ApiController]
    [Route("api/tienda")]
    public class TiendaController
    {
        private AplicationDbContext _DbContext;
        private readonly IMapper _mapper;
        public TiendaController(IMapper mapper, AplicationDbContext DbContext)
        {
            this._mapper = mapper;
            this._DbContext = DbContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<TiendaDto>>> ObtenerTodo()
        {
            var tiendas = await _DbContext.Tienda.ToListAsync();
            return _mapper.Map<List<TiendaDto>>(tiendas);
        }
    }
}