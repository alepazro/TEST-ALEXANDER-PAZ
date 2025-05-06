using Inmubles.Aplication.DTOs.Owners;
using Inmubles.Aplication.Queries.Owner;
using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace Inmubles.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OwnersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OwnersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<OwnerDto>>> Get()
        {
            var result = await _mediator.Send(new GetAllOwnersQuery());
            return Ok(result);
        }
    }
}
