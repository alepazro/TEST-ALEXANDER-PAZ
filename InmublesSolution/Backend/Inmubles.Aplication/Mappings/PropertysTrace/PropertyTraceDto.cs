using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmubles.Aplication.Mappings.PropertysTrace
{
    public class PropertyTraceDto
    {
        public string Id { get; set; }
        public int IdPropertyTrace { get; set; }
        public DateTime DateSale { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public double Tax { get; set; }
        public int IdProperty { get; set; }
    }
}
