using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.model
{
    
        public class BarberModel : BaseModel
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string PhoneNumber { get; set; }
            public string Cnpj { get; set; }
            public double Star { get; set; }

        public int BarberShopId { get; set; }
        [ForeignKey("BarberShopId")]


        public BarberShopModel? BarberShop { get; set; }
        public override string ToString()
            {
                return base.ToString();
            }
        

    }
}
