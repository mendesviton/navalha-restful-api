using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.model
{
    public class ServicesModel : BaseModel
    {
        public string Service { get; set; }

        public int Duration { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
