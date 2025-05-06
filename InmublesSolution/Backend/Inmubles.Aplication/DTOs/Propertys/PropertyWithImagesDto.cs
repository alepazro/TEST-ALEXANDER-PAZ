using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inmubles.Aplication.DTOs.PropertysImage;
using Inmubles.Domain.Entities;

namespace Inmubles.Aplication.DTOs.Propertys
{
    public class PropertyWithImagesDto
    {
        public string? Id { get; set; }
        public int IdProperty { get; set; }
        public int IdOwner { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Price { get; set; }
        public List<PropertyImageDto> Images { get; set; }

    }
}
