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
using apiTienda.Dto.Vendedor;
using apiTienda.Dto.VendedorDocumento;

namespace apiTienda.Utilidades
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<PersonaCreateDto, Persona>();
            CreateMap<Persona, PersonaDto>();

            CreateMap<VendedorCreateDto, Vendedor>();
            CreateMap<Vendedor, VendedorDto>();

            CreateMap<VendedorArchivoCreateDto, VendedorArchivo>();
            CreateMap<VendedorArchivo, VendedorArchivoDto>();

            CreateMap<UsuarioCreateDto, Usuario>();
            CreateMap<Usuario, UsuarioDto>();

            CreateMap<ProductoDto, Producto>();
            CreateMap<Producto, ProductoDto>();

        }
    }
}