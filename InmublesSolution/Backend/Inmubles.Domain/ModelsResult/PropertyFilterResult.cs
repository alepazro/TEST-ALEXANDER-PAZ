using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmubles.Domain.ModelsResult
{
    public class PropertyFilterResult
    {
        public double? MinPrice { get; set; }
        public double? MaxPrice { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
