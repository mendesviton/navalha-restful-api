using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace data.model
{
    public class ClientModel : BaseModel
    {
        public string  Name { get; set; }
        public string Cep { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int  AdressId { get; set; }
        [ForeignKey("AdressId")]

        
        public AdressModel? Adress { get; set; } 



        public override string ToString()
        {
            return base.ToString();
        }
    }
}
