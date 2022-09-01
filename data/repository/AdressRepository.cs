using data.ContextWebApi;
using data.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.repository
{
    public class AdressRepository : BaseRepository<AdressModel>
    {
        public override List<AdressModel> GetAll()
        {
            List<AdressModel> list = new List<AdressModel>();
            using (WebApiContext context = new WebApiContext())
            {
                list = context.Adress.Include("Clients").ToList();

            }
            return list;
        }
    }
}
