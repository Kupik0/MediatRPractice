using MediatR;
using MediatROrnek.Med.Commands;
using MediatROrnek.Med.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatROrnek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet("Id")]
        public async Task<IActionResult> Get(Guid Id)
        {
            var query = new GetProductByIdQuery() { Id = Id };
            return Ok(await mediator.Send(query));
        }
        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllProductQuery() ;
            return Ok(await mediator.Send(query));
        }
        [HttpPost()]
        public async Task<IActionResult> Post(CreateProductCommand command)
        {
          
            return Ok(await mediator.Send(command));
        }
    }
    }
                                              

