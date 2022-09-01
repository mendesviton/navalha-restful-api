using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace data.model
{
    public class AdressModel : BaseModel
    {
        public string Street { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }


        [JsonIgnore]
        public ICollection<ClientModel> Clients { get; set; }

    }
}
