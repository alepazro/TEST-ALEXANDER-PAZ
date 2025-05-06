using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inmubles.Aplication.DTOs.Propertys;
using MediatR;

namespace Inmubles.Aplication.Queries.Property
{
    public class GetPropertyWithImagesQuery : IRequest<List<PropertyWithImagesDto>> {
        public double? MinPrice { get; set; }  // Filtro de precio mínimo
        public double? MaxPrice { get; set; }  // Filtro de precio máximo
        public string? Name { get; set; }       // Filtro de nombre
        public string? Address { get; set; }    // Filtro de dirección
       
    }
}
