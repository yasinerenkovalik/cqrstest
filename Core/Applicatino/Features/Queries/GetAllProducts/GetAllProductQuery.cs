using System;
using Applicatino.Dtos;
using Applicatino.Interfaces.Repository;
using Applicatino.Wrapper;
using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Applicatino.Features.Queries.GetAllProducts
{
    
    public class GetAllProductQuery : IRequest<ServiceResponse<List<ProductViewDto>>>
    {
    }

    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, ServiceResponse<List<ProductViewDto>>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetAllProductQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<ProductViewDto>>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetAllAysnc();
            var viewModel = _mapper.Map<List<ProductViewDto>>(product);
            return new ServiceResponse<List<ProductViewDto>>(viewModel);
        }
    }
}
