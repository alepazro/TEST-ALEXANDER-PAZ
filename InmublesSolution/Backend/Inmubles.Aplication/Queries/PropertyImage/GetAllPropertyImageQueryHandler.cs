using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Inmubles.Aplication.DTOs.Owners;
using Inmubles.Aplication.DTOs.PropertysImage;
using Inmubles.Aplication.Queries.Owner;
using Inmubles.Domain.Interfaces;

namespace Inmubles.Aplication.Queries.PropertyImage
{
    public class GetAllPropertyImageQueryHandler
    {
        private readonly IPropertyImageRepository _repository;
        private readonly IMapper _mapper;
        public GetAllPropertyImageQueryHandler(IPropertyImageRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<PropertyImageDto>> Handle(GetAllPropertyImageQuery request, CancellationToken cancellationToken)
        {
            var propertysImages = await _repository.GetAllPropertyImageAsync();
            return _mapper.Map<List<PropertyImageDto>>(propertysImages);
        }
    }
}
