using AutoMapper;
using Laboratorio11_Empresariales.Application.Commands;
using Laboratorio11_Empresariales.Domain.Entities;
using Laboratorio11_Empresariales.Infrastructure;
using MediatR;

namespace Laboratorio11_Empresariales.Application.Handlers
{
    internal sealed class AddEmpresaCommandHandler : IRequestHandler<AddEmpresaCommand, Guid>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AddEmpresaCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(AddEmpresaCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Empresa>(request);
            _unitOfWork.Repository<Empresa>().AddEntity(entity);
            await _unitOfWork.Complete();
            return entity.Id;
        }
    }
}