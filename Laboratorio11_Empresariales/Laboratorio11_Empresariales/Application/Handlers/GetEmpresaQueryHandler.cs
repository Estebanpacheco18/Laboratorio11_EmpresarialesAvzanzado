using Laboratorio11_Empresariales.API.DTOs;
using Laboratorio11_Empresariales.Application.Queries;
using Laboratorio11_Empresariales.Domain.Entities;
using Laboratorio11_Empresariales.Infrastructure;
using MediatR;

namespace Laboratorio11_Empresariales.Application.Handlers
{
    internal sealed class GetEmpresaQueryHandler : IRequestHandler<GetEmpresaQuery, EmpresaDto>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetEmpresaQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<EmpresaDto> Handle(GetEmpresaQuery request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.Repository<Empresa>().GetByIdAsync(request.Id);
            return new EmpresaDto
            {
                Id = entity.Id,
                Ruc = entity.Ruc,
                RazonSocial = entity.RazonSocial,
                Telefono = entity.Telefono
            };
        }
    }
}