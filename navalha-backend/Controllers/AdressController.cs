using data.model;
using data.repository;
using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers;

namespace navalha_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdressController: GenericController<AdressModel, AdressRepository>
    {
      
    }
}
