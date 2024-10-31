using System;
using Applicatino.Dtos;
using Applicatino.Interfaces.Repository;
using Applicatino.Wrapper;
using AutoMapper;
using MediatR;

namespace Applicatino.Features.Queries.GetProductById;

public class GetProductIdQueryHandler : IRequestHandler<GetProductByIdQuery, ServiceResponse<ProductViewDto>>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;
    public GetProductIdQueryHandler(IProductRepository productRepository,IMapper mapper)
    {
        _productRepository=productRepository;
        _mapper=mapper;
        
    }
    public async Task<ServiceResponse<ProductViewDto>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var product=await _productRepository.GetByIdAsync(request.Id);
        var dto= _mapper.Map<ProductViewDto>(product);
        return new ServiceResponse<ProductViewDto>(dto);
    }
}
