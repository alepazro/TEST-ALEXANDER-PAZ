using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inmubles.Domain.Entities;

namespace Inmubles.Infrastructure.Models
{
    public class PropertyWithImages
    {
        public int IdProperty { get; set; }
        public int IdOwner { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Price { get; set; }
        public List<PropertyImage> Images { get; set; }
    }
}
