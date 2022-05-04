using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class root
    {
        public Coordenadas coord { get; set; }
        public List<Weather> weather {get; set;}
        public Main main { get; set; }
        public wind wind { get; set; }
        public long dt { get; set; }
        public sys sys { get; set; }
    }
}
