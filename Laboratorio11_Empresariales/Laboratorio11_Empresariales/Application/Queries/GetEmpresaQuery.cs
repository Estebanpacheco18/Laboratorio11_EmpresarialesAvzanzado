using Laboratorio11_Empresariales.API.DTOs;
using MediatR;

namespace Laboratorio11_Empresariales.Application.Queries
{
    public record GetEmpresaQuery(Guid Id) : IRequest<EmpresaDto>;
}