using AutoMapper;
using Laboratorio11_Empresariales.Application.Commands;
using Laboratorio11_Empresariales.Domain.Entities;

namespace Laboratorio11_Empresariales.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddEmpresaCommand, Empresa>();
        }
    }
}