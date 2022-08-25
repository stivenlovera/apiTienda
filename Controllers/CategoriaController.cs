using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiTienda.Dto;
using apiTienda.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace apiTienda.Controllers 
{

    public class CategoriaController :ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly AplicationDbContext _aplicationDbContext;

        public CategoriaController(IMapper mapper, AplicationDbContext aplicationDbContext)
        {
            this._mapper = mapper;
            this._aplicationDbContext = aplicationDbContext;
        }
       [HttpPost()]
        public async Task<ActionResult> store(CategoriaCreateDto categoriaCreateDto)
        {
            var vendedor = _mapper.Map<Categoria>(categoriaCreateDto);
            this._aplicationDbContext.Add(vendedor);
            await this._aplicationDbContext.SaveChangesAsync();

            return Ok(new
            {
                message = "registrado correctamente"
            });
        }
       /*  [HttpGet]
        public async Task<ActionResult<List<VendedorDto>>> ObtenerTodo()
        {
            var vendedores = await this._aplicationDbContext.Vendedor.Include(vendedor=>vendedor.Persona).ToListAsync();
            return _mapper.Map<List<VendedorDto>>(vendedores);
        }  */
    }
}