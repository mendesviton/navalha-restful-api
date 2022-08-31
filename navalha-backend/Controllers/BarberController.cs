using data.model;
using data.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers;

namespace navalha_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarberController : GenericController<BarberModel, BarberRepository>
    {
        public BarberController() : base(new BarberRepository())
        {
        }
    }
}
