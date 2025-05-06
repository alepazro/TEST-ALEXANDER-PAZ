using Inmubles.Aplication.DTOs.Propertys;
using Inmubles.Aplication.Queries.Owner;
using Inmubles.Aplication.Queries.Property;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Inmubles.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PropertyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PropertyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<PropertyDto>>> Get()
        {
            var result = await _mediator.Send(new GetAllPropertysQuery());
            return Ok(result);
        }

        [HttpGet("images")]
        public async Task<ActionResult<List<PropertyDto>>> GetAllPropertyWithImage([FromQuery] GetPropertyWithImagesQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

    }
}
