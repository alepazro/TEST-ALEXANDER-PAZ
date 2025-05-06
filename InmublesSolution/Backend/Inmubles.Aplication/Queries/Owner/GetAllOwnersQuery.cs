using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inmubles.Aplication.DTOs.Owners;
using MediatR;

namespace Inmubles.Aplication.Queries.Owner
{
    public class GetAllOwnersQuery : IRequest<List<OwnerDto>> { }
}
