using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inmubles.Aplication.DTOs.Owners;
using Inmubles.Aplication.DTOs.PropertysImage;
using MediatR;

namespace Inmubles.Aplication.Queries.PropertyImage
{
    public class GetAllPropertyImageQuery : IRequest<List<PropertyImageDto>> { }
}
