using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.model
{
    public class BarberShopModel : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Cnpj { get; set; }
        public float Stars { get; set; }

    }
}
