using MediatR;

namespace Laboratorio11_Empresariales.Application.Commands
{
    public record AddEmpresaCommand : IRequest<Guid>
    {
        public string Ruc { get; init; } = null!;
        public string RazonSocial { get; init; } = null!;
        public string? Telefono { get; init; }
    }
}