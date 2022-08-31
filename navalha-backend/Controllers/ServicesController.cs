using data.model;
using data.repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace navalha_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        ServicesRepository servicesRepository = new ServicesRepository();

        [HttpGet("ServiceById")]
        public dynamic GetById(int id)
        {
            ServicesModel serviceModel = servicesRepository.GetById(id);
            Dictionary<string, dynamic> returnMap = new Dictionary<string, dynamic>();


            if (serviceModel is null)
            {
                returnMap.Add("result", "user not exists");

            }
            else
            {
                returnMap.Add("result", serviceModel);
            }
            return returnMap;

        }

        [HttpPost]

        public string Post(ServicesModel model)
        {
            return servicesRepository.Create(model);
        }

        [HttpDelete]

        public string Delete(int id)
        {
            return servicesRepository.Delete(id);
        }
    }
}
