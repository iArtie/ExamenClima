using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Ciudad
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Coordenadas lat { get; set; }
        public Coordenadas Longt { get; set; }
    }
}
