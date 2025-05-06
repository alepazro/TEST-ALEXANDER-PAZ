using Inmubles.Aplication.DTOs.Owners;
using Inmubles.Aplication.DTOs.PropertysImage;
using Inmubles.Aplication.Queries.Owner;
using Inmubles.Aplication.Queries.PropertyImage;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inmubles.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyImageController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PropertyImageController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<PropertyImageDto>>> Get()
        {
            var result = await _mediator.Send(new GetAllPropertyImageQuery());
            return Ok(result);
        }


    }
}
