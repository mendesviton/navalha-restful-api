using data.ContextWebApi;
using data.model;
using data.utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.repository
{
    public class ClientRepository : BaseRepository<ClientModel>
    {
        public override List<ClientModel> GetAll()
        {
            List<ClientModel> list = new List<ClientModel>();

            using (WebApiContext context = new WebApiContext())
            {
                list = context.Client.Include("Adress").ToList();

            }
            return list;
        }





        public override string Create(ClientModel model)
        {
            model.Password = Criptiografia.Criptografar(model.Password);
            return base.Create(model);
        }

        public ClientModel Logon(string password, string email)
        {
            password = Criptiografia.Criptografar(password);
            ClientModel user = new ClientModel();
            using (WebApiContext context = new WebApiContext())
            {
                user = context.Client.Where(u => u.Email == email && u.Password == password).FirstOrDefault();

            }
            return user;
        }
    }
}
