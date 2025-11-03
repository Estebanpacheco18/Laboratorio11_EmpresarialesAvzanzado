namespace Laboratorio11_Empresariales.API.DTOs
{
    public class EmpresaDto
    {
        public Guid Id { get; set; }
        public string Ruc { get; set; } = null!;
        public string RazonSocial { get; set; } = null!;
        public string? Telefono { get; set; }
    }
}