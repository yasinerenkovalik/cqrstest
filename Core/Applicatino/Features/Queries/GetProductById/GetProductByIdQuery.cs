using System;
using Applicatino.Dtos;
using Applicatino.Wrapper;
using MediatR;

namespace Applicatino.Features.Queries.GetProductById;

public class GetProductByIdQuery:IRequest<ServiceResponse<ProductViewDto>>
{
    public int Id { get; set; }

}
