using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inmubles.Aplication.DTOs.Propertys;
using MediatR;

namespace Inmubles.Aplication.Queries.Property
{
    public class GetAllPropertysQuery : IRequest<List<PropertyDto>> { }
   
}
