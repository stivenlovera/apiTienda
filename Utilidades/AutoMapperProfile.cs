using System.Reflection.Metadata.Ecma335;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using apiTienda.Dto.Persona;
using apiTienda.Entities;

namespace apiTienda.Utilidades
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<PersonaCreateDto, Persona>();
        }
    }
}