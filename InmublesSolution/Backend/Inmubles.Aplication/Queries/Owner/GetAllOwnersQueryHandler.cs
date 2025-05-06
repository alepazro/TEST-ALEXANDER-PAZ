using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Inmubles.Aplication.DTOs.Owners;
using Inmubles.Domain.Interfaces;
using MediatR;

namespace Inmubles.Aplication.Queries.Owner
{
    public class GetAllOwnersQueryHandler : IRequestHandler<GetAllOwnersQuery, List<OwnerDto>>
    {
        private readonly IOwnerRepository _repository;
        private readonly IMapper _mapper;

        public GetAllOwnersQueryHandler(IOwnerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<OwnerDto>> Handle(GetAllOwnersQuery request, CancellationToken cancellationToken)
        {
            var owners = await _repository.GetAllOwnersAsync();
            return _mapper.Map<List<OwnerDto>>(owners);
        }
    }
}
