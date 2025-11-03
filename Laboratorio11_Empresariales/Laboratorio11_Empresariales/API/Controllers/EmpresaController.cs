using Laboratorio11_Empresariales.API.DTOs;
using Laboratorio11_Empresariales.Domain.Entities;
using Laboratorio11_Empresariales.Infrastructure;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorio11_Empresariales.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpresaController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;

        public EmpresaController(IMediator mediator, IUnitOfWork unitOfWork)
        {
            _mediator = mediator;
            _unitOfWork = unitOfWork;
        }

        [HttpPost("users")]
        public async Task<IActionResult> AddUser([FromBody] UserDto userDto)
        {
            var user = new user
            {
                user_id = Guid.NewGuid(),
                username = userDto.Username,
                password_hash = userDto.PasswordHash, // Contraseña sin encriptar
                email = userDto.Email,
                created_at = DateTime.UtcNow
            };

            _unitOfWork.Repository<user>().AddEntity(user);
            await _unitOfWork.Complete();

            return Ok(user.user_id);
        }

        [HttpGet("users/{id}")]
        public async Task<IActionResult> GetUser(Guid id)
        {
            var user = await _unitOfWork.Repository<user>().GetByIdAsync(id);
            if (user == null)
            {
                return NotFound("Usuario no encontrado");
            }

            var userDto = new UserDto
            {
                Username = user.username,
                Email = user.email
            };

            return Ok(userDto);
        }
    }
}