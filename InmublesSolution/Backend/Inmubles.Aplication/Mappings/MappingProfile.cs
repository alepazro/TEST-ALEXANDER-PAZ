using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Inmubles.Aplication.DTOs.Owners;
using Inmubles.Aplication.DTOs.Propertys;
using Inmubles.Aplication.DTOs.PropertysImage;
using Inmubles.Aplication.Mappings.PropertysTrace;
using Inmubles.Domain.Entities;

namespace Inmubles.Aplication.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
         {
            CreateMap<Owner, OwnerDto>().ReverseMap();
            CreateMap<Property, PropertyDto>().ReverseMap();
            CreateMap<PropertyImage, PropertyImageDto>().ReverseMap();
            CreateMap<PropertyTrace, PropertyTraceDto>().ReverseMap();
        }
    }
}
