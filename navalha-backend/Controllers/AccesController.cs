using data.model;
using data.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using navalha_backend.DTO;

namespace navalha_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccesController : ControllerBase
    {
        [HttpPost("Logon")]
        public ClientModel Logon(UsuarioDTO UsuarioDto)
        {
            ClientRepository repo = new ClientRepository();
            ClientModel user = repo.Logon( UsuarioDto.password, UsuarioDto.email);
            return user;
        }
    }
}
