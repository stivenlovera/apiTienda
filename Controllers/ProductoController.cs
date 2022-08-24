using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiTienda.Dto.Producto;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace apiTienda.Controllers
{
    [ApiController]
    [Route("api/producto")]
    public class ProductoController : ControllerBase
    {
        private AplicationDbContext _DbContext;
        private readonly IMapper _mapper;
        public ProductoController(IMapper mapper, AplicationDbContext DbContext)
        {
            this._mapper = mapper;
            this._DbContext = DbContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<ProductoDto>>> ObtenerTodo()
        {
            var producto = await _DbContext.Usuario.ToListAsync();
            return _mapper.Map<List<ProductoDto>>(producto);
        }
    }
}