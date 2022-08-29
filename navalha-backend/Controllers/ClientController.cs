using data.model;
using data.repository;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace navalha_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        ClientRepository clientRepository;
        
        
        public ClientController()
        {
            clientRepository = new ClientRepository();
        }

        [HttpGet]
        public dynamic Get()
        {
            List<ClientModel> clientModelList = clientRepository.GetAll();
            Dictionary<string, dynamic> returnMap = new Dictionary<string, dynamic>();

            if (clientModelList.Count == 0)
            {
                returnMap.Add("result", "user not exists");
            }
            else
            {
                returnMap.Add("result", clientRepository.GetAll());
            }
            return returnMap;
        }

        [HttpPost]
        public string Post(ClientModel model)
        {

            return clientRepository.Create(model);


        }

        [HttpDelete]
        public string Delete(int id)
        {
            return clientRepository.Delete(id);
        }

        [HttpGet, Route("ClientById")]
        public dynamic GetById(int id)
        {
            ClientModel clientModel = clientRepository.GetById(id);
            Dictionary<string, dynamic> returnMap = new Dictionary<string, dynamic>();


            if (clientModel is null)
            {
               returnMap.Add("result","user not exists");

            }
            else
            {
                returnMap.Add("result", clientModel);
            }
            return returnMap;

        }



    }
}
