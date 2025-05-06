using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Inmubles.Aplication.DTOs.Propertys;
using Inmubles.Aplication.Queries.Owner;
using Inmubles.Domain.Interfaces;
using MediatR;

namespace Inmubles.Aplication.Queries.Property
{
    public class GetAllPropertysQueryHandler : IRequestHandler<GetAllPropertysQuery, List<PropertyDto>>
    {
        private readonly IPropertyRepository _repository;
        private readonly IMapper _mapper;

        public GetAllPropertysQueryHandler(IPropertyRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<List<PropertyDto>> Handle(GetAllPropertysQuery request, CancellationToken cancellationToken)
        {
            var propertys = await _repository.GetAllPropertysAsync();
            return _mapper.Map<List<PropertyDto>>(propertys);
        }
    }
}
