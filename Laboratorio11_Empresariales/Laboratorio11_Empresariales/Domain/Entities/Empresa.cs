namespace Laboratorio11_Empresariales.Domain.Entities
{
    public class Empresa
    {
        public Guid Id { get; set; }
        public string Ruc { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public string? Telefono { get; set; }
    }
}