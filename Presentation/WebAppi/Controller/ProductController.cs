
using Applicatino.Features.Commat.CreateProduct;
using Applicatino.Features.Queries.GetAllProducts;
using Applicatino.Interfaces.Repository;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAppi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator=mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get(){
            var query=new GetAllProductQuery();
            return Ok(await _mediator.Send(query));
        }
        [HttpPost]
        public async Task<IActionResult>Post(CreateProductCommand createProductCommand){
               return Ok(await _mediator.Send(createProductCommand));
        }
   
    }
}
