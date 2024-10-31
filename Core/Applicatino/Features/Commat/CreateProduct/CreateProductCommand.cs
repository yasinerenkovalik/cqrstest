using System;
using Applicatino.Interfaces.Repository;
using Applicatino.Wrapper;
using AutoMapper;
using MediatR;

namespace Applicatino.Features.Commat.CreateProduct
{
    public class CreateProductCommand:IRequest<ServiceResponse<int>>
{
    public string Name { get; set; }
   // public decimal Value { get; set; }
    public int Stock { get; set; }
}

    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ServiceResponse<int>>
    {
        IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public CreateProductCommandHandler(IProductRepository productRepository,IMapper mapper)
        {
            _productRepository=productRepository;
            _mapper=mapper;
        }
        
        public async Task<ServiceResponse<int>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
           var product= _mapper.Map<Domain.Product>(request);
            await _productRepository.AddAsync(product);
            return new ServiceResponse<int>(product.Id);
        }
    }
    }



