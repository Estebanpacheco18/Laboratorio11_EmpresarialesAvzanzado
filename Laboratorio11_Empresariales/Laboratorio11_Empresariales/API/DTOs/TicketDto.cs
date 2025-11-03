namespace Laboratorio11_Empresariales.API.DTOs
{
    public class TicketDto
    {
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string Status { get; set; } = null!;
        public Guid UserId { get; set; }
    }
}