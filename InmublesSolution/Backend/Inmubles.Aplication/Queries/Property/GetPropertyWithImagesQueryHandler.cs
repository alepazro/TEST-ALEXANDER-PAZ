using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Inmubles.Aplication.DTOs.Propertys;
using Inmubles.Aplication.DTOs.PropertysImage;
using Inmubles.Domain.Interfaces;
using MediatR;

namespace Inmubles.Aplication.Queries.Property
{
    public class GetPropertyWithImagesQueryHandler : IRequestHandler<GetPropertyWithImagesQuery, List<PropertyWithImagesDto>>
    {
        private readonly IPropertyRepository _repository;
        private readonly IMapper _mapper;

        public GetPropertyWithImagesQueryHandler(IPropertyRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<List<PropertyWithImagesDto>> Handle(GetPropertyWithImagesQuery request, CancellationToken cancellationToken)
        {
            var propertysWithImages = await _repository.GetAllPropertiesWithImagesAsync();

            // Aplicar filtros de manera condicional
            if (request.MinPrice.HasValue)
            {
                propertysWithImages = propertysWithImages.Where(p => p.Price >= request.MinPrice.Value).ToList();
            }

            if (request.MaxPrice.HasValue)
            {
                propertysWithImages = propertysWithImages.Where(p => p.Price <= request.MaxPrice.Value).ToList();
            }

            if (!string.IsNullOrEmpty(request.Name))
            {
                propertysWithImages = propertysWithImages.Where(p => p.Name.Contains(request.Name, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (!string.IsNullOrEmpty(request.Address))
            {
                propertysWithImages = propertysWithImages.Where(p => p.Address.Contains(request.Address, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            var propertysWithImagesDto = propertysWithImages.Select(m => new PropertyWithImagesDto
            {
                Id = m.Id,
                IdProperty = m.IdProperty,
                IdOwner = m.IdOwner,
                Name = m.Name,
                Address = m.Address,
                Price = m.Price,
                Images = m.Images.Select(p => new PropertyImageDto
                {
                    Id = p.Id,
                    IdPropertyImage = p.IdPropertyImage,
                    IdProperty = p.IdProperty,
                    File = p.File,
                    Enable = p.Enable
                }).ToList()
            }).ToList();

            return propertysWithImagesDto;
        }
    }
}