using System.Reflection.Metadata.Ecma335;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using apiTienda.Dto.Persona;
using apiTienda.Entities;
using apiTienda.Dto.Usuario;
using apiTienda.Dto.Producto;

namespace apiTienda.Utilidades
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<PersonaCreateDto, Persona>();
            CreateMap<Persona, PersonaDto>();
            CreateMap<PersonaCreateDto, Persona>();

            CreateMap<UsuarioDto, Usuario>();
            CreateMap<Usuario, UsuarioDto>();
            CreateMap<UsuarioCreateDto, Usuario>();


            CreateMap<ProductoDto, Producto>();
            CreateMap<Producto, ProductoDto>();
        }
    }
}