using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmubles.Infrastructure.Models
{
    public class PropertyFilter
    {
        public double? MinPrice { get; set; }
        public double? MaxPrice { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
